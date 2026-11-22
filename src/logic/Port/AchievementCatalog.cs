// 成就目录(事实表): data/achievements.txt, 每行 "编号\t标题\t描述(|代表换行)".
// 标题/描述/编号取自改版成就目录(与 Steam 成就对齐), 这里只做读取, 不做判定.
using System;
using UnityEngine;

namespace CML.Logic.Port;

public static class AchievementCatalog
{
    public static readonly int[] Numbers;
    public static readonly string[] Titles;
    public static readonly string[] Descs;
    // Steam 成就图标 hash: 界面按 https://steamcdn-a.akamaihd.net/.../<hash>.jpg 在线加载
    public static readonly string[] Icons;

    static AchievementCatalog()
    {
        var text = GameDataRegistry.LoadTextFile("achievements")
            ?? throw new InvalidOperationException("嵌入资源 achievements.txt 缺失");
        var lines = text.Split('\n');
        var count = 0;
        foreach (var line in lines) if (line.Trim().Length > 0) count++;

        Numbers = new int[count];
        Titles = new string[count];
        Descs = new string[count];
        Icons = new string[count];

        var index = 0;
        foreach (var raw in lines)
        {
            var line = raw.Trim('\r', ' ', '\t');
            if (line.Length == 0) continue;
            var parts = line.Split('\t');
            if (parts.Length < 3)
                throw new InvalidOperationException($"achievements.txt 第 {index + 1} 行字段不足: {line}");
            Numbers[index] = int.Parse(parts[0]);
            Titles[index] = parts[1];
            Descs[index] = parts[2];
            Icons[index] = parts.Length > 3 ? parts[3] : "";
            index++;
        }
    }

    public static int Count => Numbers.Length;

    // 原版成就图标走 Steam CDN(界面/弹窗共用); 空 hash 返回空串(自建成就用本地图)
    public static string IconUrl(int index)
        => string.IsNullOrEmpty(Icons[index])
            ? ""
            : "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/apps/950740/" + Icons[index] + ".jpg";
}
