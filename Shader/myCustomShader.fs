

varying vec2 vUv; // 接收来自顶点着色器的 UV
    uniform float uTime; // 接收来自 JavaScript 的时间信号

    void main() {
        // 利用 UV 坐标和时间来创建一个渐变色
        // vUv.x 随水平方向从 0-1 变化
        // sin(uTime) 随时间从 -1 到 1 周期性变化
        
        vec3 color = vec3(vUv.x, vUv.y, 0.5 + 0.5 * sin(uTime));
        
        gl_FragColor = vec4(color, 1.0); // 设置最终像素颜色 (RGBA)
    }