extends Control
## 保存界面 — 纯视图。槽位元信息来自 SavePane。

const 面板 := "存档"
const 槽号 := [5, 1, 2, 3, 4]

@onready var 槽位: Array[Button] = [
	$成就存档位, $无成就存档位1, $无成就存档位2, $无成就存档位3, $无成就存档位4
]
@onready var 文本: Label = $保存文本


func _ready() -> void:
	for i in 槽位.size():
		槽位[i].pressed.connect(_保存.bind(i))
	$返回主菜单.pressed.connect(_返回)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)


func _保存(index: int) -> void:
	UiBridge.act(面板, "保存", [槽号[index]])
	文本.text = "已保存到槽位 %d" % 槽号[index]
	UiBridge.request(面板)


func _返回() -> void:
	# 从游戏内 ESC 进入时 save_return_scene = 外交; 从主菜单进入时 = 主菜单
	get_tree().change_scene_to_file(全局管理.save_return_scene)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	var slots: Array = data["slots"]
	for i in 槽位.size():
		var info: Dictionary = slots[槽号[i] - 1]
		槽位[i].text = "槽位 %d  %s" % [info["slot"], info["date"] if info["exists"] else "空"]
