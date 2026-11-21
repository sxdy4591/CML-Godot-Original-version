// 存档路径: 每个槽位一个 user:// 文件.
namespace CML.Logic.Port;

public static class SavePaths
{
    // 自动存档固定用 0 号槽(与 1..5 手动槽分开, 避免原版"自动存档覆盖手动档"的问题)
    public const int AutoSlot = 0;

    public static string Slot(int slot) => Godot.ProjectSettings.GlobalizePath($"user://save_{slot}.dat");

    public static bool Exists(int slot) => System.IO.File.Exists(Slot(slot));
}
