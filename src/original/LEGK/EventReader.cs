using System;
using System.Collections.Generic;
using Reader;

namespace LEGK;

internal static class EventReader
{
	public static Dictionary<string, EventDesc> events;

	private static string[] dictionary = new string[10] { "newevent", "endevent", "name", "title", "desc", "icon", "option", "result", "locked", "titleresult" };

	public static void CreateDictionary()
	{
		events = new Dictionary<string, EventDesc>();
	}

	public static Lexem CreateLexem(string text, int line)
	{
		string[] array = dictionary;
		foreach (string text2 in array)
		{
			if (text2 == text)
			{
				return new Lexem(text, text2, line);
			}
		}
		return new Lexem("", "", 0);
	}

	public static void ReadEvents(string text)
	{
		List<Lexem> list = new List<Lexem>();
		string text2 = "";
		int num = 0;
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == '<')
			{
				if (!string.IsNullOrWhiteSpace(text2))
				{
					list.Add(new Lexem(text2, "text", num));
				}
				text2 = "";
				for (i++; i < text.Length && text[i] != '>'; i++)
				{
					if (text[i] == '\n')
					{
						num++;
					}
					if (text[i] != ' ')
					{
						text2 += text[i];
					}
				}
				list.Add(CreateLexem(text2, num));
				text2 = "";
			}
			else
			{
				if (text[i] == '\n')
				{
					num++;
				}
				text2 += text[i];
			}
		}
		CreateEvents(list);
	}

	private static string NameProcessing(string text)
	{
		return text.Trim();
	}

	private static string WordProcessing(string text)
	{
		List<string> list = new List<string>();
		string[] array = text.Split('\n');
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrWhiteSpace(array[i]))
			{
				list.Add(array[i].Trim());
			}
		}
		return string.Join(" ", list.ToArray());
	}

	public static void CreateEvents(List<Lexem> list_lexems)
	{
		Lexem[] array = list_lexems.ToArray();
		string text = "";
		string desc = "";
		string title = "";
		string icon = "";
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		for (int i = 0; i < array.Length; i++)
		{
			string lexem_type = array[i].lexem_type;
			switch (ComputeStringHash(lexem_type))
			{
			case 1353374856u:
				if (!(lexem_type == "titleresult"))
				{
					break;
				}
				list4.Add(WordProcessing(array[i + 1].text));
				i++;
				continue;
			case 171406884u:
				if (!(lexem_type == "result"))
				{
					break;
				}
				list3.Add(WordProcessing(array[i + 1].text));
				i++;
				continue;
			case 2369371622u:
				if (!(lexem_type == "name"))
				{
					break;
				}
				text = NameProcessing(array[i + 1].text);
				i++;
				continue;
			case 2198011936u:
				if (!(lexem_type == "desc"))
				{
					break;
				}
				title = WordProcessing(array[i + 1].text);
				i++;
				continue;
			case 1451867211u:
			{
				if (!(lexem_type == "newevent"))
				{
					break;
				}
				int line = array[i].line;
				continue;
			}
			case 2723566662u:
				if (!(lexem_type == "endevent"))
				{
					break;
				}
				events.Add(text, new EventDesc(text, desc, title, icon, list.ToArray(), list3.ToArray(), list4.ToArray(), list2.ToArray()));
				text = "";
				title = "";
				desc = "";
				icon = "";
				list = new List<string>();
				list2 = new List<string>();
				list3 = new List<string>();
				list4 = new List<string>();
				continue;
			case 2556802313u:
				if (!(lexem_type == "title"))
				{
					break;
				}
				desc = WordProcessing(array[i + 1].text);
				i++;
				continue;
			case 3890322324u:
				if (!(lexem_type == "option"))
				{
					break;
				}
				list.Add(WordProcessing(array[i + 1].text));
				i++;
				continue;
			case 3862959600u:
				if (!(lexem_type == "icon"))
				{
					break;
				}
				icon = WordProcessing(array[i + 1].text);
				i++;
				continue;
			case 3457564819u:
				if (!(lexem_type == "locked"))
				{
					break;
				}
				list2.Add(WordProcessing(array[i + 1].text));
				i++;
				continue;
			}
			throw new Exception($"Неизвестный тип команды! Текст: {array[i].text}. Строка: {array[i].line}");
		}
	}

	internal static uint ComputeStringHash(string s)
	{
		uint num = 0u;
		if (s != null)
		{
			num = 2166136261u;
			for (int i = 0; i < s.Length; i++)
			{
				num = (s[i] ^ num) * 16777619;
			}
		}
		return num;
	}
}
