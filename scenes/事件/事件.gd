extends Control
## 事件界面 — 纯视图。三页式: 描述 → 选项 → 结果。
## 文本/选项/结果全部来自 EventPane 快照; 翻页与选择只转发动作。

const 面板 := "事件"

enum 页 { 描述, 选项, 结果 }

@onready var 标题: Label = $事件标题
@onready var 描述: RichTextLabel = $事件描述
@onready var 未读完提示: Label = $事件内容未读完提示
@onready var 左翻: TextureButton = $事件切换页面按钮2
@onready var 右翻: TextureButton = $事件切换页面按钮
@onready var 图片: TextureRect = $事件图片
@onready var 选项容器: Control = $事件选项
@onready var 结果容器: Control = $事件结果
@onready var 结果描述: RichTextLabel = $事件结果/事件结果描述
@onready var 选项文本: Array[Label] = [
	$事件选项/选项1文本, $事件选项/选项2文本, $事件选项/选项3文本,
	$事件选项/选项4文本, $事件选项/选项5文本, $事件选项/选项6文本
]
@onready var 选项按钮: Array[TextureButton] = [
	$事件选项/选项1, $事件选项/选项2, $事件选项/选项3,
	$事件选项/选项4, $事件选项/选项5, $事件选项/选项6
]

var _快照: Dictionary = {}
var _页: int = 页.描述
var _已选: int = -1
var _已确认: bool = false
var _编号: int = -1
var _ui: Node
static var _插图池: Array[String] = []


func _ready() -> void:
	_ui = get_node("/root/UISettings")
	_apply_text_settings()
	左翻.pressed.connect(_左翻页)
	右翻.pressed.connect(_右翻页)
	for i in 选项按钮.size():
		选项按钮[i].pressed.connect(_选择.bind(i))
	var 滚动条 := 描述.get_v_scroll_bar()
	滚动条.value_changed.connect(_更新提示)
	滚动条.changed.connect(_更新提示)
	var 结果滚动条 := 结果描述.get_v_scroll_bar()
	结果滚动条.value_changed.connect(_更新提示)
	结果滚动条.changed.connect(_更新提示)
	UiBridge.connect("panel_snapshot", _收到快照)
	# 原版每进一次事件场景都新建事件对象: 通知逻辑层从描述页重新开始(含结算状态)
	UiBridge.act(面板, "进入", [])
	UiBridge.request(面板)
	print("[事件] ready 按钮=", 选项按钮.size(), " 描述可见=", 描述.visible)


func _选择(index: int) -> void:
	# 选中阶段可以随便改选; 只有按右翻确认(结算)之后才锁死, 避免重复结算 ResultsOfEvents.
	if _已确认:
		return
	print("[事件] 选择=", index)
	_已选 = index
	for i in 选项按钮.size():
		选项按钮[i].set_pressed_no_signal(i == index)


func _左翻页() -> void:
	print("[事件] 左翻 页=", _页)
	if _页 != 页.选项:
		return
	_页 = 页.描述
	_刷新页()


func _右翻页() -> void:
	print("[事件] 右翻 页=", _页)
	match _页:
		页.描述:
			_页 = 页.选项
		页.选项:
			if _已选 < 0:
				return
			# 右翻 = 确认选择: 这一刻才结算(与原版点选项后立刻 LoadScene(Results) 同一时机)
			UiBridge.act(面板, "选择", [_已选])
			_已确认 = true
			UiBridge.request(面板)
			_页 = 页.结果
		页.结果:
			UiBridge.act(面板, "关闭", [])
			return
	_刷新页()


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_快照 = data
	标题.text = data["title"]
	描述.text = _排版(data["body"])
	结果描述.text = _排版(data["result"])
	var 编号 := int(data["number"])
	var 专属 := "res://assets/illustrations/%d.png" % 编号
	if ResourceLoader.exists(专属):
		图片.texture = load(专属) as Texture2D
	else:
		图片.texture = _兜底插图(编号)
	图片.visible = 图片.texture != null
	# 换事件(链式事件不离开本场景)时重置选择与页码
	if 编号 != _编号:
		_编号 = 编号
		_已选 = -1
		_已确认 = false
		_页 = 页.描述
	var options: Array = data["options"]
	for i in 选项按钮.size():
		var 有: bool = i < options.size()
		var 可点: bool = 有 and bool(options[i]["enabled"])
		选项文本[i].visible = 有
		if not 有:
			# 本事件没有第 i 个选项: 右侧方框要一并藏掉, 否则会多出空框(与文本行错位)
			选项按钮[i].visible = false
			选项按钮[i].disabled = true
		elif _已确认:
			# 已确认结算: 冻结选项显示. 不能设 disabled(TextureButton 的勾选图会退回普通态),
			# 用 IGNORE 让它不再接收点击, 同时保持选中态与纹理.
			选项按钮[i].visible = true
			选项按钮[i].disabled = false
			选项按钮[i].mouse_filter = Control.MOUSE_FILTER_IGNORE
			选项按钮[i].set_pressed_no_signal(i == _已选)
		else:
			# 原版不可用的选项会 Destroy 掉按钮(galka_stuk), 只留文本; 这里同样把方框藏掉
			选项文本[i].text = _纯文本(options[i]["text"])
			选项按钮[i].visible = 可点
			选项按钮[i].disabled = not 可点
			选项按钮[i].mouse_filter = Control.MOUSE_FILTER_STOP
	_刷新页()


func _刷新页() -> void:
	描述.visible = _页 == 页.描述
	选项容器.visible = _页 == 页.选项
	结果容器.visible = _页 == 页.结果
	_更新提示()


# 自定义设置: 事件标题/正文/选项/结果字号(乘全局字体倍率)与正文对齐
func _apply_text_settings() -> void:
	var 倍率: float = _ui.get_scale()
	_字号(标题, _ui.get_int("event_title_size", 55), 倍率)
	_字号(描述, _ui.get_int("event_desc_size", 29), 倍率)
	_字号(结果描述, _ui.get_int("event_result_size", 29), 倍率)
	for lbl in 选项文本:
		_字号(lbl, _ui.get_int("event_option_size", 28), 倍率)
	var 对齐 := _ui.get_int("event_align", 0) as HorizontalAlignment
	描述.horizontal_alignment = 对齐
	结果描述.horizontal_alignment = 对齐


func _字号(node: Control, 基础: int, 倍率: float) -> void:
	var 值: int = maxi(6, int(round(基础 * 倍率)))
	if node is RichTextLabel:
		node.add_theme_font_size_override("normal_font_size", 值)
	else:
		node.add_theme_font_size_override("font_size", 值)


# 原版文案用 "|" 换行、<color=...> 富文本; 再按设置加段落间距与段首缩进
func _排版(text: String) -> String:
	var t: String = 悬浮提示.unity_to_bbcode(str(text).replace("|", "\n"))
	if _ui.get_bool("paragraph_spacing", false):
		t = t.replace("\n\n", "\n\n\n")
	if _ui.get_bool("paragraph_indent", false):
		var 行 := t.split("\n")
		for i in 行.size():
			if 行[i].strip_edges() != "":
				行[i] = "　　" + 行[i]
		t = "\n".join(行)
	return t


# 选项文本是普通 Label: 换行转正并剥掉 Unity 富文本标签
func _纯文本(text: String) -> String:
	var t: String = str(text).replace("|", "\n")
	var re := RegEx.new()
	re.compile("<[^>]*>")
	return re.sub(t, "", true).strip_edges()


# 无专属插画的事件: 从 assets/illustrations 取全部插画, 按事件编号取模稳定选一张
func _兜底插图(编号: int) -> Texture2D:
	if _插图池.is_empty():
		var dir := DirAccess.open("res://assets/illustrations")
		dir.list_dir_begin()
		var 文件 := dir.get_next()
		while 文件 != "":
			if not dir.current_is_dir():
				var 名 := ""
				if 文件.ends_with(".png"):
					名 = 文件
				elif 文件.ends_with(".png.import"):
					名 = 文件.trim_suffix(".import")
				if not 名.is_empty() and not _插图池.has(名):
					_插图池.append(名)
			文件 = dir.get_next()
		dir.list_dir_end()
		_插图池.sort()
	if _插图池.is_empty():
		return null
	var path := "res://assets/illustrations/%s" % _插图池[posmod(编号, _插图池.size())]
	return load(path) as Texture2D


# 当前页内容未滚到底时显示"下方还有未读内容"
func _更新提示(_值: float = 0.0) -> void:
	var 未读完 := false
	if 描述.visible:
		var 滚动条 := 描述.get_v_scroll_bar()
		未读完 = 滚动条.value + 滚动条.page < 滚动条.max_value - 1.0
	elif 结果容器.visible:
		var 滚动条 := 结果描述.get_v_scroll_bar()
		未读完 = 滚动条.value + 滚动条.page < 滚动条.max_value - 1.0
	未读完提示.visible = 未读完
