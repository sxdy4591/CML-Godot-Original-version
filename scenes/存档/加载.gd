extends "res://scenes/存档/存档列表.gd"
## 读档界面 — 列表式: 自动存档单独一栏, 手动槽无限列表.


func _ready() -> void:
	面板 = "读档"
	主按钮文案 = "读取"
	自动主按钮文案 = "读取"
	super()
