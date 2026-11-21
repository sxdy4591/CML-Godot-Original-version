extends Node


const PRESS_SCALE := 0.95
const PRESS_DOWN_TIME := 0.05
const PRESS_UP_TIME := 0.12
const HOVER_SCALE := 1.03
const HOVER_TIME := 0.08

var _bound: Dictionary = {}      # instance_id → true
var _anim_safe: Dictionary = {}  # instance_id → bool (无旋转且无缩放)

func _ready() -> void:
	get_tree().node_added.connect(_on_node_added)
	call_deferred("_scan_current_tree")

func _on_node_added(node: Node) -> void:
	if node is BaseButton:
		_bind(node)

func _scan_current_tree() -> void:
	if get_tree().current_scene == null:
		return
	_bind_recursive(get_tree().current_scene)

func _bind_recursive(node: Node) -> void:
	if node is BaseButton:
		_bind(node)
	for child in node.get_children():
		_bind_recursive(child)

func _bind(btn: BaseButton) -> void:
	var id := btn.get_instance_id()
	if _bound.has(id):
		return
	_bound[id] = true
	if not btn.tree_exited.is_connected(_on_btn_exited):
		btn.tree_exited.connect(_on_btn_exited.bind(id))
	if btn.has_meta("no_fx") and btn.get_meta("no_fx"):
		return
	btn.set_meta("fx_orig_scale", btn.scale)
	_anim_safe[id] = btn.rotation == 0.0 and btn.scale.is_equal_approx(Vector2.ONE)
	if not btn.pressed.is_connected(_on_pressed):
		btn.pressed.connect(_on_pressed.bind(btn))
	if not btn.mouse_entered.is_connected(_on_hover):
		btn.mouse_entered.connect(_on_hover.bind(btn))
	if not btn.mouse_exited.is_connected(_on_hover_end):
		btn.mouse_exited.connect(_on_hover_end.bind(btn))

func _on_btn_exited(id: int) -> void:
	_bound.erase(id)
	_anim_safe.erase(id)

## ---- 外部基色接口(按条件改色的按钮必须走这里) ----
##
## 供 scenes/外交/国家面板.gd 的 4 个互动按钮之类"随状态变灰/还原"的按钮调用。
## 为什么不能直接写 btn.modulate:
##   本层用 modulate 补间实现按下/悬停反馈, 补间的落地色取自 fx_prev_modulate(基色)。
##   外部直接写 modulate 时, 本层在途的补间会在随后 0.05+0.12 秒里继续覆写 modulate,
##   并最终还原成"按下前的旧基色" —— 表现为点击后要等约 0.2 秒才变灰、甚至一直亮着。
## 此接口先杀掉在途补间, 再把新基色登记为后续补间的基准色, 换色当帧生效。
func set_base_modulate(btn: CanvasItem, color: Color) -> void:
	_kill_tween(btn)
	btn.set_meta("fx_prev_modulate", color)
	btn.modulate = color

func _on_pressed(btn: BaseButton) -> void:
	_call_audio("play_button_click_sound")
	if not (btn.has_meta("no_anim") and btn.get_meta("no_anim")):
		_press_anim(btn)

func _on_hover(btn: BaseButton) -> void:
	if not (btn.has_meta("no_hover") and btn.get_meta("no_hover")):
		_call_audio("play_button_hover_sound")
	if not (btn.has_meta("no_anim") and btn.get_meta("no_anim")):
		_hover_anim(btn, true)

func _on_hover_end(btn: BaseButton) -> void:
	if not (btn.has_meta("no_anim") and btn.get_meta("no_anim")):
		_hover_anim(btn, false)

func _call_audio(method: String) -> void:
	var audio := get_node_or_null("/root/AudioSys")
	if audio and audio.has_method(method):
		audio.call(method)

func _press_anim(btn: BaseButton) -> void:
	if _anim_safe.get(btn.get_instance_id(), false):
		_scale_tween(btn, PRESS_SCALE, PRESS_DOWN_TIME, PRESS_UP_TIME)
	else:
		_modulate_tween(btn, 0.82, PRESS_DOWN_TIME, PRESS_UP_TIME)

func _hover_anim(btn: BaseButton, hovering: bool) -> void:
	if _anim_safe.get(btn.get_instance_id(), false):
		_scale_tween(btn, HOVER_SCALE if hovering else 1.0, HOVER_TIME, HOVER_TIME)
	else:
		if hovering:
			btn.set_meta("fx_prev_modulate", btn.modulate)
			_tween_to(btn, "modulate", btn.modulate * 1.18, HOVER_TIME)
		else:
			var prev: Color = btn.get_meta("fx_prev_modulate", Color.WHITE)
			_tween_to(btn, "modulate", prev, HOVER_TIME)

func _scale_tween(btn: BaseButton, factor: float, down_time: float, up_time: float) -> void:
	_ensure_pivot(btn)
	var orig: Vector2 = btn.get_meta("fx_orig_scale", Vector2.ONE)
	_kill_tween(btn)
	var tw := btn.create_tween()
	btn.set_meta("fx_tween", tw)
	tw.tween_property(btn, "scale", orig * factor, down_time)
	tw.tween_property(btn, "scale", orig, up_time) \
		.set_trans(Tween.TRANS_BACK).set_ease(Tween.EASE_OUT)

func _modulate_tween(btn: BaseButton, factor: float, down_time: float, up_time: float) -> void:
	if not btn.has_meta("fx_prev_modulate"):
		btn.set_meta("fx_prev_modulate", btn.modulate)
	var prev: Color = btn.get_meta("fx_prev_modulate", Color.WHITE)
	_kill_tween(btn)
	var tw := btn.create_tween()
	btn.set_meta("fx_tween", tw)
	tw.tween_property(btn, "modulate", prev * factor, down_time)
	tw.tween_property(btn, "modulate", prev, up_time) \
		.set_trans(Tween.TRANS_BACK).set_ease(Tween.EASE_OUT)

func _tween_to(btn: BaseButton, prop: String, value: Variant, dur: float) -> void:
	_kill_tween(btn)
	var tw := btn.create_tween()
	btn.set_meta("fx_tween", tw)
	tw.tween_property(btn, prop, value, dur)

## 缩放中心 = 按钮中心(绑定先于布局, 动效触发时布局已就绪)
func _ensure_pivot(btn: BaseButton) -> void:
	btn.pivot_offset = btn.size / 2.0

func _kill_tween(btn: CanvasItem) -> void:
	if btn.has_meta("fx_tween"):
		var tw: Tween = btn.get_meta("fx_tween")
		if tw != null and tw.is_valid():
			tw.kill()
