extends Control
## 结局界面 — 纯视图。分类、页数、标题、正文全部来自 EndingPane 快照。

const 面板 := "结局"

const 背景图 := preload("res://assets/ui/结局/结局背景图.png")
const 背景图_正常 := preload("res://assets/ui/结局/结局背景图_正常.png")

@onready var 标题: Label = $结局标题
@onready var 正文: RichTextLabel = $结局文案
@onready var 背景: TextureRect = $背景
@onready var 页码: Label = $页码
@onready var 左翻: TextureButton = $左翻页
@onready var 右翻: TextureButton = $右翻页
@onready var 卷宗: Control = $卷宗
@onready var 卷签: Array[Button] = [
	$卷宗/本篇按钮, $卷宗/中东非洲按钮, $卷宗/美洲亚太按钮, $卷宗/欧洲按钮,
]

var _坏结局: bool = false
var _卷宗: Array = []
var _当前卷: int = 0
var _当前页: int = 0


func _ready() -> void:
	process_mode = Node.PROCESS_MODE_ALWAYS
	左翻.pressed.connect(_翻页.bind(-1))
	右翻.pressed.connect(_翻页.bind(1))
	for i in 卷签.size():
		卷签[i].pressed.connect(_选卷.bind(i))
	$返回主菜单.pressed.connect(_返回)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)


func _返回() -> void:
	get_tree().paused = false
	get_tree().change_scene_to_file("res://scenes/主菜单/主菜单.tscn")


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_坏结局 = data["bad"]
	_卷宗 = data["panels"]
	背景.texture = 背景图 if _坏结局 else 背景图_正常
	页码.visible = not _坏结局
	左翻.visible = not _坏结局
	右翻.visible = not _坏结局
	卷宗.visible = not _坏结局
	for i in 卷签.size():
		卷签[i].visible = not _坏结局 and _卷宗[i]["enabled"]
	_选卷(0)


func _选卷(index: int) -> void:
	_当前卷 = index
	_当前页 = 0
	卷签[index].button_pressed = true
	_刷新()


func _翻页(方向: int) -> void:
	var 页数: int = _卷宗[_当前卷]["pages"].size()
	_当前页 = posmod(_当前页 + 方向, 页数)
	_刷新()


func _刷新() -> void:
	var 页: Dictionary = _卷宗[_当前卷]["pages"][_当前页]
	标题.text = 页["title"]
	正文.text = _转bbcode(页["body"])
	正文.scroll_to_line(0)
	页码.text = 页["label"]


func _转bbcode(text: String) -> String:
	var out := 悬浮提示.unity_to_bbcode(text.replace("||", "\n\n").replace("|", "\n"))
	var re := RegEx.new()
	re.compile("</color>")
	out = re.sub(out, "[/color]", true)
	re.compile("<size=([0-9]+)>")
	out = re.sub(out, "[font_size=$1]", true)
	re.compile("</size>")
	out = re.sub(out, "[/font_size]", true)
	return out
