// 原版内核宿主: 立起 GlobalScript / GameState / TimeScript, 开局, 速度.
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using CML.Logic.Port;

namespace CML.Logic;

public static class GameHost
{
	public static GlobalScript Global { get; private set; }
	public static TimeScript Clock { get; private set; }
	public static GameState State => Global.gameState;
	public static int Speed => Global.speed;
	public static bool Booted => Global != null;

	public static void Boot()
	{
		PanelRouter.RegisterAll();

		var state = new GameState();
		// GlobalScript 不是场景对象: 生命周期由本类按原版顺序手动驱动(Init), 不进泵.
		Global = new GlobalScript { gameState = state };
		Stub.Detach(Global);
		Global.Init();
		for (var i = 0; i < Global.dlc.Length; i++) Global.dlc[i] = true;

		GameStateFactory.Fill(state);
		StartNewGame(1);
		// decisions 的文案来自 new_texts, 必须等 GameStartScript 载入文本后才建
		Global.CreateDecisions();
		Clock = TimeHostFactory.Create();
		// 首局也要清: 替身组件在进程内复用, 上一局的图标/计时不能带进新局
		ResetTimeHostState();
	}

	public static void StartNewGame(int number)
	{
		// 设置页改难度只落 playerprefs [ui] difficulty; 开局数据读的是 gameState.diff,
		// 它只在启动时由 GlobalScript.Init 从 PlayerPrefs("our_diff_in") 读过一次.
		// 这里重同步, 否则改完难度开新档还是启动时的那个难度.
		var 难度 = ReadDifficultySetting();
		SetDifficulty(难度);
		Global.gameState.diff = 难度;
		// 焦点树是静态字典, 重开局必须清空, 否则 CreateTree 会因同名 key 抛重复键异常
		KGFocus.FocusManager.all_trees.Clear();
		NewGameSetup.Reset(Global.gameState);
		ResetRoundState();
		// 重开局时时钟已存在; 首局由 Boot 在 Create 之后调用
		ResetTimeHostState();

		var starter = Stub.Take<GameStartScript>("GameStarter", Lifecycle.Lazy);
		starter.Set("number", number);
		starter.Invoke("OnMouseDown");
		DataContract.Verify(Global.gameState);
		NewGameSetup.ApplyOpeningData(Global.gameState);

		// GameStartScript 会按 Country_data 重建国家数组(长度与 parts 槽都会缩水);
		// 旧的 Unity 存档更是只有 99 国, 统一按 1.132 口径补齐
		GameStateFactory.EnsureCapacity(Global.gameState);
		// GameStartScript 把 iron_and_blood 设成 diff>=2; 移植版不受难度限制, 开局后统一打开
		成就不设限();
	}

	static int ReadDifficultySetting()
	{
		var cfg = new Godot.ConfigFile();
		cfg.Load("user://playerprefs.ini");
		return (int)cfg.GetValue("ui", "difficulty", 2);
	}

	// 原版 TimeScript.Reborn(): 1986-1-1 自动打开 ending 面板并停表(见 TimeScript.Repaint 的
	// data[19]==1 && data[20]==1 && data[21]==1986 分支). 移植版时钟常驻, 视图按这个状态弹 1986 抉择.
	public static bool RetireOpen => Clock.ending.activeSelf;

	public static void SetSpeed(int speed)
	{
		// SpeedScript.OnMouseDown 会读 map1.okno.active; okno 由外交宿主装配
		Port.DiploHost.Ensure();
		Clock.probel.GetComponent<SpeedScript>().adad(speed);
	}

	// 设置页 [ui] event_pause_after: 事件结束回到外交后是否停表(默认 true).
	// 这项设置以前只有默认值、没有消费者 —— 事件结束后总是按原速度继续跑.
	public static bool EventPauseAfter
	{
		get
		{
			var cfg = new Godot.ConfigFile();
			cfg.Load("user://playerprefs.ini");
			return (bool)cfg.GetValue("ui", "event_pause_after", true);
		}
	}

	// 停表(原版暂停就是 speed = 0)
	public static void PauseTime() => Global.speed = 0;

	// 原版 TimeScript.Update 的空格: SpeedScript.Probel() 暂停/恢复
	public static void ToggleTime()
	{
		Port.DiploHost.Ensure();
		Clock.probel.GetComponent<SpeedScript>().Probel();
	}

	// 原版 F5/F9: TimeScript.AutoSaveMethod 走的是旧格式 Savescript,
	// 移植版存档统一在 SaveService(与存档界面同格式), 槽位取设置页的"保存槽位".
	public static void QuickSave() => Port.SaveService.Save(State, Port.SavePaths.Slot(Global.savePlace));

	public static void QuickLoad()
	{
		ReplaceState(Port.SaveService.Load(Port.SavePaths.Slot(Global.savePlace)));
		UiEvents.RequestScene("Diplomacy");
	}

	// 读档: 换掉 gameState 并重链时钟.
	public static void ReplaceState(GameState state)
	{
		// 旧版本(Unity)存档的数组是旧口径(如 allcountries 99、data 150): 不补齐的话
		// 地图按 168 国取索引、外交按 200 槽摆、开新局按 167 行写国家名, 全是越界.
		GameStateFactory.EnsureCapacity(state);
		Global.gameState = state;
		// 原版 LoadInScript.OnMouseDown 就是读档入口: 重新载入文本表(new_texts/old_modify_*)、
		// 按存档状态重算修正文案、重建决策对象. 文本表不在 GameState 里, 不做这一步
		// 概览里的动态文案会退回基础文本(事件/时间脚本往 old_modify_desc 追加的内容全丢).
		执行原版读档后处理();
		// 政治界面的名字表是静态对象图里的克隆, 读档后必须重指(见 PoliticsHost.RefreshNames)
		PoliticsHost.RefreshNames();
		typeof(TimeScript).GetField("global2", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
			.SetValue(Clock, state);
		ResetRoundState();
		ResetTimeHostState();
		// 原版读档会重新载入外交场景: MapChangesScript.Awake → EventWrite(gameState)
		// 按存档里的 Events_active/time/number 把地图事件图标摆回来.
		// 这里没有场景重载, 不显式补这一句, 存档时停在图上的事件读档后就消失了.
		Port.DiploHost.Ensure();
		Port.DiploHost.Ui.Map.EventWrite(state);
		成就不设限();
		去重战争();
		// 存档里那条欧加登战争是反序列化出来的副本, 与进程里 Wars.O 指向的对象不是同一个;
		// 不重指的话焦点再次 DecleredWar 会追加第二条, 且 WarEnds/AttackerInfluence 作用在
		// 不在列表里的静态对象上 —— 玩家看到的就是"多出来一场欧加登战争".
		重指欧加登战争();
	}

	// ---------- 原版读档后处理 ----------
	// 原版 LoadInScript.OnMouseDown 的完整流程是:
	//   读槽位元信息 → 重载全部文本表 → LoadYugoSave(读 state) → CreateDecisions ×2 → 切外交
	//   → 按 state 重算修正文案.
	// 移植版存档是 SaveService 格式, 槽位文件不在 NewData 下, 所以让它走"文件不存在"分支:
	// LoadYugoSave 不动刚读入的 state, 只执行文本表重载与文案重算(以及原版的两次 CreateDecisions).
	// 切场景在这里抑制(由调用方统一发 scene_requested), 避免同一请求切两次.
	const int 原版占位槽 = 1000000;
	static Stub _loadScript;

	static void 执行原版读档后处理()
	{
		_loadScript ??= Stub.Take<LoadInScript>("LoadScript", Lifecycle.Lazy).Set("number", 原版占位槽);
		var 键 = "data14" + (原版占位槽 + 10);
		UnityEngine.PlayerPrefs.SetInt(键, 0);
		var 抑制 = SceneRouter.SuppressLoadScene;
		SceneRouter.SuppressLoadScene = true;
		try
		{
			_loadScript.Invoke("OnMouseDown");
		}
		finally
		{
			SceneRouter.SuppressLoadScene = 抑制;
			SceneRouter.ConsumeCapturedScene();
			UnityEngine.PlayerPrefs.DeleteKey(键);
		}
	}

	// 移植版没有 Steam, 原版的 iron_and_blood 门控只为成就服务; 玩家要求成就不受难度/读档影响.
	static void 成就不设限() => Global.gameState.iron_and_blood = true;

	// 新局/读档共用: 清掉"每局重新开始"的静态缓存与一次性计时,
	// 否则上一档的状态会延续到新档(地图颜色缓存、事件需求日、战争去重月、自动化进度).
	static void ResetRoundState()
	{
		_autoSaveDay = -1;
		_eventRequirementsDay = -1;
		_warDedupMonth = -1;
		Automation.Reset();
		Panes.MapPane.InvalidateColors();
		Panes.ShortcutPane.Reset();
	}

	// 时钟替身是进程内单例: 警报图标一旦被 SetActive(true) 就不会自己熄灭(原版 AlarmIconChange 只亮不灭).
	// 首局由 Boot 在创建时钟后调用; 重开/读档在这里关掉全部图标, 再交给原版的月度判定重新点亮.
	static void ResetTimeHostState()
	{
		if (Clock == null) return;
		foreach (var icon in Clock.alarmIcons) icon.SetActive(false);
		// 原版新局/读档会重建整个外交场景, events[] 是场景里预置的 inactive 对象;
		// 移植版时钟常驻, 上一档停在图上的事件不倒回 inactive 就会带进新档
		// (读档时随后由 ReplaceState 的 EventWrite 按存档重新点亮).
		foreach (var marker in Clock.events) marker.SetActive(false);
		// 1986 抉择面板同理: 上一局弹过(is_showed=true)或停在打开状态, 新局到 1986 就永远走不到 Reborn 的打开分支
		Clock.ending.SetActive(false);
		Clock.is_showed = false;
	}

	// 原版 TimeScript 是 Diplomacy 场景对象: 切到经济/政治/事件等独立场景时它随场景卸载,
	// 时间与事件倒计时全部停住. 移植后时钟常驻, 由桥层按当前场景开关这里.
	static bool _mainScene;
	public static void SetMainScene(bool active) => _mainScene = active;

	static readonly System.Reflection.MethodInfo ClockUpdateMethod =
		typeof(TimeScript).GetMethod("Update",
			System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);


	// 原版 DiffScript 把难度写进 PlayerPrefs("our_diff_in"), GlobalScript.Init 再读回 gameState.diff;
	// GameStartScript 按 diff 设置开局数据(牛棚小酌 0: 预算 +500 = 53.0).
	public static void SetDifficulty(int difficulty)
	{
		UnityEngine.PlayerPrefs.SetInt("our_diff_in", difficulty);
		UnityEngine.PlayerPrefs.Save();
	}

	// ================= 每帧推进 =================
	// 桥层只负责每帧叫一次 + 把"高亮集合变了"翻译成信号; 是否推进由当前场景决定.
	public static void Tick(double delta)
	{
		if (!_mainScene) return;
		MaybeAutoSave();
		TickWarDedup();
		Automation.Tick();
		Panes.MapPane.Tick();
		// 金手指: 开关打开时每帧把数值钉在最高/最低(见 ShortcutPane.Apply 的上限依据)
		Panes.ShortcutPane.Apply();
		// 原版 Update: 时间推进 + 每日事件需求挂载 + 事件图标超时(会自动切事件场景)
		ClockUpdateMethod.Invoke(Clock, null);
		TickEventMarker(delta);
	}

	// ================= 地图事件图标 =================
	// 原版流程: TimeScript.EventsRequirements() 在每日结算里把事件挂到 events[0],
	// 之后由 EventScript.Update 倒计时, 到 0 或点击进入事件场景.
	// 移植后两者都由 GameHost.Tick 按游戏时间推进, 与视图刷新频率无关.
	static readonly System.Reflection.MethodInfo EventsRequirementsMethod =
		typeof(TimeScript).GetMethod("EventsRequirements",
			System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
	static readonly System.Reflection.MethodInfo EventUpdateMethod =
		typeof(EventScript).GetMethod("Update",
			System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
	static readonly System.Reflection.MethodInfo EventMouseDownMethod =
		typeof(EventScript).GetMethod("OnMouseDown",
			System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
	static int _eventRequirementsDay = -1;

	public static void TickEventMarker(double delta)
	{
		// 事件只在时间推进时结算
		if (Global.speed <= 0) return;
		// 原版按"每天一次"挂事件; 这里按游戏日门控, 不每帧把几百条条件重算一遍.
		var day = Global.gameState.data[21] * 10000 + Global.gameState.data[20] * 100 + Global.gameState.data[19];
		if (day != _eventRequirementsDay)
		{
			_eventRequirementsDay = day;
			EventsRequirementsMethod.Invoke(Clock, null);
		}

		var marker = Clock.events[0];
		if (!marker.activeSelf)
		{
			return;
		}
		var script = marker.GetComponent<EventScript>();
		// 超时结算(扣预算/特工、记 event_done、停表、切场景)全在 EventScript.Update 里,
		// TimeHostFactory 已停掉泵, 这里把时间压到阈值内直接调原版, 不复制它的结算.
		if (script.time <= 0.1f)
		{
			script.time = 0.05f;
			EventUpdateMethod.Invoke(script, null);
			return;
		}
		// 原版 EventScript 倒计时以"游戏时间"计: 每游戏日 8 单位(TimeScript 的日阈值),
		// 本端口日阈值是 1.2, 按比例换算, 否则日期跑快了, 事件会被推迟好几个月.
		script.time -= (float)delta * Global.speed * (8f / 1.2f);
	}

	// 原版 EventScript.OnMouseDown: 点击地图事件图标进入事件场景
	public static void OpenEventIcon()
	{
		var marker = Clock.events[0];
		if (!marker.activeSelf) return;
		EventMouseDownMethod.Invoke(marker.GetComponent<EventScript>(), null);
	}

	// ================= 战争去重 =================
	// 原版 KGWars.Wars.O 是进程级静态单例, War.DecleredWar() 每次都往 ingamewars 末尾追加
	// (没有"已宣战"检查). 移植版是长驻进程: 焦点层在 active() 抛异常时会整层重跑,
	// 存档/读档边界也可能让同一层再执行, 结果同一场欧加登战争被追加两条(同引用).
	// 原版每月结算时按引用去重; 读档后立即去重一次, 把重复位置换成已结束的空位
	// (不能把战争本身 is_going 置 false: 同引用会把唯一那条一起关掉, 战争凭空消失).
	public static void 去重战争()
	{
		var state = Global.gameState;
		var 已见 = new HashSet<warinwars>();
		var 已见定义 = new HashSet<string>();
		for (var i = 0; i < state.ingamewars.Length; i++)
		{
			var war = state.ingamewars[i];
			if (!war.is_going) continue;
			// 跨进程读档时 Wars.O 是新建对象, 与存档里那条不是同一引用, 所以再按
			// 战争定义(名称+双方)收拢 —— 原版只有 Wars.O 一场欧加登战争, 同名同双方即同一场.
			// 旧版本战争面板会把战名就地改成中文, 存档里留下的中文名按同一场归一.
			var 定义 = 战争定义(war);
			if (!已见.Add(war) || !已见定义.Add(定义))
			{
				state.ingamewars[i] = new warinwars { is_going = false };
			}
		}
	}

	// 战名/side 的本地化别名归一(视图只翻译输出, 存档里可能有旧版本写下的中文名)
	static string 战争定义(warinwars war)
		=> 归一(war.name_war) + "\u0001" + 归一(war.side1) + "\u0001" + 归一(war.side2);

	static string 归一(string text) => text switch
	{
		" 欧加登战争" => "Война за Огаден",
		" 索马里" => "Сомали",
		" 埃塞俄比亚" => "Эфиопия",
		_ => text,
	};

	// 读档后把 KGWars.Wars.O 的 target_war 指回存档里的那条(焦点/战争结算全部经由它).
	// 存档里没有这场战争时不动 —— 那是"没打过", 保持原版初始对象.
	static void 重指欧加登战争()
	{
		var state = Global.gameState;
		var o = (warinwars)typeof(KGWar.War)
			.GetField("target_war", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
			.GetValue(KGWars.Wars.O);
		var 目标 = 归一(o.name_war) + "\u0001" + 归一(o.side1) + "\u0001" + 归一(o.side2);
		foreach (var war in state.ingamewars)
		{
			if (!war.is_going || 战争定义(war) != 目标) continue;
			typeof(KGWar.War)
				.GetField("target_war", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
				.SetValue(KGWars.Wars.O, war);
			return;
		}
	}

	static int _warDedupMonth = -1;

	public static void TickWarDedup()
	{
		var state = Global.gameState;
		var month = state.data[21] * 100 + state.data[20];
		if (month == _warDedupMonth) return;
		_warDedupMonth = month;
		去重战争();
	}

	// ================= 自动存档 =================
	// 原版 Savescript 写 NewData/*.save(旧格式), 与存档界面的 SaveService 不互通,
	// 且槽位取全局 savePlace(会覆盖手动档)。这里由逻辑层接管: 按原版时间条件
	// (每月 1 日 / 每 6 个月 1 日) 写独立的 0 号自动槽, 界面与手动档同格式.
	static int _autoSaveDay = -1;

	// 玩家自动存档模式(0关/1每月/2半年): 与保存槽位一起从设置页推来.
	// 原版 GlobalScript.autosavej 保持 0 —— 原版自动存档用 BinaryFormatter, .NET 10 已移除;
	// 移植版自动存档全部走 SaveService(见 MaybeAutoSave).
	static int _autoSaveMode = 1;

	// 自动存档目标槽(0=关闭): 槽位无限, 由玩家在存档界面的行按钮任意指定, 不再固定 0 号独立槽.
	static int _autoSaveSlot = 1;

	public static int AutoSaveSlot => _autoSaveSlot;

	public static void SetAutoSlot(int slot) => _autoSaveSlot = slot;

	public static void SetSaveOptions(int mode, int place)
	{
		_autoSaveMode = mode;
		Global.savePlace = place;
		Global.autosavej = 0;
	}

	public static void MaybeAutoSave()
	{
		var s = Global.gameState;
		if (_autoSaveSlot <= 0 || Global.speed <= 0 || _autoSaveMode <= 0) return;
		if (s.data[19] != 1) return;
		if (_autoSaveMode == 2 && s.data[20] % 6 != 0) return;
		var key = s.data[21] * 10000 + s.data[20] * 100 + s.data[19];
		if (key == _autoSaveDay) return;
		_autoSaveDay = key;
		Port.SaveService.Save(s, Port.SavePaths.Slot(_autoSaveSlot));
	}
}
