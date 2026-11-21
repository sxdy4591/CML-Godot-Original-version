extends CanvasLayer
## 成就解锁提示层(autoload): 监听桥层的 achievement_unlocked, 右下角弹提示.

const 弹窗场景 := preload("res://scenes/成就/成就解锁弹窗.tscn")

@onready var 队列: VBoxContainer = $根/队列


func _ready() -> void:
	UiBridge.connect("achievement_unlocked", _on_解锁)


func _on_解锁(number: int) -> void:
	var 文本: Array = UiBridge.achievement_text(number)
	var 标题文本 := str(文本[0]) if 文本.size() > 0 else "成就 %d" % number
	var 描述文本 := str(文本[1]) if 文本.size() > 1 else ""
	var 实例 := 弹窗场景.instantiate()
	队列.add_child(实例)
	实例.call("show_toast", number, 标题文本, 描述文本)
	while 队列.get_child_count() > 3:
		var 旧 := 队列.get_child(0)
		队列.remove_child(旧)
		旧.queue_free()
