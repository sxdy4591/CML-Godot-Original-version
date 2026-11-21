extends CanvasLayer
## 顶部状态栏 — 纯视图。文本与 tooltip 由 TopStatePane 给好（含 ×10 换算）。
## 时间推进时逻辑层数据每帧变化，这里 0.5s 轮询一次（契约 §10）。

const 面板 := "状态栏"

const 节点 := {
	"party_support": "党内支持度",
	"people_support": "人民支持度",
	"freedom": "思想自由度",
	"living": "生活水平",
	"prestige": "国际声望",
	"influence": "国际影响力",
	"budget": "预算",
	"agents": "特工网络",
	"american": "与美国关系",
	"soviet": "与苏联关系",
}


func _ready() -> void:
	UiBridge.connect("panel_snapshot", _收到快照)
	var timer := Timer.new()
	timer.wait_time = 0.5
	timer.timeout.connect(func() -> void: UiBridge.request(面板))
	add_child(timer)
	timer.start()
	UiBridge.request(面板)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	for key in 节点:
		var label := get_node(节点[key]) as Label
		var item: Dictionary = data[key]
		label.mouse_filter = Control.MOUSE_FILTER_PASS
		label.text = item["text"]
		label.tooltip_text = item["tip"]
