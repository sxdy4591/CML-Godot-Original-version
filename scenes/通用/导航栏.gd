extends CanvasLayer
## 导航栏 — 纯 GDScript 导航层。页签显隐 + 紧凑重排 + 未实装禁用。
## 目标场景写在 .tscn 的 metadata(scene_path) 里, 点击只发 全局管理.request_scene_change。

const 按钮名 := ["世界地图", "派系", "经济", "科学", "概览", "政治", "战争"]

const 起始X := 56.0
const 间距 := 310.0
const 按钮宽 := 279.0
const 按钮高 := 65.0
const 按钮Y := 80.0

var _当前: String = "diplomacy"


func _ready() -> void:
	for 名 in 按钮名:
		var 按钮 := get_node(名) as BaseButton
		按钮.pressed.connect(_切换.bind(按钮))
	_刷新()


func set_screen(screen: String) -> void:
	if _当前 == screen:
		return
	_当前 = screen
	_刷新()


func _刷新() -> void:
	var 序号 := 0
	for 名 in 按钮名:
		var 按钮 := get_node(名) as BaseButton
		var 显示 := str(按钮.get_meta("screen_id", "")) != _当前
		按钮.visible = 显示
		if 显示:
			按钮.position = Vector2(起始X + 序号 * 间距, 按钮Y)
			按钮.size = Vector2(按钮宽, 按钮高)
			序号 += 1
		var 路径 := str(按钮.get_meta("scene_path", ""))
		按钮.disabled = not ResourceLoader.exists(路径)


func _切换(按钮: BaseButton) -> void:
	var 路径 := str(按钮.get_meta("scene_path", ""))
	全局管理.request_scene_change.emit(load(路径) as PackedScene)
