extends Control
## 科学界面 — 纯视图。文本/状态由 SciencePane 调原版 Science_Script 生成。
## 场景里条目的排列顺序与 science[] 索引不同, 按节点名查号。

const 面板 := "科学"
const 外交场景 := "res://scenes/外交/外交.tscn"
const 摄像机最小Y := 540.0
const 摄像机最大Y := 2400.0

const 科技号 := {
	"大跃进的遗产": 0, "巩固农业设施": 1, "农业方法革新": 2, "发展农业机械化": 3,
	"选育与基因研究": 4, "新增研究设施": 5, "新型肥料与杀虫剂": 6, "遗传修饰": 7, "开垦处女地": 8,
	"改良流水线生产模式": 9, "自研工业科技": 10, "工业设施中国化": 11, "电子工业中国化": 12,
	"现代制造业": 13, "改进国内工业机械": 14, "自动化生产控制": 15, "计算机化": 16, "中国版的OGAS": 17,
	"加强军备开发": 18, "情报部门新装备": 19, "新式间谍装备": 20, "发展核武器与导弹": 21,
	"迎接信息化战争": 22, "更新军队装备": 23, "发展海军与空军": 24, "现代间谍装备": 25,
	"指挥链与军事组织改革": 26, "通讯卫星": 27, "导航卫星": 28, "军事卫星": 29,
	"载人航天": 30, "行星际飞行器": 31, "轨道空间站": 32, "航天飞机": 33,
}

@onready var 分组: Array[Control] = [$农业科技, $工业科技, $军事科技, $航天科技]
@onready var 预算数值: Label = $固定/预算数值
@onready var 科研点数数值: Label = $固定/科研点数数值
@onready var 关系线: Node2D = $科研关系线
@onready var 摄像机: Camera2D = $移动视角摄像机
@onready var 提示板: Array[Control] = [$提示层/科研提示板, $提示层/提示标题, $提示层/提示状态, $提示层/提示描述]
@onready var 提示标题: Label = $提示层/提示标题
@onready var 提示状态: RichTextLabel = $提示层/提示状态
@onready var 提示描述: RichTextLabel = $提示层/提示描述


func _ready() -> void:
	$固定/返回外交.pressed.connect(_返回)
	# 非按钮控件鼠标穿透, 避免挡住科技条目的点击
	_穿透鼠标(self)
	_隐藏提示()
	UiBridge.connect("panel_snapshot", _收到快照)
	var timer := Timer.new()
	timer.wait_time = 0.5
	timer.timeout.connect(func() -> void: UiBridge.request(面板))
	add_child(timer)
	timer.start()
	UiBridge.request(面板)


func _穿透鼠标(node: Node) -> void:
	if node is CanvasLayer or node is TextureButton:
		return
	if node is Control:
		node.mouse_filter = Control.MOUSE_FILTER_IGNORE
	for child in node.get_children():
		_穿透鼠标(child)


## 手机: 单指上下拖 = 滚动科技树; 拖动超过阈值后消费触摸, 避免松手误触科技按钮
var _触摸起点: Vector2 = Vector2.ZERO
var _触摸已拖: bool = false


func _input(event: InputEvent) -> void:
	if event is InputEventScreenTouch:
		if event.pressed:
			_触摸起点 = event.position
			_触摸已拖 = false
		elif _触摸已拖:
			get_viewport().set_input_as_handled()
		return
	if event is InputEventScreenDrag:
		if not _触摸已拖 and (event.position - _触摸起点).length() > 12.0:
			_触摸已拖 = true
		if _触摸已拖:
			摄像机.position.y = clampf(摄像机.position.y - event.relative.y, 摄像机最小Y, 摄像机最大Y)
			get_viewport().set_input_as_handled()


func _unhandled_input(event: InputEvent) -> void:
	if event is InputEventKey and event.pressed and not event.echo and event.keycode == KEY_ESCAPE:
		get_tree().change_scene_to_file(外交场景)
		return
	if event is InputEventMouseButton and event.pressed:
		if event.button_index == MOUSE_BUTTON_WHEEL_UP:
			摄像机.position.y = maxf(摄像机.position.y - 80.0, 摄像机最小Y)
			get_viewport().set_input_as_handled()
		elif event.button_index == MOUSE_BUTTON_WHEEL_DOWN:
			摄像机.position.y = minf(摄像机.position.y + 80.0, 摄像机最大Y)
			get_viewport().set_input_as_handled()


func _返回() -> void:
	get_tree().change_scene_to_file(外交场景)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	预算数值.text = data["budget"]
	科研点数数值.text = data["science_points"]
	var items: Array = data["items"]
	var 条目: Array = []
	条目.resize(科技号.size())
	for group in 分组:
		for child in group.get_children():
			var 号: int = 科技号[str(child.name)]
			条目[号] = child
			child.setup(items[号])
			if not child.hovered.is_connected(_显示提示):
				child.hovered.connect(_显示提示)
				child.unhovered.connect(_隐藏提示)
	关系线.call("重画", data["dependencies"], 条目)


func _显示提示(info: Dictionary) -> void:
	for node in 提示板:
		node.visible = true
	提示标题.text = info["name"]
	提示状态.text = "[center]" + 悬浮提示.unity_to_bbcode(info["cost"]).replace(" ", "") + "[/center]"
	提示描述.text = 悬浮提示.unity_to_bbcode(info["desc"]).replace(" ", "")


func _隐藏提示() -> void:
	for node in 提示板:
		node.visible = false
