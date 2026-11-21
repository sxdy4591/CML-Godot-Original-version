extends CanvasLayer
## 国家列表 — "地图上点不到"的三个小国的入口。
## 原版 CountryScript.cs 在外交界面右缘常驻三面国旗(格林纳达 48 / 塞舌尔 155 / 科摩罗 158),
## 点击与地图点选同一条路径。这里收成导航栏下方的"地图外国家"按钮 + 横排旗条,
## 国名常显(触屏没有 tooltip)。数据只有国名, 来自 CountryListPane。

signal country_selected(index: int)

const 面板 := "国家列表"
const 展开时长 := 0.15

@onready var _toggle_btn: TextureButton = $托盘/开关
@onready var _rows: Control = $托盘/行容器

var _open := false
var _tween: Tween
var _rows_base_y := 0.0


func _ready() -> void:
	_rows.visible = false
	_rows.modulate.a = 0.0
	# 记住场景里摆好的纵向位置: 动画只做相对位移, 不能把 offset 冲掉
	_rows_base_y = _rows.position.y
	_toggle_btn.pressed.connect(_toggle)
	if not DisplayServer.is_touchscreen_available():
		_toggle_btn.mouse_entered.connect(_open_panel)
	for node in _rows.get_children():
		if not (node is BaseButton) or not node.has_meta("country_index"):
			continue
		var btn := node as BaseButton
		var index := int(btn.get_meta("country_index"))
		btn.pressed.connect(_on_picked.bind(index))
		btn.mouse_entered.connect(_set_hover.bind(btn, true))
		btn.mouse_exited.connect(_set_hover.bind(btn, false))
		# 触屏没有 hover: 用按下态给反馈
		btn.button_down.connect(_set_pressed.bind(btn, true))
		btn.button_up.connect(_set_pressed.bind(btn, false))
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	var countries: Array = data["countries"]
	for node in _rows.get_children():
		if not (node is BaseButton) or not node.has_meta("country_index"):
			continue
		var btn := node as BaseButton
		for item in countries:
			if int(item["index"]) != int(btn.get_meta("country_index")):
				continue
			btn.tooltip_text = str(item["name"])
			(btn.get_node("名称") as Label).text = str(item["name"])


# ---------- 开合 ----------

func _toggle() -> void:
	if _open:
		_close()
	else:
		_open_panel()


func _open_panel() -> void:
	if _open:
		return
	_open = true
	_rows.visible = true
	_rows.position.y = _rows_base_y + 6.0
	if _tween != null:
		_tween.kill()
	_tween = create_tween().set_trans(Tween.TRANS_CUBIC).set_ease(Tween.EASE_OUT)
	_tween.tween_property(_rows, "position:y", _rows_base_y, 展开时长)
	_tween.parallel().tween_property(_rows, "modulate:a", 1.0, 展开时长 * 0.8)


func _close() -> void:
	if not _open:
		return
	_open = false
	if _tween != null:
		_tween.kill()
	_tween = create_tween().set_trans(Tween.TRANS_CUBIC).set_ease(Tween.EASE_IN)
	_tween.tween_property(_rows, "position:y", _rows_base_y + 6.0, 展开时长)
	_tween.parallel().tween_property(_rows, "modulate:a", 0.0, 展开时长 * 0.7)
	_tween.tween_callback(func() -> void: _rows.visible = false)


# ---------- 交互 ----------

func _on_picked(index: int) -> void:
	_close()
	country_selected.emit(index)


func _set_hover(btn: BaseButton, entered: bool) -> void:
	if DisplayServer.is_touchscreen_available():
		return
	btn.modulate = Color(1.25, 1.25, 1.25) if entered else Color.WHITE


func _set_pressed(btn: BaseButton, down: bool) -> void:
	btn.modulate = Color(0.82, 0.82, 0.82) if down else Color.WHITE
