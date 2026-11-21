// ============================================================
// Bridge — UnityRuntime: Godot 运行时泵
// 职责:
//  1. 驱动原版 UnityEngine.MonoBehaviour 的 Awake/Start/Update/FixedUpdate
//  2. 维护 UnityEngine.Time / 输入状态 / GameObject 注册表
//  3. Invoke/InvokeRepeating 调度
// 作为 Autoload "GameRuntime" 挂在场景树上。
// ============================================================
using System;
using System.Collections.Generic;
using Godot;
using UnityEngine;

[GlobalClass]
public partial class UnityRuntime : Node
{
	// ---- 供 UnityEngine 静态类访问的运行时引用 ----
	internal static SceneTree Tree;
	internal static Viewport Viewport;
	internal static FastNoiseLite Noise;

	// ---- MonoBehaviour 泵 ----
	private static readonly List<MonoBehaviour> _monos = new List<MonoBehaviour>();
	private static readonly List<MonoBehaviour> _pendingAdd = new List<MonoBehaviour>();
	private static bool _pumping = false;

	// ---- Invoke 调度 ----
	private class InvokeEntry
	{
		public MonoBehaviour Target;
		public string MethodName;
		public double AtTime;
		public double Interval; // >0 表示重复
		public bool Cancelled;
	}
	private static readonly List<InvokeEntry> _invokes = new List<InvokeEntry>();

	// ---- GameObject 注册表 ----
	private static readonly Dictionary<string, GameObject> _gameObjects = new Dictionary<string, GameObject>();

	// ---- 按键刚按下/刚释放 ----
	private static readonly Dictionary<Key, bool> _prevKeys = new Dictionary<Key, bool>();
	private static readonly HashSet<Key> _justPressed = new HashSet<Key>();
	private static readonly HashSet<Key> _justReleased = new HashSet<Key>();
	private static readonly bool[] _prevMouse = new bool[8];
	private static readonly bool[] _mouseJustPressed = new bool[8];

	private static int _instanceIdCounter = 1;


	public static int NextInstanceId() => _instanceIdCounter++;

	// ---- 生命周期反射分派 ----
	// Unity 语义: Awake/Start/Update/FixedUpdate 等是按"方法名"调用具体类型上的实现,
	// 不要求 public / override(原版大量使用 private void Update() 等非覆写声明)。
	// 因此泵不能走基类虚调用(会把 private Update 当成新方法隐藏掉, 永远调不到),
	// 必须按具体类型反射查找并调用。
	private static readonly HashSet<MonoBehaviour> _awokenSet = new HashSet<MonoBehaviour>();
	private static readonly HashSet<MonoBehaviour> _startedSet = new HashSet<MonoBehaviour>();
	private static readonly Dictionary<(Type, string), System.Reflection.MethodInfo> _lifecycleCache = new Dictionary<(Type, string), System.Reflection.MethodInfo>();

	private static System.Reflection.MethodInfo FindLifecycleMethod(Type type, string name)
	{
		if (_lifecycleCache.TryGetValue((type, name), out var cached)) return cached;
		System.Reflection.MethodInfo found = null;
		try
		{
			var m = type.GetMethod(name, System.Reflection.BindingFlags.Instance
				| System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
			// 只命中基类空实现(或未声明) → 无需调用
			if (m != null && m.DeclaringType != typeof(UnityEngine.MonoBehaviour)
				&& m.DeclaringType != typeof(UnityEngine.Behaviour)
				&& m.DeclaringType != typeof(UnityEngine.Component)
				&& m.DeclaringType != typeof(UnityEngine.Object))
			{
				found = m;
			}
		}
		catch (System.Reflection.AmbiguousMatchException e)
		{
			GD.PushWarning($"[UnityRuntime] FindLifecycleMethod 歧义匹配 {type.Name}.{name}: {e.Message}");
			found = null;
		}
		_lifecycleCache[(type, name)] = found;
		return found;
	}

	//按具体类型调用生命周期方法(反射, 还原 Unity 按名派发语义)
	private static void InvokeLifecycle(MonoBehaviour mb, string name)
	{
		var m = FindLifecycleMethod(mb.GetType(), name);
		if (m == null) return;
		try
		{
			m.Invoke(mb, null);
		}
		catch (System.Reflection.TargetInvocationException tie)
		{
			// 保留原始异常的内层堆栈(直接 throw 会重置栈, 丢失 TimeScript 原始行号)
			if (tie.InnerException != null)
			{
				System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(tie.InnerException).Throw();
			}
			throw;
		}
	}

	// ================= Godot 生命周期 =================

	public override void _Ready()
	{
		Tree = GetTree();
		Viewport = GetViewport();
		Noise = new FastNoiseLite();
		Noise.Seed = (int)GD.Randi();
		GD.Print("[UnityRuntime] 运行时泵已启动 — 原版逻辑适配层就绪");
	}

	public override void _Process(double delta)
	{
		float dt = (float)delta;
		UnityEngine.UnityTimeShim.DeltaTime = dt;
		UnityEngine.UnityTimeShim.TimeSinceStartup += dt;
		UnityEngine.UnityTimeShim.FrameCount++;

		// 输入状态跟踪
		TrackInput();

		// 调度器
		PumpInvokes();

		// MonoBehaviour 生命周期
		PumpMonos();
	}

	public override void _PhysicsProcess(double delta)
	{
		foreach (var mb in _monos)
		{
			if (!mb._alive || !mb.enabled) continue;
			if (mb.gameObject != null && !mb.gameObject.activeSelf) continue; // 非激活对象不泵
			InvokeLifecycle(mb, "FixedUpdate");
		}
	}

	public override void _ExitTree()
	{
		Tree = null;
		Viewport = null;
	}

	// ================= MonoBehaviour 泵 =================

	internal static void RegisterMonoBehaviour(MonoBehaviour mb)
	{
		// 注意: MonoBehaviour 构造函数与 GameObject.AddComponent 都会调用本方法,
		// 同一实例必须只注册一次, 否则 Update 等每帧被泵两次。
		if (mb == null) return;
		if (_pumping)
		{
			if (!_pendingAdd.Contains(mb)) _pendingAdd.Add(mb);
		}
		else if (!_monos.Contains(mb))
		{
			_monos.Add(mb);
		}
	}

	internal static void UnregisterMonoBehaviour(MonoBehaviour mb)
	{
		_monos.Remove(mb);
		_pendingAdd.Remove(mb);
	}

	//世界时间场景门控: 仅 外交.tscn(世界地图) 允许时间/事件推进
	private static bool IsSceneTimeActive()
	{
		var tree = UnityRuntimeShim.Tree;
		if (tree == null || tree.CurrentScene == null) return false;
		return tree.CurrentScene.SceneFilePath == "res://scenes/外交/外交.tscn";
	}

	private static void PumpMonos()
	{
		_pumping = true;
		try
		{
			for (int i = 0; i < _monos.Count; i++)
			{
				var mb = _monos[i];
				if (mb == null || !mb._alive) continue;
				// 非激活 GameObject 上的组件不泵(SetActive 只切换激活, 不销毁组件)
				if (mb.gameObject != null && !mb.gameObject.activeSelf) continue;
				// 逐 mono 隔离异常: 单个组件的生命周期异常不得阻断其他组件的泵
				// (与 Unity 一致, 且桥接层替身组件可能抛出可预期的空引用)
				try
				{
					if (_awokenSet.Add(mb)) InvokeLifecycle(mb, "Awake");
					if (_startedSet.Add(mb)) InvokeLifecycle(mb, "Start");
					if (mb.enabled)
					{
						// 世界时间仅在外交场景推进: 经济/科学/政治/决议/设置等界面时间冻结,
						// 快捷键(空格/1-4/F5/F9 由 TimeScript.Update 驱动)也随之只在外交生效
						if ((mb is TimeScript || mb is EventScript) && !IsSceneTimeActive())
						{
							continue;
						}
						InvokeLifecycle(mb, "Update");
					}
				}
				catch (Exception e)
				{
					GD.PushError($"[UnityRuntime] 生命周期异常 {mb.GetType().Name}: {e}");
				}
			}
		}
		finally
		{
			_pumping = false;
		}
		if (_pendingAdd.Count > 0)
		{
			_monos.AddRange(_pendingAdd);
			_pendingAdd.Clear();
		}
		// 清理死亡对象
		for (int i = _monos.Count - 1; i >= 0; i--)
		{
			if (!_monos[i]._alive)
			{
				_awokenSet.Remove(_monos[i]);
				_startedSet.Remove(_monos[i]);
				_monos.RemoveAt(i);
			}
		}
	}

	// ================= Invoke 调度 =================

	internal static void ScheduleInvoke(MonoBehaviour target, string methodName, float time)
	{
		_invokes.Add(new InvokeEntry
		{
			Target = target,
			MethodName = methodName,
			AtTime = UnityEngine.UnityTimeShim.TimeSinceStartup + time,
			Interval = 0d
		});
	}

	internal static void ScheduleInvokeRepeating(MonoBehaviour target, string methodName, float time, float repeatRate)
	{
		_invokes.Add(new InvokeEntry
		{
			Target = target,
			MethodName = methodName,
			AtTime = UnityEngine.UnityTimeShim.TimeSinceStartup + time,
			Interval = repeatRate
		});
	}

	internal static void CancelInvokes(MonoBehaviour target)
	{
		foreach (var e in _invokes)
		{
			if (e.Target == target) e.Cancelled = true;
		}
	}

	internal static void CancelInvoke(MonoBehaviour target, string methodName)
	{
		foreach (var e in _invokes)
		{
			if (e.Target == target && e.MethodName == methodName) e.Cancelled = true;
		}
	}

	private static void PumpInvokes()
	{
		double now = UnityEngine.UnityTimeShim.TimeSinceStartup;
		for (int i = _invokes.Count - 1; i >= 0; i--)
		{
			var e = _invokes[i];
			if (e.Cancelled || e.Target == null || !e.Target._alive)
			{
				_invokes.RemoveAt(i);
				continue;
			}
			if (now >= e.AtTime)
			{
				if (e.Interval > 0d)
				{
					e.AtTime = now + e.Interval;
					e.Target.InvokeMethod(e.MethodName);
				}
				else
				{
					_invokes.RemoveAt(i);
					e.Target.InvokeMethod(e.MethodName);
				}
			}
		}
	}

	// ================= GameObject 注册表 =================

	internal static void RegisterGameObject(GameObject go)
	{
		if (!string.IsNullOrEmpty(go.name)) _gameObjects[go.name] = go;
	}

	internal static void UnregisterGameObject(GameObject go)
	{
		if (!string.IsNullOrEmpty(go.name) && _gameObjects.TryGetValue(go.name, out var existing) && ReferenceEquals(existing, go))
		{
			_gameObjects.Remove(go.name);
		}
	}

	internal static GameObject FindGameObject(string name)
	{
		return _gameObjects.TryGetValue(name, out var go) ? go : null;
	}

	// ================= 输入状态 =================

	// 按键探测集: 一次性构建 (原实现每帧 Enum.GetValues 新建数组 + 装箱)
	private static readonly Key[] _trackedKeys = BuildTrackedKeys();

	private static Key[] BuildTrackedKeys()
	{
		var all = Enum.GetValues(typeof(Key));
		var list = new System.Collections.Generic.List<Key>(all.Length);
		foreach (Key k in all)
		{
			if ((int)k < 32) continue;
			list.Add(k);
		}
		return list.ToArray();
	}

	private static void TrackInput()
	{
		_justPressed.Clear();
		_justReleased.Clear();
		foreach (var kv in _prevKeys)
		{
			bool now = Godot.Input.IsPhysicalKeyPressed(kv.Key);
			if (now && !kv.Value) _justPressed.Add(kv.Key);
			if (!now && kv.Value) _justReleased.Add(kv.Key);
		}
		// 探测常用键 (索引遍历, 枚举数组不装箱)
		for (int i = 0; i < _trackedKeys.Length; i++)
		{
			var k = _trackedKeys[i];
			if (Godot.Input.IsPhysicalKeyPressed(k))
			{
				_prevKeys.TryGetValue(k, out bool was);
				if (!was) _justPressed.Add(k);
				_prevKeys[k] = true;
			}
			else if (_prevKeys.TryGetValue(k, out bool was2) && was2)
			{
				_justReleased.Add(k);
				_prevKeys[k] = false;
			}
		}
		for (int i = 1; i < 8; i++)
		{
			bool now = Godot.Input.IsMouseButtonPressed((MouseButton)i);
			_mouseJustPressed[i] = now && !_prevMouse[i];
			_prevMouse[i] = now;
		}
	}

	internal static bool IsKeyJustPressed(Key k) => _justPressed.Contains(k);
	internal static bool IsKeyJustReleased(Key k) => _justReleased.Contains(k);
	internal static bool IsMouseJustPressed(int button) => button >= 0 && button < 8 && _mouseJustPressed[button];
}
