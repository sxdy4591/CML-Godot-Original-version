extends Control
## 战争条目 — 纯视图。字段/可用性由 WarPane 给好，按钮只转发动作编号。
## 动作 id 与原版 WarButtonScript.this_number 一致:
##   左 0人力 1特战 2军武 3外交; 右 4特战 5人力 6军武 7外交.

const 面板 := "战争"

const 动作 := {
	"人力增援左方参战势力": 0,
	"特战支援左方参战势力": 1,
	"军武援助左方参战势力": 2,
	"外交声援左方参战势力": 3,
	"特战支援右方参战势力": 4,
	"人力增援右方参战势力": 5,
	"军武援助右方参战势力": 6,
	"外交声援右方参战势力": 7,
}

const 左方图标 := preload("res://assets/ui/战争/左方参战势力图标.png")
const 右方图标 := preload("res://assets/ui/战争/右方参战势力图标.png")
const 圆圈图标 := preload("res://assets/ui/战争/圆圈.png")

@onready var 战争名称: Label = $战争名称
@onready var 左方势力: Label = $左方势力
@onready var 右方势力: Label = $右方势力
@onready var 左方数值: Label = $左方数值
@onready var 右方数值: Label = $右方数值
@onready var 左方主图标: TextureRect = $左方主图标
@onready var 左方圆圈: TextureRect = $左方圆圈
@onready var 右方主图标: TextureRect = $右方主图标
@onready var 右方圆圈: TextureRect = $右方圆圈

var _war_index: int = -1


func _ready() -> void:
	for 名称 in 动作:
		var 按钮 := get_node(名称) as Button
		按钮.add_theme_color_override("font_disabled_color", Color(0, 0, 0, 1))
		按钮.pressed.connect(_支援.bind(动作[名称]))


func setup(w: Dictionary) -> void:
	_war_index = int(w["index"])
	战争名称.text = w["name"]
	左方势力.text = w["left"]
	右方势力.text = w["right"]
	左方数值.text = w["left_value"]
	右方数值.text = w["right_value"]
	_paint_side(左方主图标, 左方圆圈, int(w["usa_side"]), int(w["ussr_side"]), 0)
	_paint_side(右方主图标, 右方圆圈, int(w["usa_side"]), int(w["ussr_side"]), 1)
	var can: Array = w["can_action"]
	for 名称 in 动作:
		var 按钮 := get_node(名称) as Button
		var ok := bool(can[动作[名称]])
		按钮.disabled = not ok
		按钮特效.set_base_modulate(按钮, Color.WHITE if ok else Color(0.5, 0.5, 0.5, 1))


# 原版 WarsScript.EstablishWarsChar(124-147): 主图标美优先、其次苏;
# 美苏同时支持本方时圆圈替换为另一超级大国图标。
func _paint_side(main_icon: TextureRect, circle: TextureRect, usa: int, ussr: int, side: int) -> void:
	var main_tex: Texture2D = null
	if usa == side:
		main_tex = 右方图标
	elif ussr == side:
		main_tex = 左方图标
	main_icon.visible = main_tex != null
	main_icon.texture = main_tex
	circle.texture = 左方图标 if usa == side and ussr == side else 圆圈图标


func _支援(button: int) -> void:
	UiBridge.act(面板, "支援", [_war_index, button])
	UiBridge.request(面板)
