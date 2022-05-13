#version 430
layout (location = 0) in vec3 vPosition;


out vec3 glPosition;

void main ()
{
	gl_Position = vec4(vPosition, 1.0);
	glPosition = vPosition;
}

