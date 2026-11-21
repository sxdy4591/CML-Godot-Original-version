// ============================================================
// UnityCompat — IO: PlayerPrefs / Resources / TextAsset / SceneManager
// PlayerPrefs → user://playerprefs.ini (Godot ConfigFile)
// Resources.Load → GameDataRegistry 名称映射表(由 Bridge 注册)
// SceneManager.LoadScene → SceneRouter 场景映射表(由 Bridge 注册)
// ============================================================
using System;
using System.Collections.Generic;
using Godot;

namespace UnityEngine
{
	//Unity PlayerPrefs 兼容 — 持久化到 user://playerprefs.ini
	public static class PlayerPrefs
	{
		private const string FileName = "user://playerprefs.ini";
		private static ConfigFile _cfg;
		private static bool _loaded = false;
		private static bool _dirty = false;

		private static void EnsureLoaded()
		{
			if (_loaded) return;
			_loaded = true;
			_cfg = new ConfigFile();
			Error err = _cfg.Load(FileName);
			if (err != Error.Ok && err != Error.FileNotFound)
			{
				GD.PushWarning($"[PlayerPrefs] 读取 {FileName} 失败: {err}");
			}
		}

		private static void SaveIfDirty()
		{
			if (_dirty)
			{
				_dirty = false;
				_cfg.Save(FileName);
			}
		}

		public static bool HasKey(string key)
		{
			EnsureLoaded();
			return _cfg.HasSectionKey("prefs", key);
		}

		public static void DeleteKey(string key)
		{
			EnsureLoaded();
			if (_cfg.HasSectionKey("prefs", key))
			{
				_cfg.EraseSectionKey("prefs", key);
				_dirty = true;
			}
		}

		public static void DeleteAll()
		{
			EnsureLoaded();
			_cfg.EraseSection("prefs");
			_dirty = true;
		}

		public static void Save()
		{
			EnsureLoaded();
			SaveIfDirty();
		}

		public static int GetInt(string key, int defaultValue = 0)
		{
			EnsureLoaded();
			return _cfg.HasSectionKey("prefs", key) ? (int)_cfg.GetValue("prefs", key, defaultValue) : defaultValue;
		}

		public static void SetInt(string key, int value)
		{
			EnsureLoaded();
			_cfg.SetValue("prefs", key, value);
			_dirty = true;
		}

		public static float GetFloat(string key, float defaultValue = 0f)
		{
			EnsureLoaded();
			return _cfg.HasSectionKey("prefs", key) ? (float)_cfg.GetValue("prefs", key, defaultValue) : defaultValue;
		}

		public static void SetFloat(string key, float value)
		{
			EnsureLoaded();
			_cfg.SetValue("prefs", key, value);
			_dirty = true;
		}

		public static string GetString(string key, string defaultValue = "")
		{
			EnsureLoaded();
			return _cfg.HasSectionKey("prefs", key) ? (string)_cfg.GetValue("prefs", key, defaultValue) : defaultValue;
		}

		public static void SetString(string key, string value)
		{
			EnsureLoaded();
			_cfg.SetValue("prefs", key, value);
			_dirty = true;
		}
	}

	//Unity TextAsset 兼容 — 包装文本数据
	public class TextAsset : Object
	{
		public string text = "";
		public byte[] bytes = Array.Empty<byte>();

		public TextAsset() { }
		public TextAsset(string text) { this.text = text; }

		public override string ToString() => text;
	}

	//Unity Resources 兼容 — 经 GameDataRegistry 映射到 res:// 路径
	public static class Resources
	{
		//原版装饰性傀儡图标(PuppetIcons\N), 本项目未移植该资产,
		/// UI 侧有文本兜底, 加载失败属预期 — 静默返回 null 避免警告刷屏
		private static bool IsMissingDecorative(string path) =>
			path != null && path.StartsWith("PuppetIcons", StringComparison.OrdinalIgnoreCase);

		public static T Load<T>(string path) where T : Object
		{
			var asset = GameDataRegistry.Load(path);
			if (asset is T t) return t;
			if (asset == null && typeof(T) == typeof(TextAsset))
			{
				// 允许直接按 res:// 相对路径读文本
				string text = GameDataRegistry.LoadTextFile(path);
				if (text != null) return new TextAsset(text) { name = path } as T;
			}
			if (asset == null && !IsMissingDecorative(path))
			{
				GD.PushWarning($"[Resources.Load] 未注册的资源: {path} ({typeof(T).Name})");
			}
			return null;
		}

		public static Object Load(string path)
		{
			var asset = GameDataRegistry.Load(path);
			if (asset != null) return asset;
			// 文本资源回退: 从 res://data/ 读取
			string text = GameDataRegistry.LoadTextFile(path);
			if (text != null) return new TextAsset(text) { name = path };
			if (!IsMissingDecorative(path))
			{
				GD.PushWarning($"[Resources.Load] 未注册的资源: {path} (Object)");
			}
			return null;
		}

		public static T[] LoadAll<T>(string path) where T : Object => Array.Empty<T>();
		public static Object[] LoadAll(string path) => Array.Empty<Object>();
		public static void UnloadAsset(Object assetToUnload) { }
		public static ResourceRequest LoadAsync(string path, Type type) => new ResourceRequest();
	}

	public class ResourceRequest : AsyncOperation
	{
		public Object asset => null;
	}

	public class AsyncOperation : Object
	{
		public bool isDone => true;
		public float progress => 1f;
		public bool allowSceneActivation { get; set; } = true;
	}
	//
	/// 资源注册表 — Bridge 层注册原版资源名 → Godot 路径的映射。
	/// GDScript 也可以调用 src/bridge/GameData 的方法注册。
	/// 
	public static class GameDataRegistry
	{
		private static readonly Dictionary<string, string> _mappings = new Dictionary<string, string>();
		private static readonly Dictionary<string, Func<Object>> _factories = new Dictionary<string, Func<Object>>();

		public static void Register(string unityName, string resPath)
		{
			_mappings[unityName] = resPath;
		}

		public static void RegisterFactory(string unityName, Func<Object> factory)
		{
			_factories[unityName] = factory;
		}

		public static Object Load(string unityName)
		{
			if (_factories.TryGetValue(unityName, out var f)) return f();
			if (_mappings.TryGetValue(unityName, out var resPath))
			{
				var res = ResourceLoader.Load(resPath);
				if (res != null)
				{
					// 尝试包装为兼容对象
					return new ResourceWrapper(res) { name = unityName };
				}
			}
			return null;
		}

		//
		/// 读取文本数据。多级回退, 优先级从高到低:
		///  1. 注册表映射路径 (res:// 下的任何位置)
		///  2. res://data/ 与 res:// (pck/编辑器内含 txt 时)
		///  3. 可执行文件旁的 数据/ 目录 (把 txt 与 exe 放一起即可, 无需重导出)
		///  4. user://数据/
		///  5. 程序集嵌入资源 (数据/*.txt 已嵌入 DLL, 导出后最稳)
		/// 
		public static string LoadTextFile(string unityName)
		{
			return ApplyKnownDataFixes(unityName, NormalizeNewlines(LoadTextFileRaw(unityName)));
		}

		// 1.132 数据缺陷: 英文焦点文本 new_focuses_texts_en 缺 4 个 key
		// (俄语版有), 原版 FocusReader.CreateFocuses 遇到缺失 key 会抛
		// KeyNotFoundException, 新局直接崩在 GameStartScript.OnMouseDown。
		// 在**读取层**补齐占位项, data/*.txt 保持 1.132 原样。
		// 出处: src/original/Focuses/*.cs 的 AddFocus 字面量与 data 实际 key 集合之差。
		private static readonly string[] _focusTextMissingKeys =
		{
			"Death of Biedich", "Fall Yemen", "People", "President end",
		};

		private static string ApplyKnownDataFixes(string unityName, string text)
		{
			if (unityName != "new_focuses_texts_en") return text;
			if (string.IsNullOrEmpty(text)) return text;
			var sb = new System.Text.StringBuilder(text);
			foreach (var key in _focusTextMissingKeys)
			{
				if (text.Contains(key)) continue;
				if (sb.Length > 0 && sb[sb.Length - 1] != '\n') sb.Append('\n');
				sb.Append("<new way>\n    <name> \n        ").Append(key)
				  .Append("\n    <title> \n         ").Append(key)
				  .Append("\n    <desc> \n         ").Append(key)
				  .Append("\n    <icon> \n        none\n<end way>\n");
			}
			return sb.ToString();
		}

		private static string NormalizeNewlines(string text)
		{
			if (string.IsNullOrEmpty(text)) return text;
			if (text.IndexOf('\r') < 0) return text;
			return text.Replace("\r\n", "\n").Replace('\r', '\n');
		}

		private static string LoadTextFileRaw(string unityName)
		{
			if (_mappings.TryGetValue(unityName, out var resPath))
			{
				using var file = FileAccess.Open(resPath, FileAccess.ModeFlags.Read);
				if (file != null) return file.GetAsText();
			}
			// 直接尝试 res:// 下的数据目录
			foreach (var basePath in new[] { "res://data/", "res://" })
			{
				using var f = FileAccess.Open(basePath + unityName + ".txt", FileAccess.ModeFlags.Read);
				if (f != null) return f.GetAsText();
			}
			// 磁盘回退: exe 同目录 数据/ (导出后把 数据/ 拷到 exe 旁即可生效)
			string exeDir = OS.GetExecutablePath().GetBaseDir();
			if (!string.IsNullOrEmpty(exeDir))
			{
				using var f = FileAccess.Open(exeDir + "数据/" + unityName + ".txt", FileAccess.ModeFlags.Read);
				if (f != null) return f.GetAsText();
			}
			// 用户数据目录回退
			using (var f = FileAccess.Open("user://数据/" + unityName + ".txt", FileAccess.ModeFlags.Read))
			{
				if (f != null) return f.GetAsText();
			}
			// 程序集嵌入回退
			return LoadEmbeddedText(unityName);
		}

		private static readonly Dictionary<string, string> _embeddedCache = new Dictionary<string, string>();
		// 未命中同样缓存: 否则每次调用都重扫资源名表 + 重打警告 (Resources.Load 的常见路径)
		private static readonly HashSet<string> _embeddedMiss = new HashSet<string>();
		private static string[] _manifestNames;

		//
		/// 从程序集嵌入资源读取文本 (csproj 中 data/*.txt → EmbeddedResource)。
		/// 兼容 LogicalName=文件名 与 RootNamespace.路径 两种命名, 按后缀匹配。
		/// 
		private static string LoadEmbeddedText(string unityName)
		{
			if (_embeddedCache.TryGetValue(unityName, out var cached)) return cached;
			if (_embeddedMiss.Contains(unityName)) return null;
			var asm = typeof(GameDataRegistry).Assembly;
			// 资源名表只取一次 (原来是每次新 string[] + 每个名字两次 EndsWith)
			if (_manifestNames == null) _manifestNames = asm.GetManifestResourceNames();
			foreach (var resName in _manifestNames)
			{
				bool hit = resName.Equals(unityName, StringComparison.Ordinal)
						|| resName.EndsWith("." + unityName, StringComparison.Ordinal)
						|| resName.EndsWith("." + unityName + ".txt", StringComparison.Ordinal);
				if (!hit) continue;
				using var stream = asm.GetManifestResourceStream(resName);
				if (stream == null) continue;
				using var reader = new System.IO.StreamReader(stream, System.Text.Encoding.UTF8);
				string text = reader.ReadToEnd();
				_embeddedCache[unityName] = text;
				return text;
			}
			_embeddedMiss.Add(unityName);
			return null;
		}

		//包装 Godot 资源的最小对象(供需要非空引用的代码使用)
		public class ResourceWrapper : Object
		{
			public Resource GodotResource { get; }
			public ResourceWrapper(Resource res) { GodotResource = res; }
		}
	}
}

namespace UnityEngine.SceneManagement
{
	//Unity SceneManager 兼容 — 经 SceneRouter 映射到 Godot 场景
	public static class SceneManager
	{
		public static void LoadScene(string sceneName) => SceneRouter.LoadScene(sceneName);
		public static void LoadScene(string sceneName, LoadSceneMode mode) => SceneRouter.LoadScene(sceneName);
		public static Scene GetActiveScene() => new Scene { name = SceneRouter.CurrentSceneName };
		public static Scene GetSceneByName(string name) => new Scene { name = name };
		public static int sceneCount => 1;
		public static void LoadSceneAsync(string sceneName) => SceneRouter.LoadScene(sceneName);
		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { SceneRouter.LoadScene(sceneName); return new AsyncOperation(); }
	}

	public enum LoadSceneMode { Single = 0, Additive = 1 }

	public struct Scene
	{
		public string name;
		public int buildIndex => 0;
		public bool isLoaded => true;
		public string path => "res://";
		public bool IsValid() => true;
		public override string ToString() => name;
	}

	//
	/// 场景路由 — 原版场景名 → Godot .tscn 路径。
	/// 默认注册原版场景名; 尚未实现的场景记日志并保持当前场景。
	/// 
	public static class SceneRouter
	{
		private static readonly Dictionary<string, string> _map = new Dictionary<string, string>
		{
			{ "Event", "res://scenes/事件/事件.tscn" },
			{ "Results", "res://scenes/事件/事件.tscn" },
			{ "Diplomacy", "res://scenes/外交/外交.tscn" },
			{ "Map", "res://scenes/外交/外交.tscn" },
			{ "Economy", "res://scenes/经济/经济.tscn" },
			{ "Ending", "res://scenes/结局/结局.tscn" },
			{ "War", "res://scenes/战争/战争.tscn" },
			{ "MainMenu", "res://scenes/主菜单/主菜单.tscn" },
			// 注意: "Main"(原版主菜单) 有意未注册 — 本项目开局由 GlobalScript._Ready
			// 自动 bootstrap 进外交, 不经过主菜单; StartGameScript/LanguageScript
			// 仍可能调用 LoadScene("Main"), 走下方未注册警告即可。
		};

		public static string CurrentSceneName { get; private set; } = "";

		//桥接合成防切: 结果页点击时事件.gd 自己负责切场景; 原版 EventN.Update 里的
		//SceneManager.LoadScene(...) 若此刻同步 ChangeSceneToFile, 会把当前事件场景从树中
		//释放, 事件.gd 后续 get_tree() 返回 null 崩溃。桥层在调用 Update 期间开启此开关:
		//不真正切场景, 只把"原版请求了哪个场景"记录下来供调用方决定。
		public static bool SuppressLoadScene;

		//SuppressLoadScene 期间最近一次 LoadScene 请求(Unity 场景名); 无请求为 null。
		//**必须按请求场景路由, 不能把"有请求"当成"进结局"** —— 链式事件(669→456)与
		//真结局事件(5→Ending)都会置 load_scene_after_click, 唯一可靠的区别是 Update 里
		//LoadScene 的参数本身。
		private static string _capturedScene;

		public static void ClearCapturedScene() => _capturedScene = null;

		//取走并清空被抑制的 LoadScene 请求
		public static string ConsumeCapturedScene()
		{
			var captured = _capturedScene;
			_capturedScene = null;
			return captured;
		}

		//原版场景名 → Godot .tscn 路径(未注册返回 false)
		public static bool TryGetScenePath(string unityName, out string godotPath)
		{
			godotPath = null;
			if (string.IsNullOrEmpty(unityName)) return false;
			return _map.TryGetValue(unityName, out godotPath);
		}

		public static void RegisterScene(string unityName, string godotPath)
		{
			_map[unityName] = godotPath;
		}

		public static bool HasScene(string unityName) => _map.ContainsKey(unityName);

		//桥层订阅这个出口, 把原版场景名转成 Godot 场景请求
		public static event System.Action<string> Requested;

		public static void LoadScene(string unityName)
		{
			if (string.IsNullOrEmpty(unityName))
			{
				return; // 原版 new_scene 为空时表示不切换场景
			}
			if (SuppressLoadScene)
			{
				// 桥层合成点击期间只记录原版请求的目标场景(写结局号等副作用照常执行),
				// 到底切到哪由调用方按 capturedScene 决定 — 见 EventBridge.OnResultClick。
				// 这里不查 _map: 未注册的场景也要捕获, 让调用方能报出"事件请求了哪个未实现场景"。
				_capturedScene = unityName;
				return;
			}
			Requested?.Invoke(unityName);
		}
	}
}
