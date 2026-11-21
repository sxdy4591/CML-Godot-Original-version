extends VBoxContainer
## 修正模板 — 概览界面修正(buff)列表的单条模板(对照原版修正提示样式)。
## setup(id, info) 由 概览.gd 调用; info 来自 OverviewPane 的快照 modifiers 项:
##   {index, active, turned, row, name, desc, icon}
##
## 样式要点(对齐原版修改版提示的观感):
##   - 图标: assets/修正图标/{icon}.png。该素材「本身自带」深褐描边 + 米色底 + 线稿,
##     故无需再画外框(出处: 原版 ModifyButtonScript.ChangeIcon 的资源名规则
##     `modify_sp\{num}_{activated ? "0" : "1"}` —— 激活用 _0, 未激活用 _1)。
##   - 标题: 深红 28px + 同色描边 2px(工程字体无粗体面, 用描边得到加粗观感)。
##   - 正文: RichTextLabel 保留原版 <color=…> 语义色, 自动换行。
##   - 每条末尾一条细深褐分隔线。
##
## 注意: 原版文案嵌 Unity <color=…> 标签且以 | 分段 —— 名称(纯 Label)剥离标签;
##   正文转 Godot BBCode 并 | → 换行。颜色转换复用 Core/悬浮提示.gd 的通用实现。

@onready var icon_rect: TextureRect = $横排/图标
@onready var name_label: Label = $横排/纵排/名称
@onready var body_label: RichTextLabel = $横排/纵排/效果

var modifier_id: int = -1

## 滚轮修复: RichTextLabel 默认 mouse_filter=STOP 且 scroll_active=true,
## 会把自己收到的滚轮当成"滚动自身内容"消费掉, 外层 ScrollContainer 永远收不到。
## 于是鼠标停在条目正文上时列表只能拖滚动条(首屏条目少、停在空白处时又能滚,
## 表现为"第一次可以滑动, 后续只能靠滑条")。条目本身只读, 全部交给外层滚动。
func _ready() -> void:
	mouse_filter = Control.MOUSE_FILTER_PASS
	body_label.mouse_filter = Control.MOUSE_FILTER_IGNORE
	body_label.scroll_active = false
	name_label.mouse_filter = Control.MOUSE_FILTER_IGNORE
	icon_rect.mouse_filter = Control.MOUSE_FILTER_IGNORE

func setup(id: int, info: Dictionary) -> void:
	modifier_id = id
	var active: bool = int(info.get("active", 0)) == 1
	var icon_name: String = str(info.get("icon", ""))
	var icon_path := "res://assets/modifiers/%s.png" % icon_name if not icon_name.is_empty() else "res://assets/modifiers/7_1.png"
	var 纹理 := load(icon_path) as Texture2D if ResourceLoader.exists(icon_path) else null
	# 图标兜底: ResourceLoader.exists() 对"导入无效(valid=false)"仍返回 true, 此时 load() 得到 null
	if 纹理 != null:
		icon_rect.texture = 纹理
		icon_rect.visible = true
	else:
		icon_rect.visible = false
	name_label.text = _strip_unity_tags(str(info.get("name", "")))
	var body: String = str(info.get("desc", ""))
	# 未生效: 正文显示"未生效"(原版 ModifyButtonScript 新文本 229 语义)
	if not active:
		body = "未生效"
	body_label.text = _unity_to_bbcode(body).strip_edges()
	modulate = Color.WHITE if active else Color(0.72, 0.72, 0.72, 1.0)
	# tooltip: 默认 tooltip 是纯 Label, 既不折行也不解析 BBCode;
	# 原版描述用 `|` 分段, 所以这里要做 ① 剥标签 ② `|` → 换行,
	# 再由 _make_custom_tooltip 交给 悬浮提示 的 RichTextLabel 渲染(自动折行)。
	tooltip_text = "%s\n%s" % [
		_strip_unity_tags(str(info.get("name", ""))),
		_tooltip_body(str(info.get("desc", ""))),
	]

## tooltip 专用正文: 保留原版配色(深色底用亮色系) + 把分段符 `|` 还原成换行
func _tooltip_body(t: String) -> String:
	if t.is_empty():
		return ""
	# ① 先转颜色: tooltip 是近黑底, 用亮色表(<color=green> → [color=#7BD88F])
	var out := 悬浮提示.unity_to_bbcode_亮(t)
	# ② 原版 `|` 是分段符 → 换行
	out = out.replace("|", "\n")
	# ③ <size=N> → BBCode 字号
	out = out.replace("</size>", "[/font_size]")
	var re := RegEx.new()
	re.compile("<size=([0-9]+)>")
	out = re.sub(out, "[font_size=$1]", true)
	# ④ 剥掉其余未知标签(此时 <color> 已转成 BBCode, 不会被误删)
	re.compile("<[^>]*>")
	return re.sub(out, "", true).strip_edges()

## 交给 悬浮提示 渲染: RichTextLabel + AUTOWRAP_WORD_SMART, 长句不会撑成一条超宽提示
func _make_custom_tooltip(for_text: String) -> Control:
	return 悬浮提示.build_tooltip(for_text)

## 名称用: 剥掉全部 Unity 标签(纯文本)
func _strip_unity_tags(t: String) -> String:
	var out := 悬浮提示.unity_to_bbcode(t)
	var re := RegEx.new()
	re.compile("\\[/?color[^\\]]*\\]")
	out = re.sub(out, "", true)
	re.compile("<[^>]*>")
	return re.sub(out, "", true)

## 正文用: 转 Godot BBCode。
## 颜色转换复用 悬浮提示.unity_to_bbcode(命名色与 #RRGGBB 都覆盖), 再补 | 分段与 <size=N>。
func _unity_to_bbcode(t: String) -> String:
	var out := 悬浮提示.unity_to_bbcode(t)
	out = out.replace("|", "\n")
	var re := RegEx.new()
	re.compile("<size=([0-9]+)>")
	out = re.sub(out, "[font_size=$1]", true)
	out = out.replace("</size>", "[/font_size]")
	# 剥除残余的未知标签(避免 RichTextLabel 把 <...> 原样显示)
	re.compile("<[^>]*>")
	return re.sub(out, "", true)
