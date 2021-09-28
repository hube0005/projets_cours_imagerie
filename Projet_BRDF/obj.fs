
precision mediump float;

varying vec4 pos3D;
varying vec3 N;
uniform vec3 uSourcePos;
uniform vec3 uSourcePower;
uniform vec3 uKd;
uniform vec3 uLi;
uniform int uBLambert;
uniform float uNi;
uniform float uSigma;

const float PI = 3.14;

// --------------------------------------------

vec3 lambert(){
	float cosTetaI = dot(N,normalize(vec3(uSourcePos-vec3(pos3D)))); 
	
	vec3 lo = uSourcePower * (uKd / PI) * cosTetaI;
	return lo;
}

// --------------------------------------------

vec3 F(vec3 i, vec3 m){//   	page 33
	float r0 = pow((1.0 - uNi) / (1.0 + uNi), 2.0);
	vec3 res = r0 + (vec3(1.0, 1.0, 1.0) - r0) * pow((1.0 - dot(m,i)), 5.0);

	return vec3(res);
}

// --------------------------------------------
float D(vec3 m){//			page 35
    float sigma2    = uSigma * uSigma;
    float cosTetaM   = dot(N, m);
    float cos2TetaM  = cosTetaM * cosTetaM;
	float cos4TetaM = cos2TetaM * cos2TetaM;
    float tan2TetaM = (cos2TetaM - 1.0) / (sigma2 * cos2TetaM);

    return (clamp(cosTetaM, 0.00, 1.00) * exp(tan2TetaM)) / (PI * sigma2 * (cos4TetaM));
}


// --------------------------------------------

float G(vec3 o, vec3 i, vec3 m){//		page 36
	float equO = (2.0 * dot(N,m) * dot(N,o)) / dot(o,m);
	float equI = (2.0 * dot(N,m) * dot(N,i)) / dot(i,m);

	float res = min(equO, equI);
	res = min(res, 1.0);
	
	return res;
}

// --------------------------------------------

vec3 fs(vec3 i, vec3 o, vec3 n, vec3 m){
	vec3 fresnel = F(i, m);

	vec3 res = (fresnel * D(m) * G(o,i,m)) / (4.0 * abs(dot(i,n)) * abs(dot(o,n)) );
	res += (vec3(1.0) - fresnel) * uKd / PI;

	return res;
}

// --------------------------------------------

void main(void)
{
	vec3 uCameraPos = vec3(0, 0, 0);
	vec3 o = normalize(uCameraPos-vec3(pos3D));
	vec3 vi = normalize(uSourcePos-vec3(pos3D));// = i
	vec3 m  = normalize(vi+o);//bisectrice entre i et o
	if(uBLambert == 1){
		gl_FragColor = vec4(lambert(),1.0);
	} else {
		gl_FragColor = vec4(uLi * PI * normalize(dot(vi,N)) * fs(vi, o, N, m), 1.0);
	}
}



