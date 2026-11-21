extends Control
## 政治界面 — 纯视图。18 张卡片与左栏/职位/右栏数据全部来自 PoliticsPane。

const 面板 := "政治"
const 部件表 = preload("res://src/common/头像部件表.gd")

@onready var 卡片: Array[Control] = [
	$政治家1, $政治家2, $政治家3, $政治家4, $政治家5, $政治家6,
	$政治家7, $政治家8, $政治家9, $政治家10, $政治家11, $政治家12,
	$政治家13, $政治家14, $政治家15, $政治家16, $政治家17, $政治家18
]
@onready var 左栏姓名: Label = $左栏_当前选中政治家姓名
@onready var 左栏派系: Label = $左栏_当前选中政治家派系
@onready var 左栏特质1: Label = $左栏_当前选中政治家特质1
@onready var 左栏特质2: Label = $左栏_当前选中政治家特质2
@onready var 左栏状态: RichTextLabel = $左栏_当前选中政治家状态
@onready var 领袖肖像: Control = $实权领袖肖像
@onready var 领袖节点: Array[TextureRect] = [
	$实权领袖肖像/基底脸, $实权领袖肖像/层0, $实权领袖肖像/层1, $实权领袖肖像/层2,
	$实权领袖肖像/层3, $实权领袖肖像/层4, $实权领袖肖像/层5, $实权领袖肖像/层6,
	$实权领袖肖像/层7, $实权领袖肖像/外套
]
@onready var 中央职位: Array[Label] = [$国务院总理, $中央军委主席, $外交部长]
@onready var 地方职位: Array[Label] = [$首都主管, $北方主管, $西方主管, $南方主管, $东方主管]
@onready var 预算: Label = $右栏数据/预算
@onready var 特工网络: Label = $右栏数据/特工网络

const 动作按钮 := {
	"支持": 0, "打压": 1, "开始调查": 3, "监视": 4,
	"自动支持": 15, "自动打压": 16, "任命领袖军委": 13,
	"指定为派系负责人": 14, "调往中央军委": 5, "调往外交部": 6,
	"调往国务院": 7, "调往首都": 8, "调往北方": 9,
	"调往南方": 10, "调往西方": 11, "调往东方": 12,
	"送去再教育": 2,
}

var _快照: Dictionary = {}
var _选中: int = 0


func _ready() -> void:
	for i in 卡片.size():
		卡片[i].gui_input.connect(_选中卡片.bind(i))
	for 名称 in 动作按钮:
		get_node(名称).pressed.connect(_动作.bind(动作按钮[名称]))
	$返回外交界面.pressed.connect(_返回)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)
	# 权力排名会随自动化/后台动作变化, 界面停留时定时拉取, 别等重进场景
	var 计时器 := Timer.new()
	计时器.wait_time = 0.5
	计时器.timeout.connect(func() -> void: UiBridge.request(面板))
	add_child(计时器)
	计时器.start()


func _动作(num: int) -> void:
	# 卡片位置 ≠ 政治家编号: 卡片顺序是原版权力排名, 动作必须带快照里的真实编号
	UiBridge.act(面板, "政治动作", [num, int(_快照["politicians"][_选中]["index"])])
	UiBridge.request(面板)


func _选中卡片(event: InputEvent, index: int) -> void:
	if not (event is InputEventMouseButton and event.pressed and event.button_index == MOUSE_BUTTON_LEFT):
		return
	_选中 = index
	_刷新选中框()
	_显示选中()
	_显示领袖()


func _刷新选中框() -> void:
	for i in 卡片.size():
		卡片[i].get_node("选中框").visible = i == _选中


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_快照 = data
	var list: Array = data["politicians"]
	for i in 卡片.size():
		卡片[i].setup(list[i])
	var posts: Array = data["posts"]
	for i in 中央职位.size():
		中央职位[i].text = posts[i]
	for i in 地方职位.size():
		地方职位[i].text = posts[i + 3]
	预算.text = str(data["budget"])
	特工网络.text = str(data["agents"])
	_刷新选中框()
	_显示选中()
	_显示领袖()


func _显示选中() -> void:
	var p: Dictionary = _快照["politicians"][_选中]
	左栏姓名.text = "%s（%d岁）" % [p["name"], p["age"]]
	左栏派系.text = p["faction"]
	左栏特质1.text = p["trait1"]
	左栏特质2.text = p["trait2"]
	左栏状态.text = 悬浮提示.unity_to_bbcode(p["status"]).replace("|", "\n")
	var actions: Array = p["actions"]
	for 名称 in 动作按钮:
		get_node(名称).disabled = not bool(actions[动作按钮[名称]])


func _显示领袖() -> void:
	var 领袖: Dictionary = _快照["leader"]
	部件表.apply_layers(领袖肖像, 领袖节点, _领袖层列表(领袖))


func _领袖层列表(info: Dictionary) -> Array:
	var face: Dictionary = 部件表.FACE_TYPES[int(info["face_type"])]
	var out: Array = [_项(face["base"])]
	var parts: Array = info["face_parts"]
	for layer in 8:
		var entry = face["layers"][layer][int(parts[layer])]
		if entry != null:
			out.append(_项(entry))
	var jacket = face["jacket"][int(info["jacket"])]
	if jacket != null:
		out.append(_项(jacket))
	return out


func _项(entry: Array) -> Dictionary:
	return {"file": entry[0], "pos": entry[1], "size": entry[2], "slot": entry[4]}


func _返回() -> void:
	get_tree().change_scene_to_file("res://scenes/外交/外交.tscn")
