extends "res://scenes/存档/存档列表.gd"
## 保存界面 — 列表式: 自动存档单独一栏, 手动槽无限列表.


func _ready() -> void:
	面板 = "存档"
	主按钮文案 = "保存"
	自动主按钮文案 = "写入自动槽"
	super()
