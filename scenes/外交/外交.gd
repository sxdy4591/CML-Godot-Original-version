extends Control
## 外交（世界地图）界面 — 纯视图。
## 日期 / 速度 / 地图模式都来自逻辑层；本脚本只做控件赋值与信号转发。

const ESC菜单场景 := preload("res://scenes/通用/ESC菜单.tscn")
const 面板 := "游戏"

# ---------- 节点引用 ----------
@onready var time_label: Label = $时间/时间
@onready var pause_button: TextureButton = $时间/时间启停
@onready var speed_indicators: Array[ColorRect] = [
	$时间/速度1,
	$时间/速度2,
	$时间/速度3,
	$时间/速度4
]
@onready var speed_buttons: Array[Button] = [
	$时间/速度按钮1,
	$时间/速度按钮2,
	$时间/速度按钮3,
	$时间/速度按钮4
]
@onready var map_government: Button = $地图模式/政府类型地图模式
@onready var map_influence: Button = $地图模式/影响地图模式
@onready var map_military: Button = $地图模式/军事阵营地图模式
@onready var map_economy: Button = $地图模式/经济阵营地图模式

@onready var world_map: Node2D = $世界地图
@onready var country_panel: CanvasLayer = $国家面板

var last_speed: int = 4
var _speed: int = 0
var _date: String = ""
var _esc_menu: CanvasLayer = null
var _esc_button: BaseButton = null


func _ready() -> void:
	var nav := find_child("导航栏", true, false)
	nav.call("set_screen", "diplomacy")

	# 自动化勾选落在 playerprefs, 进游玩场景时推回逻辑层(bridge 只搬运, 不读配置)
	UiBridge.set_auto_types(UISettings.get_string("auto_types", ""))
	UiBridge.set_auto_decision(UISettings.get_bool("auto_decision", false))
	# 自动存档开关/槽位同样落盘在 playerprefs, 推回原版 GlobalScript 才真的会存
	UiBridge.set_save_options(UISettings.get_int("autosave", 1), UISettings.get_int("saveplace", 1))

	country_panel.connect("互动完成", _on_country_interact)

	pause_button.toggled.connect(_on_pause_toggled)
	for i in range(4):
		speed_buttons[i].pressed.connect(_on_speed_button_pressed.bind(i + 1))

	map_government.pressed.connect(_on_map_mode_pressed.bind(1))
	map_influence.pressed.connect(_on_map_mode_pressed.bind(3))
	map_military.pressed.connect(_on_map_mode_pressed.bind(0))
	map_economy.pressed.connect(_on_map_mode_pressed.bind(2))

	world_map.country_selected.connect(_on_map_country_selected)

	var decision_btn := get_node("地图模式/决议") as TextureButton
	decision_btn.pressed.connect(func() -> void:
		get_tree().change_scene_to_file("res://scenes/决议/决议.tscn"))

	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)

	var window_root := get_tree().root
	if not window_root.go_back_requested.is_connected(_on_go_back_request):
		window_root.go_back_requested.connect(_on_go_back_request)

	_setup_esc_button()


func _process(delta: float) -> void:
	_accum += delta
	if _accum < 0.5:
		return
	_accum = 0.0
	UiBridge.request(面板)
	if _speed > 0:
		last_speed = _speed
	_更新速度指示()


var _accum: float = 0.0


# ---------- 快照 ----------

func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_speed = int(data["speed"])
	_date = data["date"]
	time_label.text = _date
	_更新速度指示()
	pause_button.set_pressed_no_signal(_speed > 0)


func _更新速度指示() -> void:
	var highlight: int = _speed if _speed > 0 else last_speed
	var running: bool = _speed > 0
	for i in range(4):
		if i + 1 <= highlight:
			speed_indicators[i].color = Color(0.95, 0.1, 0.1, 1.0) if running else Color(0.95, 0.1, 0.1, 0.4)
		else:
			speed_indicators[i].color = Color(0.5, 0.5, 0.5, 0.3)


# ---------- 速度 ----------

func _on_speed_button_pressed(speed: int) -> void:
	UiBridge.act(面板, "设置速度", [speed])


func _on_pause_toggled(pressed: bool) -> void:
	UiBridge.act(面板, "设置速度", [last_speed if pressed else 0])


# ---------- 地图模式 ----------

func _on_map_mode_pressed(mode: int) -> void:
	UiBridge.act("地图", "设置模式", [mode])
	world_map.call("refresh_tints")


func _on_map_country_selected(index: int) -> void:
	country_panel.call("show_country", index)


# 国家面板互动(发展贸易等)改的是地图着色来源, 动作后立刻重拉地图色
func _on_country_interact() -> void:
	world_map.call("refresh_tints")


# ---------- ESC 暂停菜单 ----------

func _unhandled_input(event: InputEvent) -> void:
	if not (event is InputEventKey and event.pressed and not event.echo):
		return
	var key: int = event.physical_keycode if event.physical_keycode != 0 else event.keycode
	if key == KEY_ESCAPE:
		if _esc_menu == null:
			_toggle_esc_menu()
		get_viewport().set_input_as_handled()


func _setup_esc_button() -> void:
	var btn := get_node("顶层按钮/ESC") as BaseButton
	_esc_button = btn
	btn.focus_mode = Control.FOCUS_NONE
	btn.mouse_default_cursor_shape = Control.CURSOR_POINTING_HAND
	if not btn.pressed.is_connected(_toggle_esc_menu):
		btn.pressed.connect(_toggle_esc_menu)


func _toggle_esc_menu() -> void:
	if _esc_menu != null:
		_esc_menu.queue_free()
		_esc_menu = null
		get_tree().paused = false
	else:
		_esc_menu = ESC菜单场景.instantiate()
		add_child(_esc_menu)
		get_tree().paused = true
	_esc_button.visible = (_esc_menu == null)


func _on_go_back_request() -> void:
	_toggle_esc_menu()
