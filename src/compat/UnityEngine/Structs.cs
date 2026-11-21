// ============================================================
// UnityCompat — 数学结构体: Vector2 / Vector3 / Quaternion / Color / Rect
// 与 Godot 对应类型提供隐式转换, 便于桥接代码使用。
// ============================================================
using System;

namespace UnityEngine
{
    [Serializable]
    public struct Vector2 : IEquatable<Vector2>
    {
        public float x, y;
        public Vector2(float x, float y) { this.x = x; this.y = y; }
        public static Vector2 zero => new Vector2(0f, 0f);
        public static Vector2 one => new Vector2(1f, 1f);
        public static Vector2 up => new Vector2(0f, 1f);
        public static Vector2 down => new Vector2(0f, -1f);
        public static Vector2 left => new Vector2(-1f, 0f);
        public static Vector2 right => new Vector2(1f, 0f);
        public static Vector2 positiveInfinity => new Vector2(float.PositiveInfinity, float.PositiveInfinity);
        public static Vector2 negativeInfinity => new Vector2(float.NegativeInfinity, float.NegativeInfinity);
        public float magnitude => (float)Math.Sqrt(x * x + y * y);
        public float sqrMagnitude => x * x + y * y;
        public Vector2 normalized
        {
            get
            {
                float m = magnitude;
                return m > 1E-05f ? new Vector2(x / m, y / m) : zero;
            }
        }
        public float this[int index]
        {
            get => index == 0 ? x : y;
            set { if (index == 0) x = value; else y = value; }
        }
        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.x + b.x, a.y + b.y);
        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.x - b.x, a.y - b.y);
        public static Vector2 operator -(Vector2 a) => new Vector2(-a.x, -a.y);
        public static Vector2 operator *(Vector2 a, float d) => new Vector2(a.x * d, a.y * d);
        public static Vector2 operator *(float d, Vector2 a) => new Vector2(a.x * d, a.y * d);
        public static Vector2 operator /(Vector2 a, float d) => new Vector2(a.x / d, a.y / d);
        public static bool operator ==(Vector2 a, Vector2 b) => a.x == b.x && a.y == b.y;
        public static bool operator !=(Vector2 a, Vector2 b) => !(a == b);
        public static float Dot(Vector2 a, Vector2 b) => a.x * b.x + a.y * b.y;
        public static float Distance(Vector2 a, Vector2 b) => (a - b).magnitude;
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t) => a + (b - a) * Mathf.Clamp01(t);
        public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) => a + (b - a) * t;
        public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
        {
            Vector2 toDelta = target - current;
            float dist = toDelta.magnitude;
            if (dist <= maxDistanceDelta || dist == 0f) return target;
            return current + toDelta / dist * maxDistanceDelta;
        }
        public static Vector2 Scale(Vector2 a, Vector2 b) => new Vector2(a.x * b.x, a.y * b.y);
        public static Vector2 Min(Vector2 a, Vector2 b) => new Vector2(Math.Min(a.x, b.x), Math.Min(a.y, b.y));
        public static Vector2 Max(Vector2 a, Vector2 b) => new Vector2(Math.Max(a.x, b.x), Math.Max(a.y, b.y));
        public static Vector2 ClampMagnitude(Vector2 v, float maxLength)
        {
            float m = v.magnitude;
            if (m > maxLength) return v / m * maxLength;
            return v;
        }
        public void Normalize()
        {
            float m = magnitude;
            if (m > 1E-05f) { x /= m; y /= m; } else { x = 0f; y = 0f; }
        }
        public void Set(float nx, float ny) { x = nx; y = ny; }
        public override string ToString() => $"({x:0.###}, {y:0.###})";
        public bool Equals(Vector2 other) => x == other.x && y == other.y;
        public override bool Equals(object obj) => obj is Vector2 v && Equals(v);
        public override int GetHashCode() => x.GetHashCode() ^ (y.GetHashCode() << 2);

        public static implicit operator Godot.Vector2(Vector2 v) => new Godot.Vector2(v.x, v.y);
        public static implicit operator Vector2(Godot.Vector2 v) => new Vector2(v.X, v.Y);
    }

    [Serializable]
    public struct Vector3 : IEquatable<Vector3>
    {
        public float x, y, z;
        public Vector3(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
        public Vector3(float x, float y) { this.x = x; this.y = y; this.z = 0f; }
        public static Vector3 zero => new Vector3(0f, 0f, 0f);
        public static Vector3 one => new Vector3(1f, 1f, 1f);
        public static Vector3 up => new Vector3(0f, 1f, 0f);
        public static Vector3 down => new Vector3(0f, -1f, 0f);
        public static Vector3 left => new Vector3(-1f, 0f, 0f);
        public static Vector3 right => new Vector3(1f, 0f, 0f);
        public static Vector3 forward => new Vector3(0f, 0f, 1f);
        public static Vector3 back => new Vector3(0f, 0f, -1f);
        public static Vector3 positiveInfinity => new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        public static Vector3 negativeInfinity => new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        public float magnitude => (float)Math.Sqrt(x * x + y * y + z * z);
        public float sqrMagnitude => x * x + y * y + z * z;
        public Vector3 normalized
        {
            get
            {
                float m = magnitude;
                return m > 1E-05f ? new Vector3(x / m, y / m, z / m) : zero;
            }
        }
        public float this[int index]
        {
            get { switch (index) { case 0: return x; case 1: return y; default: return z; } }
            set { switch (index) { case 0: x = value; break; case 1: y = value; break; default: z = value; break; } }
        }
        public static Vector3 operator +(Vector3 a, Vector3 b) => new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Vector3 operator -(Vector3 a, Vector3 b) => new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Vector3 operator -(Vector3 a) => new Vector3(-a.x, -a.y, -a.z);
        public static Vector3 operator *(Vector3 a, float d) => new Vector3(a.x * d, a.y * d, a.z * d);
        public static Vector3 operator *(float d, Vector3 a) => new Vector3(a.x * d, a.y * d, a.z * d);
        public static Vector3 operator *(Vector3 a, Vector3 b) => new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Vector3 operator /(Vector3 a, float d) => new Vector3(a.x / d, a.y / d, a.z / d);
        public static bool operator ==(Vector3 a, Vector3 b) => a.x == b.x && a.y == b.y && a.z == b.z;
        public static bool operator !=(Vector3 a, Vector3 b) => !(a == b);
        public static float Dot(Vector3 a, Vector3 b) => a.x * b.x + a.y * b.y + a.z * b.z;
        public static Vector3 Cross(Vector3 a, Vector3 b) => new Vector3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        public static float Distance(Vector3 a, Vector3 b) => (a - b).magnitude;
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t) => a + (b - a) * Mathf.Clamp01(t);
        public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) => a + (b - a) * t;
        public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
        {
            Vector3 toDelta = target - current;
            float dist = toDelta.magnitude;
            if (dist <= maxDistanceDelta || dist == 0f) return target;
            return current + toDelta / dist * maxDistanceDelta;
        }
        public static Vector3 Scale(Vector3 a, Vector3 b) => new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Vector3 Min(Vector3 a, Vector3 b) => new Vector3(Math.Min(a.x, b.x), Math.Min(a.y, b.y), Math.Min(a.z, b.z));
        public static Vector3 Max(Vector3 a, Vector3 b) => new Vector3(Math.Max(a.x, b.x), Math.Max(a.y, b.y), Math.Max(a.z, b.z));
        public static Vector3 ClampMagnitude(Vector3 v, float maxLength)
        {
            float m = v.magnitude;
            if (m > maxLength) return v / m * maxLength;
            return v;
        }
        public static float Angle(Vector3 from, Vector3 to)
        {
            float d = Dot(from.normalized, to.normalized);
            return (float)(Math.Acos(Mathf.Clamp(d, -1f, 1f)) * Mathf.Rad2Deg);
        }
        public static Vector3 Project(Vector3 vector, Vector3 onNormal)
        {
            float sqr = onNormal.sqrMagnitude;
            if (sqr < 1.175494E-38f) return zero;
            return onNormal * Dot(vector, onNormal) / sqr;
        }
        public void Normalize()
        {
            float m = magnitude;
            if (m > 1E-05f) { x /= m; y /= m; z /= m; } else { x = 0f; y = 0f; z = 0f; }
        }
        public void Set(float nx, float ny, float nz) { x = nx; y = ny; z = nz; }
        public override string ToString() => $"({x:0.###}, {y:0.###}, {z:0.###})";
        public bool Equals(Vector3 other) => x == other.x && y == other.y && z == other.z;
        public override bool Equals(object obj) => obj is Vector3 v && Equals(v);
        public override int GetHashCode() => x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2);

        public static implicit operator Godot.Vector3(Vector3 v) => new Godot.Vector3(v.x, v.y, v.z);
        public static implicit operator Vector3(Godot.Vector3 v) => new Vector3(v.X, v.Y, v.Z);
        public static implicit operator Vector2(Vector3 v) => new Vector2(v.x, v.y);
    }

    [Serializable]
    public struct Quaternion : IEquatable<Quaternion>
    {
        public float x, y, z, w;
        public Quaternion(float x, float y, float z, float w) { this.x = x; this.y = y; this.z = z; this.w = w; }
        public static Quaternion identity => new Quaternion(0f, 0f, 0f, 1f);
        public Vector3 eulerAngles
        {
            get
            {
                // 将四元数转为欧拉角(Unity 的 ZXY 顺序近似)
                var gq = new Godot.Quaternion(x, y, z, w);
                var e = gq.GetEuler();
                return new Vector3((float)(e.X * Mathf.Rad2Deg), (float)(e.Y * Mathf.Rad2Deg), (float)(e.Z * Mathf.Rad2Deg));
            }
            set => SetEuler(value);
        }
        public static Quaternion Euler(float x, float y, float z)
        {
            var q = new Quaternion();
            q.SetEuler(new Vector3(x, y, z));
            return q;
        }
        public static Quaternion Euler(Vector3 euler) => Euler(euler.x, euler.y, euler.z);
        public static Quaternion AngleAxis(float angle, Vector3 axis)
        {
            var gq = new Godot.Quaternion(new Godot.Vector3(axis.x, axis.y, axis.z), (float)(angle * Mathf.Deg2Rad));
            return FromGodot(gq);
        }
        public static Quaternion Inverse(Quaternion q)
        {
            var gq = new Godot.Quaternion(q.x, q.y, q.z, q.w).Inverse();
            return FromGodot(gq);
        }
        public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
        {
            var a = new Godot.Vector3(fromDirection.x, fromDirection.y, fromDirection.z).Normalized();
            var b = new Godot.Vector3(toDirection.x, toDirection.y, toDirection.z).Normalized();
            if (a.Dot(b) > 0.99999f) return identity;
            if (a.Dot(b) < -0.99999f) return AngleAxis(180f, new Vector3(1f, 0f, 0f));
            var gq = new Godot.Quaternion(a, b);
            return FromGodot(gq);
        }
        public static Quaternion LookRotation(Vector3 forward, Vector3 upwards = default)
        {
            var f = new Godot.Vector3(forward.x, forward.y, forward.z).Normalized();
            var u = upwards == default ? Godot.Vector3.Up : new Godot.Vector3(upwards.x, upwards.y, upwards.z).Normalized();
            return FromGodot(new Godot.Quaternion(Godot.Basis.LookingAt(f, u)));
        }
        public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
        {
            var gq = new Godot.Quaternion(a.x, a.y, a.z, a.w).Slerp(new Godot.Quaternion(b.x, b.y, b.z, b.w), Mathf.Clamp01(t));
            return FromGodot(gq);
        }
        public static Quaternion Lerp(Quaternion a, Quaternion b, float t) => Slerp(a, b, t);
        public static Quaternion operator *(Quaternion a, Quaternion b)
        {
            var gq = new Godot.Quaternion(a.x, a.y, a.z, a.w) * new Godot.Quaternion(b.x, b.y, b.z, b.w);
            return FromGodot(gq);
        }
        public static Vector3 operator *(Quaternion q, Vector3 v)
        {
            var gq = new Godot.Quaternion(q.x, q.y, q.z, q.w);
            var gv = new Godot.Vector3(v.x, v.y, v.z);
            var r = gq * gv;
            return new Vector3(r.X, r.Y, r.Z);
        }
        public static bool operator ==(Quaternion a, Quaternion b) => a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w;
        public static bool operator !=(Quaternion a, Quaternion b) => !(a == b);
        public static Quaternion FromGodot(Godot.Quaternion q) => new Quaternion(q.X, q.Y, q.Z, q.W);
        public static Quaternion FromGodot(Godot.Basis b) => FromGodot(new Godot.Quaternion(b));
        public Godot.Quaternion ToGodot() => new Godot.Quaternion(x, y, z, w);
        private void SetEuler(Vector3 euler)
        {
            var gq = Godot.Quaternion.FromEuler(new Godot.Vector3(
                (float)(euler.x * Mathf.Deg2Rad), (float)(euler.y * Mathf.Deg2Rad), (float)(euler.z * Mathf.Deg2Rad)));
            x = gq.X; y = gq.Y; z = gq.Z; w = gq.W;
        }
        public void Set(float nx, float ny, float nz, float nw) { x = nx; y = ny; z = nz; w = nw; }
        public override string ToString() => $"({x:0.###}, {y:0.###}, {z:0.###}, {w:0.###})";
        public bool Equals(Quaternion other) => x == other.x && y == other.y && z == other.z && w == other.w;
        public override bool Equals(object obj) => obj is Quaternion q && Equals(q);
        public override int GetHashCode() => x.GetHashCode() ^ (y.GetHashCode() << 2) ^ (z.GetHashCode() >> 2) ^ (w.GetHashCode() >> 4);
    }

    [Serializable]
    public struct Color : IEquatable<Color>
    {
        public float r, g, b, a;
        public Color(float r, float g, float b, float a = 1f) { this.r = r; this.g = g; this.b = b; this.a = a; }

        public static Color red => new Color(1f, 0f, 0f);
        public static Color green => new Color(0f, 1f, 0f);
        public static Color blue => new Color(0f, 0f, 1f);
        public static Color white => new Color(1f, 1f, 1f);
        public static Color black => new Color(0f, 0f, 0f);
        public static Color yellow => new Color(1f, 0.9215686f, 0.01568628f);
        public static Color cyan => new Color(0f, 1f, 1f);
        public static Color magenta => new Color(1f, 0f, 1f);
        public static Color gray => new Color(0.5f, 0.5f, 0.5f);
        public static Color grey => gray;
        public static Color clear => new Color(0f, 0f, 0f, 0f);
        public float this[int index]
        {
            get { switch (index) { case 0: return r; case 1: return g; case 2: return b; default: return a; } }
            set { switch (index) { case 0: r = value; break; case 1: g = value; break; case 2: b = value; break; default: a = value; break; } }
        }
        public static Color operator +(Color a, Color b) => new Color(a.r + b.r, a.g + b.g, a.b + b.b, a.a + b.a);
        public static Color operator -(Color a, Color b) => new Color(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);
        public static Color operator *(Color a, float b) => new Color(a.r * b, a.g * b, a.b * b, a.a * b);
        public static Color operator *(float b, Color a) => a * b;
        public static Color operator *(Color a, Color b) => new Color(a.r * b.r, a.g * b.g, a.b * b.b, a.a * b.a);
        public static bool operator ==(Color a, Color b) => a.r == b.r && a.g == b.g && a.b == b.b && a.a == b.a;
        public static bool operator !=(Color a, Color b) => !(a == b);
        public static Color Lerp(Color a, Color b, float t)
        {
            t = Mathf.Clamp01(t);
            return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
        }
        public static Color LerpUnclamped(Color a, Color b, float t)
            => new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
        public Color gamma => this;
        public Color linear => this;
        public float grayscale => (r + g + b) / 3f;
        public float maxColorComponent => Math.Max(r, Math.Max(g, b));
        public static implicit operator Godot.Color(Color c) => new Godot.Color(c.r, c.g, c.b, c.a);
        public static implicit operator Color(Godot.Color c) => new Color(c.R, c.G, c.B, c.A);
        public override string ToString() => $"RGBA({r:0.###}, {g:0.###}, {b:0.###}, {a:0.###})";
        public bool Equals(Color other) => r == other.r && g == other.g && b == other.b && a == other.a;
        public override bool Equals(object obj) => obj is Color c && Equals(c);
        public override int GetHashCode() => r.GetHashCode() ^ (g.GetHashCode() << 2) ^ (b.GetHashCode() >> 2) ^ (a.GetHashCode() >> 4);
    }

    [Serializable]
    public struct Rect
    {
        public float x, y, width, height;
        public Rect(float x, float y, float width, float height) { this.x = x; this.y = y; this.width = width; this.height = height; }
        public Rect(Vector2 position, Vector2 size) { x = position.x; y = position.y; width = size.x; height = size.y; }
        public float xMin { get => x; set { float xMax = this.xMax; x = value; this.xMax = xMax; } }
        public float yMin { get => y; set { float yMax = this.yMax; y = value; this.yMax = yMax; } }
        public float xMax { get => x + width; set { width = value - x; } }
        public float yMax { get => y + height; set { height = value - y; } }
        public Vector2 position { get => new Vector2(x, y); set { x = value.x; y = value.y; } }
        public Vector2 size { get => new Vector2(width, height); set { width = value.x; height = value.y; } }
        public Vector2 center { get => new Vector2(x + width / 2f, y + height / 2f); set { x = value.x - width / 2f; y = value.y - height / 2f; } }
        public Vector2 min { get => new Vector2(xMin, yMin); set { xMin = value.x; yMin = value.y; } }
        public Vector2 max { get => new Vector2(xMax, yMax); set { xMax = value.x; yMax = value.y; } }
        public bool Contains(Vector2 point) => point.x >= xMin && point.x < xMax && point.y >= yMin && point.y < yMax;
        public static Rect zero => new Rect(0f, 0f, 0f, 0f);
        public override string ToString() => $"(x:{x:0.###}, y:{y:0.###}, w:{width:0.###}, h:{height:0.###})";
    }

    [Serializable]
    public struct Color32 : IEquatable<Color32>
    {
        public byte r, g, b, a;
        public Color32(byte r, byte g, byte b, byte a) { this.r = r; this.g = g; this.b = b; this.a = a; }
        public static Color32 operator +(Color32 a, Color32 b) => new Color32((byte)(a.r + b.r), (byte)(a.g + b.g), (byte)(a.b + b.b), (byte)(a.a + b.a));
        public static Color32 operator -(Color32 a, Color32 b) => new Color32((byte)(a.r - b.r), (byte)(a.g - b.g), (byte)(a.b - b.b), (byte)(a.a - b.a));
        public static Color32 operator *(Color32 a, Color32 b) => new Color32((byte)(a.r * b.r), (byte)(a.g * b.g), (byte)(a.b * b.b), (byte)(a.a * b.a));
        public static Color32 operator *(Color32 a, float b) => new Color32((byte)(a.r * b), (byte)(a.g * b), (byte)(a.b * b), (byte)(a.a * b));
        public static bool operator ==(Color32 a, Color32 b) => a.r == b.r && a.g == b.g && a.b == b.b && a.a == b.a;
        public static bool operator !=(Color32 a, Color32 b) => !(a == b);
        public static implicit operator Color32(Color c) => new Color32((byte)(c.r * 255f), (byte)(c.g * 255f), (byte)(c.b * 255f), (byte)(c.a * 255f));
        public static implicit operator Color(Color32 c) => new Color(c.r / 255f, c.g / 255f, c.b / 255f, c.a / 255f);
        public static Color32 Lerp(Color32 a, Color32 b, float t)
        {
            t = Mathf.Clamp01(t);
            return new Color32((byte)(a.r + (b.r - a.r) * t), (byte)(a.g + (b.g - a.g) * t), (byte)(a.b + (b.b - a.b) * t), (byte)(a.a + (b.a - a.a) * t));
        }
        public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
            => new Color32((byte)(a.r + (b.r - a.r) * t), (byte)(a.g + (b.g - a.g) * t), (byte)(a.b + (b.b - a.b) * t), (byte)(a.a + (b.a - a.a) * t));
        public override string ToString() => $"RGBA({r}, {g}, {b}, {a})";
        public bool Equals(Color32 other) => r == other.r && g == other.g && b == other.b && a == other.a;
        public override bool Equals(object obj) => obj is Color32 c && Equals(c);
        public override int GetHashCode() => r.GetHashCode() ^ (g.GetHashCode() << 2) ^ (b.GetHashCode() >> 2) ^ (a.GetHashCode() >> 4);
    }

    //Unity ColorUtility 兼容
    public static class ColorUtility
    {
        public static bool TryParseHtmlString(string htmlString, out Color color)
        {
            color = Color.white;
            if (string.IsNullOrEmpty(htmlString)) return false;
            string s = htmlString.TrimStart('#');
            uint v = Convert.ToUInt32(s, 16);
            if (s.Length <= 6)
            {
                color = new Color(((v >> 16) & 0xFF) / 255f, ((v >> 8) & 0xFF) / 255f, (v & 0xFF) / 255f, 1f);
            }
            else
            {
                color = new Color(((v >> 24) & 0xFF) / 255f, ((v >> 16) & 0xFF) / 255f, ((v >> 8) & 0xFF) / 255f, (v & 0xFF) / 255f);
            }
            return true;
        }

        public static string ToHtmlStringRGBA(Color color)
            => $"{(byte)(color.r * 255f):X2}{(byte)(color.g * 255f):X2}{(byte)(color.b * 255f):X2}{(byte)(color.a * 255f):X2}";

        public static string ToHtmlStringRGB(Color color)
            => $"{(byte)(color.r * 255f):X2}{(byte)(color.g * 255f):X2}{(byte)(color.b * 255f):X2}";
    }

    //Unity KeyCode 枚举 — 常用键, 映射到 Godot Key
    public enum KeyCode
    {
        None = 0,
        Backspace = 8, Tab = 9, Clear = 12, Return = 13, Pause = 19, Escape = 27,
        Space = 32, Exclaim = 33, DoubleQuote = 34, Hash = 35, Dollar = 36, Percent = 37, Ampersand = 38,
        Quote = 39, LeftParen = 40, RightParen = 41, Asterisk = 42, Plus = 43, Comma = 44, Minus = 45,
        Period = 46, Slash = 47, Alpha0 = 48, Alpha1 = 49, Alpha2 = 50, Alpha3 = 51, Alpha4 = 52,
        Alpha5 = 53, Alpha6 = 54, Alpha7 = 55, Alpha8 = 56, Alpha9 = 57, Colon = 58, Semicolon = 59,
        Less = 60, Equals = 61, Greater = 62, Question = 63, At = 64,
        LeftBracket = 91, Backslash = 92, RightBracket = 93, Caret = 94, Underscore = 95, BackQuote = 96,
        A = 97, B = 98, C = 99, D = 100, E = 101, F = 102, G = 103, H = 104, I = 105, J = 106,
        K = 107, L = 108, M = 109, N = 110, O = 111, P = 112, Q = 113, R = 114, S = 115, T = 116,
        U = 117, V = 118, W = 119, X = 120, Y = 121, Z = 122,
        LeftCurlyBracket = 123, Pipe = 124, RightCurlyBracket = 125, Tilde = 126,
        Delete = 127, Keypad0 = 256, Keypad1 = 257, Keypad2 = 258, Keypad3 = 259, Keypad4 = 260,
        Keypad5 = 261, Keypad6 = 262, Keypad7 = 263, Keypad8 = 264, Keypad9 = 265,
        KeypadPeriod = 266, KeypadDivide = 267, KeypadMultiply = 268, KeypadMinus = 269,
        KeypadPlus = 270, KeypadEnter = 271, KeypadEquals = 272,
        UpArrow = 273, DownArrow = 274, RightArrow = 275, LeftArrow = 276,
        Insert = 277, Home = 278, End = 279, PageUp = 280, PageDown = 281,
        F1 = 282, F2 = 283, F3 = 284, F4 = 285, F5 = 286, F6 = 287, F7 = 288, F8 = 289,
        F9 = 290, F10 = 291, F11 = 292, F12 = 293,
        LeftShift = 304, LeftControl = 306, LeftAlt = 308, RightShift = 303, RightControl = 305, RightAlt = 307,
        LeftCommand = 310, RightCommand = 309, LeftWindows = 311, RightWindows = 312,
        Mouse0 = 323, Mouse1 = 324, Mouse2 = 325, Mouse3 = 326, Mouse4 = 327,
        JoystickButton0 = 330, JoystickButton1 = 331, JoystickButton2 = 332, JoystickButton3 = 333,
        JoystickButton4 = 334, JoystickButton5 = 335, JoystickButton6 = 336, JoystickButton7 = 337,
        JoystickButton8 = 338, JoystickButton9 = 339,
        CapsLock = 301, Numlock = 300, ScrollLock = 302
    }

    //Unity KeyCode → Godot Key 映射辅助
    internal static class KeyCodeMap
    {
        public static Godot.Key ToGodot(KeyCode code)
        {
            if (code >= KeyCode.A && code <= KeyCode.Z) return (Godot.Key)((int)code - 32); // ASCII 大写
            if (code >= KeyCode.Alpha0 && code <= KeyCode.Alpha9) return (Godot.Key)((int)code);
            if (code >= KeyCode.F1 && code <= KeyCode.F12) return (Godot.Key)(Godot.Key.F1 + ((int)code - (int)KeyCode.F1));
            switch (code)
            {
                case KeyCode.Space: return Godot.Key.Space;
                case KeyCode.Return: case KeyCode.KeypadEnter: return Godot.Key.Enter;
                case KeyCode.Escape: return Godot.Key.Escape;
                case KeyCode.Tab: return Godot.Key.Tab;
                case KeyCode.Backspace: return Godot.Key.Backspace;
                case KeyCode.Delete: return Godot.Key.Delete;
                case KeyCode.UpArrow: return Godot.Key.Up;
                case KeyCode.DownArrow: return Godot.Key.Down;
                case KeyCode.LeftArrow: return Godot.Key.Left;
                case KeyCode.RightArrow: return Godot.Key.Right;
                case KeyCode.LeftShift: case KeyCode.RightShift: return Godot.Key.Shift;
                case KeyCode.LeftControl: case KeyCode.RightControl: return Godot.Key.Ctrl;
                case KeyCode.LeftAlt: case KeyCode.RightAlt: return Godot.Key.Alt;
                case KeyCode.Home: return Godot.Key.Home;
                case KeyCode.End: return Godot.Key.End;
                case KeyCode.PageUp: return Godot.Key.Pageup;
                case KeyCode.PageDown: return Godot.Key.Pagedown;
                case KeyCode.Insert: return Godot.Key.Insert;
                case KeyCode.Minus: return Godot.Key.Minus;
                case KeyCode.Equals: return Godot.Key.Equal;
                case KeyCode.Period: return Godot.Key.Period;
                case KeyCode.Comma: return Godot.Key.Comma;
                case KeyCode.Slash: return Godot.Key.Slash;
                case KeyCode.Semicolon: return Godot.Key.Semicolon;
                case KeyCode.Quote: return Godot.Key.Apostrophe;
                case KeyCode.LeftBracket: return Godot.Key.Bracketleft;
                case KeyCode.RightBracket: return Godot.Key.Bracketright;
                case KeyCode.Backslash: return Godot.Key.Backslash;
                case KeyCode.BackQuote: return Godot.Key.Quoteleft;
                default: return Godot.Key.None;
            }
        }
    }
}
