using EventsForDLC;
using UnityEngine;

public class Event375 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[765];
		text = string.Format(GlobalScript.inst.new_events_text[766], "\n", (a.allcountries[35].proprc && a.allcountries[35].okb) ? GlobalScript.inst.new_events_text[775] : null);
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (a.allcountries[35].proprc && a.allcountries[35].okb)
		{
			kolvo_variant = 5;
		}
		else
		{
			kolvo_variant = 4;
		}
		if (a.data[22] >= 500 && a.data[8] + a.data[36] >= 250)
		{
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[767], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 250)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 25f);
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[776], 50f);
		}
		button_text[1] = string.Format(GlobalScript.inst.new_events_text[768], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		button_text[2] = string.Format(GlobalScript.inst.new_events_text[769], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		if (a.allcountries[35].proprc && a.allcountries[35].okb)
		{
			if (a.data[22] >= 500 && a.data[8] + a.data[36] >= 350)
			{
				button_text[3] = string.Format(GlobalScript.inst.new_events_text[770], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (a.data[8] + a.data[36] < 350)
			{
				Object.Destroy(button[3]);
				button_text[3] = string.Format(GlobalScript.inst.new_events_text[566], 35f);
			}
			else
			{
				Object.Destroy(button[3]);
				button_text[3] = string.Format(GlobalScript.inst.new_events_text[776], 50f);
			}
			if (a.data[8] + a.data[36] >= 100)
			{
				button_text[4] = string.Format(GlobalScript.inst.new_events_text[771], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
				return;
			}
			Object.Destroy(button[4]);
			button_text[4] = string.Format(GlobalScript.inst.new_events_text[566], 35f);
		}
		else if (a.data[8] + a.data[36] >= 100 && a.data[22] >= 250 && a.allcountries[51].Torg)
		{
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[772], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (!a.allcountries[51].Torg)
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[658], 10f);
		}
		else if (a.data[8] + a.data[36] < 100)
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[566], 10f);
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[776], 35f);
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[765];
		switch (result_num)
		{
		case 0:
		{
			a.data[8] -= 250;
			a.data[22] -= 500;
			int num3 = 0;
			if (a.influencePRC >= 750)
			{
				text = string.Format(GlobalScript.inst.new_events_text[777], "\n", (num3 <= 0) ? null : ((num3 == 1) ? GlobalScript.inst.new_events_text[780] : GlobalScript.inst.new_events_text[781]));
				a.allcountries[84].JoinAllOurAlliances(yes: true).EstablishGovernment(Government.ProChina);
				GlobalScript.inst.gameState.allcountries[84].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
				GlobalScript.inst.gameState.allcountries[84].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
				a.empires[1].power -= 50;
				a.influencePRC += 80;
				a.data[1] += 300;
				a.empires[1].relations -= 500;
				a.empires[0].relations += 300;
				if (a.relres)
				{
					a.relres = false;
				}
				break;
			}
			text = string.Format(GlobalScript.inst.new_events_text[778], "\n", (num3 <= 0) ? null : ((num3 == 1) ? GlobalScript.inst.new_events_text[780] : GlobalScript.inst.new_events_text[781]));
			a.data[127] = 1;
			a.influencePRC -= 50;
			if (a.allcountries[7].parts[1])
			{
				a.allcountries[7].parts[1] = false;
				a.allcountries[7].parts[2] = true;
			}
			else
			{
				a.allcountries[7].parts[0] = true;
			}
			a.empires[1].power += 100;
			a.empires[1].relations -= 500;
			a.data[1] -= 300;
			if (a.relres)
			{
				a.relres = false;
			}
			break;
		}
		case 1:
			text = " 中 国 外 交 部 代 表 在 发 言 中 表 达 了 对 苏 联 占 据 伊 斯 坦 布 尔 海 峡 的 肯 定 ， 称 其 为 “ 打 击 帝 国 主 义 ， 维 护 苏 联 国 家 安 全 ” 的 明 智 决 策 。 这 使 得 国 际 社 会 普 遍 将 我 们 与 苏 联 侵 略 者 并 列 进 行 谴 责 ， 而 罗 曼 诺 夫 则 表 达 了 对 我 方 支 持 的 感 谢 。|| 苏 联 已 经 开 始 向 内 陆 推 进 。 从 保 加 利 亚 方 向 出 动 的 部 队 占 领 了 土 耳 其 的 欧 洲 部 分 与 海 峡 ， 驻 守 在 那 里 的 美 军 则 接 到 了 撤 往 希 腊 地 区 ， 以 防 冲 突 升 级 的 命 令 。 ||联 合 国 安 理 会 通 过 了 谴 责 苏 联 侵 略 的 决 议 ， 但 除 了 对 苏 联 引 入 新 一 轮 制 裁 外 ， 没 有 采 取 新 的 决 定 。";
			if (a.allcountries[7].parts[1])
			{
				a.allcountries[7].parts[1] = false;
				a.allcountries[7].parts[2] = true;
			}
			else
			{
				a.allcountries[7].parts[0] = true;
			}
			a.data[6] += 100;
			a.empires[1].power += 100;
			a.empires[1].relations += 300;
			a.empires[0].relations -= 500;
			a.data[1] -= 300;
			break;
		case 2:
			text = string.Format(GlobalScript.inst.new_events_text[779], "\n");
			a.data[1] -= 300;
			a.empires[1].power += 100;
			if (a.allcountries[7].parts[1])
			{
				a.allcountries[7].parts[1] = false;
				a.allcountries[7].parts[2] = true;
			}
			else
			{
				a.allcountries[7].parts[0] = true;
			}
			break;
		case 3:
		case 4:
			if (a.allcountries[35].proprc && a.allcountries[35].okb)
			{
				switch (result_num)
				{
				case 3:
				{
					a.data[8] -= 350;
					a.data[22] -= 500;
					int num2;
					if (a.influencePRC > 500 && a.allcountries[35].proprc && a.allcountries[35].okb)
					{
						num2 = 1;
						a.allcountries[84].parts[3] = true;
						a.data[6] += 50;
						a.data[1] += 100;
						a.empires[0].relations -= 150;
					}
					else
					{
						a.data[1] -= 100;
						num2 = 2;
						a.data[6] += 50;
						a.empires[0].relations -= 150;
					}
					if (a.influencePRC >= 750)
					{
						text = string.Format(GlobalScript.inst.new_events_text[777], "\n", (num2 <= 0) ? null : ((num2 == 1) ? GlobalScript.inst.new_events_text[780] : GlobalScript.inst.new_events_text[781]));
						a.allcountries[84].JoinAllOurAlliances(yes: true).EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[84].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
						GlobalScript.inst.gameState.allcountries[84].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
						a.empires[1].power -= 50;
						a.data[1] += 300;
						a.empires[1].relations -= 500;
						a.empires[0].relations += 300;
						if (a.relres)
						{
							a.relres = false;
						}
						break;
					}
					text = string.Format(GlobalScript.inst.new_events_text[778], "\n", (num2 <= 0) ? null : ((num2 == 1) ? GlobalScript.inst.new_events_text[780] : GlobalScript.inst.new_events_text[781]));
					a.data[127] = 1;
					a.influencePRC -= 50;
					if (a.allcountries[7].parts[1])
					{
						a.allcountries[7].parts[1] = false;
						a.allcountries[7].parts[2] = true;
					}
					else
					{
						a.allcountries[7].parts[0] = true;
					}
					a.empires[1].relations -= 500;
					a.data[1] -= 300;
					if (a.relres)
					{
						a.relres = false;
					}
					break;
				}
				case 4:
				{
					if (a.allcountries[7].parts[1])
					{
						a.allcountries[7].parts[1] = false;
						a.allcountries[7].parts[2] = true;
					}
					else
					{
						a.allcountries[7].parts[0] = true;
					}
					a.data[6] += 100;
					a.empires[1].power += 100;
					a.empires[1].relations += 300;
					a.empires[0].relations -= 500;
					int num;
					if (a.influencePRC > 500 && a.allcountries[35].proprc && a.allcountries[35].okb)
					{
						num = 1;
						a.allcountries[84].parts[3] = true;
						a.data[6] += 50;
						a.data[1] += 100;
						a.empires[0].relations -= 150;
					}
					else
					{
						a.data[1] -= 100;
						num = 2;
						a.data[6] += 50;
						a.empires[0].relations -= 150;
					}
					text = string.Format(GlobalScript.inst.new_events_text[777], "\n", (num <= 0) ? null : ((num == 1) ? GlobalScript.inst.new_events_text[780] : GlobalScript.inst.new_events_text[781]));
					break;
				}
				}
			}
			else
			{
				if (result_num != 3)
				{
					break;
				}
				text = string.Format(GlobalScript.inst.new_events_text[783], "\n");
				a.data[8] -= 100;
				a.data[22] -= 250;
				if (a.influencePRC + a.empires[0].power >= 750)
				{
					text = string.Format(GlobalScript.inst.new_events_text[782], "\n", "\n");
					a.allcountries[84].JoinAllOurAlliances(yes: true).EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[84].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
					GlobalScript.inst.gameState.allcountries[84].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
					a.empires[1].power -= 50;
					a.influencePRC += 80;
					a.data[1] += 300;
					a.empires[1].relations -= 500;
					a.empires[0].relations += 300;
					if (a.relres)
					{
						a.relres = false;
					}
					break;
				}
				text = string.Format(GlobalScript.inst.new_events_text[783], "\n");
				a.data[127] = 1;
				a.influencePRC -= 50;
				if (a.allcountries[7].parts[1])
				{
					a.allcountries[7].parts[1] = false;
					a.allcountries[7].parts[2] = true;
				}
				else
				{
					a.allcountries[7].parts[0] = true;
				}
				a.empires[1].power += 100;
				a.empires[1].relations -= 500;
				a.data[1] -= 300;
				if (a.relres)
				{
					a.relres = false;
				}
			}
			break;
		}
	}
}
