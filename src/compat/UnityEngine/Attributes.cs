// ============================================================
// UnityCompat — Unity 序列化/编辑器特性桩
// 原版代码用 [SerializeField] 等特性; 移植版中仅编译期使用。
// ============================================================
using System;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class SerializeFieldAttribute : Attribute { }

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class HeaderAttribute : Attribute
	{
		public string header;
		public HeaderAttribute(string header) { this.header = header; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class TooltipAttribute : Attribute
	{
		public string tooltip;
		public TooltipAttribute(string tooltip) { this.tooltip = tooltip; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class SpaceAttribute : Attribute
	{
		public float height;
		public SpaceAttribute() { }
		public SpaceAttribute(float height) { this.height = height; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class RangeAttribute : Attribute
	{
		public float min;
		public float max;
		public RangeAttribute(float min, float max) { this.min = min; this.max = max; }
		public RangeAttribute(int min, int max) { this.min = min; this.max = max; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class MinAttribute : Attribute
	{
		public float min;
		public MinAttribute(float min) { this.min = min; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class MultilineAttribute : Attribute
	{
		public int lines;
		public MultilineAttribute() { }
		public MultilineAttribute(int lines) { this.lines = lines; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class TextAreaAttribute : Attribute
	{
		public int minLines;
		public int maxLines;
		public TextAreaAttribute() { }
		public TextAreaAttribute(int minLines, int maxLines) { this.minLines = minLines; this.maxLines = maxLines; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class HideInInspector : Attribute { }

	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ContextMenu : Attribute
	{
		public string menuName;
		public ContextMenu(string menuName) { this.menuName = menuName; }
	}

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class SerializeReference : Attribute { }
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class DisallowMultipleComponentAttribute : Attribute { }
}
