class_name 版本
extends RefCounted
## 版本号的唯一真值 = project.godot 的 application/config/version.
## .tscn 里不写死版本号; 发布清单(site/version.json)与本版本号的一致性由
## tools/check_version.py 校验. 纯静态工具, 不注册 autoload.


## 当前版本, 形如 "0.7.2.1"
static func 当前() -> String:
	return str(ProjectSettings.get_setting("application/config/version", "0.0.0"))


## 显示用, 形如 "v0.7.2.1"
static func 文本() -> String:
	return "v" + 当前()


## 语义化比较: 左小于右返回 -1, 相等 0, 左大于右 1; 忽略 -beta 之类后缀.
static func 比较(左: String, 右: String) -> int:
	var a := 左.split(".")
	var b := 右.split(".")
	for i in maxi(a.size(), b.size()):
		var x := a[i].to_int() if i < a.size() else 0
		var y := b[i].to_int() if i < b.size() else 0
		if x < y:
			return -1
		if x > y:
			return 1
	return 0
