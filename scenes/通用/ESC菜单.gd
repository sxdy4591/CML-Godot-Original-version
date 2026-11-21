extends CanvasLayer
## ESC 暂停菜单 — 纯 GDScript 系统界面（对接原游戏逻辑 = 无）。
##
## 只负责两件事：
##   1. 暂停状态：菜单打开时 get_tree().paused = true；关闭时恢复。
##   2. 页面跳转：全部转成 全局管理.request_scene_change，由 场景管理器 执行。
## 不读写游戏状态、不判定结果、不调 UiBridge。
##
## 生命周期由容器管理：外交.gd 用 _toggle_esc_menu() 实例化/销毁本菜单，
## 因此"关闭"与 ESC 键都回调父节点同一个入口，保证容器里的 _esc_menu 引用
## 与暂停状态同时复位（否则会出现"关掉后再按 ESC 打不开"）。
## "结束"按钮在 .tscn 里 visible=false（结局流程不在本菜单），这里只保留同入口。

const 主菜单场景 := preload("res://scenes/主菜单/主菜单.tscn")
const 设置场景 := preload("res://scenes/设置/设置.tscn")
const 保存场景 := preload("res://scenes/存档/保存.tscn")
const 加载场景 := preload("res://scenes/存档/加载.tscn")

func _ready() -> void:
	# 暂停期间菜单要照常响应（含 ESC 键），故整层不随 get_tree().paused 冻结
	process_mode = Node.PROCESS_MODE_ALWAYS
	get_tree().paused = true

func _unhandled_input(event: InputEvent) -> void:
	if not (event is InputEventKey and event.pressed and not event.echo):
		return
	if event.keycode != KEY_ESCAPE and event.physical_keycode != KEY_ESCAPE:
		return
	_关闭()
	get_viewport().set_input_as_handled()

func _on_存档_pressed() -> void:
	全局管理.save_return_scene = _当前场景路径()
	全局管理.request_scene_change.emit(保存场景)

func _on_加载_pressed() -> void:
	全局管理.save_return_scene = _当前场景路径()
	全局管理.request_scene_change.emit(加载场景)

func _on_设置_pressed() -> void:
	全局管理.settings_return_scene = _当前场景路径()
	全局管理.request_scene_change.emit(设置场景)

func _on_退出_pressed() -> void:
	全局管理.request_scene_change.emit(主菜单场景)

func _on_结束_pressed() -> void:
	_关闭()

func _on_关闭_pressed() -> void:
	_关闭()

## 菜单随所在游戏场景实例化，当前场景路径就是"关闭后该回去的地方"
func _当前场景路径() -> String:
	return get_tree().current_scene.scene_file_path

## 交给容器销毁（它同时负责恢复暂停与重新显示右上角 ESC 入口按钮）
func _关闭() -> void:
	get_parent().call("_toggle_esc_menu")
