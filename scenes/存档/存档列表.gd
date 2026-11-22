extends Control
## 存档/读档共用的列表界面逻辑。保存.gd / 加载.gd 只设置面板名与主按钮文案后 super()。
## 槽位是无限的: 列表按磁盘上 save_*.dat 生成, 每一行是一条存档; 点行选中 = 导入目标槽。

const 行场景 := preload("res://scenes/存档/存档行.tscn")
const 难度名 := ["牛棚小酌", "上山下乡", "斗私批修", "造反有理", "浩荡文革"]

var 面板 := ""          # "存档" / "读档"
var 主按钮文案 := "读取" # 行内主按钮: 保存 / 读取
var 自动主按钮文案 := "读取"

@onready var 自动信息: Label = $自动存档区/自动存档信息
@onready var 自动主按钮: Button = $自动存档区/自动存档主按钮
@onready var 列表: VBoxContainer = $存档列表滚动/存档列表
@onready var 消息: Label = $消息
@onready var 导入对话框: FileDialog = $导入对话框
@onready var 导出对话框: FileDialog = $导出对话框
@onready var 返回按钮: BaseButton = $返回主菜单

var _快照: Dictionary = {}
var _选中槽: int = -1
var _列表签名: String = ""
var _导入类型: String = ""
var _导出槽: int = -1


func _ready() -> void:
	自动主按钮.text = 自动主按钮文案
	自动主按钮.pressed.connect(_自动主按钮点击)
	导入对话框.file_selected.connect(_导入文件选中)
	导出对话框.file_selected.connect(_导出文件选中)
	返回按钮.pressed.connect(_返回)
	$底部按钮行/导入Godot.pressed.connect(_选导入文件.bind("Godot"))
	$底部按钮行/导入Unity.pressed.connect(_选导入文件.bind("Unity"))
	if has_node("底部按钮行/新建存档"):
		$底部按钮行/新建存档.pressed.connect(_新建存档)
	# 黑色字体: 主题里没给 Button 定义 hover/pressed 色, 不补的话鼠标一上去文字就变白
	for 按钮 in _界面按钮():
		for 键 in ["font_hover_color", "font_pressed_color", "font_focus_color"]:
			按钮.add_theme_color_override(键, Color(0, 0, 0, 1))
	UiBridge.connect("panel_snapshot", _收到快照)
	UiBridge.request(面板)


func _界面按钮() -> Array[BaseButton]:
	var 按钮们: Array[BaseButton] = [自动主按钮, $底部按钮行/导入Godot, $底部按钮行/导入Unity]
	if has_node("底部按钮行/新建存档"):
		按钮们.append($底部按钮行/新建存档 as BaseButton)
	return 按钮们


func _返回() -> void:
	get_tree().change_scene_to_file(全局管理.save_return_scene)


## 自动存档不再是固定的 0 号槽: 槽号由玩家点行按钮指定, 这里读写"当前自动槽".
func _自动主按钮点击() -> void:
	if _快照.is_empty():
		return
	var 自动: Dictionary = _快照["auto"]
	var 槽 := int(自动["slot"])
	if 槽 <= 0:
		return
	UiBridge.act(面板, "保存" if 面板 == "存档" else "读取", [槽])
	UiBridge.request(面板)


## 行内「自动」按钮: 把该槽设为自动存档目标; 再点一次当前自动槽 = 关闭自动存档.
func _切换自动槽(槽: int) -> void:
	var ui := get_node("/root/UISettings")
	var 新 := 0 if ui.get_int("autosave_slot", 1) == 槽 else 槽
	ui.set_int("autosave_slot", 新)
	UiBridge.set_auto_slot(新)
	UiBridge.request(面板)


func _新建存档() -> void:
	UiBridge.act(面板, "新建", [])
	UiBridge.request(面板)


## 导入目标槽 = 列表里选中的行; 没选就用下一个空槽(绝不覆盖已有存档).
func _选导入文件(类型: String) -> void:
	_导入类型 = 类型
	导入对话框.filters = PackedStringArray(["*.save ; Unity 存档"]) if 类型 == "Unity" else PackedStringArray(["*.dat ; Godot 存档"])
	导入对话框.current_dir = OS.get_system_dir(OS.SYSTEM_DIR_DOWNLOADS)
	导入对话框.popup_centered_ratio(0.7)


func _导入文件选中(路径: String) -> void:
	UiBridge.act(面板, "导入" + _导入类型, [路径, _选中槽])
	UiBridge.request(面板)


func _导出文件选中(路径: String) -> void:
	UiBridge.act(面板, "导出", [_导出槽, 路径])
	UiBridge.request(面板)


func _行导出(槽: int) -> void:
	_导出槽 = 槽
	导出对话框.current_dir = OS.get_system_dir(OS.SYSTEM_DIR_DOWNLOADS)
	导出对话框.current_file = "存档_%d.dat" % 槽
	导出对话框.popup_centered_ratio(0.7)


func _选中行(槽: int) -> void:
	_选中槽 = 槽
	for 行 in 列表.get_children():
		行.modulate = Color.WHITE if int(行.槽位号) == 槽 else Color(0.72, 0.72, 0.72, 1.0)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	_快照 = data
	var 自动: Dictionary = data["auto"]
	var 自动槽 := int(自动["slot"])
	if 自动槽 <= 0:
		自动信息.text = "自动存档：未指定（点某行的「自动」按钮指定一个槽位）"
		自动主按钮.disabled = true
	else:
		自动信息.text = "自动存档 → 槽位 %d ｜ %s" % [自动槽, _描述(自动)]
		自动主按钮.disabled = 面板 == "读档" and not bool(自动["exists"])
	消息.text = str(data["message"])
	_重建列表(data["slots"])


func _描述(info: Dictionary) -> String:
	if not bool(info["exists"]):
		return "（空）"
	# 工程字体里半角空格宽度为 0, 这里的分隔全部用可见字符
	return "%s ｜ %s ｜ 难度:%s ｜ 存档于 %s" % [
		info["date"], info["leader"], 难度名[int(info["difficulty"])], info["time"]
	]


func _重建列表(槽们: Array) -> void:
	# 只有槽位内容真的变了才重建: 每次动作后都会拉一次快照, 无条件重建会把列表
	# 清空重排, 滚动位置丢回顶部(手机上一存一读就跳回最上面).
	var 签名 := str(槽们)
	if 签名 == _列表签名:
		return
	_列表签名 = 签名
	for child in 列表.get_children():
		列表.remove_child(child)
		child.queue_free()
	for info in 槽们:
		var 槽: int = int(info["slot"])
		var 行 := 行场景.instantiate()
		列表.add_child(行)
		行.槽位号 = 槽
		行.槽位名.text = "槽位 %d" % 槽
		行.日期.text = str(info["date"])
		行.领袖.text = str(info["leader"])
		行.难度.text = 难度名[int(info["difficulty"])]
		行.时间.text = str(info["time"])
		行.主按钮.text = 主按钮文案
		行.自动.set_pressed_no_signal(bool(info["auto"]))
		行.恢复.visible = bool(info["has_backup"])
		行.pressed.connect(_选中行.bind(槽))
		行.主按钮.pressed.connect(_行主按钮.bind(槽))
		行.自动.toggled.connect(func(_开: bool) -> void: _切换自动槽(槽))
		行.复制.pressed.connect(_行动作.bind("复制", 槽))
		行.删除.pressed.connect(_行动作.bind("删除", 槽))
		行.恢复.pressed.connect(_行动作.bind("恢复备份", 槽))
		行.导出.pressed.connect(_行导出.bind(槽))
	if _选中槽 >= 0:
		_选中行(_选中槽)


func _行主按钮(槽: int) -> void:
	UiBridge.act(面板, "保存" if 面板 == "存档" else "读取", [槽])
	UiBridge.request(面板)


func _行动作(动作: String, 槽: int) -> void:
	UiBridge.act(面板, 动作, [槽])
	UiBridge.request(面板)
