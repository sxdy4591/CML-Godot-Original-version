extends Node
## 触摸滚动(Autoload) — 手机上的列表拖动。
##
## Godot 的 ScrollContainer 只处理滚轮与手势事件, 触摸拖动在手机上没人为你转成滚动,
## 于是玩家只能去抠右侧那根几像素宽的滚动条。这里在全局 _input 层接管:
## 按下点落在哪个可见 ScrollContainer 里, 拖动就滚那个容器。
##
## 纯 UI 交互, 不碰游戏状态; 桌面鼠标不受影响(地图右键拖动照旧)。

## 手指移动超过这个距离才算"在拖动", 避免轻点列表时列表跟着抖
const 拖动阈值 := 8.0
## 滚动条最小宽度(逻辑像素): 抠不到条的时候至少还能看见它在哪
const 滚动条宽 := 22

var _目标: ScrollContainer = null
var _起点: Vector2 = Vector2.ZERO


func _ready() -> void:
	process_mode = Node.PROCESS_MODE_ALWAYS
	# 场景/列表都是运行时实例化的, 靠 node_added 逐个把滚动条加宽
	get_tree().node_added.connect(_节点加入)


func _节点加入(node: Node) -> void:
	if node is ScrollContainer:
		_加宽滚动条.call_deferred(node)


func _input(event: InputEvent) -> void:
	if event is InputEventScreenTouch:
		_目标 = _找容器(event.position) if event.pressed else null
		_起点 = event.position
		return
	if event is InputEventScreenDrag and _目标 != null:
		if event.position.distance_to(_起点) < 拖动阈值:
			return
		_目标.scroll_vertical -= int(event.relative.y)


## 取最内层命中的容器: find_children 是深度优先, 子容器排在父容器之后
func _找容器(pos: Vector2) -> ScrollContainer:
	var 命中: ScrollContainer = null
	for node in get_tree().root.find_children("*", "ScrollContainer", true, false):
		var sc := node as ScrollContainer
		if not sc.is_visible_in_tree():
			continue
		if sc.get_global_rect().has_point(pos):
			命中 = sc
	return 命中


func _加宽滚动条(sc: ScrollContainer) -> void:
	var bar := sc.get_v_scroll_bar()
	bar.custom_minimum_size = Vector2(maxf(bar.custom_minimum_size.x, 滚动条宽), 0)
