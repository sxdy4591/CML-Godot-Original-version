extends Control
## 决议界面 — 纯视图。决议列表来自 DecisionPane。

const 面板 := "决议"
const 条目场景 := preload("res://scenes/决议/决议条目.tscn")

@onready var 列表: VBoxContainer = $决议滚动/决议列表
@onready var 空提示: Label = $决议滚动/空提示

var _签名: String = ""
var _决议自动: bool = false


func _ready() -> void:
	$返回.pressed.connect(_返回)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)
	# 自动化会在后台执行周期型决议; 开着本页时把已执行的那条刷成"已完成"(按钮一并消失)
	var 计时器 := Timer.new()
	计时器.wait_time = 1.0
	计时器.timeout.connect(func() -> void: UiBridge.request(面板))
	add_child(计时器)
	计时器.start()


func _返回() -> void:
	get_tree().change_scene_to_file("res://scenes/外交/外交.tscn")


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	# 决议自动开关的真值在逻辑层, 这里只负责抄进 playerprefs
	var 自动 := bool(data["auto_decision"])
	if 自动 != _决议自动:
		_决议自动 = 自动
		UISettings.set_bool("auto_decision", 自动)
	var items: Array = data["decisions"]
	# 原版 FocusesScript.Repaint 的排布: 可执行置顶, 条件未满足居中, 已完成沉底
	var 可执行: Array = []
	var 未满足: Array = []
	var 已完成: Array = []
	for item in items:
		if bool(item["completed"]):
			已完成.append(item)
		elif bool(item["available"]):
			可执行.append(item)
		else:
			未满足.append(item)
	var 排序: Array = 可执行 + 未满足 + 已完成
	# 条目没变就不重建: 重建会把滚动位置弹回顶部
	var 签名 := ""
	for item in 排序:
		签名 += "%d:%s:%s;" % [int(item["index"]), str(item["available"]), str(item["completed"])]
	if 签名 == _签名:
		return
	_签名 = 签名
	for child in 列表.get_children():
		child.queue_free()
	for item in 排序:
		var entry := 条目场景.instantiate()
		列表.add_child(entry)
		entry.setup(item)
	空提示.visible = items.is_empty()
