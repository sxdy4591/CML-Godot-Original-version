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
var 当前曲目: int = -1
var 循环: bool = false
var 随机: bool = true

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

	_应用音量()
	_扫描专辑()
	if not 专辑目录列表.is_empty():
		选择专辑(0)
	print("[AudioSys] 音频总管就绪: %d 张专辑, 音乐音量 %d / 音效音量 %d"
			% [专辑目录列表.size(), _音乐音量, _音效音量])
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
	print("[AudioSys] 专辑列表: %s" % str(专辑名列表))


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
		return {"paths": paths, "names": names}
	# 回退: 扫描目录内音频文件
	var dir := DirAccess.open(目录)
	if dir == null:
		return {"paths": paths, "names": names}
	dir.list_dir_begin()
	var f := dir.get_next()
	while f != "":
		if not f.begins_with("."):
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
		var parsed: Variant = JSON.parse_string(FileAccess.get_file_as_string(path))
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

func _on_歌曲播完() -> void:
	if 当前曲目 < 0:
		return
	if 循环:
		背景音乐播放器.play()
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
