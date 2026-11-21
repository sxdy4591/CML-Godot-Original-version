extends Control
## 成就界面 — 纯视图(主菜单子场景). 目录/解锁状态来自 AchievementPane 快照.
## 图标是 Steam 成就原图, 按需在线加载并缓存; 网络失败时条目保持默认图标.

const 面板 := "成就"
const 条目场景 := preload("res://scenes/成就/成就条目.tscn")

static var _图标缓存: Dictionary = {}

@onready var 列表: VBoxContainer = $滚动/列表
@onready var 进度: Label = $进度
@onready var 在线: Node = get_node("/root/在线更新")

var _待设图标: Dictionary = {}   # url -> [条目]
var _已请求: Dictionary = {}     # url -> true


func _ready() -> void:
	$返回主菜单.pressed.connect(_关闭)
	UiBridge.connect("panel_snapshot", _收到快照)
	visibility_changed.connect(_刷新)
	_刷新()


func _process(_delta: float) -> void:
	for url in 在线.图片结果.keys():
		var tex: Texture2D = 在线.图片结果[url]
		在线.图片结果.erase(url)
		_图标缓存[url] = tex
		for 条目 in _待设图标.get(url, []):
			if is_instance_valid(条目):
				条目.call("设图标", tex)
		_待设图标.erase(url)


func _关闭() -> void:
	visible = false


func _刷新() -> void:
	if visible:
		UiBridge.request(面板)


func _收到快照(panel: String, data: Dictionary) -> void:
	if panel != 面板:
		return
	进度.text = "已解锁 %d / %d" % [int(data["unlocked"]), int(data["total"])]
	var items: Array = data["items"]
	for i in items.size():
		while 列表.get_child_count() <= i:
			列表.add_child(条目场景.instantiate())
		var 条目 := 列表.get_child(i)
		条目.call("setup", items[i])
		_请求图标(条目, str(items[i].get("icon_url", "")))


func _请求图标(条目: Control, url: String) -> void:
	if url.is_empty():
		return
	if _图标缓存.has(url):
		条目.call("设图标", _图标缓存[url])
		return
	if not _待设图标.has(url):
		_待设图标[url] = []
	_待设图标[url].append(条目)
	if not _已请求.has(url):
		_已请求[url] = true
		在线.请求图片(url)
