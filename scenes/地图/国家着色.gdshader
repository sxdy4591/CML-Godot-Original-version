shader_type canvas_item;
// 国家着色 — 逐像素复刻原版 MapTotalShader(旧项目 省份采样.gdshaderinc):
//   out = t + t * (main - minus) - 0.09
// t = 精灵灰度, main = _MainColor, minus = _MainColor2.
//
// 色彩: 采样灰度先还原成 sRGB 再代入原版公式; 输出不再做 gamma 压缩
// (压了会整体发暗), 只做轻微亮度压制 0.9 避免发白。
// 最后乘 tint(modulate/顶点色), 悬停与选中高亮生效。

uniform vec4 main_color = vec4(0.0, 0.0, 0.0, 1.0);
uniform vec4 minus_color = vec4(0.0, 0.0, 0.0, 1.0);

void fragment() {
	vec4 tint = COLOR;
	vec4 tex = texture(TEXTURE, UV);
	float t = pow(tex.r, 1.0 / 2.2);
	vec3 c = vec3(t) + vec3(t) * (main_color.rgb - minus_color.rgb) - vec3(0.09);
	c = clamp(c, 0.0, 1.0) * 1.25;
	COLOR = vec4(c * tint.rgb, tex.a * tint.a);
}
