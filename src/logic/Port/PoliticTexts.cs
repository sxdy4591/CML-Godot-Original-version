// 原版场景序列化文案(事实表, 不是规则).
// traits_en 逐字取自 1.132 Politic_Manager prefab 的序列化字段(长度 21);
// 1.132 的 Politic.traits 只有 3 槽, 值域 0..20.
namespace CML.Logic.Port;

public static class PoliticTexts
{
    public static readonly string[] Traits =
    {
        "极左派", "温和派", "改革派", "自由派",
        "硬汉", "实用主义", "宽容", "科学家",
        "苛刻", "和平", "小暴君", "经管学家", "傲慢", "偶像",
        "中华派", "西渐派", "谋士", "羞怯", "贪腐", "病弱",
        "保守派",
    };

    public static string Trait(int index) => Traits[index];

    // 原版 Politic_Script 的 dolzh 图标按职位槽取 4 种; 移植版用文字角标, 名称取政治界面职位标题.
    public static readonly string[] Posts =
    {
        "国务院总理", "中央军委主席", "外交部长",
        "首都主管", "北方主管", "西方主管", "南方主管", "东方主管",
    };
}
