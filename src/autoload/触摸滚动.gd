extends Node
## 触摸滚动(Autoload) — 手机上的列表拖动。
##
## Godot 的 ScrollContainer 自带的触摸拖动是"模拟鼠标"实现的: 引擎先判断
## is_touchscreen_available, 再拿左键按下 + 鼠标移动去拖。所以内容控件只要
## mouse_filter = STOP 把模拟鼠标吃掉(典型就是内容直接是 RichTextLabel 的容器),
## 内建拖动就一次都不会启动 —— 这种容器只能由这里接管。
##
## 反过来, 内容控件是 PASS/IGNORE 的容器(内容是大片 VBoxContainer/Label)引擎自己
## 会滚; 这里必须让开, 否则一次拖动被滚两遍, 速度翻倍。
##
## 纯 UI 交互, 不碰游戏状态; 桌面鼠标不受影响(地图右键拖动照旧)。

## 手指移动超过这个距离才算"在拖动", 避免轻点列表时列表跟着抖
const 拖动阈值 := 8.0
## 滚动条最小宽度(逻辑像素): 抠不到条的时候至少还能看见它在哪
const 滚动条宽 := 22

var _目标: ScrollContainer = null
var _起点: Vector2 = Vector2.ZERO
## 这个容器引擎自己会滚吗? 按下时判一次
var _引擎会滚: bool = false
## 未满 1 像素的位移必须攒着: 触摸坐标被 content_scale 缩放过, 高 DPI 手机上单个
## ScreenDrag 的 relative 常常不到 1 逻辑像素, 直接 int() 截断就永远是 0,
## 表现是"这个列表怎么划都不动"。
var _余量: float = 0.0
## 命中测试的中间状态(递归用, 免得每次分配数组)
var _最上: Control = null
var _最上层号: int = -1000000


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
		_余量 = 0.0
		_引擎会滚 = _目标 != null and _引擎收得到拖动(_目标, event.position)
		return
	if event is InputEventScreenDrag and _目标 != null and not _引擎会滚:
		if event.position.distance_to(_起点) < 拖动阈值:
			return
		_余量 += event.relative.y
		var 位移 := int(_余量)
		if 位移 == 0:
			return
		_余量 -= 位移
		_目标.scroll_vertical -= 位移


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


## 模拟鼠标的按下/移动能不能一路冒泡到这个容器:
## 从手指下最上层控件往上爬, 中途有 mouse_filter = STOP 的控件就把事件截住了,
## 引擎那套拖动收不到, 得这里自己滚。
## 手指按在滚动条上时让开 —— 滚动条自己会拖, 两边一起改会把位置拽回去。
func _引擎收得到拖动(sc: ScrollContainer, pos: Vector2) -> bool:
	var 控件 := _最上层控件(pos)
	while 控件 != null and 控件 != sc:
		if 控件 is ScrollBar:
			return true
		if 控件.mouse_filter == Control.MOUSE_FILTER_STOP:
			return false
		控件 = 控件.get_parent() as Control
	return 控件 == sc


## 屏幕点下最上层、且能接收鼠标的 Control。坐标走 canvas 变换反解,
## 异形屏(canvas_items + 黑边)下也能对上触摸点。
func _最上层控件(pos: Vector2) -> Control:
	_最上 = null
	_最上层号 = -1000000
	_扫控件(get_tree().root, pos, 0)
	return _最上


func _扫控件(node: Node, pos: Vector2, 层号: int) -> void:
	for 子 in node.get_children():
		var 子层 := 层号
		if 子 is CanvasLayer:
			var 层 := 子 as CanvasLayer
			if not 层.visible:
				continue
			子层 = 层.layer
		if 子 is Control:
			var 控件 := 子 as Control
			if not 控件.is_visible_in_tree():
				continue
			# 先测自己再递归子节点: 子节点绘制在父之上, 后遍历到会覆盖父
			if 控件.mouse_filter != Control.MOUSE_FILTER_IGNORE and 子层 >= _最上层号:
				var 内 := 控件.get_global_transform_with_canvas().affine_inverse() * pos
				if Rect2(Vector2.ZERO, 控件.size).has_point(内):
					_最上层号 = 子层
					_最上 = 控件
			_扫控件(控件, pos, 子层)
		else:
			_扫控件(子, pos, 子层)


func _加宽滚动条(sc: ScrollContainer) -> void:
	var bar := sc.get_v_scroll_bar()
	bar.custom_minimum_size = Vector2(maxf(bar.custom_minimum_size.x, 滚动条宽), 0)
