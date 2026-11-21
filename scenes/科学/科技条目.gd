extends Control
## 科技条目 — 纯视图。状态/进度/年份/悬停文案由 SciencePane 调原版 Science_Script 给好。

const 面板 := "科学"
const 可科研是 := preload("res://assets/ui/科研/是否可科研状态_是.png")
const 可科研否 := preload("res://assets/ui/科研/是否可科研状态_否.png")

@export var button_texture: Texture2D
@export var tech_name: String

signal hovered(info: Dictionary)
signal unhovered

@onready var 按钮: TextureButton = $按钮
@onready var 可科研状态: TextureRect = $是否可科研状态
@onready var 进度: ProgressBar = $科研进度
@onready var 年份: Label = $解锁年份

var _info: Dictionary = {}
var _index: int = -1


func _ready() -> void:
	按钮.texture_normal = button_texture
	按钮.pressed.connect(_开始研究)
	按钮.mouse_entered.connect(func() -> void: hovered.emit(_info))
	按钮.mouse_exited.connect(func() -> void: unhovered.emit())


func setup(info: Dictionary) -> void:
	_info = info
	_index = int(info["index"])
	# 勾 = 已完成 / 研究中 / 已投入; 叉 = 尚未开始(能否点看按钮与悬停提示)
	可科研状态.texture = 可科研是 if str(info["galka"]) == "yes" else 可科研否
	可科研状态.tooltip_text = str(info["tip"])
	进度.max_value = int(info["progress_max"])
	进度.value = int(info["progress_value"])
	年份.text = info["status"]
	按钮.disabled = not bool(info["available"])


func _开始研究() -> void:
	UiBridge.act(面板, "开始研究", [_index])
	UiBridge.request(面板)
