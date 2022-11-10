// NOTE: Shader automatically converted from Godot Engine 4.0.beta3's StandardMaterial3D.

shader_type spatial;
render_mode unshaded, shadows_disabled;

uniform sampler2D view_tex;

void fragment() {
	vec4 view = texture(view_tex, SCREEN_UV);
	view.rgb = mix(pow((view.rgb + vec3(0.055)) * (1.0 / (1.0 + 0.055)),vec3(2.4)),view.rgb.rgb * (1.0 / 12.92),lessThan(view.rgb,vec3(0.04045)));
	ALBEDO = view.rgb;
}