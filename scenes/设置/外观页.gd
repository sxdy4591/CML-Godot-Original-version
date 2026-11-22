extends Control
## 外观页 — 缩放适配 + 通用配色 + 四种地图模式的阵营配色.
## 纯 GDScript(系统界面例外): 这些设置不碰原版 GameState, 只落 playerprefs [ui].
##
## 地图配色: 玩家只挑一个"显示色", 原版 CountryScript 的双色参数由 UISettings.解算双色 反推,
## 默认值就是原版现在看起来的颜色. 判定与绘制仍在 original, 这里只存玩家挑的颜色.
## 四种模式(意识形态/经济/军事/影响)的类别各自独立, 一份 playerprefs[ui] map_palette_<模式>_<键>.

const 配色行 := preload("res://scenes/设置/配色行.tscn")

## 模式号对应原版 GlobalScript.map_type: 0 军事 / 1 意识形态(政府类型) / 2 经济 / 3 影响
const 模式分组 := [
	{"模式": 1, "容器": "意识形态配色"},
	{"模式": 2, "容器": "经济配色"},
	{"模式": 0, "容器": "军事配色"},
	{"模式": 3, "容器": "影响配色"},
]

var ui: Node
var _行: Array = []

@onready var 列表: VBoxContainer = $滚动/列表


func _ready() -> void:
	ui = get_node("/root/UISettings")
	绑定循环("Stretch", "stretch_scheme", 0, ui.适配方案名.size() - 1)
	find_child("重置外观", true, false).pressed.connect(_恢复默认)
	绑定配色("MapTint", "map_highlight_tint", Color(1, 1, 1, 1))
	绑定配色("Ocean", "map_ocean", Color(0.3783699, 0.75245696, 0.99999887, 1))
	_构建配色行()
	刷新()


# ---------- 循环行 ----------

func 绑定循环(prefix: String, key: String, lo: int, hi: int) -> void:
	find_child(prefix + "Prev", true, false).pressed.connect(_步进.bind(key, lo, hi, -1))
	find_child(prefix + "Next", true, false).pressed.connect(_步进.bind(key, lo, hi, +1))


func _步进(key: String, lo: int, hi: int, dir: int) -> void:
	var v: int = ui.get_int(key, lo) + dir
	if v > hi:
		v = lo
	if v < lo:
		v = hi
	ui.set_int(key, v)
	应用(key)
	刷新()


func 应用(key: String) -> void:
	if key == "stretch_scheme":
		ui.apply_stretch()


func 刷新() -> void:
	(列表.get_node("StretchRow/StretchValue") as Label).text = str(ui.适配方案名[ui.get_int("stretch_scheme", 0)])


# ---------- 通用配色 ----------

func 绑定配色(prefix: String, key: String, def: Color) -> void:
	var picker := find_child(prefix + "Picker", true, false) as ColorPickerButton
	picker.color = ui.get_color(key, def)
	picker.color_changed.connect(_配色改变.bind(key))


func _配色改变(c: Color, key: String) -> void:
	ui.set_color(key, c)


func 绑定刷新配色() -> void:
	for pair in [["MapTint", "map_highlight_tint"], ["Ocean", "map_ocean"]]:
		var picker := find_child(str(pair[0]) + "Picker", true, false) as ColorPickerButton
		picker.color = ui.get_color(str(pair[1]), picker.color)


# ---------- 地图阵营配色 ----------

func _构建配色行() -> void:
	var cfg := ConfigFile.new()
	cfg.load("user://playerprefs.ini")
	for 组 in 模式分组:
		var 容器 := 列表.get_node(str(组["容器"])) as VBoxContainer
		for 类 in ui.地图配色类别:
			if int(类[0]) != int(组["模式"]):
				continue
			var 键 := "map_palette_%d_%s" % [int(类[0]), str(类[1])]
			var 默认: Color = ui.原版显示色(类[3], 类[4])
			var 行 := 配色行.instantiate()
			容器.add_child(行)
			(行.get_node("标题") as Label).text = str(类[2])
			var 色 := 行.get_node("颜色") as ColorPickerButton
			色.color = Color(cfg.get_value("ui", 键, 默认))
			色.color_changed.connect(_地图配色改变.bind(键))
			_行.append({"键": 键, "色": 色, "默认": 默认})


func _地图配色改变(c: Color, 键: String) -> void:
	ui.set_color(键, c)


# ---------- 恢复默认 ----------

func _恢复默认() -> void:
	ui.set_int("stretch_scheme", 0)
	ui.apply_stretch()
	ui.set_color("map_highlight_tint", Color(1, 1, 1, 1))
	ui.set_color("map_ocean", Color(0.3783699, 0.75245696, 0.99999887, 1))
	for 项 in _行:
		ui.set_color(str(项["键"]), 项["默认"])
		(项["色"] as ColorPickerButton).color = 项["默认"]
	绑定刷新配色()
	刷新()
