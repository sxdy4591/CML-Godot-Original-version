// Steamworks 桩: 原版 achievements 只用到这几类, 全部空实现.
// 真 Steamworks 程序集依赖 UnityEngine.CoreModule(Unity 原生), 在 Godot 下无法加载,
// 所以本工程不再引用 libs/Assembly-CSharp-firstpass.dll, 由这里提供同名类型.
using System;

namespace Steamworks
{
    public class Callback<T>
    {
        public static Callback<T> Create(Action<T> handler) => new Callback<T>();
    }

    public struct CGameID
    {
        public uint Value;
        public CGameID(uint value) { Value = value; }
        public static implicit operator ulong(CGameID id) => id.Value;
    }

    public enum EResult
    {
        k_EResultOK = 1,
        k_EResultInvalidParam = 15,
    }

    public struct UserStatsReceived_t
    {
        public ulong m_nGameID;
        public EResult m_eResult;
    }

    public struct UserStatsStored_t
    {
        public ulong m_nGameID;
        public EResult m_eResult;
    }

    public struct UserAchievementStored_t
    {
        public ulong m_nGameID;
        public string m_rgchAchievementName;
    }

    public static class SteamUtils
    {
        public static uint GetAppID() => 0;
    }

    public static class SteamUserStats
    {
        public static bool ClearAchievement(string name) => true;
        public static bool SetAchievement(string name) => true;
        public static bool RequestCurrentStats() => false;
        public static bool StoreStats() => true;
    }
}

// 原版 achievements 通过 GameObject.Find("SteamManager").GetComponent<SteamManager>() 取开关,
// achivki_sosut = true 表示"成就系统关闭", Update/OnEnable 直接空转.
public class SteamManager : UnityEngine.MonoBehaviour
{
    public static bool Initialized => false;

    public bool achivki_sosut = true;
}
