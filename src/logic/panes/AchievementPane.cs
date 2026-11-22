// 成就界面: 目录来自 data/achievements.txt, 解锁状态来自原版 achievements.ach_this(聚合).
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class AchievementPane : IPanel
{
    public string Name => "成就";

    public Dictionary<string, object> Snapshot()
    {
        var items = new List<object>(AchievementCatalog.Count);
        // 已解锁的置顶: 分两遍追加, 组内保持目录顺序
        for (var pass = 0; pass < 2; pass++)
        {
            for (var i = 0; i < AchievementCatalog.Count; i++)
            {
                var number = AchievementCatalog.Numbers[i];
                var unlocked = AchievementCenter.Unlocked(number);
                if (unlocked != (pass == 0)) continue;
                items.Add(new Dictionary<string, object>
                {
                    ["number"] = number,
                    ["title"] = AchievementCatalog.Titles[i],
                    // 目录里用 | 表示换行(原版文案的多行描述)
                    ["desc"] = AchievementCatalog.Descs[i].Replace("|", "\n"),
                    // 原版成就: 图标走网络(Steam CDN), 视图拿不到时保留默认图标;
                    // 自建成就(无 Steam hash): 用本地 res://assets/achievements/<编号>.png
                    ["icon"] = LocalIcon(number),
                    ["icon_url"] = AchievementCatalog.IconUrl(i),
                    ["unlocked"] = unlocked,
                });
            }
        }
        return new PanelSnapshot()
            .Put("items", items)
            .Put("unlocked", AchievementCenter.UnlockedCount())
            .Put("total", AchievementCatalog.Count)
            .Build();
    }

    static string LocalIcon(int number) => "res://assets/achievements/" + number + ".png";


    public void Act(string action, List<object> args)
        => throw new System.ArgumentOutOfRangeException(nameof(action), action, "成就面板没有动作");
}
