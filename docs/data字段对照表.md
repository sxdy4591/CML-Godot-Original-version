# GameState.data 全字段对照表（1.132 口径，200 槽）

`GameState.data` 是 `int[200]`，游戏内几乎所有"玩家看得见的数值"都住在这里。
所有槽位都是 **×10 内部单位**：`data[8] = 500` 在界面上显示为 `50.0`。
例外：日期（19/20/21）、战争编号（82）、结局编号（35）、人口政策（105）、军队忠诚（108）是原值。

依据全部来自 `src/original` 的真实读写点，不是按数组顺序猜的。
标注 `[确证]` 的槽有明确读写点；标注 `[事件标记]` 的槽由事件/结局分支写入常量，含义随事件而定；
标注 `[未引用]` 的槽在 1.132 源码里没有任何常量下标引用。

游戏内查看与修改（调试控制台，F12 或外交界面「控制台」按钮）：

```
data                 列出 0..19（每行带槽名）
data 20              从 20 起列出 20 个
data 8               查看单个槽
data 8 9999          直接改写
data 8 +100          增加
field influencePRC 500         data 之外的任意状态字段
field empires[0].relations 900
field allcountries[1].Gosstroy 1
rel 1 1000                     美国关系(0)/苏联关系(1), 同时同步 data[28]/[29]
```

### 先看这一节：三个"看起来像真值"的缓存槽

`data[7] / data[28] / data[29]` 不是独立状态，而是 `TimeScript.KumihaRepaint()` **每天**用真值覆盖的镜像：

```csharp
private void KumihaRepaint()
{
    global2.data[28] = global2.empires[0].relations;   // 美国关系
    global2.data[29] = global2.empires[1].relations;   // 苏联关系
    global2.data[7]  = global2.influencePRC;           // 全球影响力
}
```

原版的判定（事件条件、焦点 `QueryChina` 等）读这三个槽，但**界面显示读真值字段**。
只改缓存 = 界面不动、第二天还被盖回去。控制台已经做了双向同步：

- `data 29 1000` → 写完自动同步 `empires[1].relations = 1000`，顶栏立刻变
- `field empires[1].relations 1000` → 自动同步 `data[29]`
- `data 29` 查看时会额外打印"该槽是每日缓存，真值 = …"

其余槽（8 预算、9 特工、22 军力、12/13/68 产业、26 腐败…）都是真值，改完即生效。

---

## 一、核心数值（界面顶栏与概览直接显示）

| 槽 | 含义 | 依据 |
| --- | --- | --- |
| 0 | 军事干预度（对外干预累计） | `WarPane.Snapshot` 的 `intervention`；`WarButtonScript` 支援扣减 |
| 1 | 党内支持度 | `TopStatePane` 注释；`TimeScript` 按 `data[31]` 修正 |
| 3 | 人民支持度 | `TopStatePane`；`TimeScript` 按 `data[23]-data[24]` 修正 |
| 4 | 思想自由度 | `TopStatePane`；`BoundsOfVariables` 钳制 0..1000 |
| 5 | 生活水平 | `TopStatePane`；钳制 0..1500 |
| 6 | 国际声望 | `TopStatePane`；钳制 −50..1100 |
| 7 | 全球影响力（每日缓存） | `TimeScript.KumihaRepaint()` 每天写 `data[7] = influencePRC`；**真值是 `influencePRC`** |
| 8 | 预算 | `TopStatePane`；外交按钮判定 `data[8] + data[36]` |
| 9 | 特工网络 | `TopStatePane`；外交按钮费用 |
| 10 | 美国实力初值 | `GameStartScript`：`empires[0].power = data[10]` |
| 11 | 科研点 | `DiploButtonScript` 按钮条件 `data[11] >= 100`，执行时 `-= 100` |
| 12 | 工业 | `BoundsOfVariables` 1500 上限；`ImportChange` 计算 |
| 13 | 农业 | 同上 |
| 14 | 视图/存档辅助状态（0..5） | 原版 `PlayerPrefs["data" + 14 + …]` 一起存 |
| 15 | 政体政策 | `Doctrine_script.this_number = 15` |
| 16 | 经济政策 | 同上，16 |
| 17 | 言论政策 | 同上，17 |
| 18 | 国家结构政策 | 同上，18 |
| 19 | 日期（日） | `TimeScript` 日推进 |
| 20 | 日期（月） | 同上 |
| 21 | 日期（年） | 同上 |
| 22 | 军事力量 | 外交按钮文案「Сила армии」；`BoundsOfVariables` 无上限 |
| 23 | 出口规模（占全球 %） | 经济界面 `Наш экспорт: data[23]/5 %` |
| 24 | 进口规模（相对 1975 年） | 经济界面 `% от 1975: num - data[24]` |
| 25 | 自由化压力 | 概览文案「自由化思潮（每两周）」 |
| 26 | 腐败度 | `Repaint_corrupt`；`BoundsOfVariables` 下限 0 |
| 28 | 美国关系（每日缓存） | `TimeScript.KumihaRepaint()` 每天写 `data[28] = empires[0].relations`；**真值是 `empires[0].relations`** |
| 29 | 苏联关系（每日缓存） | 同上：`data[29] = empires[1].relations`；**真值是 `empires[1].relations`** |
| 30 | 中苏党际联系 | `GameStartScript`：`SOV_PRC_PartiesConnection = data[30]` |
| 31 | 两极平衡刻度（500 为中点） | 概览文案「两极大国关系: (500 − data[31])/100」 |
| 32 | 毛派（纳萨尔派）力量 | 外交文案「支持东部游击武装｜毛主义者力量: data[32]/10」 |
| 34 | 人口 | `ShortcutPane.Population`：1 单位 = 10 万人，+1000 = 1 亿 |
| 35 | 结局编号 | `EndingScript`：`data[35]` 为 1..13 时分别走不同结局 |
| 36 | 可用储备金 | `ReserveRepaint`；`data[8] += data[36]`（预算不够时自动动用储备） |
| 37 | 毛主义者力量 | 外交文案「支持毛派游击武装｜毛主义者力量」 |
| 39 | 对越作战进攻力 | 外交文案「Сила наступления」对应 `data[39]` |
| 40 | 对印作战进攻力 | 同上，`data[40]` |
| 42 | 泛左翼力量 | 概览文案「泛左翼力量」 |
| 43 | 君主主义者力量 | 概览文案「君主主义者力量」 |
| 44 | 自由派力量 | 概览文案「自由派力量」 |
| 45 | 伊斯兰主义者力量 | 概览文案「伊斯兰主义者力量」 |
| 46 | 毛主义者力量（另一分支） | 概览文案「毛主义者力量」（与 37 分属不同国家分支） |
| 48 | 人民派力量（阿富汗） | 概览文案「人民派力量」 |
| 49 | 旗帜派力量（阿富汗） | 概览文案「旗帜派力量」 |
| 50 | 宗教政策 | `Doctrine_script.this_number = 50` |
| 51 | 军事政策 | 同上，51 |
| 52 | 战略政策 | 同上，52 |
| 53 | 已出台政策数（派系解锁门禁） | `Crushko`：`data[53] >= 4` 才显示下一层；`Doctrine_button_script` 重置为 0 |
| 54 | 政策组下标（38..41） | `Doctrine_button_script` 按 `data[54]` 取文案组 |
| 55 | 政策调整的声望/支持累计 | `Doctrine_button_script`：`(number - data[this_number]) * 100` |
| 56 | 执政派系编号 | `DebugPane.Faction`：「执政 = data[56]」；政治界面按此高亮 |
| 57 | 国家凝聚力 | 概览文案「国家凝聚力」 |
| 60 | 某国政变/干涉阶段（0..3） | `DiploButtonScript` 与 `event_done[380]` 联动 |
| 68 | 服务业 | `BoundsOfVariables` 1500 上限；`ServicesSectorMore` |
| 69 | 国债 | `StateDebtMore/Less`、`Repaint_dolg` |
| 71 | 陆军军费 | `AddArmyFunding` 系列 |
| 72 | 情报机关经费 | `AddFinancingMGB` |
| 73 | 科研经费 | `AddFinancingScience` |
| 74 | 国家机关经费 | `AddFinancingStateApparatus` |
| 75 | 信封预算（黑账） | `AddEnvelopeBudget` |
| 76 | 宣传经费 | `AddFundingPropaganda` |
| 77 | 农业经费 | `AddFinancingAgricultural` |
| 78 | 工业经费 | `AddFinancingIndustry` |
| 79 | 服务业经费 | `AddFinancingServiceSector` |
| 80 | 社会政策经费 | `AddFinancingSocialPolicy` |
| 81 | 驻外使团经费 | `AddFinancingDiplomaticMissions` |
| 82 | 当前进行中的战争编号 | `WarResult` / `TextOfEvents`：`ingamewars[data[82]]` |
| 105 | 人口政策（0 一胎 / 1 二胎 / 2 无限制） | `NewGameSetup` 开局写 1；界面按此显示 |
| 106 | 现状满意度（执政稳定度） | `DebugPane.Faction`：「满足现状 = data[106]」 |
| 108 | 军队忠诚（0..100） | `BoundsOfVariables` 钳制 0..100；`Event456` 按 54/72 分档 |

## 二、事件/结局分支标记槽（`[事件标记]`）

以下槽位由 `Event{N}.ResultsOfEvents`、`doneventscript`、`EndingScript` 等写入常量，
用来记住"某个事件的某个选项已经选过"。含义绑定在具体事件上，不看事件就无法判断：

`2 27 33 38 41 47 58 59 61 62 63 64 65 66 67 70 83 84 85 86 87 88 89 90 91 92 93
94 95 96 97 98 99 100 101 102 103 104 107 109 110 111 112 113 114 115 116 117 118
119 120 121 122 123 124 125 126 127 128 129 130 131 132 133 134 135 136 137 138 139
140 141 142 143 144 145 146 147 148 149 150 151 152 153 154 155 156 157 158 159 160
161`

其中几个已知：

| 槽 | 含义 | 依据 |
| --- | --- | --- |
| 2 | 苏联实力比对值（外交判定用） | `empires[1].power = data[2]`；按钮 `data[2] >= 250` |
| 33 | 影响力投入累计（界面 %） | `DiploButtonScript`「影响 …… %」 |
| 38 | 政客库初始化标记（=100 表示已建立） | 政客按钮判定 `data[38] == 100 || selected_politic > 0` |
| 62/64/65/66/67 | 中国/台湾相关阶段标记 | `Country.cs`、`CountryScript.cs` 的 `this_number == 69/70` 分支 |
| 85 | 巴以方案结果（0/1/2 …） | 概览文案「巴勒斯坦建立阿拉伯国 / 已建成巴以联盟国家」 |
| 120 | 某国干涉方式结果 | 概览事件正文分支 |
| 143 | 国债比例（10..60） | 外交文案「国债 …… $」，范围 10..60 |

## 三、未引用槽（`[未引用]`）

1.132 源码里没有任何 `data[n]` 常量下标访问（可能是被变量下标访问的中间量，也可能曾是废弃槽）。
控制台仍然可以随意读写，但改动不会影响任何原版判定：

`58 59 61 93 101 109 148 154 159 162 163 164 165 166 167 168 169 170 171 172 173
174 175 176 177 178 179 180 181 182 183 184 185 186 187 188 189 190 191 192 193 194
195 196 197 198 199`

> 注意：`162..199` 在 1.132 里没有被任何常量下标引用，但焦点 DSL（`src/original/Focuses`）
> 有按变量下标访问 `data[...]` 的封装，改动前先用 `field` 命令确认当前值。

## 四、怎么自己确证一个槽

1. 控制台 `data n` 看当前值，`data n +100` 试探；
2. 在仓库里搜：`grep -rn "data\[n\]" src/original --include=*.cs`，看写入点所在方法名与界面文案；
3. 搜带文案的行：`grep -rh "data\[n\]" src/original --include=*.cs | grep text`；
4. 存档对比：`save 1` → 改槽 → 再 `save 2`，用外部 diff 比对二进制差异（槽位顺序即 data 下标）。

槽位名称表在 `src/logic/Port/DataSlots.cs`，控制台与自动化提示共用它；补一个新槽的名字只改这一个文件。
