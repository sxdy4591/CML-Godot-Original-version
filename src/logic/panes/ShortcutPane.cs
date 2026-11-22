// ============================================================
// 逻辑层 — ShortcutPane: 快捷键动作表 + 执行 + 金手指.
//
// 动作表是全项目唯一的编号来源: 设置页(端游重绑)与手机快捷面板都按这份表渲染,
// 不再像旧版那样在 设置.gd / 调试控制台.gd 各写一份 13 条作弊、靠注释对齐顺序.
//
// 存储: playerprefs.ini [ui] key_action_<id>(由 UISettings 读写), 键值是
// **Godot 物理键码**(与 OS.get_keycode_string 同域), 兼容层 InputAudioPhysics 按同域读.
// 组合键: 修饰位另存 key_action_mod_<id>(1=Ctrl 2=Shift 4=Alt), 玩家自己绑.
//
// 分工:
//   0..4 / 10..12  原版已有行为 —— 这里只转发给原版(GameHost/SpeedScript/SceneManager);
//   100..112       原版 TimeScript.Update 的 Ctrl+数字 作弊语义, 逐条对齐(含难度 0 门控);
//   230/231        人口 +1亿 / 金手指开关.
// ============================================================
using System;
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class ShortcutPane : IPanel
{
	public string Name => "快捷键";

	// ================= 动作表 =================

	public readonly struct Entry
	{
		public readonly int Id;
		public readonly string Group;
		public readonly string Label;
		// 玩家没在设置里绑过该动作时用的默认键(Godot 物理键码, 与 OS.get_keycode_string 同域); 0 = 无默认
		public readonly int DefaultKey;
		public Entry(int id, string group, string label, int defaultKey = 0)
		{
			Id = id;
			Group = group;
			Label = label;
			DefaultKey = defaultKey;
		}
	}

	// 时间/速度/存档/战争: id 与 playerprefs 的 key_action_0..12 一一对应
	// (10..12 = 原版 F5/F9/W, 由兼容层做别名判定; 0..4 同理).
	static readonly Entry[] Table = BuildTable();

	static Entry[] BuildTable()
	{
		var list = new List<Entry>();
		list.Add(new Entry(0, "时间", "暂停/继续"));
		list.Add(new Entry(1, "时间", "一速"));
		list.Add(new Entry(2, "时间", "二速"));
		list.Add(new Entry(3, "时间", "三速"));
		list.Add(new Entry(4, "时间", "四速"));
		list.Add(new Entry(10, "存档", "保存"));
		list.Add(new Entry(11, "存档", "读取"));
		list.Add(new Entry(12, "存档", "战争面板"));

		list.Add(new Entry(100, "作弊", "党内支持 +10"));
		list.Add(new Entry(101, "作弊", "人民支持 +10"));
		list.Add(new Entry(102, "作弊", "思想自由 +10"));
		list.Add(new Entry(103, "作弊", "生活水平 +10"));
		list.Add(new Entry(104, "作弊", "国际声望 +10"));
		list.Add(new Entry(105, "作弊", "全球影响力 +10"));
		list.Add(new Entry(106, "作弊", "预算 +10"));
		list.Add(new Entry(107, "作弊", "特工网络 +10"));
		list.Add(new Entry(108, "作弊", "军事力量 +10"));
		list.Add(new Entry(109, "作弊", "美苏关系 +10"));
		list.Add(new Entry(110, "作弊", "阵营援助开关"));
		list.Add(new Entry(111, "作弊", "国际声望 -10"));
		list.Add(new Entry(112, "作弊", "军事成绩 +10"));

		list.Add(new Entry(230, "超级", "人口 +1亿"));
		list.Add(new Entry(231, "超级", "金手指模式"));

		// 事件界面选项: 240..245 勾选选项 1..6, 246/247 上下一个选项.
		// 默认键 = 数字 1..6 与 上下键(Godot 物理键码); 事件场景里这套键没有别的消费者
		// (原版 1..4 变速只在外部世界场景生效), 玩家可在设置页改成任意键.
		list.Add(new Entry(240, "事件", "选项1", (int)Godot.Key.Key1));
		list.Add(new Entry(241, "事件", "选项2", (int)Godot.Key.Key2));
		list.Add(new Entry(242, "事件", "选项3", (int)Godot.Key.Key3));
		list.Add(new Entry(243, "事件", "选项4", (int)Godot.Key.Key4));
		list.Add(new Entry(244, "事件", "选项5", (int)Godot.Key.Key5));
		list.Add(new Entry(245, "事件", "选项6", (int)Godot.Key.Key6));
		list.Add(new Entry(246, "事件", "上一个选项", (int)Godot.Key.Up));
		list.Add(new Entry(247, "事件", "下一个选项", (int)Godot.Key.Down));
		return list.ToArray();
	}

	public static IReadOnlyList<Entry> Actions => Table;

	// ================= 快照 =================

	public Dictionary<string, object> Snapshot()
	{
		var actions = new List<object>(Table.Length);
		foreach (var entry in Table)
		{
			actions.Add(new Dictionary<string, object>
			{
				["id"] = entry.Id,
				["group"] = entry.Group,
				["label"] = entry.Label,
				["key"] = entry.DefaultKey,
			});
		}
		return new PanelSnapshot()
			.Put("actions", actions)
			.Put("gold", GoldFinger ? 1 : 0)
			.Put("diff", GameHost.State.diff)
			.Build();
	}

	// ================= 执行 =================

	public void Act(string action, List<object> args)
	{
		switch (action)
		{
			case "执行":
				Run((int)(long)args[0]);
				break;
			default:
				throw new ArgumentOutOfRangeException(nameof(action), action, "快捷键面板没有该动作");
		}
	}

	public static void Run(int id)
	{
		// 事件选项: 只是事件界面的选中导航, 没有游戏数值可改, 语义按编号转发给视图
		if (id >= 240 && id <= 247)
		{
			UiEvents.RequestEventShortcut(id);
			return;
		}
		var state = GameHost.State;
		if (id >= 0 && id <= 4)
		{
			if (id == 0) GameHost.ToggleTime();
			else GameHost.SetSpeed(id);
			return;
		}
		switch (id)
		{
			case 10: GameHost.QuickSave(); return;
			case 11: GameHost.QuickLoad(); return;
			case 12: UiEvents.RequestScene("War"); return;
		}
		if (id >= 100 && id <= 112)
		{
			// 原版 TimeScript.Update: 作弊键整块包在 globalState.diff == 0 里
			if (state.diff != 0) return;
			Cheat(id - 100);
			return;
		}
		switch (id)
		{
			case 230: Population(1000); return;   // data[34] 1 单位 = 10 万人 → 1 亿 = 1000
			case 231: ToggleGoldFinger(); return;
			default:
				throw new ArgumentOutOfRangeException(nameof(id), id, "没有这个快捷键动作");
		}
	}

	// ================= 作弊(逐条对齐 TimeScript.Update 的 Ctrl+数字) =================

	// 调试台的 cheat 命令不限难度(它本来就是调试口), 所以单独暴露 internal.
	internal static void Cheat(int action)
	{
		var state = GameHost.State;
		switch (action)
		{
			case 0: state.data[1] += 100; break;
			case 1: state.data[3] += 100; break;
			case 2: state.data[4] += 100; break;
			case 3: state.data[5] += 100; break;
			case 4: state.data[6] += 100; break;
			// 原版写的是 influencePRC(真值); data[7] 只是 KumihaRepaint 每天覆写的缓存,
			// 改它下次结算就被抹掉 —— 旧实现的"影响力作弊无效"就是写错了字段.
			case 5: state.influencePRC += 100; break;
			case 6: state.data[8] += 100; break;
			case 7: state.data[9] += 100; break;
			case 8: state.data[22] += 100; break;
			case 9:
				state.empires[0].relations += 100;
				state.empires[1].relations += 100;
				break;
			case 10: state.relres = !state.relres; break;
			case 11: state.data[6] -= 100; break;
			case 12: state.data[0] += 100; break;
			default:
				throw new ArgumentOutOfRangeException(nameof(action), action, "作弊动作只有 0-12");
		}
		// Table 前 8 项是时间/存档(0..4、10..12), 作弊从 8 号位开始
		UiEvents.Toast(Table[8 + action].Label);
	}

	// ================= 人口 =================

	static void Population(int units)
	{
		var state = GameHost.State;
		state.data[34] += units;
		UiEvents.Toast($"人口 +{units / 1000}亿");
	}

	// ================= 金手指 =================

	// 上限依据: TimeScript.BoundsOfVariables() 的硬钳制(逐行对齐原版取值),
	// 其余没有硬上限的项取 9999 —— 远高于原版任何判定阈值(影响力最高判定 5000),
	// 且距 int 上限(21 亿)有六个数量级的余量, 不会溢出.
	const int PartyCap = 1000;        // data[1]  党内支持  BoundsOfVariables
	const int PeopleCap = 1000;       // data[3]  人民支持
	const int LivingCap = 1500;       // data[5]  生活水平
	const int IndustryCap = 1500;     // data[12] 工业
	const int AgricultureCap = 1500;  // data[13] 农业
	const int ServiceCap = 1500;      // data[68] 服务业
	const int CorruptionFloor = 0;    // data[26] 腐败
	const int OpenCap = 9999;

	public static bool GoldFinger { get; private set; }

	static void ToggleGoldFinger()
	{
		GoldFinger = !GoldFinger;
		if (GoldFinger) Apply();
		UiEvents.Toast(GoldFinger ? "金手指模式 开启" : "金手指模式 关闭");
	}

	// GameHost.Tick 每帧调用: 开关打开时把各项钉在最高/最低
	public static void Apply()
	{
		if (!GoldFinger) return;
		var state = GameHost.State;
		state.data[1] = PartyCap;
		state.data[3] = PeopleCap;
		state.data[5] = LivingCap;
		state.data[12] = IndustryCap;
		state.data[13] = AgricultureCap;
		state.data[68] = ServiceCap;
		state.data[26] = CorruptionFloor;
		state.data[8] = OpenCap;
		state.data[9] = OpenCap;
		state.data[22] = OpenCap;
		state.data[0] = OpenCap;
		state.data[11] = OpenCap;
		state.influencePRC = OpenCap;
		state.empires[0].relations = 1000;   // BoundsOfVariables: 关系 0..1000
		state.empires[1].relations = 1000;
	}

	// 新局/读档时复位: 金手指是"本局状态", 不跟着存档走
	public static void Reset()
	{
		GoldFinger = false;
	}
}
