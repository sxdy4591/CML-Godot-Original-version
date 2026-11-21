extends Control
## 读档界面 — 纯视图。槽位元信息来自 LoadPane。

const 面板 := "读档"
## slots 顺序: 0=自动存档, 1..5=成就/无成就手动槽
const 槽号 := [0, 5, 1, 2, 3, 4]

@onready var 槽位: Array[Button] = [
	$自动存档位, $成就存档位, $无成就存档位1, $无成就存档位2, $无成就存档位3, $无成就存档位4
]
@onready var 文本: Label = $加载文本

var _可用: Array[bool] = []


func _ready() -> void:
	for i in 槽位.size():
		槽位[i].pressed.connect(_读取.bind(i))
	$从Unity导入.pressed.connect(_导入Unity)
	$返回主菜单.pressed.connect(_返回)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)


func _读取(index: int) -> void:
	# 空档位按钮保持可见可点, 但点了不读取(不置 disabled: disabled 的按钮几乎看不见)
	if index >= _可用.size() or not _可用[index]:
		return
	UiBridge.act(面板, "读取", [槽号[index]])


func _导入Unity() -> void:
	UiBridge.act(面板, "导入Unity", [])
	UiBridge.request(面板)


func _返回() -> void:
	# 从游戏内 ESC 进入时回外交; 从主菜单"读取存档"进入时回主菜单
	get_tree().change_scene_to_file(全局管理.save_return_scene)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	var slots: Array = data["slots"]
	_可用 = []
	for i in 槽位.size():
		var info: Dictionary = slots[槽号[i]]
		var 名: String = "自动存档" if 槽号[i] == 0 else "槽位 %d" % info["slot"]
		槽位[i].text = "%s  %s" % [名, info["date"] if info["exists"] else "空"]
		_可用.append(bool(info["exists"]))
	var 消息 := str(data["import_message"])
	if not 消息.is_empty():
		文本.text = 消息
