// ============================================================
// UnityCompat — uGUI/事件桩: UnityEngine.UI.Scrollbar 与 UnityEngine.Events.UnityAction
// 若该文件被重新纳入工程, 此处桩保证其可编译; 运行时不承担实际 UI 职责
// (Godot 重制版 UI 由 GDScript 实现)。
// ============================================================
using System;

namespace UnityEngine.Events
{
    //UnityEvent 回调委托 — 原版 ChatController 用 UnityAction<string> 挂/摘 onSubmit
    public delegate void UnityAction();
    public delegate void UnityAction<T0>(T0 arg0);
    public delegate void UnityAction<T0, T1>(T0 arg0, T1 arg1);
    public delegate void UnityAction<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2);
    public class UnityEvent<T0>
    {
        private event UnityAction<T0> _listeners;
        public void AddListener(UnityAction<T0> call) => _listeners += call;
        public void RemoveListener(UnityAction<T0> call) => _listeners -= call;
        public void Invoke(T0 arg0) => _listeners?.Invoke(arg0);
    }
}

namespace UnityEngine.UI
{
    //Unity Scrollbar 兼容 — 仅保留原版脚本使用到的 value 等成员
    public class Scrollbar : Behaviour
    {
        public float value { get; set; } = 1f;
        public float normalizedValue { get => value; set => this.value = value; }
        public float size { get; set; } = 0.2f;
        public float minValue { get; set; } = 0f;
        public float maxValue { get; set; } = 1f;
        public ScrollDirection direction { get; set; }
        public bool interactable { get; set; } = true;
        public RectTransform handleRect { get; set; }
        public RectTransform targetGraphic { get; set; }
    }

    public enum ScrollDirection
    {
        LeftToRight = 0,
        RightToLeft = 1,
        BottomToTop = 2,
        TopToBottom = 3
    }
}
