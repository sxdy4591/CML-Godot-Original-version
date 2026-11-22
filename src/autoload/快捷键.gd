extends Node
## 快捷键(Autoload) — 这里只做"物理键 → 动作 id"的转发。
## 动作表、难度门控、数值操作全部在 C# 逻辑层 ShortcutPane(面板名 "快捷键"):
## 这里不判断游戏数值、不算结局、不碰 GameState。
##
## 捕获哪些动作: 从逻辑层 ShortcutPane 的快照里取 id >= 100 的全部(作弊/预算/超级),
## 本文件不写死编号. 0..4(时间/速度) 与 10..12(存/读/战争) 由原版 TimeScript + compat 别名处理,
## 这里不重复捕获, 否则按一次键触发两遍。
##
## 用 _unhandled_input 而不是 _input: 设置页重绑时自己的 _input 会 set_input_as_handled,
## 这里就收不到, 不会"一边重绑一边触发"。

const 面板 := "快捷键"

## 状态: 键码 → Array[{id, mod}](一个键可以同时绑多条, 原版 key_action_* 各自独立)
## 组合键: mod 是修饰位(1=Ctrl 2=Shift 4=Alt), 存在 key_action_mod_<id>.
const MOD_CTRL := 1
const MOD_SHIFT := 2
const MOD_ALT := 4

var _绑定: Dictionary = {}
var _捕获: Array = []
## 动作默认键(逻辑层 ShortcutPane 给出): 配置里没有 key_action_<id> 时才用
var _默认: Dictionary = {}
var _累计: float = 0.0

## 不在游戏里就不响应(主菜单/设置/关于/存档/成就这些界面没有可作弊的局)
const 非游戏场景 := [
	"res://scenes/主菜单/主菜单.tscn",
	"res://scenes/设置/设置.tscn",
	"res://scenes/关于/关于.tscn",
	"res://scenes/存档/保存.tscn",
	"res://scenes/存档/加载.tscn",
	"res://scenes/成就/成就.tscn",
]


func _ready() -> void:
	process_mode = Node.PROCESS_MODE_ALWAYS
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_捕获.clear()
	_默认.clear()
	for a in data["actions"]:
		var id := int(a["id"])
		if id >= 100:
			_捕获.append(id)
			_默认[id] = int(a["key"])
	_重建绑定()


func _process(delta: float) -> void:
	_累计 += delta
	if _累计 < 0.5:
		return
	_累计 = 0.0
	_重建绑定()


func _重建绑定() -> void:
	# 一次读盘: UISettings.get_int 每次都 load 一遍文件, 37 个动作逐个问会读 37 次.
	var cfg := ConfigFile.new()
	cfg.load("user://playerprefs.ini")
	_绑定.clear()
	for id in _捕获:
		var 键名 := "key_action_%d" % id
		# 配置里从没写过这个动作 = 用逻辑层默认键; 玩家在设置页点过清除(写 0)就真的不绑
		var 键: int = int(cfg.get_value("ui", 键名, 0)) if cfg.has_section_key("ui", 键名) else int(_默认.get(id, 0))
		if 键 == 0:
			continue
		var 修饰: int = int(cfg.get_value("ui", "key_action_mod_%d" % id, 0))
		var 项 := {"id": id, "mod": 修饰}
		if _绑定.has(键):
			_绑定[键].append(项)
		else:
			_绑定[键] = [项]


func _unhandled_input(event: InputEvent) -> void:
	if not (event is InputEventKey and event.pressed and not event.echo):
		return
	var 键: int = event.physical_keycode if event.physical_keycode != 0 else event.keycode
	if not _绑定.has(键):
		return
	if 非游戏场景.has(get_tree().current_scene.scene_file_path):
		return
	var 修饰 := 0
	if event.ctrl_pressed:
		修饰 |= MOD_CTRL
	if event.shift_pressed:
		修饰 |= MOD_SHIFT
	if event.alt_pressed:
		修饰 |= MOD_ALT
	for 项 in _绑定[键]:
		if int(项["mod"]) != 修饰:
			continue
		UiBridge.act(面板, "执行", [int(项["id"])])
	get_viewport().set_input_as_handled()
