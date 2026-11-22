extends Control
## 成就条目 — 纯视图。数据来自 AchievementPane 快照; 图标由 成就.gd 在线加载后回填.

const 默认图标 := preload("res://assets/ui/战争/圆圈.png")
## 已解锁条目整行文字转绿(未解锁保持主题默认色)
const 解锁色 := Color(0.03, 0.45, 0.08, 1)

@onready var 图标: TextureRect = $图标
@onready var 标题: Label = $标题
@onready var 描述: Label = $描述
@onready var 状态: Label = $状态


func setup(info: Dictionary) -> void:
	标题.text = info["title"]
	描述.text = info["desc"]
	var 已解锁: bool = bool(info["unlocked"])
	状态.text = "已解锁" if 已解锁 else "未解锁"
	modulate = Color(1, 1, 1, 1) if 已解锁 else Color(1, 1, 1, 0.55)
	for 文字 in [标题, 描述, 状态]:
		if 已解锁:
			文字.add_theme_color_override("font_color", 解锁色)
		else:
			文字.remove_theme_color_override("font_color")
	图标.texture = 默认图标
	var 本地 := str(info.get("icon", ""))
	if not 本地.is_empty() and ResourceLoader.exists(本地):
		图标.texture = load(本地) as Texture2D


func 设图标(tex: Texture2D) -> void:
	图标.texture = tex
