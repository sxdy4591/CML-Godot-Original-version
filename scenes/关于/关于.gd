extends Control
## 关于 — 纯 GDScript 系统界面（对接原游戏逻辑 = 无）。
## 内容默认写在 .tscn 里; 在线清单(docs/content.json)到了就覆盖三个图片与两段介绍,
## 拉不到就保持本地版本. 不读游戏状态, 切场景统一走 全局管理.

const 主菜单场景 := preload("res://scenes/主菜单/主菜单.tscn")

@onready var 群图片: TextureRect = $qq群
@onready var 演示1: TextureRect = $demo1
@onready var 演示2: TextureRect = $demo2
@onready var 二版介绍: Label = $二版介绍
@onready var 在线: Node = get_node("/root/在线更新")
@onready var 一版介绍: Label = $一版介绍


func _ready() -> void:
	在线.在线内容就绪.connect(_应用内容)
	if 在线.内容.is_empty():
		在线.拉取内容()
	else:
		_应用内容(在线.内容)


## content.json 键: about_v2 / about_v1 / qq / demo1 / demo2 (图片为完整 URL)
func _应用内容(内容: Dictionary) -> void:
	_替换文本(二版介绍, 内容, "about_v2")
	_替换文本(一版介绍, 内容, "about_v1")
	_替换图片(群图片, 内容, "qq")
	_替换图片(演示1, 内容, "demo1")
	_替换图片(演示2, 内容, "demo2")


func _替换文本(标签: Label, 内容: Dictionary, 键: String) -> void:
	if 内容.has(键):
		标签.text = str(内容[键])


func _替换图片(节点: TextureRect, 内容: Dictionary, 键: String) -> void:
	if not 内容.has(键):
		return
	var 地址 := str(内容[键])
	if 地址.is_empty():
		return
	在线.下载图片(地址, func(纹理: Texture2D) -> void: 节点.texture = 纹理)


func _on_返回主菜单_pressed() -> void:
	全局管理.request_scene_change.emit(主菜单场景)
