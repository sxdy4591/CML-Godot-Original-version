extends CanvasLayer
## 1986 抉择 — 纯视图。功成身退转发给 RetirePane（原版 in1992_script）。

const 面板 := "1986抉择"


func _ready() -> void:
	$面板/继续掌权.pressed.connect(_继续掌权)
	$面板/功成身退.pressed.connect(_功成身退)


func _继续掌权() -> void:
	visible = false


func _功成身退() -> void:
	UiBridge.act(面板, "功成身退", [])
	visible = false
