extends CanvasLayer
## 预警图标 — 纯视图。图标显隐与提示文本来自逻辑层 AlarmPane。

const 面板 := "预警"

@onready var 图标: Array[Control] = [$科研未研究提示, $阴谋临近提示, $政治局缺人提示]
@onready var 事件提示: TextureButton = $事件提示


func _ready() -> void:
	事件提示.pressed.connect(_打开事件)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)
	var 计时器 := Timer.new()
	计时器.wait_time = 0.5
	计时器.timeout.connect(func() -> void: UiBridge.request(面板))
	add_child(计时器)
	计时器.start()


func _打开事件() -> void:
	UiBridge.act(面板, "打开事件", [])


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	var icons: Array = data["icons"]
	for i in 图标.size():
		图标[i].visible = bool(icons[i]["visible"])
		图标[i].tooltip_text = icons[i]["text"]

	# 事件提示 = 地图事件图标(原版 EventScript): 无事件时不显示
	var marker: Dictionary = data["event_marker"]
	事件提示.visible = bool(marker["active"])
