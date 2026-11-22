extends Button
## 存档行模板 — 只放数据; 按钮点击由 存档列表.gd 统一连接.
## 槽位号由父界面写入(1..n); 自动存档目标槽由行内「自动」开关指定.

var 槽位号: int = -1

@onready var 槽位名: Label = $槽位名
@onready var 日期: Label = $日期
@onready var 领袖: Label = $领袖
@onready var 难度: Label = $难度
@onready var 时间: Label = $时间
@onready var 主按钮: Button = $主按钮
@onready var 复制: Button = $复制
@onready var 删除: Button = $删除
@onready var 恢复: Button = $恢复
@onready var 导出: Button = $导出
@onready var 自动: CheckButton = $自动

const 黑色 := Color(0, 0, 0, 1)


func _ready() -> void:
	# 黑色字体: 主题里没给 Button 定义 hover/pressed 色, 不补的话鼠标一上去文字就变白
	for 按钮 in [主按钮, 自动, 复制, 删除, 恢复, 导出]:
		for 键 in ["font_hover_color", "font_pressed_color", "font_focus_color"]:
			按钮.add_theme_color_override(键, 黑色)
