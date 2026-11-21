extends Control
## 主菜单 — 纯 GDScript 系统界面（对接原游戏逻辑 = 无）。
## 按钮转发 全局管理 的全局信号; 版本号取 版本(autoload), 更新检测走 在线更新(autoload).
## 项目信息 是 .tscn 里的静态文本, 本脚本不碰; 不读游戏状态、不调 UiBridge.

const 版本工具 := preload("res://src/common/版本.gd")


@onready var 版本信息: RichTextLabel = $版本信息
@onready var 成就界面: Control = $成就界面
@onready var 检测更新: Button = $检测更新
@onready var 在线: Node = get_node("/root/在线更新")


func _ready() -> void:
	版本信息.text = _版本文案("")
	检测更新.pressed.connect(_检查更新)
	版本信息.meta_clicked.connect(func(链接: String) -> void: OS.shell_open(链接))
	在线.更新检查完成.connect(_更新结果)


func _检查更新() -> void:
	版本信息.text = _版本文案("[color=#777777]正在检查更新…[/color]")
	在线.检查更新()


func _更新结果(有新版本: bool, 远端: String, 下载页: String, _说明: String) -> void:
	if 有新版本:
		var 链接: String = 下载页 if not 下载页.is_empty() else str(在线.站点)
		版本信息.text = _版本文案("[url=%s][color=#C0392B]发现新版本 %s · 点击前往下载[/color][/url]" % [链接, 远端])
	else:
		版本信息.text = _版本文案("[color=#2E7D32]已是最新版本[/color]")


func _版本文案(状态: String) -> String:
	var 行 := PackedStringArray()
	行.append("[left][color=#FFD700][font_size=44]%s[/font_size][/color]" % 版本工具.文本())
	行.append("[font=res://assets/fonts/maozedong-1.ttf][font_size=40][color=#FFD700]往事越千年[/color][/font_size][/font]")
	if not 状态.is_empty():
		行.append("[font_size=28]%s[/font_size]" % 状态)
	行.append("[/left]")
	return "\n".join(行)


func _on_开始游戏_pressed() -> void:
	全局管理.start_game.emit()


func _on_设置_pressed() -> void:
	全局管理.open_settings.emit()


func _on_加载_pressed() -> void:
	全局管理.open_load.emit()


func _on_关于_pressed() -> void:
	全局管理.show_about.emit()


func _on_成就_pressed() -> void:
	成就界面.visible = true


func _on_退出_pressed() -> void:
	全局管理.quit_game.emit()
