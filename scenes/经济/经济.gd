extends Control
## 经济界面 — 纯视图。文本由 EconomyPane 给好（含 ×10 换算与全部说明文案）。

const 面板 := "经济"
const 外交场景 := "res://scenes/外交/外交.tscn"

const 预算项 := [
	"军费", "国安部经费", "科研经费", "行政支出", "高层福利",
	"宣传支出", "农业支出", "工业支出", "服务业支出", "福利支出", "外交支出",
]

const 数值提示 := {
	"工业数值": "industry",
	"农业数值": "agriculture",
	"服务业数值": "service",
	"腐败数值": "corruption",
	"贷款数值": "loan",
	"储蓄金数值": "savings",
}

@onready var 工业数值: Label = $工业数值
@onready var 农业数值: Label = $农业数值
@onready var 服务业数值: Label = $服务业数值
@onready var 腐败数值: Label = $腐败数值
@onready var 贷款数值: Label = $贷款数值
@onready var 储蓄金数值: Label = $储蓄金数值
@onready var 债务损耗: Label = $债务损耗
@onready var 债务限额: Label = $债务限额
@onready var 贪腐损耗: Label = $贪腐损耗
@onready var 最大投资: Label = $最大投资
@onready var 储蓄金影响: Label = $储蓄金影响
@onready var 寡头状态文本: Label = $寡头状态文本
@onready var 导航栏: CanvasLayer = $导航栏


func _ready() -> void:
	导航栏.call("set_screen", "economy")
	for i in 预算项.size():
		get_node(预算项[i] + "+").pressed.connect(_预算.bind(i, false))
		get_node(预算项[i] + "-").pressed.connect(_预算.bind(i, true))
	$"贷款+".pressed.connect(_贷款.bind(false))
	$"贷款-".pressed.connect(_贷款.bind(true))
	$"储蓄金+".pressed.connect(_储蓄金.bind(false))
	$"储蓄金-".pressed.connect(_储蓄金.bind(true))
	UiBridge.connect("panel_snapshot", _收到快照)
	var timer := Timer.new()
	timer.wait_time = 0.5
	timer.timeout.connect(func() -> void: UiBridge.request(面板))
	add_child(timer)
	timer.start()
	UiBridge.request(面板)


func _unhandled_input(event: InputEvent) -> void:
	if event is InputEventKey and event.pressed and not event.echo and event.keycode == KEY_ESCAPE:
		get_tree().change_scene_to_file(外交场景)


func _预算(index: int, minus: bool) -> void:
	UiBridge.act(面板, "预算", [index, minus])
	UiBridge.request(面板)


func _贷款(minus: bool) -> void:
	UiBridge.act(面板, "贷款", [minus])
	UiBridge.request(面板)


func _储蓄金(minus: bool) -> void:
	UiBridge.act(面板, "储蓄金", [minus])
	UiBridge.request(面板)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	工业数值.text = data["industry"]
	农业数值.text = data["agriculture"]
	服务业数值.text = data["service"]
	腐败数值.text = data["corruption"]
	贷款数值.text = data["loan"]
	储蓄金数值.text = data["savings"]
	债务损耗.text = data["debt_loss"]
	债务限额.text = data["debt_limit"]
	贪腐损耗.text = data["corruption_loss"]
	最大投资.text = data["max_investment"]
	储蓄金影响.text = data["savings_influence"]
	寡头状态文本.text = data["oligarch"]
	var 预算文本: Array = data["budget_texts"]
	for i in 预算项.size():
		get_node(预算项[i] + "数值").text = 预算文本[i]
	_更新提示(data["tips"])


# 悬停提示: 数值=两周内变化, 预算=原版预算说明(含 Unity 颜色标签, 交 悬浮提示 渲染)
func _更新提示(tips: Dictionary) -> void:
	for 名称 in 数值提示:
		var label := get_node(名称) as Label
		label.tooltip_text = tips[数值提示[名称]]
		悬浮提示.attach(label)
	for i in 预算项.size():
		var 说明: String = tips["budget" + str(i)]
		for 后缀 in ["", "+", "-", "数值"]:
			var 控件 := get_node(预算项[i] + 后缀) as Control
			控件.tooltip_text = 说明
			悬浮提示.attach(控件)
