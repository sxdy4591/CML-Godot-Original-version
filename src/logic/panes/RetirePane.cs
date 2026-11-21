// 1986 抉择: 功成身退走原版 in1992_script.
using System.Collections.Generic;

namespace CML.Logic.Panes;

public sealed class RetirePane : IPanel
{
    public string Name => "1986抉择";

    public Dictionary<string, object> Snapshot() => new PanelSnapshot().Build();

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "功成身退":
                var stub = Stub.Take<in1992_script>("RetireProbe", Lifecycle.Lazy);
                stub.Invoke("OnMouseDown");
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "1986抉择没有该动作");
        }
    }
}
