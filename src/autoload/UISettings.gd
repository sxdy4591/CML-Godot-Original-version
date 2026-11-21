extends Node
## UISettings(Autoload) — 设置层持久化与全局应用工具。
## 自定义设置读写统一经 playerprefs.ini 的 [ui] 分区(与 C# 桥同文件不同分区):
##   debug_console / paragraph_spacing / paragraph_indent / event_align(0左1中2右)
##   event_pause_after(事件结束自动暂停, 默认 true; false=按事件前速度继续)
##   event_title_size / event_desc_size / event_option_size / event_result_size
##   ui_scale(60..200) / map_border(10..120 → 地图着色器 border_texels 1.0..12.0)
##   key_action_0..4(时间/1-4) key_action_10..12(存/读/战争) key_action_100..112(作弊13)
## 字体倍率自动应用: 场景根节点进入树时递归覆盖字体大小(原始值记忆在 meta, 幂等)。

var _cfg: ConfigFile

func _ready() -> void:
	_cfg = ConfigFile.new()
	_cfg.load("user://playerprefs.ini")
	# 手机版默认 UI 倍率 145%: 手机屏比 1920 逻辑画布小得多, 100% 的字在手上偏小。
	# **只写一次**(配置里还没有 ui_scale 时), 之后完全以玩家在设置页里的选择为准。
	if OS.has_feature("mobile") and not _cfg.has_section_key("ui", "ui_scale"):
		set_int("ui_scale", 145)
	get_tree().node_added.connect(_on_node_added)

# ---------- 持久化 ----------

func get_int(key: String, def: int) -> int:
	_cfg.load("user://playerprefs.ini")
	return int(_cfg.get_value("ui", key, def))

func set_int(key: String, v: int) -> void:
	_cfg.set_value("ui", key, v)
	_cfg.save("user://playerprefs.ini")

func get_bool(key: String, def: bool = false) -> bool:
	_cfg.load("user://playerprefs.ini")
	return bool(_cfg.get_value("ui", key, def))

func set_bool(key: String, v: bool) -> void:
	_cfg.set_value("ui", key, v)
	_cfg.save("user://playerprefs.ini")

func get_string(key: String, def: String = "") -> String:
	_cfg.load("user://playerprefs.ini")
	return str(_cfg.get_value("ui", key, def))

func set_string(key: String, v: String) -> void:
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
