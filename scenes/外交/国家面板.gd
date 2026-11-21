extends CanvasLayer
## 国家面板 — 纯视图。图标 sprite 键与按钮数据由 CountryPanelPane 调原版组件给好。
## 本脚本只做：sprite 键 → 本工程贴图、控件赋值、悬停条件显示、点击转发。

## 互动(发展贸易等)会改地图着色, 交给外交场景去重拉地图
signal 互动完成

const 面板 := "国家面板"

const 子意识形态 := {
	0: "sub_00", 1: "sub_01", 2: "sub_02", 3: "sub_03", 4: "sub_04", 5: "sub_05",
	6: "sub_06", 7: "sub_07", 8: "sub_08", 9: "sub_09", 10: "sub_22", 11: "sub_11",
	12: "sub_12", 13: "sub_13", 14: "sub_14", 15: "sub_15", 16: "sub_16",
	17: "sub_17", 18: "sub_18", 19: "sub_19",
}
const 军事 := {
	"znachki_2": "军事联盟_华沙条约", "znachki_6": "军事联盟_军事同盟",
	"znachki_13": "军事联盟_北约", "znachki_17": "军事联盟_东南亚条约",
	"znachki_18": "军事联盟_中央条约", "znachki_19": "军事联盟_东约中央条约合并",
	"znachki_22": "军事联盟_第四国际", "znachki_24": "军事联盟_非洲革命联盟",
	"znachki_25": "军事联盟_革命国际",
}
const 经济 := {
	"znachki_5": "经济联盟_经互会", "znachki_7": "经济联盟_双边经济",
	"znachki_14": "经济联盟_欧共体", "znachki_16": "经济联盟_东盟",
	"znachki_20": "经济联盟_石油联盟", "znachki_21": "经济联盟_社会主义欧盟",
}
const 影响 := {
	"znachki_0": "在某国影响下_美国", "znachki_10": "在某国影响下_苏联",
	"znachki_11": "在某国影响下_中国", "znachki_12": "在某国影响下_阿拉伯联合共和国",
	"znachki_15": "在某国影响下_法国", "znachki_26": "在某国影响下_澳大利亚",
	"znachki_27": "在某国影响下_南非", "znachki_28": "在某国影响下_台湾特供",
	"znachki_29": "在某国影响下_巴尔干联邦",
	"znachki_22": "军事联盟_第四国际",
	"znachki_25": "军事联盟_革命国际",
}
const 联盟 := {
	"znachki_12": "在某国影响下_阿拉伯联合共和国", "znachki_23": "军事联盟_阿革共",
	"znachki_26": "在某国影响下_澳大利亚", "znachki_27": "在某国影响下_南非",
	"znachki_28": "在某国影响下_台湾特供", "znachki_29": "在某国影响下_巴尔干联邦",
	"znachki_0": "在某国影响下_美国", "znachki_10": "在某国影响下_苏联",
}

const 按钮可用色 := Color.WHITE
const 按钮不可用色 := Color(0.35, 0.35, 0.35)

@onready var 名称: Label = $当前选中国家名称
@onready var 图标: Array[TextureRect] = [
	$政府类型, $军事联盟, $经济联盟, $贸易伙伴, $在某国影响下, $联盟, $傀儡
]
@onready var 按钮: Array[Button] = [$互动按钮, $互动按钮2, $互动按钮3, $互动按钮4]
@onready var 自动勾: Array[Button] = [$自动1, $自动2, $自动3, $自动4]
@onready var 条件: RichTextLabel = $执行当前互动按钮所需条件及检查

var _图标文案: Array = []
var _按钮条件: Array = []
var _按钮说明: Array = []
var _悬停: int = -1
var _默认条件: String = ""
var _刷新计时: float = 0.0
var _自动串: String = ""


func _ready() -> void:
	$关闭.pressed.connect(关闭)
	for i in 按钮.size():
		按钮[i].pressed.connect(_互动.bind(i))
		按钮[i].mouse_entered.connect(_悬停按钮.bind(i))
		按钮[i].mouse_exited.connect(_离开按钮)
		自动勾[i].toggled.connect(_切换自动.bind(i))
	UiBridge.connect("panel_snapshot", _收到快照)
	条件.visible = false


# 面板可见时自己按 0.2s 拉快照: 资源一变, 按钮立即变灰/禁用, 不用重开面板
func _process(delta: float) -> void:
	if not visible:
		return
	_刷新计时 += delta
	if _刷新计时 < 0.2:
		return
	_刷新计时 = 0.0
	UiBridge.request(面板)


func show_country(index: int) -> void:
	visible = true
	_清空槽位()
	UiBridge.act(面板, "查看", [index])
	UiBridge.request(面板)


# 切国家时先把 4 个槽清掉, 新数据到达前不显示上一个国家的按钮
func _清空槽位() -> void:
	for i in 按钮.size():
		按钮[i].text = ""
		按钮[i].visible = false
		按钮[i].disabled = true
		自动勾[i].visible = false
		自动勾[i].set_pressed_no_signal(false)
		自动勾[i].text = ""


func 关闭() -> void:
	visible = false
	UiBridge.act(面板, "关闭", [])


func _互动(index: int) -> void:
	UiBridge.act(面板, "互动", [index])
	UiBridge.request(面板)
	互动完成.emit()


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	# 自动类别勾选的真值在逻辑层, 这里只负责抄进 playerprefs
	var 类别 := str(data["auto_types"])
	if 类别 != _自动串:
		_自动串 = 类别
		UISettings.set_string("auto_types", 类别)
	if 名称.text != str(data["name"]):
		名称.text = data["name"]

	# 0.2s 一次的轮询: 每个控件只在值真的变了才写。
	# 无条件重设会让按钮每帧重建一次, 悬停补间被反复杀掉, 表现就是闪 + 没有高亮。
	var buttons: Array = data["buttons"]
	_按钮条件 = []
	_按钮说明 = []
	for i in 按钮.size():
		var info: Dictionary = buttons[i]
		var active := bool(info["active"])
		var conds: Array = info["conditions"]
		_按钮说明.append(str(info["opis"]))

		var 自动 := bool(info["auto"])
		var 可自动 := bool(info["autoable"]) and active
		if 自动勾[i].visible != 可自动:
			自动勾[i].visible = 可自动
		if 自动勾[i].button_pressed != 自动:
			自动勾[i].set_pressed_no_signal(自动)
		var 勾字 := "√" if 自动 else ""
		if 自动勾[i].text != 勾字:
			自动勾[i].text = 勾字

		var lines := PackedStringArray()
		var texts: Array = info["condition_texts"]
		for j in conds.size():
			lines.append(("✓ " if bool(conds[j]) else "✗ ") + _紧凑(str(texts[j])))
		_按钮条件.append(lines)

		var 可点 := active and _条件全满足(conds)
		var 文字 := _紧凑(str(info["text"])) if active else ""
		var 色 := 按钮可用色 if 可点 else 按钮不可用色
		if 按钮[i].visible != active:
			按钮[i].visible = active
		if 按钮[i].text != 文字:
			按钮[i].text = 文字
		if 按钮[i].disabled != (not 可点):
			按钮[i].disabled = not 可点
		# 用按钮特效登记的基色比, 不能拿 modulate 比 —— 悬停补间期间 modulate 是 基色*1.18
		var 基色: Color = 按钮[i].get_meta("fx_prev_modulate", 按钮可用色)
		if 基色 != 色:
			按钮特效.set_base_modulate(按钮[i], 色)

	var icons: Array = data["icons"]
	var puppet := int(data["puppet_of"])
	_图标文案 = []
	for icon in icons:
		_图标文案.append(str(icon["text"]))

	_图标(0, 政府类型贴图(str(icons[0]["sprite"])))
	_图标(1, _查表(str(icons[1]["sprite"]), 军事))
	_图标(2, _查表(str(icons[2]["sprite"]), 经济))
	_图标(3, _查表(str(icons[3]["sprite"]), {"znachki_9": "贸易伙伴_中国"}))
	_图标(4, _影响贴图(str(icons[4]["sprite"]), puppet))
	_联盟或傀儡(icons[5], puppet)

	for i in 图标.size():
		var 提示: String = _图标文案[i] if i < _图标文案.size() else ""
		if 图标[i].tooltip_text != 提示:
			图标[i].tooltip_text = 提示

	_默认条件 = 悬浮提示.unity_to_bbcode(str(data["opis"])).replace("|", "\n")
	_更新条件()


func _图标(index: int, path: String) -> void:
	var 有 := not path.is_empty()
	if 图标[index].visible != 有:
		图标[index].visible = 有
	var tex: Texture2D = load(path) as Texture2D if 有 else null
	if 图标[index].texture != tex:
		图标[index].texture = tex


func 政府类型贴图(key: String) -> String:
	if key.begins_with("sub_znachki_"):
		var n := int(key.substr(12))
		# 原版 ChangeIcons 直接复用子意识形态图标(sub_znachki[N]);
		# 不要再拿"政府类型_自由主义/激进左翼"去覆盖 4/6(Gos 2/3 的图标就是 sub_04/sub_06)
		if 子意识形态.has(n):
			return "res://assets/ui/外交/子意识形态图标/%s.png" % 子意识形态[n]
		return ""
	match key:
		"znachki_1":
			return "res://assets/ui/外交/政府类型_苏式社会主义.png"
		"znachki_8":
			return "res://assets/ui/外交/政府类型_国控社会主义.png"
		_:
			return ""


func _查表(key: String, table: Dictionary) -> String:
	if key.is_empty() or not table.has(key):
		return ""
	return "res://assets/ui/外交/%s.png" % table[key]


func _影响贴图(key: String, puppet: int) -> String:
	var path := _查表(key, 影响)
	if not path.is_empty():
		return path
	if key.is_empty():
		if puppet == 21:
			return "res://assets/ui/外交/宗主影响/21.png"
		return ""
	if puppet > 0:
		return "res://assets/ui/外交/宗主影响/%d.png" % puppet if ResourceLoader.exists("res://assets/ui/外交/宗主影响/%d.png" % puppet) else "res://assets/ui/外交/在某国影响下_傀儡通用.png"
	return ""


func _联盟或傀儡(slot: Dictionary, puppet: int) -> void:
	var key := str(slot["sprite"])
	var text := str(slot["text"])
	if key == "znachki_15" or (key.is_empty() and puppet > 0 and puppet != 21 and not text.is_empty()):
		if 图标[5].visible:
			图标[5].visible = false
		if not 图标[6].visible:
			图标[6].visible = true
		var path := "res://assets/ui/外交/宗主影响/%d.png" % puppet
		var tex: Texture2D = load(path) if ResourceLoader.exists(path) else load("res://assets/ui/外交/在某国影响下_傀儡通用.png")
		if 图标[6].texture != tex:
			图标[6].texture = tex
		if 图标[6].tooltip_text != text:
			图标[6].tooltip_text = text
		return
	if 图标[6].visible:
		图标[6].visible = false
	_图标(5, _查表(key, 联盟))


func _悬停按钮(index: int) -> void:
	_悬停 = index
	_更新条件()


func _离开按钮() -> void:
	_悬停 = -1
	_更新条件()


func _更新条件() -> void:
	var lines := PackedStringArray()
	if _悬停 < 0:
		# 离开按钮: 恢复该国的默认信息(原版 Text_opis_country)
		if not _默认条件.is_empty():
			lines.append(_默认条件)
	else:
		var opis: String = str(_按钮说明[_悬停]).replace("|", "\n")
		if not opis.is_empty():
			lines.append(悬浮提示.unity_to_bbcode(opis))
		var conds: PackedStringArray = _按钮条件[_悬停]
		if not conds.is_empty():
			lines.append("执行条件:")
			for line in conds:
				lines.append(line)
	var 应该显示 := not lines.is_empty()
	var 内容 := "\n".join(lines)
	if 条件.visible != 应该显示:
		条件.visible = 应该显示
	if 条件.text != 内容:
		条件.text = 内容


# 勾/取消这个槽的自动执行; 排除清单由逻辑层持有, 快照带回后由本页抄进 playerprefs
func _切换自动(_on: bool, index: int) -> void:
	UiBridge.act(面板, "切换自动", [index])
	UiBridge.request(面板)


func _条件全满足(conds: Array) -> bool:
	for c in conds:
		if not bool(c):
			return false
	return true


# 原版按钮文本逐字带中文字间空格; 只收紧 CJK 之间的空格
func _紧凑(text: String) -> String:
	if text.find(" ") < 0:
		return text
	var out := ""
	for i in text.length():
		var ch := text[i]
		if ch == " ":
			var prev := text[i - 1] if i > 0 else ""
			var nxt := text[i + 1] if i + 1 < text.length() else ""
			if _是CJK(prev) and _是CJK(nxt):
				continue
		out += ch
	return out


func _是CJK(ch: String) -> bool:
	if ch.is_empty():
		return false
	var c := ch.unicode_at(0)
	return (c >= 0x3000 and c <= 0x303F) or (c >= 0x3400 and c <= 0x9FFF) or (c >= 0xF900 and c <= 0xFAFF)
