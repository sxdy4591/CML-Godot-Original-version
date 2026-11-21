extends Node
## 触屏 tooltip 兼容层(Autoload "触屏提示"):
## 手机/平板没有鼠标悬停, Godot 默认 tooltip 不会出现 —
## 长按(默认 0.5s)命中控件 → 显示其 tooltip(优先复用控件自身的
## _make_custom_tooltip, 否则走 悬浮提示 的 BBCode 渲染, 保留原版颜色);
## 手指移动超容差或抬起后消失; tooltip 显示期间吞掉抬起事件,
## 避免长按松手时误触底层按钮(press 已发, 释放被吞则按钮不触发 pressed)。

const HOLD_MS: int = 500
const DRAG_TOLERANCE: float = 18.0
## 自己创建的 tooltip 层打这个标记：命中测试要跳过它，否则长按后
## 手指还停在面板上时会被当成"命中了 tooltip 自己"。
const 提示层标记 := &"touch_tooltip_layer"

var _touch_active := false
var _touch_pos := Vector2.ZERO
var _press_ms := 0
## 超时后只尝试弹一次：位置不变，重试没有意义，还能省掉每帧遍历场景树。
var _press_tried := false
var _tooltip_layer: CanvasLayer = null
var _tooltip_panel: Control = null
## 命中测试的中间状态（_walk_controls 递归用，避免每次分配数组）
var _hit_best: Control = null
var _hit_layer: int = -1000000


func _ready() -> void:
	# 暂停界面(事件/ESC 菜单等)也要能长按看提示。
	# Autoload 默认 process_mode=INHERIT, get_tree().paused=true 时 _input/_process 都会停,
	# 表现为"暂停后就长按不出 tooltip" —— 与调试控制台/异常提示的做法一致, 强制常驻。
	process_mode = Node.PROCESS_MODE_ALWAYS


func _process(_delta: float) -> void:
	if not _touch_active or _tooltip_panel != null or _press_tried:
		return
	if Time.get_ticks_msec() - _press_ms < HOLD_MS:
		return
	_press_tried = true
	_show_at(_touch_pos)
	# 这个位置没有带 tooltip 的控件 → 本轮长按结束，不再每帧遍历场景树
	if _tooltip_panel == null:
		_touch_active = false


## 触摸跟踪必须在 _input 阶段做(早于 GUI 分发): Button/Label 等控件收到
## InputEventScreenTouch 后通常不会再冒泡到 _unhandled_input, 旧实现因此
## "按按钮有反应、长按却永远不出 tooltip"(手机反馈)。
## 只在真正显示 tooltip 后吞掉抬起事件, 避免长按松手误触底层按钮;
## 桌面鼠标不会触发本层 tooltip, 因此不会误吞桌面点击。

func _input(event: InputEvent) -> void:
	if event is InputEventScreenTouch:
		if event.pressed:
			# 新触点 = 关闭上一个 tooltip, 并开始新的长按计时
			_hide()
			_touch_active = true
			_press_tried = false
			_touch_pos = event.position
			_press_ms = Time.get_ticks_msec()
			return
		var had_tooltip := _tooltip_panel != null
		_hide()
		# 吞掉长按松手: press 已经发给按钮, 若 release 也传下去会误触 pressed
		if had_tooltip:
			get_viewport().set_input_as_handled()
	elif event is InputEventScreenDrag:
		if _touch_active and event.position.distance_to(_touch_pos) > DRAG_TOLERANCE:
			_touch_active = false
			_hide()


## 命中的控件：屏幕点下最上层、且能接收鼠标的 Control。
##
## 为什么不用引擎 API：Godot 4 的 Viewport **没有** `gui_get_control_at_position`
## （旧实现调用的是不存在的方法，`_show_at` 每次长按都抛
## "Invalid call. Nonexistent function"，于是手机长按永远不出提示）。
## 4.x 只公开了 `gui_get_hovered_control()` / `gui_find_control()`，而触摸按下时
## 悬停控件不更新，所以只能自己按绘制顺序做命中测试：
##   · CanvasLayer.layer 更大的整层盖在上面；
##   · 同一层内先遍历父、再遍历子 → 后遍历到的（画在上面的）覆盖前面的；
##   · mouse_filter = IGNORE 的控件收不到鼠标，不参与命中（但仍继续找它的父控件）。
## 坐标用 `get_global_transform_with_canvas()` 反变换：触摸事件坐标与它同属
## 拉伸后的画布空间，异形屏（canvas_items + 黑边）下也能对得上。
func _control_at(pos: Vector2) -> Control:
	_hit_best = null
	_hit_layer = -1000000
	_walk_controls(get_tree().root, pos, 0)
	return _hit_best


func _walk_controls(node: Node, pos: Vector2, layer: int) -> void:
	var children := node.get_children()
	for child in children:
		var child_layer := layer
		if child is CanvasLayer:
			var cl := child as CanvasLayer
			if not cl.visible:
				continue
			child_layer = cl.layer
			if cl.has_meta(提示层标记):
				continue
		if child is Control:
			var c := child as Control
			if not c.is_visible_in_tree():
				continue
			# 先测自己再递归子节点：子节点绘制在父之上，后遍历到会覆盖父。
			if c.mouse_filter != Control.MOUSE_FILTER_IGNORE and child_layer >= _hit_layer:
				var local := c.get_global_transform_with_canvas().affine_inverse() * pos
				if Rect2(Vector2.ZERO, c.size).has_point(local):
					_hit_layer = child_layer
					_hit_best = c
			_walk_controls(c, pos, child_layer)
		else:
			_walk_controls(child, pos, child_layer)


## 触摸点命中控件 → 向上找最近带 tooltip 的控件 → 渲染弹窗

func _show_at(pos: Vector2) -> void:
	if get_viewport() == null:
		return
	var ctrl := _control_at(pos)
	if ctrl == null:
		return
	var tip := ""
	var target: Control = null
	var cur: Control = ctrl
	while cur != null:
		var t := cur.get_tooltip()
		if t != null and not String(t).is_empty():
			tip = String(t)
			target = cur
			break
		cur = cur.get_parent() as Control
	if target == null or tip.is_empty():
		return
	# 优先复用控件自身的自定义 tooltip(决议条目等已实现 _make_custom_tooltip),
	# 否则用统一 BBCode 渲染(悬浮提示, 含 Unity <color> 原版颜色)
	var content: Control = null
	if target.has_method("_make_custom_tooltip"):
		content = target._make_custom_tooltip(tip)
	if content == null:
		content = 悬浮提示.build_tooltip(tip)
	if content == null:
		return
	_tooltip_layer = CanvasLayer.new()
	_tooltip_layer.layer = 100
	_tooltip_layer.set_meta(提示层标记, true)
	get_tree().root.add_child(_tooltip_layer)
	_tooltip_panel = content
	_tooltip_layer.add_child(_tooltip_panel)
	# 定位: 触摸点上方, 屏幕内钳制
	var vs := get_viewport().get_visible_rect().size
	var size := _tooltip_panel.get_combined_minimum_size()
	var p := pos + Vector2(12, -size.y - 16)
	p.x = clampf(p.x, 4, maxf(4, vs.x - size.x - 4))
	p.y = clampf(p.y, 4, maxf(4, vs.y - size.y - 4))
	_tooltip_panel.position = p


func _hide() -> void:
	_touch_active = false
	_press_tried = false
	if _tooltip_layer != null:
		_tooltip_layer.queue_free()
		_tooltip_layer = null
	_tooltip_panel = null
