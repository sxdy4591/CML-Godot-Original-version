extends Node2D
## 科研关系线 — 纯绘制。依赖对来自 SciencePane，端点取条目按钮中心，用 _draw 画线(不建节点)。

const 线色 := Color(0.2901961, 0.11764706, 0.19215687, 1)
const 线宽 := 15.0

var _依赖: Array = []
var _条目: Array = []


func 重画(dependencies: Array, 条目: Array) -> void:
	_依赖 = dependencies
	_条目 = 条目
	queue_redraw()


func _draw() -> void:
	for dep in _依赖:
		var from: Control = _条目[dep["from"]]
		var to: Control = _条目[dep["to"]]
		var a := to_local(from.get_node("按钮").get_global_rect().get_center())
		var b := to_local(to.get_node("按钮").get_global_rect().get_center())
		draw_line(a, b, 线色, 线宽)
