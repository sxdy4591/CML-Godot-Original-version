// 专辑包导入的编码边界: 只做"zip 条目名解码"这一件参数转换.
// Godot 的 ZIPReader 一律按 UTF-8 解条目名; Windows 下中文压缩软件常见两种坑:
//   1) 不设 UTF-8 标志却写 GBK 文件名;
//   2) 设了 UTF-8 标志却仍写 GBK 文件名(标志是假的), 这类连 .NET ZipArchive 都会按 UTF-8 解成乱码.
// 所以这里不信任何标志位, 直接读中央目录拿文件名的原始字节:
// 能按严格 UTF-8 解就用 UTF-8, 否则按 GBK(936) 解. 解压/进度仍由 GDScript 分帧做.
using System.IO;
using System.IO.Compression;
using System.Text;

namespace CML.Logic.Port;

public static class AlbumImport
{
    static readonly Encoding Gbk;

    static AlbumImport()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Gbk = Encoding.GetEncoding(936);
    }

    // 读文本文件: info.json 也可能是 GBK(同一批 Windows 工具写的), 按同一套规则解成 UTF-8.
    public static string ReadText(string path) => Decode(File.ReadAllBytes(path));

    // 返回中央目录里每个条目的名字(顺序与 ZIPReader.get_files() 一致), 目录条目以 "/" 结尾.
    public static string[] EntryNames(string zipPath)
    {
        var bytes = File.ReadAllBytes(zipPath);
        var eocd = FindEndOfCentralDirectory(bytes);
        var count = (int)U16(bytes, eocd + 10);
        var offset = (int)U32(bytes, eocd + 16);
        var names = new string[count];
        var p = offset;
        for (var i = 0; i < count; i++)
        {
            var nameLength = U16(bytes, p + 28);
            var extraLength = U16(bytes, p + 30);
            var commentLength = U16(bytes, p + 32);
            var raw = new byte[nameLength];
            System.Array.Copy(bytes, p + 46, raw, 0, nameLength);
            names[i] = Decode(raw).Replace('\\', '/');
            p += 46 + nameLength + extraLength + commentLength;
        }
        return names;
    }

    // 末尾找 EOCD 签名 PK\x05\x06(注释最长 65535)
    static int FindEndOfCentralDirectory(byte[] bytes)
    {
        var start = bytes.Length - 22;
        for (var i = start; i >= 0 && i >= start - 65535; i--)
        {
            if (bytes[i] == 0x50 && bytes[i + 1] == 0x4B && bytes[i + 2] == 0x05 && bytes[i + 3] == 0x06)
                return i;
        }
        return 0;
    }

    // 按中央目录序号解压单个条目: 分帧循环与进度归 GDScript, 这里只做"第 index 个条目 → 目标路径".
    // 不走 Godot 的 ZIPReader —— 它一律按 UTF-8 解条目名, GBK 名会刷一屏 Unicode parsing error.
    public static void ExtractEntry(string zipPath, int index, string targetPath)
    {
        using var archive = ZipFile.OpenRead(zipPath);
        Directory.CreateDirectory(Path.GetDirectoryName(targetPath)!);
        archive.Entries[index].ExtractToFile(targetPath, true);
    }

    static ushort U16(byte[] bytes, int at) => (ushort)(bytes[at] | bytes[at + 1] << 8);

    static uint U32(byte[] bytes, int at)
        => (uint)(bytes[at] | bytes[at + 1] << 8 | bytes[at + 2] << 16 | bytes[at + 3] << 24);

    static string Decode(byte[] raw)
        => IsValidUtf8(raw) ? Encoding.UTF8.GetString(raw) : Gbk.GetString(raw);

    // 严格 UTF-8 校验: 只要有一处非法字节就整串按 GBK 解 —— 中文压缩软件写的 GBK 名不可能通过校验.
    static bool IsValidUtf8(byte[] bytes)
    {
        var i = 0;
        while (i < bytes.Length)
        {
            var b = bytes[i];
            int extra;
            if (b < 0x80) extra = 0;
            else if (b >= 0xC2 && b <= 0xDF) extra = 1;
            else if (b >= 0xE0 && b <= 0xEF) extra = 2;
            else if (b >= 0xF0 && b <= 0xF4) extra = 3;
            else return false;
            if (i + extra >= bytes.Length) return false;
            for (var k = 1; k <= extra; k++)
                if ((bytes[i + k] & 0xC0) != 0x80) return false;
            i += extra + 1;
        }
        return true;
    }
}
