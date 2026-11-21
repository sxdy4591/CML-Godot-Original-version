extends Control
## 政治家卡片 — 纯视图。字段由 PoliticsPane 给好，肖像按头像部件表拼接。

const 部件表 = preload("res://src/common/头像部件表.gd")

@onready var 人像: Control = $人像
@onready var 节点: Array[TextureRect] = [
	$人像/基底脸, $人像/层0, $人像/层1, $人像/层2, $人像/层3,
	$人像/层4, $人像/层5, $人像/层6, $人像/层7, $人像/外套
]
@onready var 姓名: Label = $姓名
@onready var 派系: Label = $派系
@onready var 派系色条: ColorRect = $派系色条
@onready var 特质1: Label = $特质1
@onready var 特质2: Label = $特质2
@onready var 忠诚度: ProgressBar = $忠诚度
@onready var 职务角标: Label = $职务角标
@onready var 状态角标: PanelContainer = $状态角标
@onready var 状态文字: Label = $状态角标/状态文字


func setup(info: Dictionary) -> void:
	姓名.text = info["name"]
	派系.text = info["faction"]
	派系色条.color = info["faction_color"]
	特质1.text = info["trait1"]
	特质2.text = info["trait2"]
	忠诚度.value = info["loyalty"]
	职务角标.text = info["post"]
	状态文字.text = info["status_flag"]
	状态角标.visible = not 状态文字.text.is_empty()
	tooltip_text = str(info["tooltip"]).replace("|", "\n")
	部件表.apply_layers(人像, 节点, _层列表(info))


# 原版悬浮框 OkoshkoScript: 文本带 <color=yellow> 标签与 "|" 换行, 默认 tooltip 不解析 BBCode
func _make_custom_tooltip(for_text: String) -> Control:
	return 悬浮提示.build_tooltip(for_text)


func _层列表(info: Dictionary) -> Array:
	var face: Dictionary = 部件表.FACE_TYPES[int(info["face_type"])]
	var out: Array = [_项(face["base"])]
	var parts: Array = info["face_parts"]
	for layer in 8:
		var entry = face["layers"][layer][int(parts[layer])]
		if entry != null:
			out.append(_项(entry))
	var jacket = face["jacket"][int(info["jacket"])]
	if jacket != null:
		out.append(_项(jacket))
	return out


func _项(entry: Array) -> Dictionary:
	return {"file": entry[0], "pos": entry[1], "size": entry[2], "slot": entry[4]}
