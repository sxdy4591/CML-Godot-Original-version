extends Node
## 音频总管(Autoload "AudioSys") — 参考 dh-4591 项目的独立音频管理方案:
## 专辑以文件夹为单位(assets/audio/music/<专辑名>/), 支持 info.json 定制
## 专辑名/曲目名/封面; 无 info.json 时按文件名扫描。音量/循环/随机持久化。
## 不使用原版 C# 音乐代码(GlobalScript.music/MusicReset/Total 等)。

signal 曲目变更(歌名: String)
signal 专辑变更

const 内置专辑根目录 := "res://assets/audio/music/"
# 外置专辑根目录候选名: 打包分发时与 exe 同级(如 CML[godot]V0.5.0.exe 同级的 专辑/),
# 便于玩家自行增删歌曲而不必重新打包(与 数据/ 目录同一套外置策略)。
# 语义与候选名均照搬改版 场景/音频系统/音频总管.gd:40-41。
const 外置专辑根目录名候选 := ["专辑", "音乐", "Albums", "Music"]
const 音频扩展名 := [".ogg", ".wav", ".mp3"]
const 图片扩展名 := [".png", ".jpg", ".jpeg", ".webp"]
const 信息文件候选 := ["info.json", "信息.json", "metadata.json"]
const 曲目数组键 := ["tracks", "songs", "music", "曲目", "歌曲", "音乐"]
const 音量范围 := 100   # 0-100, 默认 5(原版默认 voice=5 → 线性 0.05)

var 背景音乐播放器: AudioStreamPlayer
var 按钮按下: AudioStreamPlayer
var 按钮悬停: AudioStreamPlayer = null

var 专辑目录列表: Array[String] = []
var 专辑名列表: Array[String] = []
var 当前专辑目录: String = ""
var 当前曲目路径列表: Array[String] = []
var 当前曲目名列表: Array[String] = []
var 当前专辑索引: int = -1
# 事件内指定音乐(如毛主席逝世): 临时占用背景音乐播放器, 播完恢复原专辑曲目
var 事件音乐中: bool = false
var _事件音乐之前: Dictionary = {}
var 当前曲目: int = -1
var 循环: bool = false
var 随机: bool = true
# 全部专辑随机: 随机时跨专辑选曲(所有专辑的所有曲目)
var 全专辑随机: bool = false

## 持久化(与 C# 桥共用 user://playerprefs.ini, 独立分区, 不碰原代码)
var _cfg: ConfigFile
## 音乐/音效两条独立音量(0..100)。原实现只有一个 `_音量` 同时套在两条总线上,
## 玩家没法"音乐小、音效大" —— 现按用户要求分开, 各自持久化:
##   audio/music_volume  背景音乐总线
##   audio/sfx_volume    音效总线(按钮音/界面音)
## 旧存档只有 audio/voice, 首次读不到新键时用它做初值(等价于原来的行为)。
var _音乐音量: int = 5
var _音效音量: int = 5

func _ready() -> void:
	process_mode = Node.PROCESS_MODE_ALWAYS   # 暂停菜单期间音乐/点击音照常
	_cfg = ConfigFile.new()
	_cfg.load("user://playerprefs.ini")
	var 旧音量 := clampi(int(_cfg.get_value("audio", "voice", 5)), 0, 音量范围)
	_音乐音量 = clampi(int(_cfg.get_value("audio", "music_volume", 旧音量)), 0, 音量范围)
	_音效音量 = clampi(int(_cfg.get_value("audio", "sfx_volume", 旧音量)), 0, 音量范围)
	循环 = _cfg.get_value("audio", "loop", false) == true
	全专辑随机 = _cfg.get_value("audio", "all_shuffle", false) == true
	随机 = _cfg.get_value("audio", "shuffle", true) == true

	_确保总线()
	背景音乐播放器 = AudioStreamPlayer.new()
	背景音乐播放器.name = "背景音乐播放器"
	背景音乐播放器.bus = "背景音乐"
	背景音乐播放器.process_mode = Node.PROCESS_MODE_ALWAYS
	add_child(背景音乐播放器)
	背景音乐播放器.finished.connect(_on_歌曲播完)

	按钮按下 = AudioStreamPlayer.new()
	按钮按下.name = "按钮按下"
	按钮按下.bus = "音效"
	按钮按下.stream = preload("res://assets/audio/sfx/click_default.wav")
	add_child(按钮按下)

	UiBridge.connect("event_music", 播放事件音乐)
	_应用音量()
	_扫描专辑()
	if not 专辑目录列表.is_empty():
		选择专辑(0)
	print("[AudioSys] 音频总管就绪: %d 张专辑, 音乐音量 %d / 音效音量 %d"
			% [专辑目录列表.size(), _音乐音量, _音效音量])
	if OS.get_name() == "Android":
		print("[AudioSys] Android 已授权限: %s" % str(OS.get_granted_permissions()))
		_申请存储权限()
	# 注: 按项目要求已删除全局左键/滚轮点击音效; play_button_click_sound() 保留供按钮显式调用

# ============================== 专辑扫描 ==============================

## 专辑根目录们: 外置(存在就用第一个) + 内置 res://assets/audio/music/.
## 旧行为是"找到外置就只用外置", 会把内置专辑(红色浪潮等)挤掉; 现在两边都收,
## 同名专辑由前面的外置覆盖后面的内置(玩家定制优先), 其余全部保留.
func _专辑根目录列表() -> Array[String]:
	var 根们: Array[String] = []
	var 候选 := _候选外置专辑根目录()
	for 根 in 候选:
		if _目录存在(根):
			根们.append(根)
			break
	if _目录存在(内置专辑根目录) and not 根们.has(内置专辑根目录):
		根们.append(内置专辑根目录)
	if 根们.is_empty():
		# 一个都没找到: 把找过的位置打出来, 玩家照抄任意一条路径建「专辑」文件夹即可
		# (手机上没有控制台, 这条日志进 logs/godot.log, 桌面端排查同样有用)
		print("[AudioSys] 未找到外置专辑目录, 已尝试: %s" % str(候选))
	return 根们

func _候选外置专辑根目录() -> Array[String]:
	var 结果: Array[String] = []
	# 导入落点排第一: 导入与扫描必须是同一个根, 否则会出现"导进去了却看不见".
	# 编辑器里跑时 exe 是 Godot 编辑器、res:// 是项目目录, 两个根不是一回事.
	结果.append(_导入专辑根())
	var exe_dir := OS.get_executable_path().get_base_dir()
	var project_dir := ProjectSettings.globalize_path("res://")
	for 名 in 外置专辑根目录名候选:
		结果.append(exe_dir.path_join(名))
		结果.append(project_dir.path_join(名))
	# [手机/平板] 上面两个候选在 Android/iOS 上都落在**只读的安装包内部**
	# (exe = APK 路径, res:// = pck), 用户永远放不进去 —— 必须在公共目录里找。
	# 顺序放在桌面候选之后: 桌面行为保持不变(仍优先 exe 同级)。
	#   · user://            : 应用私有目录(/data/data/<包名>/files/专辑), 无需权限
	#   · 下载 / 音乐 / 文档  : 数据线或文件管理器直接放进去(Android 11+ 受分区存储限制)
	# 顺序: user:// 在公共目录之前 —— Android 11+ 即使申请了 READ_MEDIA_*,
	# 直接枚举 /storage/emulated/0 下的目录仍可能被拒, 应用私有目录没有这个问题.
	# [Android] 内部存储根: 玩家最常见的做法是把「专辑」直接拷到 手机存储/专辑,
	# 而不是放进 Download 子目录(需要「所有文件访问权限」, 见 _申请存储权限).
	if OS.get_name() == "Android":
		for 根 in _安卓存储根():
			for 名 in 外置专辑根目录名候选:
				结果.append(根.path_join(名))
	for 名 in 外置专辑根目录名候选:
		结果.append(OS.get_user_data_dir().path_join(名))
	for sys_dir in [OS.SYSTEM_DIR_DOWNLOADS, OS.SYSTEM_DIR_MUSIC, OS.SYSTEM_DIR_DOCUMENTS]:
		var base := OS.get_system_dir(sys_dir)
		if base.is_empty():
			continue
		for 名 in 外置专辑根目录名候选:
			结果.append(base.path_join(名))
	return 结果

func _目录存在(path: String) -> bool:
	return DirAccess.open(path) != null

func _目录含有音频(dir_path: String) -> bool:
	return not _扫描目录曲目(dir_path)["paths"].is_empty()

func _扫描专辑() -> void:
	专辑目录列表.clear()
	专辑名列表.clear()
	var 根们 := _专辑根目录列表()
	if 根们.is_empty():
		push_warning("[AudioSys] 内置 res://assets/audio/music 与 exe 同级「专辑」都不存在")
		return
	var 已收 := {}
	for 根 in 根们:
		for d in _根下专辑目录(根):
			# 跳过不含音频的子目录(外置目录里可能夹带杂项)
			if _扫描目录曲目(d)["paths"].is_empty():
				continue
			var 名 := _读专辑名(d)
			# 同名专辑: 先扫到的是外置, 后面的内置同名不再收(玩家定制优先)
			if 已收.has(名):
				continue
			已收[名] = true
			专辑目录列表.append(d)
			专辑名列表.append(名)
	print("[AudioSys] 加载 %d 张专辑, 来源: %s" % [专辑目录列表.size(), str(根们)])
	_构建全部曲目()
	print("[AudioSys] 专辑列表: %s" % str(专辑名列表))


## ============================== 专辑导入 ==============================
## 专辑包 = 一个 zip: 里面直接放音频/封面/info.json, 或者只有一个顶层专辑目录.
## 解压到玩家能自己看到、自己加歌的位置:
##   桌面   = exe 同级 专辑/（与 数据/ 同一套外置策略, 玩家拷文件就能加）
##   Android = /storage/emulated/0/专辑/（手机存储根, 文件管理器直接能看到）
## 与 _候选外置专辑根目录() 的第一名一致, 导入完立刻被扫到.
const 安卓外部专辑根 := "/storage/emulated/0"

signal 专辑导入进度(已: int, 总: int)
signal 专辑导入完成(消息: String)

func _导入专辑根() -> String:
	if OS.get_name() == "Android":
		return 安卓外部专辑根.path_join(外置专辑根目录名候选[0])
	if OS.has_feature("editor"):
		return ProjectSettings.globalize_path("res://").path_join(外置专辑根目录名候选[0])
	return OS.get_executable_path().get_base_dir().path_join(外置专辑根目录名候选[0])

func 导入专辑包(源: String) -> String:
	# 统一先落盘再解压: Android 的系统文件选择器给的是 content:// URI,
	# ZIPReader 只认可以随机读的普通路径; 落盘也用 FileAccess, 两种来源都覆盖.
	var 数据 := FileAccess.get_file_as_bytes(源)
	if 数据.is_empty():
		return _结束("读取失败：%s" % 源)
	var 临时 := "user://专辑导入.zip"
	var 临时文件 := FileAccess.open(临时, FileAccess.WRITE)
	临时文件.store_buffer(数据)
	临时文件.close()
	# 条目名与内容都交给逻辑层: Godot 的 ZIPReader 一律按 UTF-8 解条目名,
	# Windows 下 GBK 打包的包会整片乱码, 还会刷一屏 Unicode parsing error.
	var 名表: Array = UiBridge.zip_entry_names(ProjectSettings.globalize_path(临时))
	if 名表.is_empty():
		DirAccess.remove_absolute(临时)
		return _结束("不是有效的 zip 压缩包")
	var 顶层 := _单一顶层目录(名表)
	var 导入根 := _导入专辑根()
	var 名 := 顶层 if 顶层 != "" else 源.get_file().get_basename()
	# 压缩包最外层目录与专辑根同名(都叫「专辑」)时, 那层只是容器:
	# 剥掉它直接落到根下, 否则会变成 专辑/专辑/古风DJ 的套娃.
	var 剥顶层 := 顶层 != "" and 顶层 == 导入根.get_file()
	var 目标 := 导入根 if 剥顶层 else 导入根.path_join(名)
	DirAccess.make_dir_recursive_absolute(目标)
	var 写入 := 0
	# 一个包里可以有多个专辑(专辑/古风DJ/…、专辑/红色浪潮/…): 按相对路径首段收集, 完成时逐个报名字.
	var 专辑集 := {}
	for i in 名表.size():
		var 条目路径: String = 名表[i]
		if 条目路径.ends_with("/"):
			continue
		var 相对 := 条目路径.trim_prefix(顶层 + "/") if 顶层 != "" else 条目路径
		if 相对.is_absolute_path() or 相对.contains(".."):
			continue
		var 段 := 相对.split("/")
		var 首段: String = 段[0] if 段.size() > 1 else 名
		专辑集[首段] = true
		var 目的 := 目标.path_join(相对)
		UiBridge.zip_extract_entry(ProjectSettings.globalize_path(临时), i, 目的)
		写入 += 1
		专辑导入进度.emit(i + 1, 名表.size())
		# 一条一帧: 进度条按真实条目走, 大包也不会卡住界面
		await get_tree().process_frame
	DirAccess.remove_absolute(临时)
	if 写入 == 0:
		return _结束("压缩包里没有可导入的文件")
	重新扫描专辑(目标 if not 剥顶层 else "")
	var 名单 := ""
	for 专辑名 in 专辑集:
		名单 += "「%s」" % 专辑名
	return _结束("已导入%s（%d 个文件）→ %s" % [名单, 写入, 目标])

## 导入结束统一出口: 设置页切走/被释放后, 这里只发信号, 不再回调已释放的界面节点.
func _结束(消息: String) -> String:
	专辑导入完成.emit(消息)
	return 消息

## zip 里所有文件都在同一个顶层目录下时返回该目录名(专辑包常见结构), 否则返回 "".
func _单一顶层目录(名表: Array) -> String:
	var 顶层 := ""
	for 文件 in 名表:
		var 条目路径: String = 文件
		if 条目路径.ends_with("/"):
			continue
		var 段 := 条目路径.split("/")
		if 段.size() < 2:
			return ""
		if 顶层 == "":
			顶层 = 段[0]
		elif 顶层 != 段[0]:
			return ""
	return 顶层

## 导入/外部改动后重扫专辑并切到指定目录(不指定就保持当前).
func 重新扫描专辑(选中 := "") -> void:
	_扫描专辑()
	if 专辑目录列表.is_empty():
		return
	var 目标目录 := 选中 if 选中 != "" else 当前专辑目录
	var 索引 := 专辑目录列表.find(目标目录)
	选择专辑(maxi(索引, 0))

## 某个专辑根下的专辑目录(按文件夹名排序, 顺序稳定); 根目录本身直接放音频时当作一张专辑.
func _根下专辑目录(根: String) -> Array[String]:
	var 目录们: Array[String] = []
	var 目录 := DirAccess.open(根)
	if 目录 == null:
		push_warning("[AudioSys] 无法打开专辑根目录 %s" % 根)
		return 目录们
	目录.list_dir_begin()
	var 名称 := 目录.get_next()
	while 名称 != "":
		if 目录.current_is_dir() and not 名称.begins_with("."):
			目录们.append(根.path_join(名称))
		名称 = 目录.get_next()
	目录.list_dir_end()
	目录们.sort()
	if 目录们.is_empty() and _目录含有音频(根):
		目录们.append(根)
	return 目录们

## 扫描单个专辑目录的曲目 → {paths: Array[String], names: Array[String]}
## 编辑器: 直接枚举音频文件; 导出包/内置: 目录枚举只返回 .import 条目,
## 反推原始资源路径(ResourceLoader remap 在导出包中仍有效); 外置目录则是真实文件。
func _扫描目录曲目(目录: String) -> Dictionary:
	var paths: Array[String] = []
	var names: Array[String] = []
	var info := _读信息json(目录)
	var 条目: Array = []
	for key in 曲目数组键:
		if info.has(key) and info[key] is Array:
			条目 = info[key]
			break
	if not 条目.is_empty():
		for 条目元素 in 条目:
			var p := _解析曲目路径(条目元素, 目录)
			if p == "":
				continue
			paths.append(p)
			names.append(_解析曲目名(条目元素, p))
		# info.json 的曲目表一个都对不上磁盘(改名/子目录/编码不一致)时不能就此判成空专辑,
		# 继续按目录递归扫, 否则整张专辑被静默跳过
		if not paths.is_empty():
			return {"paths": paths, "names": names}
	# 回退: 递归扫描目录内音频文件
	_递归收集音频(目录, paths, names)
	# 路径/曲目名配对同步排序(原实现只排路径, 会导致列表错位)
	var pairs: Array = []
	for i in paths.size():
		pairs.append([paths[i], names[i]])
	pairs.sort_custom(func(a: Array, b: Array) -> bool:
		return String(a[0]) < String(b[0]))
	paths.clear()
	names.clear()
	for p in pairs:
		paths.append(p[0])
		names.append(p[1])
	return {"paths": paths, "names": names}

## 递归收集音频: 音乐包常见结构是 顶层专辑目录/子目录(如 古风DJ)/歌.mp3,
## 只扫一层会把这些专辑判成空目录直接跳过 —— 表现为"导入完加载不了".
func _递归收集音频(目录: String, paths: Array[String], names: Array[String]) -> void:
	var dir := DirAccess.open(目录)
	if dir == null:
		return
	dir.list_dir_begin()
	var f := dir.get_next()
	while f != "":
		if not f.begins_with("."):
			if dir.current_is_dir():
				_递归收集音频(目录.path_join(f), paths, names)
			else:
				var lower := f.to_lower()
				var 已加 := false
				for ext in 音频扩展名:
					if lower.ends_with(ext):
						paths.append(目录.path_join(f))
						names.append(f.get_basename())
						已加 = true
						break
				if not 已加 and lower.ends_with(".import"):
					var src := f.trim_suffix(".import")
					var src_path := 目录.path_join(src)
					if _是音频(src_path) and not paths.has(src_path):
						paths.append(src_path)
						names.append(src.get_basename())
		f = dir.get_next()
	dir.list_dir_end()

func _读专辑名(目录: String) -> String:
	var info := _读信息json(目录)
	for key in ["name", "title", "专辑名", "名称", "专辑"]:
		var s := str(info.get(key, "")).strip_edges()
		if s != "" and s != "<null>":
			return s
	return 目录.trim_suffix("/").get_file()

func _读信息json(目录: String) -> Dictionary:
	for f in 信息文件候选:
		var path := 目录.path_join(f)
		if not FileAccess.file_exists(path):
			continue
		# info.json 可能是 GBK(Windows 压缩软件常见), 经逻辑层按 UTF-8/GBK 解码后再解析;
		# 直接用 FileAccess.get_file_as_string 会刷一屏 Unicode parsing error 且解析失败.
		# res:// 是打包进 pck 的内置资源, C# 按文件路径读不到, 仍走 FileAccess(内置表本来就是 UTF-8).
		var 文本: String
		if path.begins_with("res://"):
			文本 = FileAccess.get_file_as_string(path)
		else:
			文本 = UiBridge.read_text(ProjectSettings.globalize_path(path) if path.begins_with("user://") else path)
		var parsed: Variant = JSON.parse_string(文本)
		if parsed is Dictionary:
			return parsed
	return {}

# ============================== 曲目 ==============================

func 选择专辑(索引: int) -> void:
	if 索引 < 0 or 索引 >= 专辑目录列表.size():
		return
	当前专辑索引 = 索引
	当前专辑目录 = 专辑目录列表[索引]
	_扫描当前专辑()
	当前曲目 = -1
	专辑变更.emit()
	# 选专辑后的第一首: 尊重随机开关 —— 旧实现一律随机, 随机关掉后"选专辑"仍乱序,
	# 玩家会以为随机开关没生效(与 _on_歌曲播完 的语义也不一致)。
	var 下一首 := _随机曲目索引() if 随机 else 0
	if 下一首 >= 0:
		播放曲目(下一首)

func _扫描当前专辑() -> void:
	当前曲目路径列表.clear()
	当前曲目名列表.clear()
	if 当前专辑目录 == "":
		return
	# 与 _扫描专辑 走同一套目录扫描(编辑器直读文件 / 导出包反推 .import / 外置绝对路径),
	# 避免两处逻辑分叉
	var r := _扫描目录曲目(当前专辑目录)
	当前曲目路径列表.assign(r["paths"])
	当前曲目名列表.assign(r["names"])

func _解析曲目路径(条目: Variant, 目录: String) -> String:
	if 条目 is String:
		var s := (条目 as String).strip_edges()
		if s == "":
			return ""
		if _是音频(s):
			return _解析相对路径(s, 目录)
		return _按歌名找音频(s, 目录)
	if 条目 is Dictionary:
		var dict := 条目 as Dictionary
		var file := str(dict.get("file", dict.get("path", dict.get("src", "")))).strip_edges()
		if file != "" and file != "<null>":
			return _解析相对路径(file, 目录)
		var n := str(dict.get("name", dict.get("title", ""))).strip_edges()
		if n != "":
			return _按歌名找音频(n, 目录)
	if 条目 is Array and (条目 as Array).size() >= 2:
		var arr := 条目 as Array
		var a := str(arr[0]).strip_edges()
		var b := str(arr[1]).strip_edges()
		if _是音频(a):
			return _解析相对路径(a, 目录)
		if _是音频(b):
			return _解析相对路径(b, 目录)
	return ""

func _解析曲目名(条目: Variant, path: String) -> String:
	if 条目 is Dictionary:
		var dict := 条目 as Dictionary
		var n := str(dict.get("name", dict.get("title", ""))).strip_edges()
		if n != "":
			return n
	if 条目 is Array and (条目 as Array).size() >= 2:
		var arr := 条目 as Array
		var a := str(arr[0]).strip_edges()
		var b := str(arr[1]).strip_edges()
		if a != "" and not _是音频(a):
			return a
		if b != "" and not _是音频(b):
			return b
	return path.get_file().get_basename()

func _是音频(s: String) -> bool:
	var lower := s.to_lower()
	for ext in 音频扩展名:
		if lower.ends_with(ext):
			return true
	return false

func _解析相对路径(file: String, 目录: String) -> String:
	if file.begins_with("res://") or file.begins_with("user://"):
		return file
	if file.begins_with("/") or file.contains(":"):
		return file
	return 目录.path_join(file)

func _按歌名找音频(歌名: String, 目录: String) -> String:
	var dir := DirAccess.open(目录)
	if dir == null:
		return ""
	var target := 歌名.strip_edges().to_lower()
	dir.list_dir_begin()
	var f := dir.get_next()
	while f != "":
		# 导出包: 目录枚举只有 .import 条目, 反推原始路径再按歌名匹配
		var candidate := f
		var lower := f.to_lower()
		if lower.ends_with(".import"):
			candidate = f.trim_suffix(".import")
		if candidate.get_basename().to_lower() == target:
			dir.list_dir_end()
			return 目录.path_join(candidate)
		f = dir.get_next()
	dir.list_dir_end()
	return ""

# ============================== 播放 ==============================

func 播放曲目(索引: int) -> void:
	if 索引 < 0 or 索引 >= 当前曲目路径列表.size():
		return
	var 流 := _加载音频(当前曲目路径列表[索引])
	if 流 == null:
		push_warning("[AudioSys] 无法加载曲目 %s" % 当前曲目路径列表[索引])
		return
	当前曲目 = 索引
	背景音乐播放器.stream = 流
	背景音乐播放器.play()
	曲目变更.emit(当前曲目名列表[索引])

func _加载音频(path: String) -> AudioStream:
	if path == "":
		return null
	var lower := path.to_lower()
	if lower.ends_with(".ogg"):
		return AudioStreamOggVorbis.load_from_file(path) if not path.begins_with("res://") else load(path)
	if lower.ends_with(".mp3"):
		return AudioStreamMP3.load_from_file(path) if not path.begins_with("res://") else load(path)
	if lower.ends_with(".wav"):
		return AudioStreamWAV.load_from_file(path) if not path.begins_with("res://") else load(path)
	return null

## 指定事件音乐: assets/audio/eventmusic/<名>.mp3
## 与专辑系统兼容: 只临时占用同一个播放器, 播完恢复事件前的专辑/曲目与播放状态.
func 播放事件音乐(名: String) -> void:
	var 路径 := "res://assets/audio/eventmusic/%s.mp3" % 名
	if not ResourceLoader.exists(路径):
		push_warning("[AudioSys] 事件音乐不存在: %s" % 路径)
		return
	var 流 := _加载音频(路径)
	if 流 == null:
		return
	_事件音乐之前 = {
		"专辑": 当前专辑索引,
		"曲目": 当前曲目,
		"播放中": 背景音乐播放器.playing,
	}
	事件音乐中 = true
	背景音乐播放器.stop()
	背景音乐播放器.stream = 流
	背景音乐播放器.play()
	曲目变更.emit("事件音乐：%s" % 名)

func _on_歌曲播完() -> void:
	if 事件音乐中:
		事件音乐中 = false
		var 之前: Dictionary = _事件音乐之前
		_事件音乐之前 = {}
		if bool(之前.get("播放中", false)) and int(之前.get("专辑", -1)) >= 0:
			选择专辑(int(之前["专辑"]))
			播放曲目(int(之前["曲目"]))
		return
	if 当前曲目 < 0:
		return
	if 循环:
		背景音乐播放器.play()
		return
	if 随机 and 全专辑随机:
		_随机全专辑曲目()
		return
	var 下一首: int = _随机曲目索引(当前曲目) if 随机 else _顺序下一首()
	if 下一首 >= 0:
		播放曲目(下一首)

func _随机曲目索引(排除 := -1) -> int:
	var 总数 := 当前曲目路径列表.size()
	if 总数 == 0:
		return -1
	if 总数 == 1:
		return 0
	var i := randi() % 总数
	while i == 排除:
		i = randi() % 总数
	return i

func _顺序下一首() -> int:
	var 总数 := 当前曲目路径列表.size()
	if 总数 == 0:
		return -1
	return (当前曲目 + 1) % 总数

## 所有专辑的所有曲目: [[专辑索引, 曲目索引], ...]
var _全部曲目: Array = []

func _构建全部曲目() -> void:
	_全部曲目.clear()
	for 专辑 in 专辑目录列表.size():
		var 曲目: Array = _扫描目录曲目(专辑目录列表[专辑])["paths"]
		for 编号 in 曲目.size():
			_全部曲目.append([专辑, 编号])

func _随机全专辑曲目() -> void:
	if _全部曲目.is_empty():
		return
	var 选中: Array = _全部曲目[randi() % _全部曲目.size()]
	if int(选中[0]) != 当前专辑索引:
		选择专辑(int(选中[0]))
	播放曲目(int(选中[1]))

func 设置全专辑随机(开启: bool) -> void:
	全专辑随机 = 开启
	_保存播放选项()

func 当前歌名() -> String:
	if 当前曲目 < 0 or 当前曲目 >= 当前曲目名列表.size():
		return ""
	return 当前曲目名列表[当前曲目]

func 切换循环() -> void:
	循环 = not 循环
	if 循环:
		# 循环=单曲重复, 与随机互斥: 两者同开时 _on_歌曲播完 里"循环"优先,
		# 随机永远不生效 —— 而两个按钮的灯都亮着, 玩家会以为随机按钮失效。
		随机 = false
	_保存播放选项()

func 切换随机() -> void:
	随机 = not 随机
	if 随机:
		循环 = false   # 同上: 保证两个开关不会同时点亮
	_保存播放选项()

## 播放选项落盘。user://playerprefs.ini 与 C# 桥共用(PlayerPrefs),
## 直接 save 会拿启动时的旧快照把桥后来写的段覆盖掉 → 先重读再改再存。
func _保存播放选项() -> void:
	_cfg.load("user://playerprefs.ini")
	_cfg.set_value("audio", "loop", 循环)
	_cfg.set_value("audio", "shuffle", 随机)
	_cfg.set_value("audio", "all_shuffle", 全专辑随机)
	_cfg.save("user://playerprefs.ini")

func 当前专辑索引_() -> int:
	return 当前专辑索引

func 专辑总数() -> int:
	return 专辑目录列表.size()

func 获取专辑名列表() -> Array:
	return 专辑名列表.duplicate()

func 获取当前曲目名列表() -> Array:
	return 当前曲目名列表.duplicate()

func 获取专辑封面(索引: int) -> Texture2D:
	if 索引 < 0 or 索引 >= 专辑目录列表.size():
		return null
	return _查找专辑图片(专辑目录列表[索引], false)

func 获取专辑封面_按下(索引: int) -> Texture2D:
	if 索引 < 0 or 索引 >= 专辑目录列表.size():
		return null
	var tex := _查找专辑图片(专辑目录列表[索引], true)
	return tex if tex != null else 获取专辑封面(索引)

func _查找专辑图片(目录: String, pressed: bool) -> Texture2D:
	var info := _读信息json(目录)
	var keys: Array = ["icon_pressed", "icon_h", "press_icon"] if pressed else ["icon", "cover", "封面", "图标"]
	for key in keys:
		var p := str(info.get(key, "")).strip_edges()
		if p != "" and p != "<null>":
			var tex := _加载图片(_解析相对路径(p, 目录))
			if tex != null:
				return tex
	var 候选: Array[String] = []
	if pressed:
		for ext in 图片扩展名:
			候选.append("icon_h" + ext)
	else:
		for ext in 图片扩展名:
			候选.append("icon" + ext)
			候选.append("cover" + ext)
	for f in 候选:
		var tex := _加载图片(目录.path_join(f))
		if tex != null:
			return tex
	# 封面常放在子目录里(专辑/子专辑/封面.jpg): 根目录没有就逐层往下找
	return _子目录找图片(目录, 候选)

func _子目录找图片(目录: String, 候选: Array[String]) -> Texture2D:
	var dir := DirAccess.open(目录)
	if dir == null:
		return null
	var 子目录们: Array[String] = []
	dir.list_dir_begin()
	var f := dir.get_next()
	while f != "":
		if not f.begins_with(".") and dir.current_is_dir():
			子目录们.append(目录.path_join(f))
		f = dir.get_next()
	dir.list_dir_end()
	for 子 in 子目录们:
		for 名 in 候选:
			var tex := _加载图片(子.path_join(名))
			if tex != null:
				return tex
	for 子 in 子目录们:
		var tex := _子目录找图片(子, 候选)
		if tex != null:
			return tex
	return null

func _加载图片(path: String) -> Texture2D:
	# res:// 是导出包内已导入资源: 走 ResourceLoader, 导出后仍可 load()
	if path.begins_with("res://"):
		return load(path) as Texture2D
	# 其余路径(user:// / Android 私有目录 / 绝对路径)统一读字节再解码:
	# Image.load_from_file 各平台对虚拟路径的处理不一致, FileAccess 全平台一致.
	var bytes := FileAccess.get_file_as_bytes(path)
	if bytes.is_empty():
		return null
	var lower := path.to_lower()
	var img := Image.new()
	var err := ERR_FILE_UNRECOGNIZED
	if lower.ends_with(".png"):
		err = img.load_png_from_buffer(bytes)
	elif lower.ends_with(".jpg") or lower.ends_with(".jpeg"):
		err = img.load_jpg_from_buffer(bytes)
	elif lower.ends_with(".webp"):
		err = img.load_webp_from_buffer(bytes)
	else:
		return null
	if err != OK:
		return null
	return ImageTexture.create_from_image(img)

# ============================== 总线/音量 ==============================
#
# 音乐/音效各一条总线, 各有一个独立音量(0..100):
#   背景音乐总线 ← _音乐音量   音效总线 ← _音效音量
# 旧接口 获取音量/调整音量/设置音量 保留为**音乐音量**的别名(历史调用点/存档兼容),
# 新代码一律用显式的 音乐/音效 版本。

func _确保总线() -> void:
	for bus_name in ["背景音乐", "音效"]:
		if AudioServer.get_bus_index(bus_name) >= 0:
			continue
		AudioServer.add_bus()
		var idx := AudioServer.bus_count - 1
		AudioServer.set_bus_name(idx, bus_name)
		AudioServer.set_bus_send(idx, "Master")

# ---- 音乐音量 ----

func 获取音乐音量() -> int:
	return _音乐音量

func 调整音乐音量(delta: int) -> void:
	_音乐音量 = _循环音量(_音乐音量 + delta)
	_保存音量()
	_应用音量()

func 设置音乐音量(v: int) -> void:
	_音乐音量 = clampi(v, 0, 音量范围)
	_保存音量()
	_应用音量()

# ---- 音效音量 ----

func 获取音效音量() -> int:
	return _音效音量

func 调整音效音量(delta: int) -> void:
	_音效音量 = _循环音量(_音效音量 + delta)
	_保存音量()
	_应用音量()

func 设置音效音量(v: int) -> void:
	_音效音量 = clampi(v, 0, 音量范围)
	_保存音量()
	_应用音量()

## 旧接口(等价于音乐音量): 设置页音频面板/旧调用点仍可用
func 获取音量() -> int:
	return 获取音乐音量()

func 调整音量(delta: int) -> void:
	调整音乐音量(delta)

func 设置音量(v: int) -> void:
	设置音乐音量(v)

## 加减超出 0..100 时回绕(与旧实现的循环调节一致: 加到顶再点 → 回到 0)
func _循环音量(v: int) -> int:
	if v > 音量范围:
		return 0
	if v < 0:
		return 音量范围
	return v

func _保存音量() -> void:
	# 同 _保存播放选项: 先重读, 避免覆盖 C# 桥(PlayerPrefs)刚写入的其它段
	_cfg.load("user://playerprefs.ini")
	_cfg.set_value("audio", "music_volume", _音乐音量)
	_cfg.set_value("audio", "sfx_volume", _音效音量)
	# voice 是原版/C# 桥读取的旧键: 同步成音乐音量, 保证外部逻辑读到的是最新值
	_cfg.set_value("audio", "voice", _音乐音量)
	_cfg.save("user://playerprefs.ini")

func _应用音量() -> void:
	_应用总线音量("背景音乐", _音乐音量)
	_应用总线音量("音效", _音效音量)

func _应用总线音量(bus_name: String, 音量: int) -> void:
	var idx := AudioServer.get_bus_index(bus_name)
	if idx < 0:
		return
	var 线性 := clampf(float(音量) / float(音量范围), 0.0, 1.0)
	AudioServer.set_bus_volume_db(idx, linear_to_db(clampf(线性, 0.001, 1.0)))
	AudioServer.set_bus_mute(idx, 线性 <= 0.0)

# ============================== 音效 ==============================

func play_button_click_sound() -> void:
	按钮按下.play()

func play_button_hover_sound() -> void:
	if 按钮悬停 == null:
		按钮悬停 = AudioStreamPlayer.new()
		按钮悬停.name = "按钮悬停"
		按钮悬停.bus = "音效"
		按钮悬停.stream = preload("res://assets/audio/sfx/click_mouse_over_01.wav")
		add_child(按钮悬停)
	按钮悬停.play()

func _on_gui_input(_event: InputEvent) -> void:
	pass  # 已改用 _input 全局触发

func _exit_tree() -> void:
	# 退出时停止播放, 避免 Ogg 解码资源在进程退出时滞留(退出时报资源仍在使用)
	if 背景音乐播放器:
		背景音乐播放器.stop()
	if 按钮按下:
		按钮按下.stop()
	if 按钮悬停:
		按钮悬停.stop()


# ============================== Android 存储权限 ==============================

## Android 11+ 的「所有文件访问权限」是特殊权限: 导出预设里声明(manage_external_storage)之后,
## 仍要在系统设置里手动开启. 这里申请一次, 之后每 2 秒重扫专辑, 玩家在系统设置里授权后不必重启游戏.
const 存储权限 := "android.permission.MANAGE_EXTERNAL_STORAGE"

## 内部存储根候选(/storage/emulated/0 等), 去重保序.
func _安卓存储根() -> Array[String]:
	var 根们: Array[String] = []
	for env in ["EXTERNAL_STORAGE", "SECONDARY_STORAGE", "EMULATED_STORAGE_TARGET"]:
		var p := OS.get_environment(env)
		if not p.is_empty() and not 根们.has(p):
			根们.append(p)
	var 下载 := OS.get_system_dir(OS.SYSTEM_DIR_DOWNLOADS)
	var 上级 := 下载.get_base_dir()
	if not 上级.is_empty() and not 根们.has(上级):
		根们.append(上级)
	return 根们


## 申请一次即可: 特殊权限走的是系统设置页, request_permission 可能在设置页里等玩家操作.
func _申请存储权限() -> void:
	if OS.get_granted_permissions().has(存储权限):
		return
	print("[AudioSys] 申请存储权限: %s" % 存储权限)
	OS.request_permission(存储权限)
	_复查专辑(0)


## 玩家从设置页回来后权限才生效, 而且 get_granted_permissions() 对特殊权限不一定如实上报;
## 所以不看权限位, 直接每隔 2 秒重扫一次专辑(最多 5 分钟), 扫到新专辑就切过去.
var _复查次数 := 0
const 复查上限 := 150

func _复查专辑(_第几次: int) -> void:
	var 计时 := get_tree().create_timer(2.0)
	计时.timeout.connect(func() -> void:
		_复查次数 += 1
		var 原专辑 := 当前专辑目录
		var 原数量 := 专辑目录列表.size()
		_扫描专辑()
		if 专辑目录列表.find(原专辑) < 0 and not 专辑目录列表.is_empty():
			选择专辑(0)
		elif 专辑目录列表.size() != 原数量:
			print("[AudioSys] 复查发现专辑数量变化: %d → %d" % [原数量, 专辑目录列表.size()])
		if _复查次数 < 复查上限:
			_复查专辑(_复查次数))
