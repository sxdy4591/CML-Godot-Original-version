extends Control
## 派系界面 — 纯视图。数据与政策选项来自 FactionPane。

const 面板 := "派系"

const 政策定义 := [
	{"key": "economy", "panel": "右栏经济类型", "toggle": "经济类型切换", "cat": 16,
	 "buttons": ["中央计划经济", "中式计划经济", "国家资本主义", "国控资本主义", "市场经济", "自由市场"]},
	{"key": "party", "panel": "右栏党政", "toggle": "党政切换", "cat": 15,
	 "buttons": ["无产阶级专政", "人民民主专政", "联合政府", "西式民主"]},
	{"key": "human_rights", "panel": "右栏人权", "toggle": "人权切换", "cat": 17,
	 "buttons": ["舆论一律", "纪律约束", "自然限制", "多元自由"]},
	{"key": "state_system", "panel": "右栏国家体制", "toggle": "国家体制切换", "cat": 18,
	 "buttons": ["单一制", "区域自治", "联邦制", "邦联制"]},
	{"key": "tradition", "panel": "右栏传统与宗教", "toggle": "传统与宗教切换", "cat": 50,
	 "buttons": ["文化革命", "国家无神论", "宗教管制", "世俗化", "尊崇传统", "政教协定"]},
	{"key": "military", "panel": "右栏军事力量", "toggle": "军事力量切换", "cat": 51,
	 "buttons": ["全民皆兵", "积极建军", "国防建设", "职业化军队"]},
]

const 动作按钮 := {
	"支持极左派": 0, "支持保守派": 1, "支持温和派": 2, "支持改革派": 3, "支持自由派": 4,
}
const 禁止按钮 := {"禁止极左派": 0, "禁止温和派": 2, "禁止改革派": 3, "禁止自由派": 4}

@onready var 经济类型显示: Label = $经济类型显示
@onready var 党政显示: Label = $党政显示
@onready var 人权显示: Label = $人权显示
@onready var 国家体制显示: Label = $国家体制显示
@onready var 传统与宗教显示: Label = $传统与宗教显示
@onready var 军事力量显示: Label = $军事力量显示
@onready var 派系名: Array[Label] = [$极左派, $保守派, $温和派, $改革派, $自由派]
@onready var 生育政策: Label = $生育政策
@onready var 政体类型: Label = $政体类型
@onready var 政治路线类型: Label = $政治路线类型
@onready var 军队力量: Label = $军队力量
@onready var 右栏条件显示: Label = $右栏条件显示
@onready var 中共党内派系: Label = $中共党内派系
@onready var 选举: Button = $选举
@onready var 经济同盟: Button = $经济同盟
@onready var 军事同盟: Button = $军事同盟
@onready var 饼图: Control = $派系饼图
@onready var 生育按钮: Array[Button] = [$一胎制, $二胎制, $无限制]

var _快照: Dictionary = {}
var _当前政策: int = -1


func _ready() -> void:
	find_child("导航栏", true, false).call("set_screen", "faction")
	for i in 生育按钮.size():
		生育按钮[i].pressed.connect(_生育政策.bind(i))
	for 名称 in 动作按钮:
		get_node(名称).pressed.connect(_结盟.bind(动作按钮[名称]))
	for 名称 in 禁止按钮:
		get_node(名称).pressed.connect(_禁止派系.bind(禁止按钮[名称]))
	$演讲.pressed.connect(_触发.bind("演讲"))
	$经济同盟.pressed.connect(_触发.bind("经济同盟"))
	$选举.pressed.connect(_触发.bind("选举"))
	$军事同盟.pressed.connect(_触发.bind("军事同盟"))
	for 政策号 in 政策定义.size():
		var 定义: Dictionary = 政策定义[政策号]
		get_node(定义["toggle"]).pressed.connect(_切换政策.bind(政策号))
		var 选项: Array = 定义["buttons"]
		for 槽号 in 选项.size():
			var 按钮 := get_node(定义["panel"]).get_node(选项[槽号]) as Button
			按钮.pressed.connect(_政策.bind(定义["cat"], 槽号))
			按钮.mouse_entered.connect(_显示条件.bind(定义["cat"], 槽号))
			按钮.mouse_exited.connect(_清空条件)
	_隐藏政策面板()
	# 默认展开第一类政策, 进界面即可看到右栏选项与条件
	_切换政策(0)
	# 右栏政策介绍: 收起态只留右侧展开按钮, 悬停选项时填充介绍文案
	$右栏政策介绍.visible = false
	$右栏政策介绍展开.visible = true
	$右栏政策介绍展开.pressed.connect(_展开介绍)
	$右栏政策介绍/右栏政策介绍收回.pressed.connect(_收起介绍)
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)
	_适配政策面板()



## 政策按钮用 GridContainer 自适应字体倍率: 面板尺寸跟随内容(手机 145% 字体下
## 按钮更高更宽), 不再写死 178px —— 否则字体撑大按钮最小尺寸后, 末行/末列会溢出.
func _适配政策面板() -> void:
	# 等两帧: 全局字体倍率(UISettings)在节点入树后的 deferred 调用里才落地
	for _i in 2:
		await get_tree().process_frame
	for 定义 in 政策定义:
		_调整面板(get_node(定义["panel"]) as Control)


func _调整面板(控件: Control) -> void:
	var 原: Vector2 = 控件.get_meta("policy_base_size", 控件.size)
	控件.set_meta("policy_base_size", 原)
	var 最小 := 控件.get_combined_minimum_size()
	控件.size = Vector2(maxf(原.x, 最小.x), maxf(原.y, 最小.y))


func _展开介绍() -> void:
	$右栏政策介绍.visible = true
	$右栏政策介绍展开.visible = false


func _收起介绍() -> void:
	$右栏政策介绍.visible = false
	$右栏政策介绍展开.visible = true


func _触发(action: String) -> void:
	UiBridge.act(面板, action, [])
	UiBridge.request(面板)


func _隐藏政策面板() -> void:
	_当前政策 = -1
	for 定义 in 政策定义:
		get_node(定义["panel"]).visible = false


func _切换政策(index: int) -> void:
	var 定义: Dictionary = 政策定义[index]
	var 已展开: bool = get_node(定义["panel"]).visible
	_隐藏政策面板()
	if 已展开:
		return
	var 控件 := get_node(定义["panel"]) as Control
	控件.visible = true
	_调整面板(控件)
	_当前政策 = index


func _政策(cat: int, option_index: int) -> void:
	var 定义: Dictionary = _定义(cat)
	var options: Array = _快照["policy_options"][定义["key"]]
	UiBridge.act(面板, "政策", [cat, options[option_index]["id"]])
	UiBridge.request(面板)


func _定义(cat: int) -> Dictionary:
	for 定义 in 政策定义:
		if 定义["cat"] == cat:
			return 定义
	return {}


func _显示条件(cat: int, option_index: int) -> void:
	var 定义: Dictionary = _定义(cat)
	var options: Array = _快照["policy_options"][定义["key"]]
	if option_index >= options.size():
		return
	var option: Dictionary = options[option_index]
	var opis: String = str(option["opis"]).replace("|", "\n")
	var lines := PackedStringArray()
	var conds: Array = option["conditions"]
	var texts: Array = option["condition_texts"]
	for i in conds.size():
		lines.append(("✓ " if bool(conds[i]) else "✗ ") + str(texts[i]))
	# 条件栏只放执行条件; 政策介绍长文放右侧介绍面板(原版同一分工, 避免两处重复)
	右栏条件显示.visible = not lines.is_empty()
	右栏条件显示.text = "\n".join(lines)
	$右栏政策介绍/右栏政策介绍文案.text = 悬浮提示.unity_to_bbcode(opis)


func _清空条件() -> void:
	右栏条件显示.visible = false
	右栏条件显示.text = ""


func _结盟(index: int) -> void:
	UiBridge.act(面板, "结盟", [index])
	UiBridge.request(面板)


func _禁止派系(index: int) -> void:
	UiBridge.act(面板, "禁止派系", [index])
	UiBridge.request(面板)


func _生育政策(policy: int) -> void:
	UiBridge.act(面板, "生育政策", [policy])
	UiBridge.request(面板)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_快照 = data
	经济类型显示.text = data["economy"]
	党政显示.text = data["party"]
	人权显示.text = data["human_rights"]
	国家体制显示.text = data["state_system"]
	传统与宗教显示.text = data["tradition"]
	军事力量显示.text = data["military"]
	政体类型.text = data["regime"]
	政治路线类型.text = data["route"]
	军队力量.text = data["army_power"]
	# 原版术语是「军事实力」; 悬停说明数值含义, 否则界面上只有一个裸数字
	军队力量.tooltip_text = "军事实力 %s" % data["army_power"]
	($军队力量图标 as Control).tooltip_text = 军队力量.tooltip_text
	中共党内派系.text = "%s（主导派系：%s）" % [data["title"], data["leading"]]
	右栏条件显示.text = ""
	选举.disabled = not bool(data["can_elect"])
	经济同盟.disabled = not bool(data["can_econ"])
	军事同盟.disabled = not bool(data["can_mil"])

	var factions: Array = data["factions"]
	for i in 派系名.size():
		派系名[i].text = factions[i]["name"]
	for 名称 in 动作按钮:
		get_node(名称).tooltip_text = str(factions[动作按钮[名称]]["ally_tip"])
		get_node(名称).set_pressed_no_signal(bool(factions[动作按钮[名称]]["ally"]))
	for 名称 in 禁止按钮:
		get_node(名称).tooltip_text = str(factions[禁止按钮[名称]]["ban_tip"])
		get_node(名称).set_pressed_no_signal(not bool(factions[禁止按钮[名称]]["enabled"]))
	for i in 生育按钮.size():
		生育按钮[i].set_pressed_no_signal(i == int(data["birth_policy"]))
	饼图.call("重画", data["pie"])
	var 席位列 := PackedStringArray()
	for f in factions:
		席位列.append("%s: %d 席" % [f["name"], f["seats"]])
	# 第六段是 data[106]「满足现状者」, 不属于五个派系, 但占饼图一段
	var 总数: int = int(data["seats_total"])
	var 现状: int = int(data["idle_seats"])
	var 占比 := 0.0 if 总数 <= 0 else float(现状) * 100.0 / float(总数)
	席位列.append("满足现状者: %d 席（%.1f%%）" % [现状, 占比])
	饼图.tooltip_text = "\n".join(席位列)

	for 定义 in 政策定义:
		var options: Array = data["policy_options"][定义["key"]]
		var 选项: Array = 定义["buttons"]
		for i in 选项.size():
			var button := get_node(定义["panel"]).get_node(选项[i]) as Button
			if i >= options.size():
				button.visible = false
				continue
			button.visible = true
			button.text = options[i]["text"]
			# 原版条件不满足的选项仍可点/悬停(点击由原版 OnMouseDown 内部拦截)
			button.disabled = false
			按钮特效.set_base_modulate(button, Color.WHITE if bool(options[i]["enabled"]) else Color(0.55, 0.55, 0.55))
