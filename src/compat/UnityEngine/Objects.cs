// ============================================================
// UnityCompat — 对象系统: Object / Component / MonoBehaviour / GameObject / Transform
// MonoBehaviour 生命周期(Awake/Start/Update/FixedUpdate/OnDestroy)由
// src/bridge/UnityRuntime.cs 中的泵统一驱动。
// ============================================================
using System;
using System.Collections.Generic;

namespace UnityEngine
{
	//Unity Object 兼容 — 所有原版逻辑对象的基类
	public class Object
	{
		public string name = "";
		public int GetInstanceID() => _instanceId;
		private readonly int _instanceId = UnityRuntimeShim.NextInstanceId();

		public static void Destroy(Object obj, float t = 0f)
		{
			if (obj == null) return;
			if (obj is GameObject go)
			{
				go.SetActive(false);
				go.KillAllMonos();
				go.MarkDestroyed();
				UnityRuntimeShim.UnregisterGameObject(go);
			}
			else if (obj is Component c)
			{
				c.gameObject?.SetActive(false);
			}
			obj.Destroyed = true;
		}

		public static void DestroyImmediate(Object obj) => Destroy(obj);
		public static void DontDestroyOnLoad(Object target) { }
		public static Object Instantiate(Object original) => original;
		public static T Instantiate<T>(T original) where T : Object => original;
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object => original;
		public static T FindObjectOfType<T>() where T : Object => null;
		public static T[] FindObjectsOfType<T>() where T : Object => Array.Empty<T>();
		public static T FindFirstObjectByType<T>() where T : Object => null;
		// 注意: 内部比较必须用 ReferenceEquals, 不能用 == / != (会递归调用本重载)
		public static bool operator ==(Object x, Object y)
		{
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
			// Unity 语义: 双方都已销毁视为相等
			if (x.Destroyed && y.Destroyed) return true;
			return false;
		}
		public static bool operator !=(Object x, Object y) => !(x == y);
		public override bool Equals(object other) => ReferenceEquals(this, other);
		public override int GetHashCode() => _instanceId.GetHashCode();

		internal bool Destroyed = false;
	}

	//Unity Component 兼容
	public class Component : Object
	{
		public GameObject gameObject { get; internal set; }
		public Transform transform
		{
			get
			{
				if (gameObject == null) return null;
				return gameObject.transform;
			}
		}
		public string tag { get; set; } = "Untagged";
		public bool CompareTag(string tag) => this.tag == tag;
		public Component GetComponent(Type type) => gameObject?.GetComponent(type);
		// 注意: 泛型约束有意放宽 — 原版代码会 GetComponent<GlobalScript>(),
		// 而移植版 GlobalScript 是 Godot Node, 不继承 UnityEngine.Component。
		public T GetComponent<T>() => gameObject != null ? gameObject.GetComponent<T>() : default;
		public T GetComponentInChildren<T>() => gameObject != null ? gameObject.GetComponentInChildren<T>() : default;
		public T GetComponentInParent<T>() => gameObject != null ? gameObject.GetComponentInParent<T>() : default;
		public Component[] GetComponentsInChildren(Type type) => gameObject != null ? gameObject.GetComponentsInChildren(type) : Array.Empty<Component>();
		public T[] GetComponentsInChildren<T>() => gameObject != null ? gameObject.GetComponentsInChildren<T>() : Array.Empty<T>();
		public Component AddComponent(Type type) => gameObject != null ? gameObject.AddComponent(type) : null;
		public T AddComponent<T>() where T : Component, new() => gameObject != null ? gameObject.AddComponent<T>() : null;
		public T[] GetComponents<T>() => gameObject != null ? gameObject.GetComponents<T>() : Array.Empty<T>();
		public Component[] GetComponents(Type type) => gameObject != null ? gameObject.GetComponents(type) : Array.Empty<Component>();
		public void SendMessage(string methodName, object value = null) { }
		public void BroadcastMessage(string methodName, object parameter = null) { }
		public bool enabled { get; set; } = true;
	}

	//Unity Behaviour 兼容
	public class Behaviour : Component
	{
		public bool isActiveAndEnabled => enabled && gameObject != null && gameObject.activeSelf;
	}

	//
	/// Unity MonoBehaviour 兼容 — 构造后由 UnityRuntime 泵驱动生命周期。
	/// 原版逻辑大量继承此类; 在 Godot 中不要求节点化, 泵统一调度。
	/// 
	public class MonoBehaviour : Behaviour
	{
		private bool _awoken = false;
		private bool _started = false;
		internal bool _alive = true;

		public MonoBehaviour()
		{
			UnityRuntimeShim.RegisterMonoBehaviour(this);
		}

		public virtual void Awake() { }
		public virtual void Start() { }
		public virtual void Update() { }
		public virtual void FixedUpdate() { }
		public virtual void OnDestroy() { }
		public virtual void OnEnable() { }
		public virtual void OnDisable() { }
		public virtual void LateUpdate() { }

		//由泵调用: 首次进入时执行 Awake/Start
		internal void PumpEnsureStarted()
		{
			if (!_alive) return;
			if (!_awoken) { _awoken = true; Awake(); }
			if (!_started) { _started = true; Start(); }
		}

		//由泵每帧调用
		internal void PumpUpdate()
		{
			if (!_alive || !enabled) return;
			Update();
		}

		internal void PumpFixedUpdate()
		{
			if (!_alive || !enabled) return;
			FixedUpdate();
		}

		internal void PumpLateUpdate()
		{
			if (!_alive || !enabled) return;
			LateUpdate();
		}

		internal void PumpKill()
		{
			if (!_alive) return;
			_alive = false;
			OnDestroy();
		}

		public void Invoke(string methodName, float time) => UnityRuntimeShim.ScheduleInvoke(this, methodName, time);
		public void InvokeRepeating(string methodName, float time, float repeatRate) => UnityRuntimeShim.ScheduleInvokeRepeating(this, methodName, time, repeatRate);
		public void CancelInvoke() => UnityRuntimeShim.CancelInvokes(this);
		public bool IsInvoking(string methodName = null) => false;

		public void CancelInvoke(string methodName) => UnityRuntimeShim.CancelInvoke(this, methodName);

		//发送消息到自身方法(反射调用), 供 Invoke 使用
		//缓存 MethodInfo: 原实现每次 Invoke 都 GetType().GetMethod + 分配 MethodInfo[]
		private static readonly Dictionary<(Type, string), System.Reflection.MethodInfo> _invokeMethodCache
			= new Dictionary<(Type, string), System.Reflection.MethodInfo>();

		internal void InvokeMethod(string methodName)
		{
			var key = (GetType(), methodName);
			if (!_invokeMethodCache.TryGetValue(key, out var m))
			{
				m = GetType().GetMethod(methodName, System.Reflection.BindingFlags.Instance
					| System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
				_invokeMethodCache[key] = m;   // null 也缓存: 缺失方法只解析一次
			}
			m?.Invoke(this, null);
		}
	}

	//
	/// Unity GameObject 兼容 — 轻量对象 + 组件容器。
	/// 原版代码用 GameObject.Find/SetActive/GetComponent 管理场景对象;
	/// 移植版中由注册表维护, UI 由 GDScript 实现时这些调用为空操作。
	/// 
	public class GameObject : Object
	{
		private readonly List<Component> _components = new List<Component>();
		private readonly Dictionary<Type, Component> _componentMap = new Dictionary<Type, Component>();
		private bool _active = true;
		private Transform _transform;

		public GameObject() { name = "GameObject"; UnityRuntimeShim.RegisterGameObject(this); }
		public GameObject(string name) { this.name = name; UnityRuntimeShim.RegisterGameObject(this); }
		public GameObject(string name, params Type[] components)
		{
			this.name = name;
			UnityRuntimeShim.RegisterGameObject(this);
			foreach (var t in components) AddComponent(t);
		}

		public bool activeSelf => _active;
		public bool activeInHierarchy => _active;
		//旧版 Unity 属性别名 (MapChangesScript 使用)
		public bool active
		{
			get => _active;
			set => SetActive(value);
		}
		public int layer { get; set; }
		public Transform transform => _transform ?? (_transform = new Transform(this));

		public void SetActive(bool value)
		{
			if (_active == value) return;
			_active = value;
			// Unity 语义: 停用/启用只切换激活状态, 组件(含 MonoBehaviour)不销毁。
			// 泵会对非激活 GameObject 的组件跳过 Update; 重新激活后自动恢复泵送。
			if (value)
			{
				UnityRuntimeShim.RegisterGameObject(this);
			}
			else
			{
				UnityRuntimeShim.UnregisterGameObject(this);
			}
		}

		//显式销毁: 杀掉全部 MonoBehaviour (仅在 Object.Destroy 时调用)
		internal void KillAllMonos()
		{
			foreach (var mb in _components)
			{
				if (mb is MonoBehaviour m) m.PumpKill();
			}
		}

		public T AddComponent<T>() where T : Component, new()
		{
			var c = new T { gameObject = this };
			_components.Add(c);
			_componentMap[typeof(T)] = c;
			if (c is MonoBehaviour mb) UnityRuntimeShim.RegisterMonoBehaviour(mb);
			return c;
		}

		public Component AddComponent(Type type)
		{
			var c = (Component)Activator.CreateInstance(type);
			c.gameObject = this;
			_components.Add(c);
			_componentMap[type] = c;
			if (c is MonoBehaviour mb) UnityRuntimeShim.RegisterMonoBehaviour(mb);
			return c;
		}

		public Component GetComponent(Type type)
		{
			if (_componentMap.TryGetValue(type, out var c)) return c;
			foreach (var comp in _components)
				if (type.IsInstanceOfType(comp)) return comp;
			return null;
		}

		public T GetComponent<T>()
		{
			if (typeof(T) == typeof(Transform)) return (T)(object)transform;
			if (_componentMap.TryGetValue(typeof(T), out var c) && c is T tc) return tc;
			foreach (var comp in _components)
				if (comp is T t) return t;
			return default;
		}

		public T GetComponentInChildren<T>() => GetComponent<T>();
		public Component GetComponentInChildren(Type type) => GetComponent(type);
		public T GetComponentInParent<T>() => GetComponent<T>();
		public T[] GetComponents<T>()
		{
			var list = new List<T>();
			foreach (var comp in _components) if (comp is T t) list.Add(t);
			return list.ToArray();
		}
		public Component[] GetComponents(Type type)
		{
			var list = new List<Component>();
			foreach (var comp in _components) if (type.IsInstanceOfType(comp)) list.Add(comp);
			return list.ToArray();
		}
		public Component[] GetComponentsInChildren(Type type) => GetComponents(type);
		public T[] GetComponentsInChildren<T>() => GetComponents<T>();

		public static GameObject Find(string name) => UnityRuntimeShim.FindGameObject(name);
		public static GameObject FindWithTag(string tag) => null;
		public static GameObject FindGameObjectWithTag(string tag) => null;
		public static GameObject[] FindGameObjectsWithTag(string tag) => Array.Empty<GameObject>();
		public static GameObject CreatePrimitive(PrimitiveType type) => new GameObject("Primitive");
		public static GameObject FindObjectOfType(Type type) => null;

		public void MarkDestroyed() { Destroyed = true; }
		public void SendMessage(string methodName, object value = null) { }

		public override string ToString() => name;
	}

	public enum PrimitiveType { Sphere = 0, Capsule = 1, Cylinder = 2, Cube = 3, Plane = 4, Quad = 5 }

	//Unity Transform 兼容 — 位置/旋转/缩放存储(不绑定 Godot 节点)
	public class Transform : Component
	{
		private Vector3 _position = Vector3.zero;
		private Vector3 _localPosition = Vector3.zero;
		private Quaternion _rotation = Quaternion.identity;
		private Quaternion _localRotation = Quaternion.identity;
		private Vector3 _localScale = Vector3.one;
		private Transform _parent;
		private readonly List<Transform> _children = new List<Transform>();

		public Transform(GameObject owner) { gameObject = owner; }

		public Vector3 position { get => _position; set { _position = value; } }
		public Vector3 localPosition { get => _localPosition; set { _localPosition = value; } }
		public Quaternion rotation { get => _rotation; set { _rotation = value; } }
		public Quaternion localRotation { get => _localRotation; set { _localRotation = value; } }
		public Vector3 eulerAngles { get => _rotation.eulerAngles; set => _rotation = Quaternion.Euler(value); }
		public Vector3 localEulerAngles { get => _localRotation.eulerAngles; set => _localRotation = Quaternion.Euler(value); }
		public Vector3 localScale { get => _localScale; set { _localScale = value; } }
		public Vector3 lossyScale => _localScale;
		public Vector3 up { get => _rotation * Vector3.up; set => _rotation = Quaternion.FromToRotation(Vector3.up, value); }
		public Vector3 down => _rotation * Vector3.down;
		public Vector3 right { get => _rotation * Vector3.right; set => _rotation = Quaternion.FromToRotation(Vector3.right, value); }
		public Vector3 left => _rotation * Vector3.left;
		public Vector3 forward { get => _rotation * Vector3.forward; set => _rotation = Quaternion.LookRotation(value); }
		public Vector3 back => _rotation * Vector3.back;
		public Transform parent { get => _parent; set { _parent = value; } }
		public Transform root => _parent == null ? this : _parent.root;
		public int childCount => _children.Count;
		public Transform GetChild(int index) => _children[index];
		public Transform Find(string n)
		{
			foreach (var c in _children) if (c.name == n) return c;
			return null;
		}
		public void SetParent(Transform p)
		{
			_parent?._children.Remove(this);
			_parent = p;
			p?._children.Add(this);
			// Transform.Find 按子 Transform 的 name 匹配, 必须与 GameObject.name 同步
			if (gameObject != null && string.IsNullOrEmpty(name)) name = gameObject.name;
		}
		public void SetParent(Transform p, bool worldPositionStays) => SetParent(p);
		public void SetAsFirstSibling() { }
		public void SetAsLastSibling() { }
		public void SetSiblingIndex(int index) { }
		public void Rotate(Vector3 eulers, Space relativeTo = Space.Self)
		{
			_rotation = _rotation * Quaternion.Euler(eulers);
			_localRotation = _localRotation * Quaternion.Euler(eulers);
		}
		public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo = Space.Self) => Rotate(new Vector3(xAngle, yAngle, zAngle), relativeTo);
		public void RotateAround(Vector3 point, Vector3 axis, float angle) { }
		public void LookAt(Transform target) { }
		public void LookAt(Vector3 worldPosition) { }
		public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }
		public void Translate(Vector3 translation, Space relativeTo = Space.Self) { _position += translation; _localPosition += translation; }
		public void Translate(float x, float y, float z) => Translate(new Vector3(x, y, z));
		public Vector3 TransformPoint(Vector3 position) => _position + _rotation * Vector3.Scale(position, _localScale);
		public Vector3 InverseTransformPoint(Vector3 position) => _position - position;
		public Vector3 TransformDirection(Vector3 direction) => _rotation * direction;
		public Vector3 InverseTransformDirection(Vector3 direction) => Quaternion.Inverse(_rotation) * direction;
		public void DetachChildren() { _children.Clear(); }
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { _position = position; _rotation = rotation; }
		public void SetLocalPositionAndRotation(Vector3 position, Quaternion rotation) { _localPosition = position; _localRotation = rotation; }
		public void SetAsFirstSiblingOf(Transform parent) { }
		public override string ToString() => "Transform";
	}

	public enum Space { World = 0, Self = 1 }

	//
	/// GlobalScript 兼容扩展 — 原版 UI 脚本对全局单例调用 GetComponent&lt;T&gt;();
	/// 移植版 GlobalScript 是 Godot Node, 这里提供空实现保证可编译。
	/// 
	public static class GlobalScriptCompat
	{
		public static T GetComponent<T>(this GlobalScript self) => default;
		public static T GetComponentInChildren<T>(this GlobalScript self) => default;
	}
}
