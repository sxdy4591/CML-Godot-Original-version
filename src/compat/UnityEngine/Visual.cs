// ============================================================
// UnityCompat — 渲染/视觉: Sprite / SpriteRenderer / TextMesh / Camera / Material
// 这些是原版 UI 脚本的引用面; Godot 重制版 UI 由 GDScript 实现,
// 此处提供可编译的空实现(记录日志), 逻辑保留在原版类中。
// ============================================================
using Godot;

namespace UnityEngine
{
    //Unity Sprite 兼容 — 包装 Godot Texture2D
    public class Sprite : Object
    {
        public Texture2D texture { get; set; }
        public Rect rect { get; set; }
        public Vector2 pivot { get; set; } = new Vector2(0.5f, 0.5f);
        public float pixelsPerUnit { get; set; } = 100f;
        public float borderTop { get; set; }
        public float borderBottom { get; set; }
        public float borderLeft { get; set; }
        public float borderRight { get; set; }
        public Vector4 border => new Vector4(borderLeft, borderBottom, borderRight, borderTop);

        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit = 100f, uint extrude = 0, SpriteMeshType meshType = SpriteMeshType.Tight, Vector4 border = default)
        {
            return new Sprite { texture = texture, rect = rect, pivot = pivot, pixelsPerUnit = pixelsPerUnit };
        }
    }

    public enum SpriteMeshType { FullRect = 0, Tight = 1 }

    public struct Vector4
    {
        public float x, y, z, w;
        public Vector4(float x, float y, float z, float w) { this.x = x; this.y = y; this.z = z; this.w = w; }
        public Vector4(Vector2 xy, float z, float w) { x = xy.x; y = xy.y; this.z = z; this.w = w; }
        public Vector2 xy => new Vector2(x, y);
        public static Vector4 zero => new Vector4(0f, 0f, 0f, 0f);
        public static Vector4 one => new Vector4(1f, 1f, 1f, 1f);
        public static Vector4 operator +(Vector4 a, Vector4 b) => new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        public static Vector4 operator -(Vector4 a, Vector4 b) => new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        public static Vector4 operator *(Vector4 a, float d) => new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
        public static Vector4 operator /(Vector4 a, float d) => new Vector4(a.x / d, a.y / d, a.z / d, a.w / d);
        public override string ToString() => $"({x:0.###}, {y:0.###}, {z:0.###}, {w:0.###})";
    }

    //Unity Texture2D 兼容 — 包装 Godot Image/Texture2D
    public class Texture2D : Object
    {
        public int width { get; set; }
        public int height { get; set; }
        public Godot.Texture2D GodotTexture { get; set; }
        public TextureFormat format { get; set; }
        public FilterMode filterMode { get; set; }
        public TextureWrapMode wrapMode { get; set; }
        public bool isReadable => true;

        public Texture2D() { }
        public Texture2D(int width, int height) { this.width = width; this.height = height; }
        public Texture2D(int width, int height, TextureFormat format, bool mipChain) { this.width = width; this.height = height; this.format = format; }

        public Color GetPixel(int x, int y) => Color.white;
        public Color[] GetPixels() => new Color[width * height];
        public void SetPixel(int x, int y, Color color) { }
        public void SetPixels(Color[] colors) { }
        public void Apply(bool updateMipmaps = true, bool makeNoLongerReadable = false) { }
        public bool LoadImage(byte[] data)
        {
            var img = new Godot.Image();
            var err = img.LoadPngFromBuffer(data);
            if (err != Error.Ok) err = img.LoadJpgFromBuffer(data);
            if (err == Error.Ok)
            {
                GodotTexture = Godot.ImageTexture.CreateFromImage(img);
                width = img.GetWidth();
                height = img.GetHeight();
                return true;
            }
            return false;
        }
        public byte[] EncodeToPNG() => new byte[0];
        public byte[] EncodeToJPG(int quality = 75) => new byte[0];
        public void Resize(int width, int height, FilterMode filter = FilterMode.Bilinear) { }
        public static Texture2D CreateTexture2D(int w, int h) => new Texture2D(w, h);

        // Unity 语义: blackTexture/whiteTexture 是共享的内置单例, 不是每次新建。
        // 原实现每次访问 new Texture2D —— 每帧访问即每帧垃圾。
        private static Texture2D _blackTexture;
        private static Texture2D _whiteTexture;
        public static Texture2D blackTexture => _blackTexture ??= new Texture2D(1, 1);
        public static Texture2D whiteTexture => _whiteTexture ??= new Texture2D(1, 1);
    }

    public enum TextureFormat { RGBA32 = 4, RGB24 = 3, ARGB32 = 5, Alpha8 = 1 }
    public enum FilterMode { Point = 0, Bilinear = 1, Trilinear = 2 }
    public enum TextureWrapMode { Repeat = 0, Clamp = 1, Mirror = 2 }
    public enum Texture2DArray { }

    //Unity Renderer 兼容
    public class Renderer : Component
    {
        public Material sharedMaterial { get; set; } = new Material();
        public Material material { get => sharedMaterial; set => sharedMaterial = value; }
        public bool enabled { get; set; } = true;
        public int sortingOrder { get; set; }
        public int sortingLayerID { get; set; }
        public string sortingLayerName { get; set; } = "Default";
        public Bounds bounds => new Bounds(Vector3.zero, Vector3.one);
        public void SetMaterial(Material m) => sharedMaterial = m;
        public bool isVisible => true;
    }

    public struct Bounds
    {
        public Vector3 center;
        public Vector3 size;
        public Vector3 extents => size * 0.5f;
        public Vector3 min => center - extents;
        public Vector3 max => center + extents;
        public Bounds(Vector3 center, Vector3 size) { this.center = center; this.size = size; }
        public bool Contains(Vector3 point) => point.x >= min.x && point.x <= max.x && point.y >= min.y && point.y <= max.y && point.z >= min.z && point.z <= max.z;
        public void SetMinMax(Vector3 min, Vector3 max) { center = (min + max) * 0.5f; size = max - min; }
        public void Encapsulate(Vector3 point)
        {
            var m = min; var x = max;
            m = Vector3.Min(m, point); x = Vector3.Max(x, point);
            SetMinMax(m, x);
        }
    }

    //Unity SpriteRenderer 兼容
    public class SpriteRenderer : Renderer
    {
        public Sprite sprite { get; set; }
        public Color color { get; set; } = Color.white;
        public bool flipX { get; set; }
        public bool flipY { get; set; }
        public bool maskInteraction { get; set; }
        public SpriteDrawMode drawMode { get; set; }
        public Vector2 size { get; set; } = Vector2.one;
        public float width { get; set; } = 1f;
        public float height { get; set; } = 1f;
        public void SetSprite(Sprite s) => sprite = s;
    }

    public enum SpriteDrawMode { Simple = 0, Sliced = 1, Tiled = 2, Filled = 3 }

    //Unity TextMesh 兼容
    public class TextMesh : Component
    {
        public string text { get; set; } = "";
        public Color color { get; set; } = Color.white;
        public int fontSize { get; set; } = 12;
        public FontStyle fontStyle { get; set; }
        public float characterSize { get; set; } = 1f;
        public float lineSpacing { get; set; } = 1f;
        public float tabSize { get; set; } = 4f;
        public bool richText { get; set; } = true;
        public TextAnchor anchor { get; set; }
        public TextAlignment alignment { get; set; }
        public Font font { get; set; }
        public Vector3[] vertices => new Vector3[0];
        public override string ToString() => text;
    }

    public enum FontStyle { Normal = 0, Bold = 1, Italic = 2, BoldAndItalic = 3 }
    public enum TextAnchor
    {
        UpperLeft = 0, UpperCenter = 1, UpperRight = 2,
        MiddleLeft = 3, MiddleCenter = 4, MiddleRight = 5,
        LowerLeft = 6, LowerCenter = 7, LowerRight = 8
    }
    public enum TextAlignment { Left = 0, Center = 1, Right = 2 }

    //Unity Font 兼容
    public class Font : Object
    {
        public int fontSize { get; set; }
        public static Font CreateDynamicFontFromOSFont(string fontname, int size) => new Font();
        public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size) => new Font();
    }

    //Unity Material 兼容
    public class Material : Object
    {
        public Color color
        {
            get => _color;
            set { _color = value; }
        }
        public Texture mainTexture { get; set; }
        public string shader { get; set; }
        public float mainTextureOffsetX { get; set; }
        public float mainTextureOffsetY { get; set; }
        public Vector2 mainTextureOffset { get => new Vector2(mainTextureOffsetX, mainTextureOffsetY); set { mainTextureOffsetX = value.x; mainTextureOffsetY = value.y; } }
        public Vector2 mainTextureScale { get; set; } = Vector2.one;
        private Color _color = Color.white;

        public Material() { }
        public Material(Shader shader) { }
        public Material(Material source) { _color = source._color; }

        // 原版国家着色用 sp.material.SetColor("_MainColor"/"_MainColor2", ...),
        // 两个通道必须分开存, 否则后写的会覆盖前一个。
        private readonly System.Collections.Generic.Dictionary<string, Color> _named = new();
        public void SetColor(string name, Color value) { _named[name] = value; _color = value; }
        public void SetColor(int nameID, Color value) { _color = value; }
        public Color GetColor(string name) => _named.TryGetValue(name, out var c) ? c : _color;
        public bool HasColor(string name) => _named.ContainsKey(name);
        public void SetFloat(string name, float value) { }
        public void SetInt(string name, int value) { }
        public void SetTexture(string name, Texture value) { if (name == "_MainTex") mainTexture = value; }
        public void SetVector(string name, Vector4 value) { }
        public void SetMatrix(string name, Matrix4x4 value) { }
        public void EnableKeyword(string keyword) { }
        public void DisableKeyword(string keyword) { }
        public Material Clone() => new Material(this);

        // Unity 语义: defaultMaterial 是共享内置材质(不是每次新建)
        private static Material _defaultMaterial;
        public static Material defaultMaterial => _defaultMaterial ??= new Material();
    }

    //Unity Shader 兼容
    public class Shader : Object
    {
        public static Shader Find(string name) => new Shader { name = name };
    }

    //Unity Texture 兼容(基类)
    public class Texture : Object
    {
        public int width { get; set; }
        public int height { get; set; }
        public FilterMode filterMode { get; set; }
        public TextureWrapMode wrapMode { get; set; }
    }

    public struct Matrix4x4
    {
        public float m00, m10, m20, m30, m01, m11, m21, m31, m02, m12, m22, m32, m03, m13, m23, m33;
        public static Matrix4x4 identity => new Matrix4x4 { m00 = 1f, m11 = 1f, m22 = 1f, m33 = 1f };
        public static Matrix4x4 zero => new Matrix4x4();
        public Vector3 GetColumn(int i) => new Vector3();
        public Vector3 GetRow(int i) => new Vector3();
        public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) => identity;
        public static Matrix4x4 Scale(Vector3 v) => identity;
        public static Matrix4x4 Translate(Vector3 v) => identity;
        public static Matrix4x4 Rotate(Quaternion q) => identity;
        public static Matrix4x4 operator *(Matrix4x4 a, Matrix4x4 b) => a;
        public static Vector4 operator *(Matrix4x4 a, Vector4 v) => v;

        //实例版 TRS — 原版 EnvMapAnimator 用 default(Matrix4x4).SetTRS(...) 构建环境矩阵
        public void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
        {
            float x = q.x, y = q.y, z = q.z, w = q.w;
            float x2 = x + x, y2 = y + y, z2 = z + z;
            float xx = x * x2, xy = x * y2, xz = x * z2;
            float yy = y * y2, yz = y * z2, zz = z * z2;
            float wx = w * x2, wy = w * y2, wz = w * z2;
            m00 = (1f - (yy + zz)) * s.x; m01 = (xy - wz) * s.y; m02 = (xz + wy) * s.z; m03 = pos.x;
            m10 = (xy + wz) * s.x; m11 = (1f - (xx + zz)) * s.y; m12 = (yz - wx) * s.z; m13 = pos.y;
            m20 = (xz - wy) * s.x; m21 = (yz + wx) * s.y; m22 = (1f - (xx + yy)) * s.z; m23 = pos.z;
            m30 = 0f; m31 = 0f; m32 = 0f; m33 = 1f;
        }
        public Vector3 MultiplyPoint(Vector3 v) => v;
        public Vector3 MultiplyPoint3x4(Vector3 v) => v;
        public Vector3 MultiplyVector(Vector3 v) => v;
        public Matrix4x4 inverse => this;
        public Matrix4x4 transpose => this;
        public float determinant => 1f;
        public bool isIdentity => true;
    }

    //Unity Camera 兼容 — main 桥接到当前视口
    public class Camera : Behaviour
    {
        // Unity 语义: Camera.main 是被 "MainCamera" 标签标记的那个实例(稳定引用),
        // 不是每次访问新建。原实现每帧 new Camera → 每帧一个 Object + instanceId。
        private static Camera _main;
        public static Camera main => _main ??= new Camera { name = "Main Camera" };

        public static Camera current => main;
        public float orthographicSize { get; set; } = 5f;
        public float fieldOfView { get; set; } = 60f;
        public float nearClipPlane { get; set; } = 0.3f;
        public float farClipPlane { get; set; } = 1000f;
        public bool orthographic { get; set; } = true;
        public Color backgroundColor { get; set; } = Color.black;
        public float depth { get; set; }
        public Rect rect { get; set; } = new Rect(0f, 0f, 1f, 1f);
        public Rect pixelRect { get; set; } = new Rect(0f, 0f, 1920f, 1080f);
        public CameraClearFlags clearFlags { get; set; }
        public int targetDisplay { get; set; }
        public int cullingMask { get; set; } = -1;
        public bool allowHDR { get; set; } = true;
        public float aspect => 16f / 9f;

        public Vector3 ScreenToWorldPoint(Vector3 position) => position;
        public Vector2 ScreenToWorldPoint(Vector2 position) => position;
        public Vector3 WorldToScreenPoint(Vector3 position) => position;
        public Vector2 WorldToScreenPoint(Vector2 position) => position;
        public Vector3 ScreenToViewportPoint(Vector3 position) => position;
        public Vector3 ViewportToWorldPoint(Vector3 position) => position;
        public Vector3 WorldToViewportPoint(Vector3 position) => position;
        public Ray ScreenPointToRay(Vector3 pos) => new Ray();
        public Ray ViewportPointToRay(Vector3 pos) => new Ray();
        public void Reset() { }
        public void Render() { }
    }

    public enum CameraClearFlags { Skybox = 1, Color = 2, SolidColor = 2, Depth = 3, Nothing = 4 }

    public struct Ray
    {
        public Vector3 origin;
        public Vector3 direction;
        public Ray(Vector3 origin, Vector3 direction) { this.origin = origin; this.direction = direction; }
        public Vector3 GetPoint(float distance) => origin + direction * distance;
        public override string ToString() => $"Origin: {origin}, Dir: {direction}";
    }

    //Unity Canvas 兼容
    public class Canvas : Behaviour
    {
        public RenderMode renderMode { get; set; }
        public float planeDistance { get; set; }
        public int sortingOrder { get; set; }
        public int targetDisplay { get; set; }
        public static Canvas mainCanvas => null;
    }

    public enum RenderMode { ScreenSpaceOverlay = 0, ScreenSpaceCamera = 1, WorldSpace = 2 }

    //Unity RectTransform 兼容
    public class RectTransform : Transform
    {
        public RectTransform(GameObject owner) : base(owner) { }

        public Vector2 sizeDelta { get; set; } = Vector2.zero;
        public Vector2 anchorMin { get; set; } = new Vector2(0.5f, 0.5f);
        public Vector2 anchorMax { get; set; } = new Vector2(0.5f, 0.5f);
        public Vector2 pivot { get; set; } = new Vector2(0.5f, 0.5f);
        public Vector2 anchoredPosition { get; set; } = Vector2.zero;
        public Vector2 anchoredPosition3D => anchoredPosition;
        public Vector2 offsetMin { get; set; } = Vector2.zero;
        public Vector2 offsetMax { get; set; } = Vector2.zero;
        public Rect rect => new Rect(anchoredPosition.x, anchoredPosition.y, sizeDelta.x, sizeDelta.y);
        public Rect GetWorldRect() => rect;
        public Vector2 GetSizeDelta() => sizeDelta;
        public void SetSizeWithCurrentAnchors(Axis axis, float size)
        {
            if (axis == Axis.Horizontal) sizeDelta = new Vector2(size, sizeDelta.y);
            else sizeDelta = new Vector2(sizeDelta.x, size);
        }
        public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size)
        {
            if (edge == Edge.Top || edge == Edge.Bottom) sizeDelta = new Vector2(sizeDelta.x, size);
            else sizeDelta = new Vector2(size, sizeDelta.y);
        }
    }

    public enum Axis { Horizontal = 0, Vertical = 1 }
    public enum Edge { Left = 0, Bottom = 1, Right = 2, Top = 3 }
}
