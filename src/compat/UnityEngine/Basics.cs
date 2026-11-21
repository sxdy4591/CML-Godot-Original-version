// ============================================================
// UnityCompat — Unity API 适配层(移植自原版 Assembly-CSharp)
// 本文件: Mathf / Random / Debug / Time / Application / Screen
// 说明: 所有实现均桥接到 Godot 运行时, 由 UnityRuntime(Node)驱动。
// ============================================================
using System;
using Godot;

namespace UnityEngine
{
	//Unity Mathf 兼容 — 桥接 Godot.Mathf
	public static class Mathf
	{
		public const float PI = (float)Math.PI;
		public const float Epsilon = 1.401298E-45f;
		public const float Infinity = float.PositiveInfinity;
		public const float NegativeInfinity = float.NegativeInfinity;
		public const float Deg2Rad = PI / 180f;
		public const float Rad2Deg = 180f / PI;

		public static float Abs(float f) => System.Math.Abs(f);
		public static int Abs(int value) => System.Math.Abs(value);
		public static float Acos(float f) => (float)System.Math.Acos(f);
		public static float Asin(float f) => (float)System.Math.Asin(f);
		public static float Atan(float f) => (float)System.Math.Atan(f);
		public static float Atan2(float y, float x) => (float)System.Math.Atan2(y, x);
		public static float Ceil(float f) => MathfCeil(f);
		public static int CeilToInt(float f) => (int)System.Math.Ceiling(f);
		public static float Clamp(float value, float min, float max) => Godot.Mathf.Clamp(value, min, max);
		public static int Clamp(int value, int min, int max) => Godot.Mathf.Clamp(value, min, max);
		public static float Clamp01(float value) => Godot.Mathf.Clamp(value, 0f, 1f);
		public static float Cos(float f) => (float)System.Math.Cos(f);
		public static float DeltaAngle(float current, float target)
		{
			float delta = (target - current) % 360f;
			if (delta > 180f) delta -= 360f;
			if (delta < -180f) delta += 360f;
			return delta;
		}
		public static float Exp(float power) => (float)System.Math.Exp(power);
		public static float Floor(float f) => MathfFloor(f);
		public static int FloorToInt(float f) => (int)System.Math.Floor(f);
		public static float InverseLerp(float a, float b, float value)
		{
			if (a != b) return Clamp01((value - a) / (b - a));
			return 0f;
		}
		public static float Lerp(float a, float b, float t) => a + (b - a) * Clamp01(t);
		public static float LerpUnclamped(float a, float b, float t) => a + (b - a) * t;
		public static float Log(float f) => (float)System.Math.Log(f);
		public static float Log(float f, float p) => (float)System.Math.Log(f, p);
		public static float Log10(float f) => (float)System.Math.Log10(f);
		public static float Max(float a, float b) => System.Math.Max(a, b);
		public static int Max(int a, int b) => System.Math.Max(a, b);
		public static float Min(float a, float b) => System.Math.Min(a, b);
		public static int Min(int a, int b) => System.Math.Min(a, b);
		public static float MoveTowards(float current, float target, float maxDelta)
		{
			if (System.Math.Abs(target - current) <= maxDelta) return target;
			return current + System.Math.Sign(target - current) * maxDelta;
		}
		public static float PerlinNoise(float x, float y)
		{
			var n = UnityRuntimeShim.Noise;
			return n != null ? n.GetNoise2D(x, y) : 0f;
		}
		public static float PingPong(float t, float length)
		{
			t = Repeat(t, length * 2f);
			return length - System.Math.Abs(t - length);
		}
		public static float Pow(float f, float p) => (float)System.Math.Pow(f, p);
		public static float Repeat(float t, float length) => Godot.Mathf.PosMod(t, length);
		public static float Round(float f) => (float)System.Math.Round(f);
		public static int RoundToInt(float f) => (int)System.Math.Round(f);
		public static float Sign(float f) => System.Math.Sign(f);
		public static float Sin(float f) => (float)System.Math.Sin(f);
		public static float SmoothStep(float from, float to, float t)
		{
			t = Clamp01(t);
			t = t * t * (3f - 2f * t);
			return from + (to - from) * t;
		}
		public static float Sqrt(float f) => (float)System.Math.Sqrt(f);
		public static float Tan(float f) => (float)System.Math.Tan(f);
		public static float DegreesToRadians(float deg) => deg * Deg2Rad;
		public static float RadiansToDegrees(float rad) => rad * Rad2Deg;

		// 内部辅助(避免与 Godot.Mathf 重名歧义)
		private static float MathfCeil(float f) => (float)System.Math.Ceiling(f);
		private static float MathfFloor(float f) => (float)System.Math.Floor(f);
	}

	//Unity Random 兼容 — 使用 Godot 全局随机
	public static class Random
	{
		public static float value => (float)GD.Randf();
		public static Vector3 insideUnitSphere => UnityEngine.Random.insideUnitSphereImpl();
		public static Vector3 onUnitSphere => UnityEngine.Random.onUnitSphereImpl();
		public static Quaternion rotation => Quaternion.Euler(Range(0f, 360f), Range(0f, 360f), Range(0f, 360f));
		public static Quaternion rotationUniform => rotation;

		//
		/// [移植修复] Unity 的 Random.Range(int min, int max) 上界**不含**(max exclusive),
		/// 而 Godot 的 GD.RandRange 上界**含**(inclusive)。原实现直接转发, 于是
		/// Random.Range(0, arr.Length) 有 1/(Length+1) 的概率取到 arr.Length — 越界。
		/// 原版大量用它选数组下标(如 GameState.GeneratePolitic 刷政客的
		/// other[Random.Range(0, other.Length)]), 踩中即 IndexOutOfRange 抛异常,
		/// 经 EventBridge 冒泡成"事件结果执行异常", 整个事件的后续效果被跳过
		/// (实例: 事件 3「永别了, 我们的舵手」→ KillPerson(0) → BalancePolitic)。
		/// 此处按 Unity 语义收紧上界; min/max 逆序时同样按 Unity 交换。
		/// 
		public static int Range(int min, int max)
		{
			if (min > max)
			{
				int t = min;
				min = max;
				max = t;
			}
			if (max == min) return min;
			return GD.RandRange(min, max - 1);
		}

		//Unity 的 float 版上界是"含"(与 int 版不同), 与 Godot 的 double 版一致, 仅补逆序保护
		public static float Range(float min, float max)
		{
			if (min > max)
			{
				float t = min;
				min = max;
				max = t;
			}
			return (float)GD.RandRange((double)min, (double)max);
		}

		public static float Rand01() => (float)GD.Randf();
		public static void InitState(int seed) => GD.Seed((ulong)seed);
		public static int Seed { get; set; }

		private static Vector3 insideUnitSphereImpl()
		{
			var v = new Vector3(Range(-1f, 1f), Range(-1f, 1f), Range(-1f, 1f));
			return v.normalized * (float)System.Math.Pow(GD.Randf(), 1f / 3f);
		}
		private static Vector3 onUnitSphereImpl()
		{
			var v = new Vector3(Range(-1f, 1f), Range(-1f, 1f), Range(-1f, 1f));
			return v.normalized;
		}
	}

	//Unity Debug 兼容 — 桥接 Godot 输出
	public static class Debug
	{
		//
		/// 原版代码里有大量 Debug.Log 用来打印条件求值(如 "True 和 / False 或"),
		/// 每帧刷屏且对玩家/排查都无意义。默认关闭, 需要时用调试控制台 `verbose on` 打开。
		/// 警告/错误不受影响 —— 那两类必须始终可见。
		/// 
		public static bool Verbose = false;

		private static int _suppressed;

		//被抑制的 Log 条数 (诊断用, 证明没有丢日志而是有意静音)。
		public static int Suppressed => _suppressed;

		public static void Log(object message)
		{
			if (!Verbose) { _suppressed++; return; }
			GD.Print("[原逻辑] " + (message?.ToString() ?? "null"));
		}
		public static void LogWarning(object message) => GD.PushWarning("[原逻辑警告] " + (message?.ToString() ?? "null"));
		public static void LogError(object message) => GD.PushError("[原逻辑错误] " + (message?.ToString() ?? "null"));
		public static void LogException(Exception e) => GD.PushError("[原逻辑异常] " + e);
		public static void LogAssertion(object message) => GD.PushWarning("[断言] " + message);
		public static void DrawLine(Vector3 start, Vector3 end, Color color = default, float duration = 0f) { }
		public static void DrawRay(Vector3 start, Vector3 dir, Color color = default, float duration = 0f) { }
		public static void Assert(bool condition, object message = null)
		{
			if (!condition) GD.PushError("[断言失败] " + message);
		}
	}

	//Unity Time 兼容 — deltaTime 由 UnityRuntime 每帧更新
	public static class Time
	{
		public static float deltaTime => UnityTimeShim.DeltaTime;
		public static float fixedDeltaTime => 1f / 50f;
		public static float time => UnityTimeShim.TimeSinceStartup;
		public static float unscaledTime => UnityTimeShim.TimeSinceStartup;
		public static float realtimeSinceStartup => UnityTimeShim.TimeSinceStartup;
		public static float timeScale { get; set; } = 1f;
		public static int frameCount => UnityTimeShim.FrameCount;
		public static float smoothDeltaTime => UnityTimeShim.DeltaTime;
		public static float maximumDeltaTime { get; set; } = 0.333f;
	}

	//由 UnityRuntime 写入的帧数据
	public static class UnityTimeShim
	{
		public static float DeltaTime = 1f / 60f;
		public static float TimeSinceStartup = 0f;
		public static int FrameCount = 0;
	}

	//
	/// 运行时门面 — 转发到 Godot 侧的 UnityRuntime 节点 (Autoload "GameRuntime")。
	/// 兼容层代码只依赖此门面, 不直接依赖 Godot 场景树。
	/// 
	public static class UnityRuntimeShim
	{
		public static Godot.SceneTree Tree => UnityRuntime.Tree;
		public static Godot.Viewport Viewport => UnityRuntime.Viewport;
		public static Godot.FastNoiseLite Noise => UnityRuntime.Noise;

		public static int NextInstanceId() => UnityRuntime.NextInstanceId();
		public static void RegisterMonoBehaviour(MonoBehaviour mb) => UnityRuntime.RegisterMonoBehaviour(mb);
		public static void UnregisterMonoBehaviour(MonoBehaviour mb) => UnityRuntime.UnregisterMonoBehaviour(mb);
		public static void ScheduleInvoke(MonoBehaviour target, string methodName, float time) => UnityRuntime.ScheduleInvoke(target, methodName, time);
		public static void ScheduleInvokeRepeating(MonoBehaviour target, string methodName, float time, float repeatRate) => UnityRuntime.ScheduleInvokeRepeating(target, methodName, time, repeatRate);
		public static void CancelInvokes(MonoBehaviour target) => UnityRuntime.CancelInvokes(target);
		public static void CancelInvoke(MonoBehaviour target, string methodName) => UnityRuntime.CancelInvoke(target, methodName);
		public static void RegisterGameObject(GameObject go) => UnityRuntime.RegisterGameObject(go);
		public static void UnregisterGameObject(GameObject go) => UnityRuntime.UnregisterGameObject(go);
		public static GameObject FindGameObject(string name) => UnityRuntime.FindGameObject(name);
		public static bool IsKeyJustPressed(Godot.Key k) => UnityRuntime.IsKeyJustPressed(k);
		public static bool IsKeyJustReleased(Godot.Key k) => UnityRuntime.IsKeyJustReleased(k);
		public static bool IsMouseJustPressed(int button) => UnityRuntime.IsMouseJustPressed(button);
	}

	//Unity Application 兼容
	public static class Application
	{
		public static int targetFrameRate { get; set; }
		public static string dataPath => ProjectSettings.GlobalizePath("res://");
		public static string persistentDataPath => ProjectSettings.GlobalizePath("user://");
		public static string streamingAssetsPath => ProjectSettings.GlobalizePath("res://");
		public static string temporaryCachePath => System.IO.Path.GetTempPath();
		public static bool isPlaying => true;
		public static bool isEditor => false;
		public static bool isFocused => true;
		public static string version => "1.0";
		public static string productName => "中国:毛的遗产[Godot重制]";
		public static string unityVersion => "2022.3.x(移植兼容)";
		public static string identifier => "china.maos.legacy.godot";
		public static string consoleLogPath => System.IO.Path.GetTempPath();
		public static string absoluteURL => "file://" + dataPath;
		public static RuntimePlatform platform => RuntimePlatform.WindowsPlayer;
		public static bool runInBackground { get; set; }
		public static void OpenURL(string url)
		{
			if (!string.IsNullOrEmpty(url)) OS.ShellOpen(url);
		}
		public static void Quit() => UnityRuntimeShim.Tree?.Quit();
		public static void CaptureScreenshot(string filename) { }
		public static void RunInBackground(bool value) { }
		public static void SetStackTraceLogType(LogType type, StackTraceLogType value) { }
	}

	//Unity Screen 兼容
	public static class Screen
	{
		public static int width => UnityRuntimeShim.Viewport?.GetVisibleRect().Size.X > 0
			? (int)UnityRuntimeShim.Viewport.GetVisibleRect().Size.X : 1920;
		public static int height => UnityRuntimeShim.Viewport?.GetVisibleRect().Size.Y > 0
			? (int)UnityRuntimeShim.Viewport.GetVisibleRect().Size.Y : 1080;
		public static float dpi => 96f;
		public static bool fullScreen { get; set; }
		public static Resolution currentResolution => new Resolution { width = width, height = height };
		public static void SetResolution(int w, int h, bool fullscreen) { }
		public static void SetResolution(int w, int h, FullScreenMode mode, int refreshRate = 0) { }
	}

	public struct Resolution
	{
		public int width;
		public int height;
		public int refreshRate;
	}

	public enum FullScreenMode
	{
		ExclusiveFullScreen = 0,
		FullScreenWindow = 1,
		MaximizedWindow = 2,
		Windowed = 3
	}

	public enum LogType { Error = 0, Assert = 1, Warning = 2, Log = 3, Exception = 4 }
	public enum StackTraceLogType { None = 0, ScriptOnly = 1, Full = 2 }
	public enum RuntimePlatform { WindowsPlayer = 1, OSXPlayer = 2, LinuxPlayer = 3, WebGLPlayer = 4 }
}
