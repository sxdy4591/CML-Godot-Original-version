using System;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	public class TMP_Text : Behaviour
		{
			public string text { get; set; } = string.Empty;
			public Material fontSharedMaterial { get; set; } = new Material();
			public Material material { get => fontSharedMaterial; set => fontSharedMaterial = value; }
			public Color color { get; set; } = Color.white;
			public float fontSize { get; set; } = 12f;
			public override string ToString() => text;
		}

	public class TMP_InputField : Behaviour
	{
		public string text { get; set; } = string.Empty;
		public UnityEvent<string> onSubmit { get; } = new UnityEvent<string>();
		public UnityEvent<string> onValueChanged { get; } = new UnityEvent<string>();
		public void ActivateInputField() { }
		public void Select() { }
	}
}
