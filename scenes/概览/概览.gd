extends Control
## 概览界面 — 纯视图。六页内容与修正列表由 OverviewPane 调原版组件生成。
## 只显示当前页; 左右方向键切换影响页/盟友页(原版 ChinesePage)。

const 面板 := "概览"
const 外交场景 := "res://scenes/外交/外交.tscn"
const 修正模板场景 := preload("res://scenes/概览/修正模板.tscn")
const 标题色 := "#941712"
const 标题字号 := 28

@onready var 页容器: Array[RichTextLabel] = [
	$交易概览, $影响概览, $领土概览, $形势概览, $凝聚力概览, $盟友概览
]
@onready var 页签: Array[Button] = [
	$显示交易概览, $显示影响概览, $显示领土概览, $显示形势概览, $显示凝聚力概览, $显示盟友概览
]
@onready var 修正列表: VBoxContainer = $修正显示区域/ScrollContainer/修正列表
@onready var 滚动: ScrollContainer = $修正显示区域/ScrollContainer

var _快照: Dictionary = {}
var _当前页: int = 0


func _ready() -> void:
	find_child("导航栏", true, false).call("set_screen", "overview")
	for i in 页签.size():
		页签[i].pressed.connect(_显示页.bind(i))
	UiBridge.connect("panel_snapshot", _收到快照)
	_显示页(0)
	UiBridge.request(面板)


func _unhandled_input(event: InputEvent) -> void:
	if not (event is InputEventKey and event.pressed and not event.echo):
		return
	if event.keycode == KEY_ESCAPE:
		get_tree().change_scene_to_file(外交场景)
	elif event.keycode == KEY_LEFT or event.keycode == KEY_RIGHT:
		UiBridge.act(面板, "toggle_page", [])
		UiBridge.request(面板)


func _显示页(index: int) -> void:
	_当前页 = index
	for i in 页容器.size():
		页容器[i].visible = i == index
		按钮特效.set_base_modulate(页签[i], Color.WHITE if i == index else Color(0.7, 0.7, 0.7))
	_渲染()


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_快照 = data
	_渲染()
	_渲染修正()


func _渲染() -> void:
	if _快照.is_empty():
		return
	var columns: Array = _快照["pages"][_当前页]["columns"]
	var lines := PackedStringArray()
	for column in columns:
		var 标题名: String = str(column["name"])
		var text: String = str(column["text"])
		if not 标题名.is_empty():
			lines.append("[center][color=%s][font_size=%d][b]%s[/b][/font_size][/color][/center]" % [标题色, 标题字号, 标题名])
		if not text.is_empty():
			lines.append(悬浮提示.unity_to_bbcode(text).replace("|", "\n"))
	页容器[_当前页].text = "\n".join(lines)
	滚动.scroll_vertical = 0


func _渲染修正() -> void:
	for child in 修正列表.get_children():
		child.queue_free()
	for modifier in _快照["modifiers"]:
		var node := 修正模板场景.instantiate()
		修正列表.add_child(node)
		node.setup(int(modifier["id"]), modifier)
