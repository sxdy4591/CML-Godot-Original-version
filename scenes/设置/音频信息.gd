extends TextureRect
## 音频信息 — 音乐/音效音量面板。数据全部来自 AudioSys autoload。

@onready var song_label: Label = $歌曲名
@onready var volume_label: Label = $音量值
@onready var slider: HSlider = $音量滑条
@onready var sfx_slider: HSlider = $音效面板/音效滑条
@onready var sfx_label: Label = $音效面板/音效数值

var _accum: float = 0.0


func _ready() -> void:
	slider.value_changed.connect(_on_slider_changed)
	sfx_slider.value_changed.connect(_on_sfx_slider_changed)
	_refresh()


func _process(delta: float) -> void:
	_accum += delta
	if _accum < 1.0:
		return
	_accum = 0.0
	_refresh()


func _on_减小1音量_pressed() -> void:
	AudioSys.调整音乐音量(-1)
	_refresh()


func _on_减小10音量_pressed() -> void:
	AudioSys.调整音乐音量(-10)
	_refresh()


func _on_增大1音量_pressed() -> void:
	AudioSys.调整音乐音量(1)
	_refresh()


func _on_增大10音量_pressed() -> void:
	AudioSys.调整音乐音量(10)
	_refresh()


func _on_slider_changed(value: float) -> void:
	AudioSys.设置音乐音量(int(value))
	_refresh()


func _on_sfx_slider_changed(value: float) -> void:
	AudioSys.设置音效音量(int(value))
	_refresh()


func _refresh() -> void:
	volume_label.text = "音乐 %d" % AudioSys.获取音乐音量()
	slider.set_value_no_signal(float(AudioSys.获取音乐音量()))
	sfx_label.text = str(AudioSys.获取音效音量())
	sfx_slider.set_value_no_signal(float(AudioSys.获取音效音量()))
	song_label.text = AudioSys.当前歌名()
