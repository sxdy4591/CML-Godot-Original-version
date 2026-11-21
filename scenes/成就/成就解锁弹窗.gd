extends Control
## 成就解锁弹窗(右下角). 由 成就弹窗(autoload) 实例化, 展示后淡入、停留、淡出并释放.

const 默认图标 := preload("res://assets/ui/战争/圆圈.png")
const 图标目录 := "res://assets/achievements/"
const 停留 := 2.8

@onready var 图标: TextureRect = $布局/图标
@onready var 标题: Label = $布局/文本/标题
@onready var 描述: Label = $布局/文本/描述


func _ready() -> void:
	visible = false
	modulate = Color(1, 1, 1, 0)


func show_toast(number: int, 标题文本: String, 描述文本: String) -> void:
	标题.text = "成就解锁：%s" % 标题文本
	描述.text = 描述文本
	# 有本地专属图的成就(如自定的 1976 毛主席逝世)用专属图, 其余回落到通用圈
	var 本地 := "%s%d.png" % [图标目录, number]
	图标.texture = load(本地) if ResourceLoader.exists(本地) else 默认图标
	visible = true
	modulate = Color(1, 1, 1, 0)
	var 补间 := create_tween()
	补间.tween_property(self, "modulate", Color.WHITE, 0.25).set_trans(Tween.TRANS_SINE).set_ease(Tween.EASE_OUT)
	补间.tween_interval(停留)
	补间.tween_property(self, "modulate", Color(1, 1, 1, 0), 0.4)
	补间.tween_callback(queue_free)
