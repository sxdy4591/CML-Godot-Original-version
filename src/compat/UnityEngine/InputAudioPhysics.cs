// ============================================================
// UnityCompat — 输入/音频/物理: Input / AudioSource / AudioClip / Physics
// ============================================================
using Godot;

namespace UnityEngine
{
	//Unity Input 兼容 — 桥接 Godot Input
	public static class Input
	{
		public static Vector3 mousePosition
		{
			get
			{
				var vp = UnityRuntimeShim.Viewport;
				if (vp == null) return Vector3.zero;
				var pos = vp.GetMousePosition();
				return new Vector3(pos.X, pos.Y, 0f);
			}
		}
		public static Vector2 mouseScrollDelta => Vector2.zero;
		public static bool anyKey => InputMap.HasAction("ui_accept") && Godot.Input.IsActionJustPressed("ui_accept");
		public static bool anyKeyDown => anyKey;
		public static bool mousePresent => true;
		public static bool touchSupported => false;
		public static int touchCount => 0;
		public static bool simulateMouseWithTouches { get; set; }
		public static string inputString => "";
		public static Vector3 acceleration => Vector3.zero;
		public static Compass compass => new Compass();
		public static LocationService location => new LocationService();
		public static IMECompositionMode imeCompositionMode { get; set; }

		//桥接合成修饰键: 原版 Plusmisnus_script 用 Shift/Ctrl 区分 ±50/±100 档位,
		//而 Godot 侧预算按钮直接传档位数字 → 由桥在调用原版 OnMouseDown 期间置位,
		//调用后立即复位(同下面的 SimulateLeftClickPressed 手法)。
		internal static bool SimulateShift;
		internal static bool SimulateCtrl;

		public static bool GetKey(KeyCode key)
		{
			if (key == KeyCode.LeftShift && SimulateShift) return true;
			if (key == KeyCode.LeftControl && SimulateCtrl) return true;
			return IsKeyDown(key);
		}
		public static bool GetKeyDown(KeyCode key) => IsKeyJustPressed(key);
		public static bool GetKeyUp(KeyCode key) => IsKeyJustReleased(key);
		public static bool GetKey(string name) => GetKey((KeyCode)Enum_Key(name));
		public static bool GetKeyDown(string name) => GetKeyDown((KeyCode)Enum_Key(name));
		public static bool GetKeyUp(string name) => GetKeyUp((KeyCode)Enum_Key(name));

		//桥接合成按压: 事件结果页"点击收尾"由按钮 pressed 信号驱动(Godot 在释放后触发,
		//此时 IsMouseButtonPressed 已为 false) → 原版结局事件 Update(如 Event4 党权阴谋大会)
		//用 GetMouseButton(0) 判定点击才会写 data[35]=N; 此开关由 EventBridge 在调用 Update 前后置位/复位。
		internal static bool SimulateLeftClickPressed;

		public static bool GetMouseButton(int button)
		{
			if (button == 0 && SimulateLeftClickPressed) return true;
			if (UnityRuntimeShim.Viewport == null) return false;
			return Godot.Input.IsMouseButtonPressed(ButtonIndexFor(button));
		}
		public static bool GetMouseButtonDown(int button)
		{
			if (UnityRuntimeShim.Viewport == null) return false;
			return Godot.Input.IsMouseButtonPressed(ButtonIndexFor(button)) && UnityRuntimeShim.IsMouseJustPressed(button);
		}
		public static bool GetMouseButtonUp(int button) => false;

		public static float GetAxis(string axisName)
		{
			switch (axisName)
			{
				case "Horizontal": return GetAxisRaw("ui_right") - GetAxisRaw("ui_left");
				case "Vertical": return GetAxisRaw("ui_down") - GetAxisRaw("ui_up");
				default: return 0f;
			}
		}
		public static float GetAxisRaw(string axisName)
		{
			if (UnityRuntimeShim.Viewport == null) return 0f;
			switch (axisName)
			{
				case "ui_left": return Godot.Input.IsPhysicalKeyPressed(Key.Left) || Godot.Input.IsPhysicalKeyPressed(Key.A) ? -1f : 0f;
				case "ui_right": return Godot.Input.IsPhysicalKeyPressed(Key.Right) || Godot.Input.IsPhysicalKeyPressed(Key.D) ? 1f : 0f;
				case "ui_up": return Godot.Input.IsPhysicalKeyPressed(Key.Up) || Godot.Input.IsPhysicalKeyPressed(Key.W) ? -1f : 0f;
				case "ui_down": return Godot.Input.IsPhysicalKeyPressed(Key.Down) || Godot.Input.IsPhysicalKeyPressed(Key.S) ? 1f : 0f;
				default: return 0f;
			}
		}
		public static bool GetButton(string buttonName) => false;
		public static bool GetButtonDown(string buttonName) => false;
		public static bool GetButtonUp(string buttonName) => false;
		public static Touch GetTouch(int index) => new Touch();
		public static void ResetInputAxes() { }

		private static MouseButton ButtonIndexFor(int button) => button switch
		{
			0 => MouseButton.Left,
			1 => MouseButton.Right,
			2 => MouseButton.Middle,
			_ => MouseButton.Left
		};

		private static bool IsKeyDown(KeyCode key)
		{
			var k = KeyCodeMap.ToGodot(key);
			if (k == Key.None) return false;
			if (IsGameOnlyKey(key))
			{
				if (!IsGameSceneActive()) return false;
				if (TryCustomAlias(key, justPressed: false)) return true;
			}
			return Godot.Input.IsPhysicalKeyPressed(k);
		}
		private static bool IsKeyJustPressed(KeyCode key)
		{
			var k = KeyCodeMap.ToGodot(key);
			if (k == Key.None) return false;
			if (IsGameOnlyKey(key))
			{
				if (!IsGameSceneActive()) return false;
				if (TryCustomAlias(key, justPressed: true)) return true;
			}
			return Godot.Input.IsPhysicalKeyPressed(k) && UnityRuntimeShim.IsKeyJustPressed(k);
		}
		private static bool IsKeyJustReleased(KeyCode key)
		{
			var k = KeyCodeMap.ToGodot(key);
			if (k == Key.None) return false;
			if (IsGameOnlyKey(key) && !IsGameSceneActive()) return false;
			return !Godot.Input.IsPhysicalKeyPressed(k) && UnityRuntimeShim.IsKeyJustReleased(k);
		}

		//自定义快捷键别名(设置页重绑的空格/1-4/F5/F9/W): 与内置键等效但在同场景门控内生效
		private static bool TryCustomAlias(KeyCode key, bool justPressed)
		{
			int id = CustomAliasId(key);
			if (id < 0) return false;
			int custom = CustomKey(id);
			if (custom <= 0) return false;
			// 设置页存的是 **Godot 物理键码**(OS.get_keycode_string 同域). 以前强转成 Unity
			// KeyCode 再走 KeyCodeMap 反查: 字母键 Godot 65 vs Unity 97 差 32, 结果除空格/数字
			// 之外的绑定全部 ToGodot→None 静默失效("绑上了按了没反应").
			var ck = (Godot.Key)custom;
			if (ck == KeyCodeMap.ToGodot(key)) return false;
			if (!ModMatched(CustomMod(id))) return false;
			if (justPressed) return Godot.Input.IsPhysicalKeyPressed(ck) && UnityRuntimeShim.IsKeyJustPressed(ck);
			return Godot.Input.IsPhysicalKeyPressed(ck);
		}

		// 组合键: 设置页把 Ctrl/Shift/Alt 一起绑进来(1/2/4), 按下的修饰位必须完全一致,
		// 否则绑了 Shift+5 时按 5 也会触发.
		private static bool ModMatched(int mod)
		{
			var ctrl = Godot.Input.IsPhysicalKeyPressed(Godot.Key.Ctrl);
			var shift = Godot.Input.IsPhysicalKeyPressed(Godot.Key.Shift);
			var alt = Godot.Input.IsPhysicalKeyPressed(Godot.Key.Alt);
			return ((mod & 1) != 0) == ctrl && ((mod & 2) != 0) == shift && ((mod & 4) != 0) == alt;
		}

		// 设置页的键位写在 playerprefs.ini 的 [ui] 分区(UISettings 管理), 本类历史上用
		// PlayerPrefs 读的是 [prefs] 分区 —— 两个分区永不相交, 于是"设置里绑好的键从来没生效过".
		// 这里直接读 [ui], 0.5 秒重读一次文件, 改键后不必重启.
		private static readonly System.Collections.Generic.Dictionary<int, int> AliasKeys = new();
		private static readonly System.Collections.Generic.Dictionary<int, int> AliasMods = new();
		private static ulong _aliasReadAt = ulong.MaxValue;

		private static int CustomMod(int id)
		{
			CustomKey(id);
			return AliasMods.TryGetValue(id, out var value) ? value : 0;
		}

		private static int CustomKey(int id)
		{
			var now = Godot.Time.GetTicksMsec();
			if (now - _aliasReadAt >= 500)
			{
				_aliasReadAt = now;
				AliasKeys.Clear();
				AliasMods.Clear();
				var cfg = new ConfigFile();
				cfg.Load("user://playerprefs.ini");
				for (var i = 0; i <= 12; i++)
				{
					var field = "key_action_" + i;
					AliasKeys[i] = cfg.HasSectionKey("ui", field) ? (int)cfg.GetValue("ui", field, 0) : 0;
					var field_mod = "key_action_mod_" + i;
					AliasMods[i] = cfg.HasSectionKey("ui", field_mod) ? (int)cfg.GetValue("ui", field_mod, 0) : 0;
				}
			}
			return AliasKeys.TryGetValue(id, out var value) ? value : 0;
		}

		private static int CustomAliasId(KeyCode key)
		{
			switch (key)
			{
				case KeyCode.Space: return 0;
				case KeyCode.Alpha1: return 1;
				case KeyCode.Alpha2: return 2;
				case KeyCode.Alpha3: return 3;
				case KeyCode.Alpha4: return 4;
				case KeyCode.F5: return 10;
				case KeyCode.F9: return 11;
				case KeyCode.W: return 12;
				default: return -1;
			}
		}

		//仅在"世界地图(外交)"场景生效的游戏热键:
		/// 原版 TimeScript.Update 里 空格/1-4(速度)/F5(存)/F9(读)/W(战争) —
		/// 在其它界面(经济/科学/设置/事件…)按这些键不应有任何效果, 否则乱套。
		private static bool IsGameOnlyKey(KeyCode key)
		{
			switch (key)
			{
				case KeyCode.Space:
				case KeyCode.Alpha1:
				case KeyCode.Alpha2:
				case KeyCode.Alpha3:
				case KeyCode.Alpha4:
				case KeyCode.F5:
				case KeyCode.F9:
				case KeyCode.W:
					return true;
				default:
					return false;
			}
		}

		private static bool IsGameSceneActive()
		{
			var tree = UnityRuntimeShim.Tree;
			if (tree == null || tree.CurrentScene == null) return false;
			var path = tree.CurrentScene.SceneFilePath;
			if (path != "res://scenes/外交/外交.tscn") return false;
			// 调试控制台打开时屏蔽游戏热键(空格/1-4/F5/F9/W):
			// 玩家在控制台输入(含空格/数字)时不应触发暂停/变速/存读, 否则没法打字
			var console = tree.Root.GetNodeOrNull<CanvasLayer>("调试控制台");
			if (console != null && console.Visible) return false;
			return true;
		}
		private static int Enum_Key(string name)
		{
			if (System.Enum.TryParse<KeyCode>(name, true, out var k)) return (int)k;
			return 0;
		}
	}

	public class Touch
	{
		public int fingerId;
		public Vector2 position;
		public Vector2 rawPosition;
		public Vector2 deltaPosition;
		public float deltaTime;
		public int tapCount;
		public TouchPhase phase;
	}

	public enum TouchPhase { Began = 0, Moved = 1, Stationary = 2, Ended = 3, Canceled = 4 }

	public class Compass { public Vector3 rawVector => Vector3.zero; public float magneticHeading => 0f; public float trueHeading => 0f; public float headingAccuracy => 0f; public Vector3 timestamp => Vector3.zero; public bool enabled { get; set; } }

	public class LocationService
	{
		public bool isEnabledByUser => false;
		public LocationServiceStatus status => LocationServiceStatus.Stopped;
		public LocationInfo lastData => new LocationInfo();
		public void Start(float desiredAccuracyInMeters = 10f, float updateDistanceInMeters = 10f) { }
		public void Stop() { }
	}

	public enum LocationServiceStatus { Stopped = 0, Initializing = 1, Running = 2, Failed = 3 }
	public struct LocationInfo { public float latitude => 0f; public float longitude => 0f; public float altitude => 0f; public float horizontalAccuracy => 0f; public float verticalAccuracy => 0f; public double timestamp => 0d; }
	public enum IMECompositionMode { Auto = 0, On = 1, Off = 2 }

	//Unity AudioClip 兼容
	public class AudioClip : Object
	{
		public string name { get; set; } = "";
		public float length { get; set; }
		public int channels { get; set; } = 2;
		public int frequency { get; set; } = 44100;
		public bool loadInBackground { get; set; }
		public AudioClipLoadType loadType { get; set; }
		public AudioDataLoadState loadState { get; set; } = AudioDataLoadState.Loaded;

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) => new AudioClip { name = name, channels = channels, frequency = frequency };
		public bool LoadAudioData() => false;
		public bool UnloadAudioData() => false;
	}

	public enum AudioClipLoadType { DecompressOnLoad = 0, CompressedInMemory = 1, Streaming = 2 }

	//Unity AudioDataLoadState 枚举 — 与 AudioClip.loadState 配套
	public enum AudioDataLoadState { Unloaded = 0, Loading = 1, Loaded = 2, Failed = 3 }

	//Unity AudioSource 兼容 — 桥接 Godot AudioStreamPlayer(可选)
	public class AudioSource : Behaviour
	{
		public AudioClip clip { get; set; }
		public bool playOnAwake { get; set; } = true;
		public bool loop { get; set; }
		public float volume { get; set; } = 1f;
		public float pitch { get; set; } = 1f;
		public float time { get; set; }
		public bool isPlaying { get; set; }
		public bool mute { get; set; }
		public bool ignoreListenerVolume { get; set; }
		public float panStereo { get; set; }
		public float spatialBlend { get; set; }
		public int priority { get; set; } = 128;
		public AudioRolloffMode rolloffMode { get; set; }
		public float minDistance { get; set; } = 1f;
		public float maxDistance { get; set; } = 500f;
		public bool bypassReverbZones { get; set; }

		public void Play() { isPlaying = true; }
		public void Play(ulong delay) { isPlaying = true; }
		public void PlayOneShot(AudioClip clip, float volumeScale = 1f) { }
		public void Stop() { isPlaying = false; }
		public void Pause() { isPlaying = false; }
		public void UnPause() { isPlaying = true; }
		public void SetScheduledStartTime(double time) { }
		public void SetScheduledEndTime(double time) { }
	}

	public enum AudioRolloffMode { Logarithmic = 0, Linear = 1, Custom = 2 }

	//Unity Physics 兼容(2D/3D 占位)
	public static class Physics
	{
		public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal) => false;
		public static bool Raycast(Ray ray, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal) => false;
		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			hitInfo = default;
			return false;
		}
		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal) => new RaycastHit[0];
		public static bool Linecast(Vector3 start, Vector3 end, int layerMask = -5) => false;
		public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask = -5) => new Collider[0];
		public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity) { hitInfo = default; return false; }
		public static bool CheckSphere(Vector3 position, float radius, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal) => false;
		public static Vector3 gravity { get; set; } = new Vector3(0f, -9.81f, 0f);
		public static bool autoSimulation { get; set; }
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore = true) { }
		public static bool GetIgnoreLayerCollision(int layer1, int layer2) => false;
		public static void SyncTransforms() { }
	}

	public struct RaycastHit
	{
		public Vector3 point;
		public Vector3 normal;
		public Vector3 barycentricCoordinate;
		public float distance;
		public int triangleIndex;
		public Vector2 textureCoord;
		public Vector2 textureCoord2;
		public Transform transform;
		public Rigidbody rigidbody;
		public Collider collider;
		public int rigidbodyInstanceID;
		public int colliderInstanceID;
		public Vector3 lightmapCoord;
		public Vector2 lightmapScaleOffset;
	}

	public enum QueryTriggerInteraction { UseGlobal = 0, Ignore = 1, Collide = 2 }

	public class Collider : Component
	{
		public bool enabled { get; set; } = true;
		public bool isTrigger { get; set; }
		public Bounds bounds => new Bounds(Vector3.zero, Vector3.one);
		public Material sharedMaterial { get; set; }
		public int contactOffset { get; set; }
		public void OnTriggerEnter(Collider other) { }
		public void OnTriggerStay(Collider other) { }
		public void OnTriggerExit(Collider other) { }
		public void OnCollisionEnter(Collision collision) { }
	}

	public class Rigidbody : Component
	{
		public Vector3 velocity { get; set; }
		public Vector3 angularVelocity { get; set; }
		public float mass { get; set; } = 1f;
		public float drag { get; set; }
		public float angularDrag { get; set; } = 0.05f;
		public bool useGravity { get; set; } = true;
		public bool isKinematic { get; set; }
		public RigidbodyConstraints constraints { get; set; }
		public CollisionDetectionMode collisionDetectionMode { get; set; }
		public Vector3 position { get => transform.position; set { if (transform != null) transform.position = value; } }
		public Quaternion rotation { get => transform != null ? transform.rotation : Quaternion.identity; set { if (transform != null) transform.rotation = value; } }
		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force) { }
		public void AddForce(float x, float y, float z) { }
		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force) { }
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier = 0f, ForceMode mode = ForceMode.Force) { }
		public void MovePosition(Vector3 position) { if (transform != null) transform.position = position; }
		public void MoveRotation(Quaternion rot) { if (transform != null) transform.rotation = rot; }
		public void Sleep() { }
		public void WakeUp() { }
		public bool IsSleeping() => false;
		public Vector3 GetPointVelocity(Vector3 worldPoint) => Vector3.zero;
		public Vector3 ClosestPointOnBounds(Vector3 position) => position;
		public void SetMaxAngularVelocity(float a) { }
		public void SetConstraints(RigidbodyConstraints c) { constraints = c; }
	}

	public enum ForceMode { Force = 0, Impulse = 1, VelocityChange = 2, Acceleration = 3 }
	public enum RigidbodyConstraints
	{
		None = 0, FreezePositionX = 2, FreezePositionY = 4, FreezePositionZ = 8,
		FreezeRotationX = 16, FreezeRotationY = 32, FreezeRotationZ = 64,
		FreezePosition = 14, FreezeRotation = 112, FreezeAll = 126
	}
	public enum CollisionDetectionMode { Discrete = 0, Continuous = 1, ContinuousDynamic = 2, ContinuousSpeculative = 3 }

	public class Collision
	{
		public Vector3 relativeVelocity => Vector3.zero;
		public Rigidbody rigidbody => null;
		public Collider collider => null;
		public Transform transform => null;
		public ContactPoint[] contacts => new ContactPoint[0];
		public int contactCount => 0;
	}

	public struct ContactPoint
	{
		public Vector3 point;
		public Vector3 normal;
		public Collider thisCollider;
		public Collider otherCollider;
		public float separation;
	}

	//Unity Physics2D 占位
	public static class Physics2D
	{
		public static bool Raycast(Vector2 origin, Vector2 direction, float distance = float.PositiveInfinity, int layerMask = -5) => false;
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance = float.PositiveInfinity, int layerMask = -5) => new RaycastHit2D[0];
		public static bool OverlapCircle(Vector2 point, float radius, int layerMask = -5) => false;
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask = -5) => new Collider2D[0];
		public static bool Linecast(Vector2 start, Vector2 end, int layerMask = -5) => false;
		public static Vector2 gravity { get; set; }
		public static bool autoSimulation { get; set; } = true;
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore = true) { }
	}

	public struct RaycastHit2D
	{
		public Vector2 point;
		public Vector2 normal;
		public float distance;
		public Collider2D collider;
		public Transform transform => collider != null ? collider.transform : null;
		public bool IsTouching(Collider2D other) => false;
	}

	public class Collider2D : Component
	{
		public bool isTrigger { get; set; }
		public bool usedByEffector { get; set; }
		public int shapeCount => 1;
		public Bounds bounds => new Bounds(transform != null ? transform.position : Vector3.zero, Vector3.one);
		public void OnTriggerEnter2D(Collider2D other) { }
		public void OnTriggerStay2D(Collider2D other) { }
		public void OnTriggerExit2D(Collider2D other) { }
	}

	public class BoxCollider2D : Collider2D
	{
		public Vector2 size { get; set; } = Vector2.one;
		public Vector2 offset { get; set; } = Vector2.zero;
		public float edgeRadius { get; set; }
		public float density { get; set; } = 1f;
	}

	public class CircleCollider2D : Collider2D
	{
		public float radius { get; set; } = 0.5f;
		public Vector2 offset { get; set; } = Vector2.zero;
	}

	public class PolygonCollider2D : Collider2D
	{
		public Vector2[] points { get; set; } = new Vector2[0];
		public Vector2 offset { get; set; } = Vector2.zero;
		public void SetPath(int index, Vector2[] points) { this.points = points; }
	}

	public class EdgeCollider2D : Collider2D
	{
		public Vector2[] points { get; set; } = new Vector2[0];
		public Vector2 offset { get; set; } = Vector2.zero;
	}

	public class CapsuleCollider2D : Collider2D
	{
		public Vector2 size { get; set; } = Vector2.one;
		public Vector2 offset { get; set; } = Vector2.zero;
		public CapsuleDirection2D direction { get; set; }
	}

	public enum CapsuleDirection2D { Vertical = 0, Horizontal = 1 }
}
