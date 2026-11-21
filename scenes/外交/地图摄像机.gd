extends Camera2D
## 地图相机: 鼠标拖动/滚轮缩放(桌面), 单指拖动/双指捏合(手机).

var 缩放步长: float = 0.2
var 最小缩放: float = 0.8
var 最大缩放: float = 5.0
var 拖拽系数: float = 1.0
var _正在拖动: bool = false
var _拖拽起点鼠标: Vector2 = Vector2.ZERO
var _拖拽起点位置: Vector2 = Vector2.ZERO

## 触摸手势状态: index → 屏幕坐标
var _触摸: Dictionary = {}
var _触摸起点: Vector2 = Vector2.ZERO
var _触摸起点位置: Vector2 = Vector2.ZERO
var _触摸已拖: bool = false
var _捏合距离: float = 0.0


func _ready() -> void:
	make_current()
	if 全局管理.存储_摄像机状态是否存储:
		position = 全局管理.存储_摄像机位置
		zoom = 全局管理.存储_摄像机缩放

func _unhandled_input(event: InputEvent) -> void:
	if event is InputEventScreenTouch:
		_触摸按下(event)
		return
	if event is InputEventScreenDrag:
		_触摸移动(event)
		return
	if event.is_action_pressed("放大摄像机"):
		if _国家面板挡住():
			return
		_缩放(1.0 + 缩放步长)
	elif event.is_action_pressed("缩小摄像机"):
		if _国家面板挡住():
			return
		_缩放(1.0 / (1.0 + 缩放步长))


# 光标在国家互动面板上时, 滚轮不该缩放地图
func _国家面板挡住() -> bool:
	var scene := get_tree().current_scene
	if scene == null:
		return false
	var panel := scene.get_node_or_null("国家面板")
	if panel == null or not panel.visible:
		return false
	var 背景 := panel.get_node_or_null("背景") as Control
	if 背景 == null:
		return false
	return 背景.get_global_rect().has_point(get_viewport().get_mouse_position())


# 以锚点为中心缩放: 保持锚点下的世界点不动
func _缩放(倍率: float, 锚点: Vector2 = Vector2.INF) -> void:
	var 旧: float = zoom.x
	var 新: float = clampf(旧 * 倍率, 最小缩放, 最大缩放)
	if is_equal_approx(新, 旧):
		return
	var 屏幕中心 := get_viewport_rect().size * 0.5
	var 锚 := get_viewport().get_mouse_position() if 锚点 == Vector2.INF else 锚点
	var 偏移 := 锚 - 屏幕中心
	position = _限制位置(position + 偏移 / 旧 - 偏移 / 新)
	zoom = Vector2(新, 新)


# 拖拽改为"按下时的绝对位移", 并主动把摄像机中心 clamp 在 limit 内:
# 用相对位移(position -= relative)时, 越界部分会被 limit 吃掉, 反向拖动要先补回
# 被吃掉的量 → 表现为贴边后"粘一下"。
func _input(event: InputEvent) -> void:
	if event.is_action_pressed("移动摄像机"):
		_正在拖动 = true
		_拖拽起点鼠标 = get_viewport().get_mouse_position()
		_拖拽起点位置 = position
	elif event.is_action_released("移动摄像机"):
		_正在拖动 = false
	elif event is InputEventMouseMotion and _正在拖动:
		var 位移 := (get_viewport().get_mouse_position() - _拖拽起点鼠标) * 拖拽系数 / zoom.x
		position = _限制位置(_拖拽起点位置 - 位移)


# ================= 触摸手势 =================

func _触摸按下(e: InputEventScreenTouch) -> void:
	if e.pressed:
		_触摸[e.index] = e.position
		if _触摸.size() == 1:
			_触摸起点 = e.position
			_触摸起点位置 = position
			_触摸已拖 = false
		elif _触摸.size() == 2:
			_触摸已拖 = true
			_捏合距离 = _两指距离()
		return
	_触摸.erase(e.index)
	if _触摸.is_empty():
		if _触摸已拖:
			get_viewport().set_input_as_handled()
		_触摸已拖 = false
		return
	# 双指剩单指: 起点重置到当前指位, 避免下一段位移跳一下
	if _触摸.size() == 1:
		_触摸起点 = _触摸.values()[0]
		_触摸起点位置 = position
		_捏合距离 = 0.0


func _触摸移动(e: InputEventScreenDrag) -> void:
	_触摸[e.index] = e.position
	if _触摸.size() == 1:
		if not _触摸已拖 and (e.position - _触摸起点).length() > 8.0:
			_触摸已拖 = true
		if _触摸已拖:
			position = _限制位置(_触摸起点位置 - (e.position - _触摸起点) / zoom.x)
			get_viewport().set_input_as_handled()
		return
	if _触摸.size() >= 2:
		var 距离 := _两指距离()
		if _捏合距离 > 0.0:
			_缩放(距离 / _捏合距离, _两指中心())
		_捏合距离 = 距离
		get_viewport().set_input_as_handled()


func _两指距离() -> float:
	var v: Array = _触摸.values()
	return v[0].distance_to(v[1])


func _两指中心() -> Vector2:
	var v: Array = _触摸.values()
	return (v[0] + v[1]) * 0.5


func _限制位置(p: Vector2) -> Vector2:
	var half := get_viewport_rect().size * 0.5 / zoom.x
	var 左 := limit_left + half.x
	var 右 := limit_right - half.x
	var 上 := limit_top + half.y
	var 下 := limit_bottom - half.y
	var x := p.x if 左 > 右 else clampf(p.x, 左, 右)
	var y := p.y if 上 > 下 else clampf(p.y, 上, 下)
	return Vector2(x, y)


func _exit_tree() -> void:
	全局管理.存储_摄像机位置 = position
	全局管理.存储_摄像机缩放 = zoom
	全局管理.存储_摄像机状态是否存储 = true
