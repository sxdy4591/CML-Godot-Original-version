extends Control
## 战争界面 — 纯视图。进行中战争列表来自 WarPane。

const 面板 := "战争"
const 条目场景 := preload("res://scenes/战争/战争条目.tscn")

@onready var 列表: VBoxContainer = $战争列表滚动/战争列表
@onready var 空列表提示: Label = $空列表提示
@onready var 军事介入点数值: Label = $军事介入点数值


func _ready() -> void:
	find_child("导航栏", true, false).call("set_screen", "war")
	$返回.pressed.connect(_返回)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)


func _返回() -> void:
	get_tree().change_scene_to_file("res://scenes/外交/外交.tscn")


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	for child in 列表.get_children():
		child.queue_free()
	var wars: Array = data["wars"]
	for w in wars:
		var item := 条目场景.instantiate()
		列表.add_child(item)
		item.setup(w)
	空列表提示.visible = wars.is_empty()
	军事介入点数值.text = data["intervention"]
