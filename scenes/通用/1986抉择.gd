extends CanvasLayer
## 1986 抉择 — 纯视图。功成身退/继续掌权转发给 RetirePane（原版 in1992_script）。
##
## 打开时容器会 get_tree().paused = true，本节点必须 PROCESS_MODE_ALWAYS 才能收到点击
## （否则暂停后按钮全冻结，表现为"两个按钮都没用"）。
## 弹出时机由逻辑层决定：原版 TimeScript.Reborn 在 1986-1-1 自动打开 ending，
## 桥层把状态变化转成 retire_changed，这里只照结果显隐。

const 面板 := "1986抉择"


func _ready() -> void:
	process_mode = Node.PROCESS_MODE_ALWAYS
	$面板/继续掌权.pressed.connect(_继续掌权)
	$面板/功成身退.pressed.connect(_功成身退)
	UiBridge.connect("retire_changed", _退休状态变化)


func _退休状态变化(open: bool) -> void:
	get_parent().call("_set_retire", open)


func _继续掌权() -> void:
	UiBridge.act(面板, "继续掌权", [])
	get_parent().call("_hide_retire")


func _功成身退() -> void:
	get_parent().call("_hide_retire")
	UiBridge.act(面板, "功成身退", [])
