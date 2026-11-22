extends Control
## 快捷键页 — 端游重绑, 手机用的是同一张动作表.
## 动作表唯一来源: 逻辑层 ShortcutPane(快照 actions). 本页只做:
##   把快照里的 label 填到对应行的标题、把 playerprefs [ui] key_action_<id> 显示成键名、
##   捕获重绑按键并落盘. 不判断游戏数值.
## 键值口径: Godot 物理键码(与 OS.get_keycode_string 同域), 兼容层按同域读.
## 组合键: 主键存 key_action_<id>, 修饰位存 key_action_mod_<id>
##   (1=Ctrl 2=Shift 4=Alt), 重绑时一起捕获, 显示成 "Ctrl+Shift+5".

const 面板 := "快捷键"
const MOD_CTRL := 1
const MOD_SHIFT := 2
const MOD_ALT := 4

var _ui: Node
var _重绑: int = -1
## 动作默认键(逻辑层 ShortcutPane 给出): 配置里没有 key_action_<id> 时显示/使用它
var _默认: Dictionary = {}


func _ready() -> void:
	_ui = get_node("/root/UISettings")
	UiBridge.connect("panel_snapshot", _收到快照)
	for child in $滚动/列表.get_children():
		var 行名 := str(child.name)
		if not 行名.begins_with("Key"):
			continue
		var id := int(行名.substr(3, 行名.length() - 4))
		(child.get_node("Key%dRebind" % id) as Button).pressed.connect(_开始重绑.bind(id))
		(child.get_node("Key%d清除" % id) as Button).pressed.connect(_清除.bind(id))
	_刷新()
	UiBridge.request(面板)


# ---------- 快照: 标题以逻辑层动作表为准 ----------

func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	for a in data["actions"]:
		var id := int(a["id"])
		var 行 := get_node("滚动/列表/Key%d行" % id)
		(行.get_node("标题") as Label).text = str(a["label"])
		_默认[id] = int(a["key"])
	_刷新()


# ---------- 键位显示 ----------

func _行id列表() -> Array:
	var ids: Array = []
	for child in $滚动/列表.get_children():
		var 行名 := str(child.name)
		if not 行名.begins_with("Key"):
			continue
		ids.append(int(行名.substr(3, 行名.length() - 4)))
	return ids


## 一次读盘: 每行单独问 UISettings.get_int 会把同一个 ini 读 45 遍.
## 配置里没有 key_action_<id> = 逻辑层默认键(与 src/autoload/快捷键.gd 同一规则)
func _键文本表() -> Dictionary:
	var cfg := ConfigFile.new()
	cfg.load("user://playerprefs.ini")
	var 表 := {}
	for id in _行id列表():
		var 键名 := "key_action_%d" % id
		var 键: int = int(cfg.get_value("ui", 键名, 0)) if cfg.has_section_key("ui", 键名) else int(_默认.get(id, 0))
		var 修饰: int = int(cfg.get_value("ui", "key_action_mod_%d" % id, 0))
		表[id] = "—" if 键 == 0 else _修饰前缀(修饰) + OS.get_keycode_string(键)
	return 表


func _修饰前缀(修饰: int) -> String:
	var s := ""
	if 修饰 & MOD_CTRL:
		s += "Ctrl+"
	if 修饰 & MOD_SHIFT:
		s += "Shift+"
	if 修饰 & MOD_ALT:
		s += "Alt+"
	return s


func _修饰位(event: InputEventKey) -> int:
	var 修饰 := 0
	if event.ctrl_pressed:
		修饰 |= MOD_CTRL
	if event.shift_pressed:
		修饰 |= MOD_SHIFT
	if event.alt_pressed:
		修饰 |= MOD_ALT
	return 修饰


func _刷新() -> void:
	var 表 := _键文本表()
	for id in _行id列表():
		var lbl := get_node("滚动/列表/Key%d行/Key%dValue" % [id, id]) as Label
		lbl.text = "按下任意键…" if id == _重绑 else str(表[id])


# ---------- 重绑 ----------

func _开始重绑(id: int) -> void:
	_重绑 = id
	_刷新()


func _清除(id: int) -> void:
	_ui.set_int("key_action_%d" % id, 0)
	_ui.set_int("key_action_mod_%d" % id, 0)
	_刷新()


func _input(event: InputEvent) -> void:
	if _重绑 < 0:
		return
	if not (event is InputEventKey and event.pressed and not event.echo):
		return
	if event.keycode == KEY_ESCAPE or event.physical_keycode == KEY_ESCAPE:
		_重绑 = -1
		_刷新()
		get_viewport().set_input_as_handled()
		return
	var 键: int = event.physical_keycode if event.physical_keycode != 0 else event.keycode
	# 只按下修饰键本身不算一次绑定, 继续等主键
	if 键 == KEY_CTRL or 键 == KEY_SHIFT or 键 == KEY_ALT or 键 == KEY_META:
		return
	_ui.set_int("key_action_%d" % _重绑, 键)
	_ui.set_int("key_action_mod_%d" % _重绑, _修饰位(event))
	_重绑 = -1
	_刷新()
	get_viewport().set_input_as_handled()
