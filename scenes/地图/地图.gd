extends Node2D
## 世界地图 — 纯视图。
## 着色、领土块显隐、战争图标显隐全部由逻辑层 MapPane 给出（读原版 GameState）。
## 本脚本只做：节点收集、像素命中、控件赋值、选中变暗、点击转发。

signal country_selected(index: int)

const 面板 := "地图"

@onready var 国家层: Node2D = $国家层

var _sprites: Array[Dictionary] = []
var _colors: Array = []
var _index_map: Array = []
var _names: Array = []
var _parts := {}
var _wars := {}
var _selected_country: int = -1
var _hover_country: int = -1
var _hover_accum: float = 0.0
var _高亮: Dictionary = {}
# 玩家改过的阵营配色: 原版双色签名 → 解算后的 main/minus(每次快照按当前地图模式重建)
var _配色: Dictionary = {}
var _可互动开: bool = true
var _脉冲: float = 0.0
# 玩家自定义配色(设置·画面与配色): 可互动高亮乘色
var _高亮乘: Color = Color(1, 1, 1, 1)

# 像素命中用的缩放图: 按贴图路径缓存, 跨场景保留(进外交不再逐国 get_image+resize)
static var _图像缓存: Dictionary = {}


func _ready() -> void:
	_collect_sprites()
	_登记战争图标()
	_应用战争图标倍率()
	UiBridge.connect("panel_snapshot", _收到快照)
	# 可互动高亮: 逻辑层每帧推进 12 国扫描, 有变化才推 map_highlight;
	# 不能只靠 request("地图") —— 那份快照只在进场景/切地图模式时请求, 扫不全.
	UiBridge.connect("map_highlight", _收到高亮)
	UiBridge.act(面板, "激活", [true])
	UiBridge.request(面板)


func _exit_tree() -> void:
	# 离开地图就停扫, 不白烧 CPU
	if is_instance_valid(UiBridge):
		UiBridge.act(面板, "激活", [false])


# 自定义设置: 战争图标大小倍率(百分比, 100 = 原版尺寸)
func _应用战争图标倍率() -> void:
	var 倍率: float = get_node("/root/UISettings").get_int("war_icon_scale", 100) / 100.0
	for d in _sprites:
		if d["kind"] != "war":
			continue
		var sp: Sprite2D = d["node"]
		if not sp.has_meta("base_scale"):
			sp.set_meta("base_scale", sp.scale)
		sp.scale = sp.get_meta("base_scale") * 倍率


# 37 个战争图标的 (war_num, special) 交给逻辑层, 由原版 at_war_script.Repaint 判定显隐
func _登记战争图标() -> void:
	var 列表: Array = []
	for d in _sprites:
		if d["kind"] != "war":
			continue
		var sp: Sprite2D = d["node"]
		var 号 := int(sp.get_meta("war_num", -1))
		# 该节点(war_ogon (36))在 tscn 里是 special=true / war_num=-5; 原版
		# at_war_script 对 -5 是无条件显示, 开局就会亮, 与 1.132 场景不符.
		# 1.132 的 this_number 未知前先不登记(不会误显示).
		if 号 == -5:
			continue
		列表.append({
			"war": 号,
			"special": bool(sp.get_meta("special", false)),
			# 原版 AllWars 局部坐标反推用(见 MapPane.RegisterWarIcons)
			"x": sp.position.x,
			"y": sp.position.y,
		})
	UiBridge.act(面板, "登记战争图标", [列表])


func _collect_sprites() -> void:
	_sprites.clear()
	for node in 国家层.get_children():
		var sp := node as Sprite2D
		if sp == null:
			continue
		var kind := str(sp.get_meta("kind", "country"))
		# 战争图标有一部分是 part_XXX.0(metadata/tex="ogon"), 它们是图标不是领土块:
		# 显隐仍由 parts 标志控制, 但不参与国家着色
		var 是图标 := str(sp.get_meta("tex", "")) == "ogon"
		var tinted := kind != "war" and not 是图标
		var img: Image = null
		if kind != "war":
			var 键 := sp.texture.resource_path
			img = _图像缓存.get(键)
			if img == null:
				img = sp.texture.get_image()
				img.resize(192, 192, Image.INTERPOLATE_BILINEAR)
				_图像缓存[键] = img
		_sprites.append({
			"node": sp,
			"kind": kind,
			"ogon": 是图标,
			"tinted": tinted,
			"img": img,
			"z": float(sp.z_index),
		})
	_sprites.sort_custom(func(a, b): return a["z"] > b["z"])


# ================= 快照 =================

func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_colors = data["colors"]
	_index_map = data["index_map"]
	_names = data["names"]
	_归类分裂块()
	_parts.clear()
	for p in data["parts"]:
		_parts["%d:%d" % [p["country"], p["part"]]] = true
	_wars.clear()
	for w in data["wars"]:
		_wars["%d:%s" % [w["war"], w["special"]]] = Vector2(float(w["x"]), float(w["y"]))
	_高亮.clear()
	for h in data["highlight"]:
		_高亮[int(h)] = true
	var ui := get_node("/root/UISettings")
	_可互动开 = ui.get_bool("interactive_highlight", true)
	_高亮乘 = ui.get_color("map_highlight_tint", Color(1, 1, 1, 1))
	_配色 = _配色方案(int(data["mode"]))
	_应用颜色()
	_应用领土()
	_应用战争()
	_应用选中()


func _收到高亮(indices: Array) -> void:
	# 快照还没到时 _index_map 是空的, 此时无法按 disp 上色, 等快照那份再来
	if _index_map.is_empty():
		return
	_高亮.clear()
	for h in indices:
		_高亮[int(h)] = true
	_应用选中()


const 国家着色 := preload("res://scenes/地图/国家着色.gdshader")
# 选中/悬停同样只调亮度, 色相交给设置页的高亮乘色(否则蓝/灰国家一样会被染黄)
const 选中高亮 := Color(1.35, 1.35, 1.35, 1.0)
const 悬停高亮 := Color(1.18, 1.18, 1.18, 1.0)


func _应用颜色() -> void:
	for d in _sprites:
		if d["kind"] == "war":
			continue
		var sp: Sprite2D = d["node"]
		if not d["tinted"]:
			sp.modulate = Color.WHITE
			continue
		var idx := int(sp.get_meta("idx", sp.get_meta("country", -1)))
		var pair: Dictionary = _colors[idx]
		var 主: Color = pair["main"]
		var 副: Color = pair["minus"]
		var 解: Array = _配色.get(_签名(主, 副), [])
		if not 解.is_empty():
			主 = 解[0]
			副 = 解[1]
		var mat := 材质(sp)
		mat.set_shader_parameter("main_color", 主)
		mat.set_shader_parameter("minus_color", 副)
		sp.modulate = Color.WHITE


## 玩家挑的是"显示色", 原版双色参数由 UISettings.解算双色 反推; 一次读盘把本模式全部类别算完
func _配色方案(mode: int) -> Dictionary:
	var cfg := ConfigFile.new()
	cfg.load("user://playerprefs.ini")
	var ui := get_node("/root/UISettings")
	var 表 := {}
	for 类 in ui.地图配色类别:
		if int(类[0]) != mode:
			continue
		var 键 := "map_palette_%d_%s" % [mode, 类[1]]
		var 显: Color = Color(cfg.get_value("ui", 键, ui.原版显示色(类[3], 类[4])))
		表[_签名(类[3], 类[4])] = ui.解算双色(显)
	return 表


## 原版双色 → 查找键(量化到 0..255: 原版颜色都是确定的常量, 不会撞)
func _签名(主: Color, 副: Color) -> String:
	return "%d,%d,%d|%d,%d,%d" % [
		roundi(主.r * 255), roundi(主.g * 255), roundi(主.b * 255),
		roundi(副.r * 255), roundi(副.g * 255), roundi(副.b * 255),
	]


# 每国一个 ShaderMaterial: 原版双色公式 out = t + t*(main-minus) - 0.09
func 材质(sp: Sprite2D) -> ShaderMaterial:
	var mat := sp.material as ShaderMaterial
	if mat == null:
		mat = ShaderMaterial.new()
		mat.shader = 国家着色
		sp.material = mat
	return mat


func _应用领土() -> void:
	for d in _sprites:
		if d["kind"] != "part":
			continue
		var sp: Sprite2D = d["node"]
		sp.visible = _parts.has("%d:%d" % [
			int(sp.get_meta("country", -1)),
			int(sp.get_meta("part", -1)),
		])


# 分裂出来的小国在场景里只是母国的一个 part 块(part_053.0 = 南苏丹, part_053.1 = 达尔富尔...),
# 原版场景里这些块没有独立的国家号, 移植场景的 metadata 只有母国+块号.
# 这里按国家名表把块归到它自己的国家索引: 上色、点击都走 idx, 否则整块永远跟母国同色、
# 点下去也只打开母国(南苏丹/达尔富尔这类外交上存在的国家等于点不到).
func _归类分裂块() -> void:
	var 名表 := {}
	for i in _names.size():
		var n := str(_names[i]).replace(" ", "")
		if not n.is_empty():
			名表[n] = i
	for d in _sprites:
		if d["kind"] != "part":
			continue
		var sp: Sprite2D = d["node"]
		var tex := str(sp.get_meta("tex", "")).replace(" ", "")
		if tex.is_empty() or tex == "ogon":
			continue
		var 母国 := int(sp.get_meta("country", -1))
		# 场景里写死归属的块(南方民主共和国那块)不参与按名字重映射
		if sp.has_meta("idx_fixed"):
			continue
		var 目标 := -1
		if 名表.has(tex):
			目标 = int(名表[tex])
		else:
			# 独立后国名会带后缀(南苏丹 → 南苏丹社会主义共和国), 块名仍是旧短名;
			# 精确匹配失败时用"国名以块名开头"再对一次, 否则整块又并回母国.
			for n in 名表:
				if str(n).begins_with(tex):
					目标 = int(名表[n])
					break
		if 目标 >= 0 and 目标 != 母国:
			sp.set_meta("idx", 目标)
		elif sp.has_meta("idx"):
			sp.remove_meta("idx")


func _应用战争() -> void:
	for d in _sprites:
		if d["kind"] != "war":
			continue
		var sp: Sprite2D = d["node"]
		var key := "%d:%s" % [
			int(sp.get_meta("war_num", -1)),
			bool(sp.get_meta("special", false)),
		]
		sp.visible = _wars.has(key)
		# 原版 at_war_script.Repaint 会把图标搬到新地点; 用逻辑层算好的位置, 而不是 tscn 初始坐标
		if sp.visible:
			sp.position = _wars[key]


func _应用选中() -> void:
	var 强度 := 0.45 + 0.55 * (0.5 + 0.5 * sin(_脉冲 / 1.2 * TAU))
	# 可互动高亮的色相只由设置页「地图高亮乘色」决定, 这里只给中性亮度脉冲.
	# 旧实现把色相硬编码成金色(R>1, G>1, B<1): 乘到蓝/灰国家上蓝通道被压低,
	# 就变成"蓝国发绿、灰国闪金光"; 玩家把高亮设成白色也不会生效, 因为金色是乘法里写死的.
	var 可互动色 := Color(1.0 + 强度 * 0.6, 1.0 + 强度 * 0.6, 1.0 + 强度 * 0.6) * _高亮乘
	for d in _sprites:
		if d["kind"] == "war" or not d["tinted"]:
			continue
		var sp: Sprite2D = d["node"]
		var base := int(sp.get_meta("idx", sp.get_meta("country", -1)))
		var disp := int(_index_map[base])
		var 选中 := _selected_country >= 0 and disp == _selected_country
		var 悬停 := _hover_country >= 0 and disp == _hover_country
		# 高亮集合存的是"点开这国看到的面板"索引(disp): 别名块(18/111 等)要与目标国同亮
		var 可互动 := _可互动开 and _高亮.has(disp)
		sp.modulate = 选中高亮 * _高亮乘 if 选中 else (悬停高亮 * _高亮乘 if 悬停 else (可互动色 if 可互动 else Color.WHITE))


# 悬停高亮: 0.1s 采样一次鼠标所在国家(逐像素拾取较重, 不逐帧跑)
func _process(delta: float) -> void:
	_脉冲 += delta
	if not _高亮.is_empty():
		_应用选中()
	_hover_accum += delta
	if _hover_accum < 0.1:
		return
	_hover_accum = 0.0
	var hit := _pick(get_global_mouse_position())
	var disp := -1
	if hit >= 0:
		var sp: Sprite2D = _sprites[hit]["node"]
		var base := int(sp.get_meta("idx", sp.get_meta("country", -1)))
		if base >= 0 and base < _index_map.size():
			disp = int(_index_map[base])
	if disp == _hover_country:
		return
	_hover_country = disp
	_应用选中()


# ================= 输入与拾取 =================

const 点击阈值 := 12.0
var _按下屏幕: Vector2 = Vector2.ZERO
var _按下世界: Vector2 = Vector2.ZERO


func _unhandled_input(event: InputEvent) -> void:
	# 手机: 单指轻触=选国, 拖动交给地图摄像机(拖动时相机会消费触摸事件, 这里收不到抬起)
	if event is InputEventScreenTouch:
		if event.pressed:
			_按下屏幕 = event.position
			_按下世界 = get_canvas_transform().affine_inverse() * event.position
		elif event.position.distance_to(_按下屏幕) <= 点击阈值:
			_click(_按下世界)
		return
	if OS.has_feature("mobile"):
		return
	# 桌面: 左键按下/抬起位移小于阈值才算点击(拖动地图不会误选国家)
	if event is InputEventMouseButton and event.button_index == MOUSE_BUTTON_LEFT:
		if event.pressed:
			_按下屏幕 = event.position
			_按下世界 = get_global_mouse_position()
		elif event.position.distance_to(_按下屏幕) <= 点击阈值:
			_click(_按下世界)


func _click(world_pos: Vector2) -> void:
	var hit := _pick(world_pos)
	if hit < 0:
		clear_selection()
		return
	var sp: Sprite2D = _sprites[hit]["node"]
	var base := int(sp.get_meta("idx", sp.get_meta("country", -1)))
	var disp := int(_index_map[base])
	_selected_country = disp
	country_selected.emit(disp)
	_应用选中()


func _pick(world_pos: Vector2) -> int:
	for i in _sprites.size():
		# war 图标与 tex=ogon 的 part(以 parts 形式表现的战争图标)在原版里没有碰撞体, 不参与点选
		if _sprites[i]["kind"] == "war" or _sprites[i]["ogon"]:
			continue
		var sp: Sprite2D = _sprites[i]["node"]
		if not sp.visible:
			continue
		var tex_size := sp.texture.get_size()
		var p := sp.to_local(world_pos) + tex_size * 0.5
		if p.x < 0.0 or p.y < 0.0 or p.x >= tex_size.x or p.y >= tex_size.y:
			continue
		var img: Image = _sprites[i]["img"]
		if img == null or img.is_empty():
			return i
		var px := clampi(int(p.x / tex_size.x * img.get_width()), 0, img.get_width() - 1)
		var py := clampi(int(p.y / tex_size.y * img.get_height()), 0, img.get_height() - 1)
		if img.get_pixel(px, py).a >= 0.25:
			return i
	return -1


# ================= 对外控制接口 =================

func clear_selection() -> void:
	_selected_country = -1
	_应用选中()


func set_map_type(t: int) -> void:
	UiBridge.act(面板, "设置模式", [t])
	UiBridge.request(面板)


func refresh_all() -> void:
	UiBridge.request(面板)


func refresh_tints() -> void:
	UiBridge.request(面板)


func refresh_parts() -> void:
	UiBridge.request(面板)


func refresh_wars_from_bridge() -> void:
	UiBridge.request(面板)


func is_flat() -> bool:
	return true


func toggle_flat() -> void:
	pass
