extends CanvasLayer
## 调试控制台(F12 呼出) — 纯视图: 输入交给逻辑层 DebugPane 执行, 输出只显示快照.
## 作弊快捷键(key_action_100..112)按原版语义只在难度 0 时生效.

const 面板 := "调试"

@onready var _output: RichTextLabel = $居中/面板/布局/输出
@onready var 输入框: LineEdit = $居中/面板/布局/输入行/输入

var _ui: Node


func _ready() -> void:
	process_mode = Node.PROCESS_MODE_ALWAYS
	_ui = get_node("/root/UISettings")
	# 控制台使用引擎默认字体, 不跟随项目主题
	var 默认主题 := Theme.new()
	默认主题.default_font = ThemeDB.fallback_font
	($居中/面板 as Control).theme = 默认主题
	_output.add_theme_font_override("normal_font", ThemeDB.fallback_font)
	输入框.add_theme_font_override("font", ThemeDB.fallback_font)
	UiBridge.connect("panel_snapshot", _收到快照)


func _input(event: InputEvent) -> void:
	if not (event is InputEventKey and event.pressed and not event.echo):
		return
	var 键: int = event.physical_keycode if event.physical_keycode != 0 else event.keycode
	if 键 == KEY_F12:
		if not _ui.get_bool("debug_console", true):
			return
		visible = not visible
		if visible:
			输入框.grab_focus()
			UiBridge.request(面板)
		get_viewport().set_input_as_handled()
		return
	if visible:
		return
	if _ui.get_int("difficulty", 2) != 0:
		return
	for i in 13:
		var 键码: int = _ui.get_int("key_action_%d" % (100 + i), 0)
		if 键码 != 0 and 键 == 键码:
			UiBridge.act(面板, "作弊", [i])
			get_viewport().set_input_as_handled()
			return


func _on_关闭_pressed() -> void:
	visible = false


func _on_执行_pressed() -> void:
	提交()


func _on_输入_submitted(_text: String) -> void:
	提交()


func 提交() -> void:
	var 命令 := 输入框.text.strip_edges()
	输入框.text = ""
	if 命令.is_empty():
		return
	UiBridge.act(面板, "执行", [命令])
	UiBridge.request(面板)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	$居中/面板/布局/标题栏/标题.text = "调试控制台 — " + str(data["date"])
	_output.text = "\n".join(PackedStringArray(data["lines"]))
