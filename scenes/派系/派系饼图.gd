extends Control
## 派系饼图 — 纯绘制。扇区角度/颜色由逻辑层调原版 Crushko.Repaint 后给出。
## 原版 _DegEnd 是累计终点角(度), -1 = 该段隐藏; _Col 是 6 段颜色。

var _角度: Array = []
var _颜色: Array = []


func 重画(segments: Array) -> void:
	_角度.clear()
	_颜色.clear()
	for s in segments:
		_角度.append(float(s["angle"]))
		_颜色.append(s["color"])
	queue_redraw()


func _draw() -> void:
	var center := size * 0.5
	var radius := minf(center.x, center.y) * 0.92
	var prev := 0.0
	for i in _角度.size():
		var end: float = _角度[i]
		if end < 0.0:
			continue
		var sweep := end - prev
		if sweep > 0.001:
			var start_rad := -PI / 2.0 + deg_to_rad(prev)
			var sweep_rad := deg_to_rad(sweep)
			var pts := PackedVector2Array([center])
			for k in 33:
				var a := start_rad + sweep_rad * float(k) / 32.0
				pts.append(center + Vector2(cos(a), sin(a)) * radius)
			draw_colored_polygon(pts, _颜色[i])
		prev = end
