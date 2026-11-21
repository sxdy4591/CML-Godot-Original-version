extends RefCounted
## 头像部件表 — 1.132 政治家/领袖肖像的九层部件拼接数据。
##
## ⚠ 自动生成，勿手改：由 tools/gen_face_layers_table.py 从 face_layers.json 生成。
## 同源产物：src/bridge/FaceLayersTable.cs（桥层 GetPoliticianFaceLayers 用它组装层列表）。
##
## 数据口径（原版 Politic_Face_Renderer.Draw + 预制体 sprite 引用）：
##   · 基底脸 base 不在 s_0..s_7 里，由预制体固定引用，层级最底（order 0），必须先画；
##   · layers[layer][index] = [文件, 中心偏移 pos_px, 尺寸 size_px, draw_order, slot]，
##     index 直接是 face_parts[layer] 的值；null = 原版空引用（missing=true），不画；
##   · 渲染顺序按 draw_order 升序；pos_px 以部件中心为原点、y 向下（与 Godot 同向）；
##   · jacket 同理，slot=9；face_type 0/1 的索引范围不同，数组长度即上界。
##
## slot 与场景节点一一对应：0=基底脸 1..8=层0..层7 9=外套

## 所有层（含 base 与外套）的并集包围盒（像素，中心为原点、y 向下）。
## 界面按容器尺寸等比缩放这个画布并居中，保证 ft0/ft1 两张脸大小一致。
const CANVAS := Rect2(-42.5, -50.586638, 85.0, 100.586637)

const FACE_TYPES := {
	0: {
		"base": ["res://assets/portraits/face/ft0/base.png", Vector2(0.0, 0.0), Vector2(59.0, 92.0), 0, 0],
		"layers": [
			[
				["res://assets/portraits/face/ft0/L0_0.png", Vector2(0.0, -19.286644), Vector2(44.0, 7.0), 1, 1],
				["res://assets/portraits/face/ft0/L0_1.png", Vector2(0.0, -19.286644), Vector2(40.0, 4.0), 1, 1],
				["res://assets/portraits/face/ft0/L0_2.png", Vector2(0.0, -19.286644), Vector2(45.0, 7.0), 1, 1],
			],
			[
				["res://assets/portraits/face/ft0/L1_0.png", Vector2(0.0, -28.586638), Vector2(56.0, 39.0), 8, 2],
				["res://assets/portraits/face/ft0/L1_1.png", Vector2(0.0, -28.586638), Vector2(52.0, 39.0), 8, 2],
				["res://assets/portraits/face/ft0/L1_2.png", Vector2(0.0, -28.586638), Vector2(51.0, 32.0), 8, 2],
				["res://assets/portraits/face/ft0/L1_3.png", Vector2(0.0, -28.586638), Vector2(56.0, 35.0), 8, 2],
				["res://assets/portraits/face/ft0/L1_4.png", Vector2(0.0, -28.586638), Vector2(55.0, 33.0), 8, 2],
				["res://assets/portraits/face/ft0/L1_5.png", Vector2(0.0, -28.586638), Vector2(57.0, 36.0), 8, 2],
			],
			[
				["res://assets/portraits/face/ft0/L2_0.png", Vector2(0.0, -11.486638), Vector2(43.0, 10.0), 2, 3],
				["res://assets/portraits/face/ft0/L2_1.png", Vector2(0.0, -11.486638), Vector2(39.0, 11.0), 2, 3],
				["res://assets/portraits/face/ft0/L2_2.png", Vector2(0.0, -11.486638), Vector2(41.0, 6.0), 2, 3],
				["res://assets/portraits/face/ft0/L2_3.png", Vector2(0.0, -11.486638), Vector2(42.0, 8.0), 2, 3],
				["res://assets/portraits/face/ft0/L2_4.png", Vector2(0.0, -11.486638), Vector2(42.0, 10.0), 2, 3],
				["res://assets/portraits/face/ft0/L2_5.png", Vector2(0.0, -11.486638), Vector2(38.0, 7.0), 2, 3],
			],
			[
				null,
				["res://assets/portraits/face/ft0/L3_1.png", Vector2(0.0, 22.113359), Vector2(33.0, 29.0), 3, 4],
				["res://assets/portraits/face/ft0/L3_2.png", Vector2(0.0, 22.113359), Vector2(50.0, 29.0), 3, 4],
				["res://assets/portraits/face/ft0/L3_3.png", Vector2(0.0, 22.113359), Vector2(50.0, 38.0), 3, 4],
			],
			[
				["res://assets/portraits/face/ft0/L4_0.png", Vector2(0.0, 18.113363), Vector2(13.0, 7.0), 4, 5],
				["res://assets/portraits/face/ft0/L4_1.png", Vector2(0.0, 18.113363), Vector2(13.0, 7.0), 4, 5],
				["res://assets/portraits/face/ft0/L4_2.png", Vector2(0.0, 18.113363), Vector2(16.0, 8.0), 4, 5],
				["res://assets/portraits/face/ft0/L4_3.png", Vector2(0.0, 18.113363), Vector2(17.0, 8.0), 4, 5],
				["res://assets/portraits/face/ft0/L4_4.png", Vector2(0.0, 18.113363), Vector2(15.0, 8.0), 4, 5],
				["res://assets/portraits/face/ft0/L4_5.png", Vector2(0.0, 18.113363), Vector2(16.0, 7.0), 4, 5],
			],
			[
				["res://assets/portraits/face/ft0/L5_0.png", Vector2(0.0, 4.0), Vector2(12.0, 18.0), 9, 6],
				["res://assets/portraits/face/ft0/L5_1.png", Vector2(0.0, 4.0), Vector2(14.0, 17.0), 9, 6],
				["res://assets/portraits/face/ft0/L5_2.png", Vector2(0.0, 4.0), Vector2(13.0, 15.0), 9, 6],
			],
			[
				["res://assets/portraits/face/ft0/L6_0.png", Vector2(0.0, 6.5), Vector2(26.0, 13.0), 5, 7],
				["res://assets/portraits/face/ft0/L6_1.png", Vector2(0.0, 6.5), Vector2(32.0, 19.0), 5, 7],
				["res://assets/portraits/face/ft0/L6_2.png", Vector2(0.0, 6.5), Vector2(27.0, 10.0), 5, 7],
				["res://assets/portraits/face/ft0/L6_3.png", Vector2(0.0, 6.5), Vector2(32.0, 13.0), 5, 7],
				["res://assets/portraits/face/ft0/L6_4.png", Vector2(0.0, 6.5), Vector2(27.0, 15.0), 5, 7],
				["res://assets/portraits/face/ft0/L6_5.png", Vector2(0.0, 6.5), Vector2(32.0, 8.0), 5, 7],
			],
			[
				null,
				["res://assets/portraits/face/ft0/L7_1.png", Vector2(0.0, 14.7), Vector2(28.0, 10.0), 6, 8],
				["res://assets/portraits/face/ft0/L7_2.png", Vector2(0.0, 14.7), Vector2(26.0, 9.0), 6, 8],
			],
		],
		"jacket": [
			["res://assets/portraits/face/jacket/jacket_0.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_1.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_2.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_3.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_4.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
		],
	},
	1: {
		"base": ["res://assets/portraits/face/ft1/base.png", Vector2(0.0, 0.0), Vector2(64.0, 88.0), 0, 0],
		"layers": [
			[
				["res://assets/portraits/face/ft1/L0_0.png", Vector2(0.0, -19.286644), Vector2(39.0, 6.0), 1, 1],
				["res://assets/portraits/face/ft1/L0_1.png", Vector2(0.0, -19.286644), Vector2(37.0, 8.0), 1, 1],
				["res://assets/portraits/face/ft1/L0_2.png", Vector2(0.0, -19.286644), Vector2(37.0, 10.0), 1, 1],
				["res://assets/portraits/face/ft1/L0_3.png", Vector2(0.0, -19.286644), Vector2(37.0, 8.0), 1, 1],
			],
			[
				["res://assets/portraits/face/ft1/L1_0.png", Vector2(0.0, -28.586638), Vector2(51.0, 34.0), 8, 2],
				["res://assets/portraits/face/ft1/L1_1.png", Vector2(0.0, -28.586638), Vector2(58.0, 36.0), 8, 2],
				["res://assets/portraits/face/ft1/L1_2.png", Vector2(0.0, -28.586638), Vector2(57.0, 38.0), 8, 2],
				["res://assets/portraits/face/ft1/L1_3.png", Vector2(0.0, -28.586638), Vector2(54.0, 33.0), 8, 2],
				["res://assets/portraits/face/ft1/L1_4.png", Vector2(0.0, -28.586638), Vector2(50.0, 36.0), 8, 2],
				["res://assets/portraits/face/ft1/L1_5.png", Vector2(0.0, -28.586638), Vector2(56.0, 44.0), 8, 2],
			],
			[
				["res://assets/portraits/face/ft1/L2_0.png", Vector2(0.0, -11.486638), Vector2(37.0, 9.0), 2, 3],
				["res://assets/portraits/face/ft1/L2_1.png", Vector2(0.0, -11.486638), Vector2(37.0, 12.0), 2, 3],
				["res://assets/portraits/face/ft1/L2_2.png", Vector2(0.0, -11.486638), Vector2(39.0, 8.0), 2, 3],
				["res://assets/portraits/face/ft1/L2_3.png", Vector2(0.0, -11.486638), Vector2(39.0, 8.0), 2, 3],
				["res://assets/portraits/face/ft1/L2_4.png", Vector2(0.0, -11.486638), Vector2(36.0, 8.0), 2, 3],
				["res://assets/portraits/face/ft1/L2_5.png", Vector2(0.0, -11.486638), Vector2(37.0, 9.0), 2, 3],
			],
			[
				null,
				["res://assets/portraits/face/ft1/L3_1.png", Vector2(0.0, 28.0), Vector2(29.0, 15.0), 3, 4],
				["res://assets/portraits/face/ft1/L3_2.png", Vector2(0.0, 28.0), Vector2(53.0, 36.0), 3, 4],
			],
			[
				["res://assets/portraits/face/ft1/L4_0.png", Vector2(0.0, 18.113363), Vector2(15.0, 7.0), 4, 5],
				["res://assets/portraits/face/ft1/L4_1.png", Vector2(0.0, 18.113363), Vector2(18.0, 6.0), 4, 5],
				["res://assets/portraits/face/ft1/L4_2.png", Vector2(0.0, 18.113363), Vector2(14.0, 6.0), 4, 5],
				["res://assets/portraits/face/ft1/L4_3.png", Vector2(0.0, 18.113363), Vector2(14.0, 7.0), 4, 5],
			],
			[
				["res://assets/portraits/face/ft1/L5_0.png", Vector2(0.0, 4.0), Vector2(10.0, 15.0), 9, 6],
				["res://assets/portraits/face/ft1/L5_1.png", Vector2(0.0, 4.0), Vector2(8.0, 16.0), 9, 6],
				["res://assets/portraits/face/ft1/L5_2.png", Vector2(0.0, 4.0), Vector2(11.0, 18.0), 9, 6],
				["res://assets/portraits/face/ft1/L5_3.png", Vector2(0.0, 4.0), Vector2(10.0, 10.0), 9, 6],
			],
			[
				["res://assets/portraits/face/ft1/L6_0.png", Vector2(0.0, 6.5), Vector2(34.0, 19.0), 5, 7],
				["res://assets/portraits/face/ft1/L6_1.png", Vector2(0.0, 6.5), Vector2(36.0, 9.0), 5, 7],
				["res://assets/portraits/face/ft1/L6_2.png", Vector2(0.0, 6.5), Vector2(28.0, 15.0), 5, 7],
				["res://assets/portraits/face/ft1/L6_3.png", Vector2(0.0, 6.5), Vector2(28.0, 9.0), 5, 7],
				["res://assets/portraits/face/ft1/L6_4.png", Vector2(0.0, 6.5), Vector2(27.0, 13.0), 5, 7],
			],
			[
				null,
				["res://assets/portraits/face/ft1/L7_1.png", Vector2(0.0, 14.7), Vector2(27.0, 16.0), 6, 8],
				["res://assets/portraits/face/ft1/L7_2.png", Vector2(0.0, 14.7), Vector2(24.0, 18.0), 6, 8],
				["res://assets/portraits/face/ft1/L7_3.png", Vector2(0.0, 14.7), Vector2(25.0, 17.0), 6, 8],
			],
		],
		"jacket": [
			["res://assets/portraits/face/jacket/jacket_0.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_1.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_2.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_3.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
			["res://assets/portraits/face/jacket/jacket_4.png", Vector2(0.0, 38.0), Vector2(85.0, 24.0), 7, 9],
		],
	},
}

## 把桥层返回的层列表画到容器内的固定节点上（slot 0=基底脸 1..8=层0..层7 9=外套）。
## 等比缩放 CANVAS 到容器并居中：ft0/ft1 两张脸大小一致，换容器尺寸不用改数据。
## 只做填数据（texture/position/size/显隐），不增删节点（AGENTS 约束②）。
static func apply_layers(container: Control, nodes: Array, layers: Array) -> void:
	if container == null:
		return
	for node in nodes:
		if node is CanvasItem:
			node.hide()
	var scale := minf(container.size.x / CANVAS.size.x, container.size.y / CANVAS.size.y)
	if scale <= 0.0:
		return
	# 画布原点（部件中心）在容器里的位置 = 容器中心 - 画布中心 * scale
	var origin := container.size * 0.5 - (CANVAS.position + CANVAS.size * 0.5) * scale
	for layer in layers:
		if not layer is Dictionary:
			continue
		var slot := int(layer.get("slot", -1))
		if slot < 0 or slot >= nodes.size():
			continue
		var rect := nodes[slot] as TextureRect
		if rect == null:
			continue
		var path := String(layer.get("file", ""))
		if path.is_empty():
			continue
		if rect.texture == null or rect.texture.resource_path != path:
			rect.texture = load(path) as Texture2D
		var size_px: Vector2 = layer.get("size", Vector2.ZERO)
		var pos_px: Vector2 = layer.get("pos", Vector2.ZERO)
		rect.size = size_px * scale
		rect.position = origin + (pos_px - size_px * 0.5) * scale
		rect.show()
