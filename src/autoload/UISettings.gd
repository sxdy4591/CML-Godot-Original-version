extends Node
## UISettings(Autoload) — 设置层持久化与全局应用工具。
## 自定义设置读写统一经 playerprefs.ini 的 [ui] 分区(与 C# 桥同文件不同分区):
##   debug_console / paragraph_spacing / paragraph_indent / event_align(0左1中2右)
##   event_pause_after(事件结束自动暂停, 默认 true; false=按事件前速度继续)
##   event_title_size / event_desc_size / event_option_size / event_result_size
##   ui_scale(60..200, 字体倍率) / war_icon_scale(50..250, 战争图标大小)
##   key_action_N(快捷键, 动作表见 C# ShortcutPane) / stretch_scheme(缩放适配方案)
##   map_highlight_tint / map_ocean(地图通用配色, Color)
##   map_palette_<模式>_<键>(地图阵营显示色, 见 地图配色类别, Color)
## 字体倍率自动应用: 场景根节点进入树时递归覆盖字体大小(原始值记忆在 meta, 幂等)。

var _cfg: ConfigFile

func _ready() -> void:
	_cfg = ConfigFile.new()
	_cfg.load("user://playerprefs.ini")
	# 手机版默认 UI 倍率 145%: 手机屏比 1920 逻辑画布小得多, 100% 的字在手上偏小。
	# **只写一次**(配置里还没有 ui_scale 时), 之后完全以玩家在设置页里的选择为准。
	if OS.has_feature("mobile") and not _cfg.has_section_key("ui", "ui_scale"):
		set_int("ui_scale", 145)
	_apply_original_cursor()
	apply_stretch()
	get_tree().node_added.connect(_on_node_added)

# 原版指针: assets/ui/common/光标_原版.png(50x50 五星红旗箭头).
# 原版游戏全局只有一个鼠标样式, 这里把 Godot 的每种 CursorShape 都指到同一张图,
# 避免悬停按钮时闪回系统手形/文本光标. 热点取箭头尖(左上角).
func _apply_original_cursor() -> void:
	var tex := load("res://assets/ui/common/光标_原版.png") as Texture2D
	var hotspot := Vector2(2, 2)
	for shape in 17:
		Input.set_custom_mouse_cursor(tex, shape, hotspot)

# ---------- 缩放适配方案 ----------
## display/window/stretch/mode 只是启动初始值, 运行时真正生效的是 root 窗口的
## content_scale_mode / content_scale_aspect —— 两者都是普通属性, 改了下一帧就按新规则重排,
## 不需要重启也不需要重建场景. 这里把常用方案列成表, 设置页只改 scheme 编号.
const 适配方案名 := ["拉伸铺满", "保持比例", "保持宽度", "保持高度", "扩展视野", "像素视口"]

func apply_stretch() -> void:
	var root := get_tree().root
	root.content_scale_size = Vector2i(1920, 1080)
	match get_int("stretch_scheme", 0):
		1:
			root.content_scale_mode = Window.CONTENT_SCALE_MODE_CANVAS_ITEMS
			root.content_scale_aspect = Window.CONTENT_SCALE_ASPECT_KEEP
		2:
			root.content_scale_mode = Window.CONTENT_SCALE_MODE_CANVAS_ITEMS
			root.content_scale_aspect = Window.CONTENT_SCALE_ASPECT_KEEP_WIDTH
		3:
			root.content_scale_mode = Window.CONTENT_SCALE_MODE_CANVAS_ITEMS
			root.content_scale_aspect = Window.CONTENT_SCALE_ASPECT_KEEP_HEIGHT
		4:
			root.content_scale_mode = Window.CONTENT_SCALE_MODE_CANVAS_ITEMS
			root.content_scale_aspect = Window.CONTENT_SCALE_ASPECT_EXPAND
		5:
			root.content_scale_mode = Window.CONTENT_SCALE_MODE_VIEWPORT
			root.content_scale_aspect = Window.CONTENT_SCALE_ASPECT_KEEP
		_:
			root.content_scale_mode = Window.CONTENT_SCALE_MODE_CANVAS_ITEMS
			root.content_scale_aspect = Window.CONTENT_SCALE_ASPECT_IGNORE

# ---------- 地图配色 ----------
## 玩家自定义的颜色. Godot 的 Color 直接存成 Color 类型, ColorPicker 选什么就是什么,
## 不做预设匹配. 视图形参: 地图着色器的 tint / 高亮 modulate / 海洋 ColorRect.
func get_color(key: String, def: Color) -> Color:
	_cfg.load("user://playerprefs.ini")
	return Color(_cfg.get_value("ui", key, def))

func set_color(key: String, v: Color) -> void:
	_cfg.load("user://playerprefs.ini")
	_cfg.set_value("ui", key, v)
	_cfg.save("user://playerprefs.ini")

# ---------- 持久化 ----------

func get_int(key: String, def: int) -> int:
	_cfg.load("user://playerprefs.ini")
	return int(_cfg.get_value("ui", key, def))

func set_int(key: String, v: int) -> void:
	# 同一文件还有 C# 侧的 [prefs] 分区在写(难度/存档位/原版快捷键), 写前必须重读,
	# 否则本份内存快照会把那边的更新整份覆盖掉。
	_cfg.load("user://playerprefs.ini")
	_cfg.set_value("ui", key, v)
	_cfg.save("user://playerprefs.ini")

# 擦掉一条设置: 快捷键恢复默认要回到"从没设置过"(缺省走逻辑层默认键), 写 0 不等价
# 键不存在时 ConfigFile.erase_section_key 会刷一条警告(恢复默认会连擦 16 个默认键), 先看有没有
func erase(key: String) -> void:
	_cfg.load("user://playerprefs.ini")
	if not _cfg.has_section_key("ui", key):
		return
	_cfg.erase_section_key("ui", key)
	_cfg.save("user://playerprefs.ini")

func get_bool(key: String, def: bool = false) -> bool:
	_cfg.load("user://playerprefs.ini")
	return bool(_cfg.get_value("ui", key, def))

func set_bool(key: String, v: bool) -> void:
	_cfg.load("user://playerprefs.ini")
	_cfg.set_value("ui", key, v)
	_cfg.save("user://playerprefs.ini")

func get_string(key: String, def: String = "") -> String:
	_cfg.load("user://playerprefs.ini")
	return str(_cfg.get_value("ui", key, def))

func set_string(key: String, v: String) -> void:
	_cfg.load("user://playerprefs.ini")
	_cfg.set_value("ui", key, v)
	_cfg.save("user://playerprefs.ini")

func get_scale() -> float:
	return float(get_int("ui_scale", 100)) / 100.0

# ---------- 字体倍率自动应用 ----------

func _on_node_added(node: Node) -> void:
	# [移植修复] 旧实现只处理"直接挂在 root 下的场景根", 运行时**新建**的控件
	# (战争界面每次操作后重建的条目、动态列表、弹窗)永远拿不到倍率 → 玩久了
	# 字体倍率像"失效"了。现在任何进入树的 Control 都按节点自身覆盖一次;
	# 子节点会各自收到 node_added, 递归入口的重复应用由 ui_orig_size 幂等挡住。
	if not (node is Control):
		return
	if node.has_meta("_ui_scale_applied"):
		return
	node.set_meta("_ui_scale_applied", true)
	# 还没挂到树上的节点(构造中)等下一帧; 已挂上的场景根走递归, 单节点只覆盖自身。
	if node.get_parent() == get_tree().root:
		apply_font_scale.call_deferred(node, get_scale())
	else:
		_apply_one.call_deferred(node, get_scale())


func _apply_one(node: Control, scale: float) -> void:
	if not is_instance_valid(node):
		return
	if scale <= 0.0:
		return
	if node is Label or node is Button or node is RichTextLabel:
		var sz := _current_size(node)
		if sz > 0:
			if not node.has_meta("ui_orig_size"):
				node.set_meta("ui_orig_size", sz)
			var base: int = int(node.get_meta("ui_orig_size"))
			_set_font_size(node, maxi(6, int(round(base * scale))))

## 递归覆盖 Label/Button/RichTextLabel 的 font_size(原始值记 meta 防叠加)
func apply_font_scale(root: Node, scale: float) -> void:
	if scale <= 0.0:
		return
	_apply_recursive(root, scale)

func _apply_recursive(node: Node, scale: float) -> void:
	if node is Label or node is Button or node is RichTextLabel:
		var sz := _current_size(node)
		if sz > 0:
			if not node.has_meta("ui_orig_size"):
				node.set_meta("ui_orig_size", sz)
			var base: int = int(node.get_meta("ui_orig_size"))
			_set_font_size(node, maxi(6, int(round(base * scale))))
	for child in node.get_children():
		_apply_recursive(child, scale)

func _current_size(node: Node) -> int:
	if node is RichTextLabel:
		return int(node.get_theme_font_size("normal_font_size"))
	return int(node.get_theme_font_size("font_size"))

func _set_font_size(node: Node, v: int) -> void:
	if node is RichTextLabel:
		node.add_theme_font_size_override("normal_font_size", v)
	else:
		node.add_theme_font_size_override("font_size", v)


# ---------- 地图阵营配色 ----------
## 四种地图模式的配色类别, 逐条来自原版 CountryScript.Repaint 的 map_type 分支:
## [模式, 键, 名称, 原版主色, 原版副色]. 玩家只挑一个"显示色", 双色由 解算双色() 反推.

const 地图配色类别 := [
	# 政府类型模式: 名称就是原版"国家体制"文本(other_text[Gosstroy])
	[1, "gos0", "威权主义", Color(0, 0, 0), Color(0, 0, 0)],
	[1, "gos1", "社会主义", Color(0, 0, 0), Color(0, 1, 1)],
	[1, "gos2", "改良主义", Color(0, 0, 0.72), Color(1, 0, 1)],
	[1, "gos3", "自由主义", Color(0, 0, 0.46), Color(1, 0.48, 0)],
	# 经济模式: 组织名取自原版 other_text[6..10]、[55]、[196]、[293]、[324]
	[2, "other", "无", Color(0, 0, 0), Color(0, 0, 0)],
	[2, "yugo", "地拉那-贝尔格莱德-布加勒斯特轴心", Color(0.5, 0.25, 0.5), Color(0, 0, 0.5)],
	[2, "eu_torg", "欧洲经济共同体 + 贸易伙伴", Color(0, 0, 0), Color(1, 0.1, 0)],
	[2, "asean_torg", "东南亚国家联盟 + 贸易伙伴", Color(0, 0.22, 0.6431), Color(0.16862, 0.101, 0)],
	[2, "eu", "欧洲经济共同体", Color(0, 0, 0.46), Color(1, 0.48, 0)],
	[2, "soceu_torg", "社会主义联盟 + 贸易伙伴", Color(1, 0.1367925, 0.1367925), Color(0, 0, 0.5)],
	[2, "soceu", "社会主义联盟", Color(1, 0.1367925, 0.1367925), Color(0, 0, 0)],
	[2, "oil", "海湾合作委员会", Color(0.17, 0.69, 1), Color(0.22, 0.81, 0)],
	[2, "asean", "东南亚国家联盟", Color(0, 0, 0.46), Color(0.4, 0, 0)],
	[2, "sev_torg", "经济互助委员会 + 贸易伙伴", Color(0, 0, 0), Color(0, 1, 0.1)],
	[2, "sev", "经济互助委员会", Color(0, 0, 0), Color(0, 1, 1)],
	[2, "econ", "经济合作组织", Color(1, 0.5490196, 0), Color(0, 0, 0.5)],
	[2, "torg", "贸易伙伴", Color(0, 0, 0.72), Color(1, 0, 1)],
	# 军事模式: 条约组织名取自原版 other_text[5]、[6]、[7]、[56]、[255]、[256]
	[0, "other", "无", Color(0, 0, 0), Color(0, 0, 0)],
	[0, "nato", "北大西洋公约", Color(0, 0, 0.46), Color(1, 0.48, 0)],
	[0, "seato", "东南亚条约组织 / 中央条约组织", Color(0, 0, 0.46), Color(0.4, 0, 0)],
	[0, "ovd", "华沙条约", Color(0, 0, 0), Color(0, 1, 1)],
	[0, "oar", "阿拉伯联合共和国", Color(0.1717331, 0.4433962, 0), Color(0.8396226, 0.8396226, 0.8396226)],
	[0, "okb", "集体安全条约", Color(1, 0.5490196, 0), Color(0, 0, 0.5)],
	[0, "okb_event", "集体安全条约（非洲的新生）", Color(0, 0, 0), Color(0, 0, 0.5)],
	# 影响模式: 文本取自原版 other_text[11..13]、[155]
	[3, "other", "中立", Color(0, 0, 0), Color(0, 0, 0)],
	[3, "puppet_fr", "法国的傀儡国", Color(0, 0, 0), Color(1, 0.1, 0)],
	[3, "puppet_za", "南非的傀儡国", Color(0, 0, 0), Color(0.25, 0.25, 0.25)],
	[3, "puppet_it", "意大利的傀儡国", Color(0, 0, 0), Color(0.255, 0.55, 1)],
	[3, "us", "在美国影响下", Color(0, 0, 0.46), Color(1, 0.48, 0)],
	[3, "sov", "在苏联影响下", Color(0, 0, 0), Color(0, 1, 1)],
	[3, "prc", "在我国影响下", Color(1, 0.5490196, 0), Color(0, 0, 0.5)],
]

## 原版 shader: t = pow(纹理灰度, 1/2.2), c = clamp((t*(1+main-minus)-0.09)*1.25).
## 中灰纹理(0.5)对应的 t, 用来把"一个显示色"和原版双色互相换算.
const 中灰 := 0.7297401


## 原版双色实际呈现的显示色(中灰处)
func 原版显示色(主色: Color, 副色: Color) -> Color:
	var d := 主色 - 副色
	return Color(
		clampf((中灰 * (1.0 + d.r) - 0.09) * 1.25, 0.0, 1.0),
		clampf((中灰 * (1.0 + d.g) - 0.09) * 1.25, 0.0, 1.0),
		clampf((中灰 * (1.0 + d.b) - 0.09) * 1.25, 0.0, 1.0))


## 反解: 原版公式只用 (main-minus), 所以把差值按正负分给两侧, 两个结果都非负.
func 解算双色(显示色: Color) -> Array:
	var d := Color(
		(显示色.r / 1.25 + 0.09) / 中灰 - 1.0,
		(显示色.g / 1.25 + 0.09) / 中灰 - 1.0,
		(显示色.b / 1.25 + 0.09) / 中灰 - 1.0)
	return [
		Color(maxf(d.r, 0.0), maxf(d.g, 0.0), maxf(d.b, 0.0)),
		Color(maxf(-d.r, 0.0), maxf(-d.g, 0.0), maxf(-d.b, 0.0)),
	]
