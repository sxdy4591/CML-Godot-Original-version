extends Control
## 决议条目 — 纯视图。文案/三态背景/条件效果提示由 DecisionPane 给好。
## tooltip 口径对照原版 DecisionButtonScript.ChangeText: 标题/描述/状态 + 条件(req) + 效果(result)。
## 可自动的周期型决议(每 6 个月刷新)在"执行"按钮上方带一个自动勾, 点一下切换。

const 面板 := "决议"

@onready var 文案: RichTextLabel = $文案
@onready var 可执行背景: TextureRect = $背景
@onready var 不可执行背景: TextureRect = $不可执行决议_背景
@onready var 已完成背景: TextureRect = $已完成决议_背景
@onready var 执行按钮: TextureButton = $执行决议
@onready var 图标: TextureRect = $决议条目图标
@onready var 自动勾: CheckBox = $自动

var _index: int = -1


func _ready() -> void:
	自动勾.toggled.connect(_切换自动)


func setup(info: Dictionary) -> void:
	_index = int(info["index"])
	var available := bool(info["available"])
	var completed := bool(info["completed"])

	# 只有周期型决议(每 6 个月刷新)给勾选框; 打勾 = 自动执行, 取消 = 排除
	自动勾.visible = bool(info["autoable"])
	自动勾.set_pressed_no_signal(bool(info["auto"]))

	文案.text = "%s\n%s" % [info["name"], info["desc"]]

	可执行背景.visible = available
	不可执行背景.visible = not completed and not available
	已完成背景.visible = completed
	执行按钮.visible = available
	执行按钮.disabled = not available or completed
	if not 执行按钮.pressed.is_connected(_执行):
		执行按钮.pressed.connect(_执行)

	_设置提示(info, available, completed)
	_设置图标(str(info["icon"]))


# 勾/取消自动; 排除清单由逻辑层持有, 快照带回后由决议页抄进 playerprefs
func _切换自动(_on: bool) -> void:
	UiBridge.act(面板, "切换自动", [_index])
	UiBridge.request(面板)


# 原版 ChangeIcon: 资源名 D{索引}; 缺图时隐藏(保留节点)
func _设置图标(icon_name: String) -> void:
	var path := "res://assets/ui/决议/决议条目图标/%s.png" % icon_name
	if icon_name.is_empty() or not ResourceLoader.exists(path):
		图标.texture = null
		图标.visible = false
		return
	图标.texture = load(path) as Texture2D
	图标.visible = true


func _设置提示(info: Dictionary, available: bool, completed: bool) -> void:
	var state := "已完成" if completed else ("可执行" if available else "条件未满足")
	var tip := "%s\n\n%s\n\n【%s】" % [info["name"], info["desc"], state]
	var req := str(info["req"]).replace("|", "\n")
	var result := str(info["result"]).replace("|", "\n")
	if not req.is_empty():
		tip += "\n\n【条件】\n" + req
	if not result.is_empty():
		tip += "\n\n【效果】\n" + result
	tooltip_text = tip


# 默认 tooltip 是纯 Label 不解析 BBCode; 条件/效果里的 Unity 颜色标签由 悬浮提示 转 BBCode
func _make_custom_tooltip(for_text: String) -> Control:
	return 悬浮提示.build_tooltip(for_text)


func _执行() -> void:
	UiBridge.act(面板, "执行", [_index])
	UiBridge.request(面板)
