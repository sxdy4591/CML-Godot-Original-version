extends Node
## 在线更新 / 在线内容: 只读 GitHub Pages 上的静态 JSON 与图片.
## 系统界面(主菜单/关于)专用, 不依赖原版内核, 不碰 UiBridge.

signal 更新检查完成(有新版本: bool, 远端版本: String, 下载页: String, 说明: String)
signal 在线内容就绪(内容: Dictionary)

## GitHub Pages 站点根: 仓库 Settings -> Pages 选 main 分支 /site 目录后,
## 根地址是 https://<用户名>.github.io/<仓库名>/. 末尾必须带斜杠.
const 版本工具 := preload("res://src/common/版本.gd")
const 站点 := "https://sxdy4591.github.io/CML-Godot-Original-version/"

var 内容: Dictionary = {}

func 检查更新() -> void:
	请求文本(站点 + "version.json", _解析版本清单)

func 拉取内容() -> void:
	请求文本(站点 + "content.json", _解析内容)

## 下载图片; 成功才回调, 失败由 请求字节 显式报错(UI 保持本地图).
func 下载图片(url: String, 回调: Callable) -> void:
	请求字节(url, func(数据: PackedByteArray) -> void:
		var 图 := Image.new()
		var 后缀 := url.get_extension().to_lower()
		var 错误 := 图.load_jpg_from_buffer(数据) if 后缀 == "jpg" or 后缀 == "jpeg" else 图.load_png_from_buffer(数据)
		if 错误 != OK:
			push_error("[在线更新] %s 不是可解码的图片: %s" % [url, error_string(错误)])
			return
		回调.call(ImageTexture.create_from_image(图)))

func 请求文本(url: String, 回调: Callable) -> void:
	请求字节(url, func(数据: PackedByteArray) -> void:
		回调.call(数据.get_string_from_utf8()))

func 请求字节(url: String, 回调: Callable) -> void:
	var 请求 := HTTPRequest.new()
	请求.timeout = 10.0
	add_child(请求)
	请求.request_completed.connect(
		func(结果: int, 码: int, _头: PackedStringArray, 体: PackedByteArray) -> void:
			请求.queue_free()
			if 结果 != HTTPRequest.RESULT_SUCCESS or 码 != 200:
				push_error("[在线更新] %s 失败: result=%d code=%d" % [url, 结果, 码])
				return
			回调.call(体))
	var 错误 := 请求.request(url)
	if 错误 != OK:
		请求.queue_free()
		push_error("[在线更新] %s 无法发起: %s" % [url, error_string(错误)])

func _解析版本清单(文本: String) -> void:
	var 清单: Variant = JSON.parse_string(文本)
	if not (清单 is Dictionary):
		push_error("[在线更新] version.json 不是合法 JSON 对象")
		return
	var 远端 := str(清单.get("version", ""))
	更新检查完成.emit(版本工具.比较(版本工具.当前(), 远端) < 0, 远端,
		str(清单.get("url", "")), str(清单.get("notes", "")))

func _解析内容(文本: String) -> void:
	var 解析: Variant = JSON.parse_string(文本)
	if not (解析 is Dictionary):
		push_error("[在线更新] content.json 不是合法 JSON 对象")
		return
	内容 = 解析
	在线内容就绪.emit(内容)
