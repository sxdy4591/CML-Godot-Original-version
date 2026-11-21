class_name 悬浮提示
extends Control
## 统一悬浮提示渲染 — 原版 Unity 富文本(<color=X>…</color>) → Godot BBCode,
## 用 RichTextLabel 自定义 tooltip 渲染(Godot 默认 tooltip 是纯 Label/TooltipLabel,
## 不解析 BBCode, 会原样显示 <color=…> 标签)。
##
## 用法:
##   - 已有脚本的控件: 自行实现
##       func _make_custom_tooltip(for_text: String) -> Control:
##           return 悬浮提示.build_tooltip(for_text)
##   - 无脚本控件(Label/TextureButton 等): 设 tooltip_text 后调 悬浮提示.attach(ctrl)

## 原版 Unity 命名色 → 本工程使用的**深色系**十六进制。
## 为什么需要这张表: Unity 文案里写的是 <color=green>/<color=yellow>/<color=lime>,
## 直接换成 Godot 的命名色会得到纯亮绿 #00FF00 / 纯黄 #FFFF00 —— 在米白纸面 UI
## (科研提示板/事件/结局/概览/派系条件栏)上几乎看不清(用户反馈"绿色黄色太亮")。
## 这里统一压到一档深色: 深绿/深黄/深青/深橙, 同时兼顾深色 tooltip 底(不用纯黑绿)。
## **全工程颜色转换的唯一真值** —— 各界面脚本不要再各写一份 replace 表。
const 命名色映射 := {
	"red": "#C0392B",       # 深红
	"green": "#2E7D32",     # 深绿
	"lime": "#558B2F",      # 深绿(偏黄)
	"yellow": "#8A6D00",    # 深黄(橄榄)
	"orange": "#B4661E",    # 深橙
	"cyan": "#2A8C96",      # 深青
	"blue": "#3B62C4",      # 中蓝(纯 #0000CC 在深色 tooltip 上看不见)
	"white": "#FFFFFF",
	"black": "#111111",
	"gray": "#777777",
	"grey": "#777777",
}

## 通用转换: <color=名称/#hex> → [color=…](命名色与 #RRGGBB 均兼容;
## 结尾 > 一并转成 ], 避免生成非法的 [color=green> 被 BBCode 解析器吞掉整段)
## 命名色经 命名色映射 换成深色; 未收录的名称原样保留(交给 BBCode 自己解析)。

## 深色底(悬浮提示面板)专用色表 —— 上面那套是给米白纸面压暗用的,
## 放到近黑 tooltip 上对比度不足(用户反馈"tooltip 里没有颜色"), 故另配一套亮的。
## 只用于 build_tooltip 渲染, 正文/纸面仍用 命名色映射。
const 命名色映射_亮 := {
	"red": "#FF6B6B",       # 亮红
	"green": "#7BD88F",     # 亮绿
	"lime": "#B7E778",      # 黄绿
	"yellow": "#FFD166",    # 亮黄
	"orange": "#FFA94D",    # 亮橙
	"cyan": "#66D9E8",      # 亮青
	"blue": "#7FA6FF",      # 亮蓝
	"white": "#FFFFFF",
	"black": "#E6E6E6",     # 黑底上"黑"没有意义, 给浅灰
	"gray": "#B0B0B0",
	"grey": "#B0B0B0",
}

static func _apply_color_map(text: String, table: Dictionary) -> String:
	var out := text.replace("</color>", "[/color]")
	var re := RegEx.new()
	re.compile("<color=([^>]+)>")
	var matches := re.search_all(out)
	# 从后往前替换: 前面的替换不会让后面的偏移失效
	for i in range(matches.size() - 1, -1, -1):
		var m: RegExMatch = matches[i]
		# 变量名不能叫 name: 会遮蔽 Node.name(编辑器报 SHADOWED_VARIABLE_BASE_CLASS)
		var 色名 := m.get_string(1).strip_edges()
		var hex: String = table.get(色名.to_lower(), "")
		var repl := "[color=%s]" % (hex if hex != "" else 色名)
		out = out.substr(0, m.get_start()) + repl + out.substr(m.get_end())
	return out

static func unity_to_bbcode(text: String) -> String:
	return _unity_tags_to_bbcode(_apply_color_map(text, 命名色映射))

## 深色底版本: 亮色系(供 tooltip 等近黑背景使用)
static func unity_to_bbcode_亮(text: String) -> String:
	return _unity_tags_to_bbcode(_apply_color_map(text, 命名色映射_亮))


## Unity 富文本的 <size=N>/<b>/<i>/<u> 转 BBCode; <color> 已由 _apply_color_map 处理.
## 原版事件正文有 "<size=40>…</size>"(如尼加拉瓜事件), 不转就会原样显示标签.
static var _size_re: RegEx
static func _unity_tags_to_bbcode(text: String) -> String:
	if _size_re == null:
		_size_re = RegEx.new()
		_size_re.compile("(?i)<size=([0-9]+)>")
	var t := _size_re.sub(text, "[font_size=$1]", true)
	t = t.replace("</size>", "[/font_size]").replace("</SIZE>", "[/font_size]")
	t = t.replace("<b>", "[b]").replace("</b>", "[/b]").replace("<B>", "[b]").replace("</B>", "[/b]")
	t = t.replace("<i>", "[i]").replace("</i>", "[/i]").replace("<I>", "[i]").replace("</I>", "[/i]")
	t = t.replace("<u>", "[u]").replace("</u>", "[/u]").replace("<U>", "[u]").replace("</U>", "[/u]")
	return t


## 命名色查询(供必须手写 BBCode 的地方复用同一套深色值)
static func 深色(色名: String) -> String:
	return 命名色映射.get(色名.to_lower(), 色名)


## 给无脚本控件挂上本脚本, 使其 tooltip 支持 BBCode 彩色渲染:
## 默认 tooltip 是纯 Label 不解析标签; Label 默认 mouse_filter=IGNORE 收不到
## 悬停 → tooltip 永不显示, 这里统一改为 STOP(重复调用无副作用)

static func attach(ctrl: Control) -> void:
	if ctrl == null or ctrl.get_script() != null:
		return
	if ctrl.mouse_filter == Control.MOUSE_FILTER_IGNORE:
		ctrl.mouse_filter = Control.MOUSE_FILTER_STOP
	ctrl.set_script(load("res://src/common/悬浮提示.gd"))


## 实例入口: attach 挂载后, 引擎回调本方法渲染 BBCode tooltip

func _make_custom_tooltip(for_text: String) -> Control:
	return build_tooltip(for_text)


## 去掉 BBCode 标签(高度估算用)

static func _strip_bbcode(text: String) -> String:
	var out := text
	while out.find("[") != -1:
		var start: int = out.find("[")
		var end: int = out.find("]", start)
		if end == -1:
			break
		out = out.substr(0, start) + out.substr(end + 1)
	return out


## 按内容估算最小高度: 弹窗前就给足高度, 避免 PopupPanel 只显示前半段

static func _estimate_min_height(display_text: String) -> float:
	var plain := _strip_bbcode(display_text)
	var newline_count: int = plain.count("\n")
	var units: int = plain.length() - newline_count
	var wrapped_lines: int = int(ceilf(float(units) / 28.0))
	return maxf(64.0, float(wrapped_lines + newline_count) * 24.0 + 16.0)


## 构建自定义悬浮提示面板(每次调用返回新实例, 引擎展示后自行释放)

static func build_tooltip(for_text: String) -> Control:
	if for_text.is_empty():
		return null
	var panel := PanelContainer.new()
	# 优先复用项目全局主题的 TooltipPanel 样式(全局UI主题.tres 为深灰底),
	# 无样式时回退到自绘深灰底, 白字永远有对比度
	var style: StyleBox = null
	var project_theme := ThemeDB.get_project_theme()
	if project_theme != null and project_theme.has_stylebox("panel", "TooltipPanel"):
		style = project_theme.get_stylebox("panel", "TooltipPanel")
	if style == null:
		var sb := StyleBoxFlat.new()
		sb.bg_color = Color(0.07, 0.07, 0.07, 0.97)
		sb.set_corner_radius_all(4)
		sb.content_margin_left = 12
		sb.content_margin_right = 12
		sb.content_margin_top = 8
		sb.content_margin_bottom = 8
		style = sb
	panel.add_theme_stylebox_override("panel", style)
	var rtl := RichTextLabel.new()
	rtl.bbcode_enabled = true
	rtl.fit_content = true
	rtl.scroll_active = false
	rtl.clip_contents = false
	rtl.autowrap_mode = TextServer.AUTOWRAP_WORD_SMART
	rtl.custom_maximum_size = Vector2(560, -1)
	rtl.add_theme_font_size_override("normal_font_size", 18)
	rtl.add_theme_color_override("default_color", Color(1, 1, 1))
	panel.add_child(rtl)
	var display := unity_to_bbcode_亮(for_text)
	var min_height := _estimate_min_height(display)
	panel.custom_minimum_size = Vector2(280, min_height)
	rtl.custom_minimum_size = Vector2(280, min_height)
	rtl.text = display
	return panel
