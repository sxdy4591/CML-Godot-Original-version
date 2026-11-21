extends Control
## 设置界面 — 基础页(难度/自动存档/槽位/窗口/快捷键/音乐/音量) + 自定义页(全量)。
## 自定义页: 调试控制台开关 / 事件段落间距 / 段首空两格 / 事件对齐 /
## 事件四字号 / 全局UI字体倍率 / 地图边界粗细 / 战争图标大小 / 音量 /
## 作弊快捷键(13 条)。地图配色行在新版省份地图下无实现, 已隐藏(见 _bind_custom_page)。
## 持久化: 难度/存档/快捷键键码走 C# 桥(原版语义, key_action_*), 自定义项走
## UISettings(playerprefs.ini [ui])。 音乐/音量全部走自研 AudioSys 层。
## 音量面板(减小/增大/滑条/歌曲名)由 音频信息.gd 独立处理, 本脚本不介入。

const 主菜单场景 := "res://scenes/主菜单/主菜单.tscn"
const 专辑名字体 := preload("res://assets/ui/theme/font.ttf")

const ROW_NAMES := ["难度行", "自动保存行", "保存槽位行", "窗口模式行"]
const SHORTCUT_ROWS := [
	["走时间快捷键行", 0], ["速度1快捷键行", 1], ["速度2快捷键行", 2],
	["速度3快捷键行", 3], ["速度4快捷键行", 4],
]
const 窗口模式名 := ["窗 口 化", "全 屏"]
const 事件对齐名 := ["左对齐", "居中", "右对齐"]

## 自定义页行: [前缀, 键, 范围[lo,hi], 步长, 默认]
const CUSTOM_STEP_ROWS := [
	["EventTitle", "event_title_size", 12, 96, 1, 55],
	["EventDesc", "event_desc_size", 12, 72, 1, 29],
	["EventOption", "event_option_size", 12, 72, 1, 28],
	["EventResult", "event_result_size", 12, 72, 1, 29],
	["UiScale", "ui_scale", 60, 200, 5, 100],
	# 战争图标大小倍率(%), 地图.gd 每帧读 UISettings.war_icon_scale
	["WarIcon", "war_icon_scale", 50, 250, 10, 100],
	# 音乐/音效音量: 值存在 AudioSys(audio/music_volume、audio/sfx_volume), 不走 UISettings
	["MusicVolume", "music_volume", 0, 100, 5, 5],
	["SfxVolume", "sfx_volume", 0, 100, 5, 5],
]
## 音量行的取值/落盘在 AudioSys, 其余行在 UISettings
const 音量行 := ["music_volume", "sfx_volume"]
## 作弊行: [行前缀, 作弊动作 id]
const CHEAT_ROWS := [
	["CheatParty", 0], ["CheatPeople", 1], ["CheatThought", 2], ["CheatLiving", 3],
	["CheatDiplo", 4], ["CheatInfluence", 5], ["CheatBudget", 6], ["CheatAgents", 7],
	["CheatArmy", 8], ["CheatRelations", 9], ["CheatUssr", 10], ["CheatDiploDown", 11],
	["CheatMil", 12],
]
const 难度名 := ["牛棚小酌", "上山下乡", "斗私批修", "造反有理", "浩荡文革"]
const 自动存档名 := ["关闭", "每月", "半年"]
const 槽位名 := ["1 无成就壹档", "2", "3", "4", "5 成就激活档位"]

var _difficulty: int = 2
var _autosave: int = 0
var _saveplace: int = 1
var _window_mode: int = 1
var _rebinding: int = -1    # 正在重绑的键 id(0..4 时间/速度; 10..12 存/读/战争; 100..112 作弊)
var _page: int = 0
var _last_scene: String = "res://scenes/主菜单/主菜单.tscn"   # 返回目标(外交 ESC 进入时由 ESC菜单.gd 设定)
var ui: Node   # UISettings autoload
## 自定义页数值行的格式化器/默认值: 切页时用它把标签刷成最新值
var _cycle_fmts: Dictionary = {}
var _cycle_defs: Dictionary = {}

func _ready() -> void:
	ui = get_node("/root/UISettings")
	var gm := get_node("/root/全局管理")
	if gm:
		_last_scene = str(gm.settings_return_scene)
	_difficulty = ui.get_int("difficulty", 2)
	_autosave = ui.get_int("autosave", 1)
	_saveplace = ui.get_int("saveplace", 1)
	_window_mode = 1 if DisplayServer.window_get_mode() == DisplayServer.WINDOW_MODE_EXCLUSIVE_FULLSCREEN else 0
	_bind_rows()
	_bind_shortcuts()
	_bind_custom_page()
	_bind_music()
	var back := find_child("返回", true, false) as BaseButton
	if back and not back.pressed.is_connected(_on_返回_pressed):
		back.pressed.connect(_on_返回_pressed)
	var reset := find_child("恢复默认", true, false) as BaseButton
	if reset and not reset.pressed.is_connected(_on_恢复默认_pressed):
		reset.pressed.connect(_on_恢复默认_pressed)
	var page_btn := find_child("基础页按钮", true, false) as BaseButton
	var page_btn2 := find_child("自定义页按钮", true, false) as BaseButton
	if page_btn:
		page_btn.pressed.connect(_switch_page.bind(0))
	if page_btn2:
		page_btn2.pressed.connect(_switch_page.bind(1))
	_switch_page(0)
	_refresh_rows()

# ---------- 基础行 ----------

func _bind_rows() -> void:
	for idx in ROW_NAMES.size():
		var node := find_child(ROW_NAMES[idx], true, false) as Control
		var left := node.get_node("左") as BaseButton
		var right := node.get_node("右") as BaseButton
		if left:
			left.pressed.connect(_on_row.bind(idx, -1))
		if right:
			right.pressed.connect(_on_row.bind(idx, +1))
		# 自动存档两行的说明(触屏长按/桌面悬停都能看到 —— 见 Autoload 触屏提示)
		# 行容器在场景里是 mouse_filter=IGNORE, 必须改 PASS 才能被长按命中
		if idx == 1:
			node.mouse_filter = Control.MOUSE_FILTER_PASS
			node.tooltip_text = "自动存档：每到该周期的 1 号，把当前局面自动写入下方「自动存档位」选定的槽位。\n" \
				+ "每月 = 每个月的 1 号；半年 = 6 月 1 号与 12 月 1 号。\n" \
				+ "保存完成会在右上角弹出「自动存档完成」提示。"
		elif idx == 2:
			node.mouse_filter = Control.MOUSE_FILTER_PASS
			node.tooltip_text = "自动存档位：自动存档与 F5 快捷保存都写入这个槽位（1 无成就壹档 … 5 成就激活档位）。\n" \
				+ "默认是无成就壹档；自动存档会覆盖该槽，建议专门留一个槽给它。\n" \
				+ "也可以直接到「保存/读档」界面点每个槽右侧的「自动」按钮来选；\n" \
				+ "再点一次当前带 ✓ 的那个槽 = 取消自动存档。"

func _on_row(row: int, dir: int) -> void:
	match row:
		0: _difficulty = _wrap(_difficulty + dir, 0, 4); ui.set_int("difficulty", _difficulty)
		1: _autosave = _wrap(_autosave + dir, 0, 2); ui.set_int("autosave", _autosave)
		2: _saveplace = _wrap(_saveplace + dir, 1, 5); ui.set_int("saveplace", _saveplace)
		3: _window_mode = _wrap(_window_mode + dir, 0, 1); _apply_window()
	_refresh_rows()

func _apply_window() -> void:
	match _window_mode:
		1:
			DisplayServer.window_set_mode(DisplayServer.WINDOW_MODE_EXCLUSIVE_FULLSCREEN)
		_:
			DisplayServer.window_set_mode(DisplayServer.WINDOW_MODE_WINDOWED)
			DisplayServer.window_set_size(Vector2i(1280, 720))

func _wrap(v: int, lo: int, hi: int) -> int:
	if v > hi: return lo
	if v < lo: return hi
	return v

# ---------- 快捷键(统一重绑) ----------

func _bind_shortcuts() -> void:
	for row in SHORTCUT_ROWS:
		var node := find_child(row[0], true, false) as Control
		var rebind := node.get_node("重绑") as BaseButton
		rebind.pressed.connect(_start_rebind.bind(row[1]))

func _start_rebind(action: int) -> void:
	_rebinding = action
	print("[重绑] 开始 action=", action)
	_update_rebind_label(action, "按下任意键…")

func _update_rebind_label(action: int, text: String) -> void:
	if action >= 100:
		for row in CHEAT_ROWS:
			if action == int(row[1]) + 100:
				_set_label(row[0] + "Value", text)
				return
		return
	for row in SHORTCUT_ROWS:
		if action == row[1]:
			_set_label(row[0] + "/值", text)
			return

func _set_label(node_path: String, text: String) -> void:
	var node := find_child(node_path, true, false) as Control
	if node is Label:
		(node as Label).text = text
	else:
		(node.get_node("值") as Label).text = text

func _input(event: InputEvent) -> void:
	if _rebinding < 0:
		return
	if event is InputEventKey and not event.echo:
		if event.keycode == KEY_ESCAPE or event.physical_keycode == KEY_ESCAPE:
			_rebinding = -1
			_refresh_rows()
			get_viewport().set_input_as_handled()
			return
		var key: int = event.physical_keycode if event.physical_keycode != 0 else event.keycode
		print("[重绑] 收到键 ", key, " -> action=", _rebinding)
		ui.set_int("key_action_%d" % _rebinding, key)
		_rebinding = -1
		_refresh_rows()
		_refresh_custom_rows()
		get_viewport().set_input_as_handled()

func _key_text(key: int) -> String:
	if key <= 0:
		return "—"
	return OS.get_keycode_string(key)

# ---------- 音乐(自研 AudioSys) ----------

## 专辑槽每页个数(设置.tscn 里 专辑 / 专辑2..专辑9 共 9 个槽)
const 专辑每页 := 9
## 曲目槽个数(左1..20 + 右1..20)
const 曲目槽上限 := 40
var _专辑页: int = 0

func _bind_music() -> void:
	var audio := get_node("/root/AudioSys")
	var loop_btn := find_child("循环播放", true, false) as BaseButton
	var shuffle_btn := find_child("随机播放", true, false) as BaseButton
	loop_btn.pressed.connect(_on_loop_pressed)
	shuffle_btn.pressed.connect(_on_shuffle_pressed)
	var 全专辑随机 := find_child("全专辑随机", true, false) as CheckButton
	全专辑随机.button_pressed = audio.全专辑随机
	全专辑随机.toggled.connect(func(on: bool) -> void: audio.设置全专辑随机(on))
	# 曲目槽: 只绑定一次, 点击时按"当前专辑的第 i 首"解析(切专辑后会重排)
	for i in 曲目槽上限:
		var slot := find_child("左%d" % (i + 1), true, false) if i < 20 else find_child("右%d" % (i - 19), true, false)
		var btn := slot.get_node("播放按钮") as BaseButton
		if not btn.pressed.is_connected(_on_track_slot_pressed):
			btn.pressed.connect(_on_track_slot_pressed.bind(i))
	# 专辑槽: 只绑定一次, 点击时按"当前页的第 i 个"解析
	# 专辑.tscn 只有按钮, 没有名字控件 —— 名字 Label 在槽根下生成(9 个槽同一套样式),
	# 挂在 120x120 封面下方(槽间距 152, 名字占 122..152), 不遮按钮.
	for i in 专辑每页:
		var aslot := find_child("专辑" if i == 0 else "专辑%d" % (i + 1), true, false) as Control
		var abtn := aslot.get_node("专辑按钮") as BaseButton
		if not abtn.pressed.is_connected(_on_album_slot_pressed):
			abtn.pressed.connect(_on_album_slot_pressed.bind(i))
		var 专辑名 := Label.new()
		专辑名.name = "专辑名"
		专辑名.position = Vector2(0, 122)
		专辑名.size = Vector2(120, 30)
		专辑名.horizontal_alignment = HORIZONTAL_ALIGNMENT_CENTER
		专辑名.autowrap_mode = TextServer.AUTOWRAP_WORD_SMART
		专辑名.mouse_filter = Control.MOUSE_FILTER_IGNORE
		专辑名.add_theme_font_override("font", 专辑名字体)
		专辑名.add_theme_color_override("font_color", Color.WHITE)
		专辑名.add_theme_font_size_override("font_size", 16)
		aslot.add_child(专辑名)
	var flip := find_child("专辑右翻页", true, false) as BaseButton
	if not flip.pressed.is_connected(_on_album_page_next):
		flip.pressed.connect(_on_album_page_next)
	# 专辑变更时刷新
	if not audio.专辑变更.is_connected(_on_专辑变更):
		audio.专辑变更.connect(_on_专辑变更)
	_refresh_track_slots()
	_refresh_album_slots()
	_跳到播放中专辑所在页()

## 进入设置时翻到"正在播放的专辑"所在页(照搬改版 设置.gd _初始化专辑页码)
func _跳到播放中专辑所在页() -> void:
	var audio := get_node("/root/AudioSys")
	var 当前 := int(audio.当前专辑索引_())
	if 当前 < 0:
		return
	_专辑页 = int(floor(float(当前) / float(专辑每页)))
	_refresh_album_slots()

func _on_专辑变更() -> void:
	_refresh_track_slots()
	_refresh_album_slots()

## 曲目槽: 显示"当前专辑"的前 40 首(外置专辑/玩家自加专辑曲目数不定)
func _refresh_track_slots() -> void:
	var audio := get_node("/root/AudioSys")
	var names: Array = audio.获取当前曲目名列表()
	for i in 曲目槽上限:
		var slot := find_child("左%d" % (i + 1), true, false) if i < 20 else find_child("右%d" % (i - 19), true, false)
		if i < names.size():
			slot.visible = true
			var lbl := slot.get_node("歌名") as Label
			lbl.text = str(names[i])
		else:
			slot.visible = false

## 专辑槽: 每页 9 张, 覆盖 内置 + 外置(专辑/ 目录) 的全部专辑;
## 专辑数超过一页时显示"专辑右翻页"(点击循环翻页)。
func _refresh_album_slots() -> void:
	var audio := get_node("/root/AudioSys")
	var album_names: Array = audio.获取专辑名列表()
	var 总数 := album_names.size()
	var 总页 := maxi(1, int(ceil(float(总数) / float(专辑每页))))
	_专辑页 = clampi(_专辑页, 0, 总页 - 1)
	var 当前: int = int(audio.当前专辑索引_())
	for i in 专辑每页:
		var slot := find_child("专辑" if i == 0 else "专辑%d" % (i + 1), true, false) as Control
		var 索引 := _专辑页 * 专辑每页 + i
		if 索引 < 总数:
			slot.visible = true
			var btn := slot.get_node("专辑按钮") as TextureButton
			var icon: Texture2D = audio.获取专辑封面(索引)
			print("[封面调试] 索引=", 索引, " icon=", icon, " 尺寸=", icon.get_size() if icon else Vector2.ZERO)
			if icon:
				btn.texture_normal = icon
			# 当前播放专辑高亮, 其余压暗(槽无独立高亮资源, 用 modulate 区分)
			按钮特效.set_base_modulate(slot, Color.WHITE if 索引 == 当前 else Color(0.62, 0.62, 0.62, 1.0))
			var lbl := slot.get_node("专辑名") as Label
			lbl.text = str(album_names[索引])
		else:
			slot.visible = false
	var flip := find_child("专辑右翻页", true, false) as BaseButton
	flip.visible = 总页 > 1

func _on_album_page_next() -> void:
	var audio := get_node("/root/AudioSys")
	var 总数: int = int(audio.专辑总数())
	var 总页 := maxi(1, int(ceil(float(总数) / float(专辑每页))))
	_专辑页 = (_专辑页 + 1) % 总页
	_refresh_album_slots()

func _on_loop_pressed() -> void:
	var audio := get_node("/root/AudioSys")
	audio.切换循环()
	_refresh_rows()

func _on_shuffle_pressed() -> void:
	var audio := get_node("/root/AudioSys")
	audio.切换随机()
	_refresh_rows()

func _on_track_slot_pressed(idx: int) -> void:
	_play_song(idx)

func _play_song(idx: int) -> void:
	var audio := get_node("/root/AudioSys")
	audio.播放曲目(idx)

func _on_album_slot_pressed(槽: int) -> void:
	_select_album(_专辑页 * 专辑每页 + 槽)

func _select_album(i: int) -> void:
	var audio := get_node("/root/AudioSys")
	audio.选择专辑(i)
	# 切专辑后曲目列表随之改变, 必须刷新(外置专辑曲目数各不相同)
	_refresh_track_slots()
	_refresh_album_slots()


# ---------- 自定义页(全量) ----------

func _bind_custom_page() -> void:
	# 地图配色: 省份地图重构后, 颜色全部来自原版美术调色板(lut_main/lut_minus),
	# 旧"柔和"预设只影响已废弃的地图调色板(无消费者)
	# —— 留着就是假开关。按"纯外观且无实现→隐藏"处理, 不改 .tscn 布局。
	var palette_row := find_child("MapPaletteRow", true, false) as Control
	palette_row.visible = false
	# 调试控制台已从 autoload 移除(纯 UI 重构), 其入口与开关一并去掉.
	_bind_checkbox("ParagraphSpacingToggle", "paragraph_spacing", false)
	_bind_checkbox("ParagraphIndentToggle", "paragraph_indent", false)
	# 地图: 可互动国家淡金色高亮(默认开)
	_bind_checkbox("InteractiveHighlightToggle", "interactive_highlight", true)
	_bind_auto_types()
	var console_toggle := find_child("DebugConsoleToggle", true, false) as CheckButton
	console_toggle.set_pressed_no_signal(ui.get_bool("debug_console", true))
	console_toggle.toggled.connect(func(on: bool) -> void: ui.set_bool("debug_console", on))
	var console_open := find_child("DebugConsoleOpen", true, false) as BaseButton
	console_open.pressed.connect(func() -> void: get_node("/root/调试控制台").visible = true)
	_bind_cycle("EventAlign", "event_align", 0, 2, 1, 0, func(v: int) -> String: return 事件对齐名[v])
	for row in CUSTOM_STEP_ROWS:
		var lo: int = int(row[2]); var hi: int = int(row[3])
		var step: int = int(row[4]); var def: int = int(row[5])
		if row[0] == "UiScale":
			_bind_cycle(row[0], row[1], lo, hi, step, def, func(v: int) -> String: return "%d%%" % v)
		elif row[0] == "WarIcon":
			_bind_cycle(row[0], row[1], lo, hi, step, def, func(v: int) -> String: return "%d%%" % v)
		elif row[0] == "MusicVolume" or row[0] == "SfxVolume":
			_bind_cycle(row[0], row[1], lo, hi, step, def, func(v: int) -> String: return str(v))
		else:
			_bind_cycle(row[0], row[1], lo, hi, step, def, func(v: int) -> String: return str(v))
	for row in CHEAT_ROWS:
		var rebind := find_child(row[0] + "Rebind", true, false) as BaseButton
		if rebind:
			rebind.pressed.connect(_start_rebind.bind(100 + int(row[1])))
	print("[设置] 作弊快捷键绑定 ", CHEAT_ROWS.size(), " 行")

func _bind_checkbox(node_name: String, key: String, def: bool) -> void:
	var cb := find_child(node_name, true, false) as CheckButton
	cb.set_pressed_no_signal(ui.get_bool(key, def))
	cb.toggled.connect(func(on: bool):
		ui.set_bool(key, on))

# ---------- 自动化类别 ----------
## 与逻辑层 Automation.Categories 一一对应; 勾选存成 playerprefs [ui] auto_types = "7,8,20"。
## 默认全关, 外交面板按钮旁的勾是同一份数据的另一种呈现。
const AUTO_TYPES := [
	[7, "恢复被破坏的沟通机构"],
	[8, "支持伊朗革命派系"],
	[20, "增援越南前线"],
	[21, "支持阿富汗势力"],
	[28, "支持印度东部游击"],
	[34, "邀请外国投资者"],
	[56, "支持毛派/伊拉克反对派"],
	[71, "增援印度前线"],
	[1009, "支持法共正统派"],
	[1024, "督促社会改革"],
	[1043, "支持拉美非洲左翼游击"],
	[1044, "支持拉美非洲右翼武装"],
	[1057, "干预乌干达内战"],
	[1061, "援助缅甸共产主义游击队"],
]

## 事件结束后自动暂停 — 由 设置.tscn 预置 EventPauseToggle 后在此绑定(代码不造控件).


func _bind_auto_types() -> void:
	var 已开 := {}
	for s in ui.get_string("auto_types", "").split(",", false):
		已开[int(s)] = true
	for row in AUTO_TYPES:
		var t: int = int(row[0])
		var cb := find_child("AutoT%dToggle" % t, true, false) as CheckButton
		cb.set_pressed_no_signal(已开.has(t))
		cb.toggled.connect(func(_on: bool): _推自动类型())
	var dcb := find_child("AutoDecisionToggle", true, false) as CheckButton
	dcb.set_pressed_no_signal(ui.get_bool("auto_decision", false))
	dcb.toggled.connect(func(on: bool): ui.set_bool("auto_decision", on))


## 把 14 个勾的当前状态拼回 "7,8,20" 落盘; 逻辑层在进外交场景时读这一行
func _推自动类型() -> void:
	var keys := PackedStringArray()
	for row in AUTO_TYPES:
		var t: int = int(row[0])
		var cb := find_child("AutoT%dToggle" % t, true, false) as CheckButton
		if cb.button_pressed:
			keys.append(str(t))
	ui.set_string("auto_types", ",".join(keys))


func _bind_cycle(prefix: String, key: String, lo: int, hi: int, step: int, def: int, fmt: Callable) -> void:
	var prev := find_child(prefix + "Prev", true, false) as BaseButton
	var next := find_child(prefix + "Next", true, false) as BaseButton
	if prev:
		prev.pressed.connect(func(): _cycle(key, lo, hi, step, def, fmt, -1))
	if next:
		next.pressed.connect(func(): _cycle(key, lo, hi, step, def, fmt, +1))
	# 记下格式化器/默认值: 切回本页时要用它们把数值标签刷成最新
	# (例如先在基础页的音频面板拖了音乐音量, 再翻到自定义页)
	_cycle_fmts[key] = fmt
	_cycle_defs[key] = def
	_refresh_cycle(key, lo, def, fmt)

func _cycle(key: String, lo: int, hi: int, step: int, def: int, fmt: Callable, dir: int) -> void:
	var cur := _cycle_get(key, def)
	var v := _wrap(cur + dir * step, lo, hi)
	_cycle_set(key, v)
	_refresh_cycle(key, lo, def, fmt)
	if key == "ui_scale":
		var root := get_tree().current_scene
		if root and ui:
			ui.apply_font_scale(root, ui.get_scale())

## 读一项循环设置: 音量在 AudioSys, 其余在 UISettings
func _cycle_get(key: String, def: int) -> int:
	if key in 音量行:
		var audio := get_node("/root/AudioSys")
		return int(audio.获取音乐音量() if key == "music_volume" else audio.获取音效音量())
	return ui.get_int(key, def)

## 写一项循环设置: 音量直接落到 AudioSys(它负责应用总线音量+持久化)
func _cycle_set(key: String, v: int) -> void:
	if key in 音量行:
		var audio := get_node("/root/AudioSys")
		if key == "music_volume":
			audio.设置音乐音量(v)
		else:
			audio.设置音效音量(v)
		return
	ui.set_int(key, v)

func _refresh_cycle(key: String, _lo: int, def: int, fmt: Callable) -> void:
	var v := _cycle_get(key, def)
	# 值标签: 前缀由调用方固定, 这里按 key 找
	var prefix := ""
	for row in CUSTOM_STEP_ROWS:
		if row[1] == key:
			prefix = row[0]
			break
	if prefix == "":
		if key == "event_align": prefix = "EventAlign"
	if prefix == "":
		return
	var value := find_child(prefix + "Value", true, false) as Label
	if value:
		value.text = fmt.call(v)


# ---------- 页面切换 ----------

## 0=基础/音乐, 1=自定义。隐藏/显示除常驻外的整组子节点(不改场景文件布局)。
func _switch_page(page: int) -> void:
	_page = page
	var keep := ["背景层", "页导航", "自定义页", "返回", "恢复默认"]
	for child in get_children():
		if child.name == "自定义页":
			child.visible = page == 1
			continue
		if child.name in keep:
			continue
		if child is Control:
			child.visible = page == 0
	# 切到自定义页时按当前真实值刷新所有数值行(音量在 AudioSys 里会被基础页的
	# 音频面板改动, 不刷新会显示成旧数字)
	if page == 1:
		_refresh_custom_rows()


func _refresh_custom_rows() -> void:
	for key in _cycle_fmts.keys():
		_refresh_cycle(str(key), 0, int(_cycle_defs.get(key, 0)), _cycle_fmts[key])
	for row in CHEAT_ROWS:
		_refresh_cheat_value(row)

# ---------- 显示 ----------

func _refresh_rows() -> void:
	_row_value("难度行", 难度名[_difficulty])
	_row_extra("难度行", "成就", "成就：%s" % ("开启" if _difficulty >= 2 else "关闭"))
	_row_value("自动保存行", 自动存档名[_autosave])
	_row_value("保存槽位行", 槽位名[_saveplace - 1])
	_row_value("窗口模式行", 窗口模式名[_window_mode])
	for row in SHORTCUT_ROWS:
		_row_value(row[0], _key_text(ui.get_int("key_action_%d" % row[1], 0)))
	var audio := get_node("/root/AudioSys")
	var loop_btn := find_child("循环播放", true, false) as TextureButton
	var shuffle_btn := find_child("随机播放", true, false) as TextureButton
	# 开关灯用 self_modulate: 与 Autoload「按钮特效」tween 的 modulate 各管各的
	if not loop_btn.disabled:
		loop_btn.self_modulate = Color(1, 1, 1, 1) if audio.循环 else Color(1, 1, 1, 0.35)
	if not shuffle_btn.disabled:
		shuffle_btn.self_modulate = Color(1, 1, 1, 1) if audio.随机 else Color(1, 1, 1, 0.35)

func _row_value(row_name: String, text: String) -> void:
	var node := find_child(row_name, true, false) as Control
	var lbl := node.get_node("值") as Label
	lbl.text = text

func _row_extra(row_name: String, child_name: String, text: String) -> void:
	var node := find_child(row_name, true, false) as Control
	var lbl := node.get_node(child_name) as Label
	lbl.text = text

func _refresh_cheat_value(row: Array) -> void:
	_set_label(row[0] + "Value", _key_text(ui.get_int("key_action_%d" % (100 + int(row[1])), 0)))

# ---------- 返回/默认 ----------

func _on_返回_pressed() -> void:
	get_tree().change_scene_to_file(_last_scene)

func _on_恢复默认_pressed() -> void:
	_difficulty = 2
	_autosave = 1          # 与 NewAwake 的默认值一致:每月自动存档
	_saveplace = 1         # 默认写"无成就壹档"(不用成就位)
	ui.set_int("difficulty", 2)
	ui.set_int("autosave", 1)
	ui.set_int("saveplace", 1)
	_window_mode = 1
	_apply_window()
	var audio := get_node("/root/AudioSys")
	audio.设置音乐音量(5)
	audio.设置音效音量(5)
	if audio.循环:
		audio.切换循环()
	if not audio.随机:
		audio.切换随机()
	ui.set_bool("debug_console", true)
	ui.set_bool("paragraph_spacing", false)
	ui.set_bool("paragraph_indent", false)
	ui.set_bool("interactive_highlight", true)
	ui.set_string("auto_types", "")
	ui.set_bool("auto_decision", false)
	ui.set_bool("event_pause_after", true)
	ui.set_int("event_align", 0)
	for row in CUSTOM_STEP_ROWS:
		if row[1] in 音量行:
			continue
		ui.set_int(row[1], int(row[5]))
	for i in range(5):
		ui.set_int("key_action_%d" % i, _default_key(i))
	for i in range(10, 13):
		ui.set_int("key_action_%d" % i, 0)
	for i in range(13):
		ui.set_int("key_action_%d" % (100 + i), 0)
	var root := get_tree().current_scene
	ui.apply_font_scale(root, ui.get_scale())
	_refresh_rows()

func _default_key(action: int) -> int:
	match action:
		0: return 32
		1: return 49
		2: return 50
		3: return 51
		4: return 52
	return 0
