#version 330 core
out vec4 FragColor;

in float out_selected;
in vec2 TexCoord;
uniform sampler2DArray tex;
uniform int layer;
in float Side;

void main()
{
    FragColor = texture(tex, vec3(TexCoord, layer + Side));
    FragColor.rgb = FragColor.rgb * out_selected;
} 