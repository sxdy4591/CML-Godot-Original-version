extends CanvasLayer
## 自动动作提示 — 纯视图。内容由逻辑层 Automation 每轮结束时经 UiBridge.auto_report 给出:
## 第一行是本轮汇总(执行几项 + 资源合计), 其余行是逐条明细(国家 · 动作 · 消耗在哪)。
## 本脚本只赋文本与显隐, 不判断任何游戏数值; 控件全部来自 外交.tscn。

@onready var 面板: PanelContainer = $面板
@onready var 内容: RichTextLabel = $面板/布局/内容
@onready var 计时: Timer = $隐藏计时


func _ready() -> void:
	UiBridge.connect("auto_report", _收到汇报)
	计时.timeout.connect(_收起)
	面板.visible = false


func _收到汇报(文本: String) -> void:
	# 设置·自定义页「自动动作提示」开关: 关掉就不弹屏幕提示(控制台 auto 仍保留明细)
	if not UISettings.get_bool("auto_report", true):
		return
	var 行 := 文本.split("\n", false)
	var 结果 := PackedStringArray()
	# 第一行 = 汇总, 加粗高亮; 之后每行 = 明细
	for i in 行.size():
		if i == 0:
			结果.append("[color=#FFD700]%s[/color]" % 行[i])
		else:
			结果.append("· %s" % 行[i])
	内容.text = "\n".join(结果)
	面板.visible = true
	计时.start()


func _收起() -> void:
	面板.visible = false
