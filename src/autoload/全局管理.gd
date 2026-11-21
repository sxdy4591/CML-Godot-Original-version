# EventBus.gd
extends Node

# 定义所有全局信号
# 注意: 这些信号由 主菜单.gd 等外部脚本经 autoload 单例触发/连接,
# 静态分析器无法识别跨脚本使用, 故屏蔽 UNUSED_SIGNAL 误报
@warning_ignore("unused_signal")
signal start_game
@warning_ignore("unused_signal")
signal open_settings
@warning_ignore("unused_signal")
signal open_load
@warning_ignore("unused_signal")
signal show_about
@warning_ignore("unused_signal")
signal quit_game
# 场景切换统一走此信号(导航栏等 UI 发出, 场景管理器接收后 change_scene_to_packed)
@warning_ignore("unused_signal")
signal request_scene_change(scene: PackedScene)

# 设置页"返回"目标: 从外交 ESC 菜单进入 → 外交; 从主菜单进入 → 主菜单
var settings_return_scene: String = "res://scenes/主菜单/主菜单.tscn"
# 存档/读档页"返回"目标(同上): ESC 菜单进入 → 外交; 从主菜单进入 → 主菜单
var save_return_scene: String = "res://scenes/主菜单/主菜单.tscn"


var 存储_摄像机位置: Vector2 = Vector2.ZERO
var 存储_摄像机缩放: Vector2 = Vector2.ONE
var 存储_摄像机状态是否存储: bool = false
