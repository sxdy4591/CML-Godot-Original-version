extends Node
## 场景管理器 — 纯 UI 导航层。
## 只做两件事：响应事件总线的界面请求、响应逻辑层的切场景通知。
## 不判断任何游戏数值，不推演结局。

const 外交场景 := preload("res://scenes/外交/外交.tscn")
const 主菜单场景 := preload("res://scenes/主菜单/主菜单.tscn")
const 设置场景 := preload("res://scenes/设置/设置.tscn")
const 读档场景 := preload("res://scenes/存档/加载.tscn")
const 关于场景 := preload("res://scenes/关于/关于.tscn")


func _ready() -> void:
	全局管理.start_game.connect(_开始游戏)
	全局管理.open_settings.connect(_打开设置)
	全局管理.open_load.connect(_打开读档)
	全局管理.show_about.connect(_打开关于)
	全局管理.quit_game.connect(_退出)
	全局管理.request_scene_change.connect(_切换)
	# 原版 LoadScene 的切场景已由桥层(UiBridge.OnScene)直接执行, 这里不再重复连接,
	# 否则同一请求会切两次场景(事件场景被重载, 状态丢失).


func _开始游戏() -> void:
	UiBridge.act("游戏", "开始新游戏", [])
	_切换(外交场景)


func _打开设置() -> void:
	全局管理.settings_return_scene = "res://scenes/主菜单/主菜单.tscn"
	_切换(设置场景)


func _打开读档() -> void:
	全局管理.save_return_scene = "res://scenes/主菜单/主菜单.tscn"
	_切换(读档场景)


func _打开关于() -> void:
	_切换(关于场景)


func _退出() -> void:
	get_tree().quit()


func _按路径切换(path: String) -> void:
	_切换到文件(path)


func _切换(scene: PackedScene) -> void:
	get_tree().paused = false
	get_tree().change_scene_to_packed(scene)


func _切换到文件(path: String) -> void:
	get_tree().paused = false
	get_tree().change_scene_to_file(path)
