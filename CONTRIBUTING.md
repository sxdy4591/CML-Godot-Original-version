# 贡献指南

## 分支模型

| 分支 | 用途 |
|---|---|
| `main` | 唯一长期分支，始终可编译、可导出；受保护，只能通过 PR 合入 |
| `feat/<主题>` | 新功能 |
| `fix/<主题>` | 缺陷修复 |
| `chore/<主题>` | 构建、数据、文档 |

- 一个 PR 只做一件事；合并后删除分支。
- 历史由 `main` 的线性提交组成，禁止 merge commit（仓库设置选 **Squash and merge** 或 **Rebase and merge**）。

## 提交格式

```
类型(范围): 说明
```

类型：`feat` / `fix` / `refactor` / `data` / `docs` / `chore` / `test`。
范围：`logic` / `bridge` / `compat` / `view` / `data` / `ci` / `docs`。

例：

```
fix(logic): 事件结果页按原版 load_scene_after_click 收尾
data: 名字表换回 1.132 TextAsset
```

提交信息写"为什么"和"依据"，不要写"更新文件"。

## 版本号

- 唯一真值：`project.godot` 的 `application/config/version`，SemVer：`主.次.补`。
- `site/version.json` 的 `version` 必须与之相等；`tools/check_version.py` 会在 CI 校验。
- 发布打 tag：`v<版本>`，例如 `v0.7.0`；`Release` workflow 会校验 tag 与两处版本一致。
- 预发布用后缀：`0.8.0-beta.1`，主菜单显示时自动带 `[beta]`。

## 发布流程

1. 改 `project.godot` 的 `config/version`；
2. 同步 `site/version.json`（`version` / `url` / `notes`）；
3. 提交、合入 `main`；
4. `git tag v<版本> && git push origin v<版本>`；
5. GitHub Release 里上传安装包（附件）。

## 在线内容（关于页）

`site/content.json` 推送到 `main` 后由 Pages workflow 自动发布，游戏下次启动/进入关于页时拉取：

```json
{
  "about_v2": "二版介绍文本",
  "about_v1": "一版介绍文本",
  "qq": "https://.../qq.png",
  "demo1": "https://.../demo1.png",
  "demo2": "https://.../demo2.png"
}
```

图片留空字符串则使用游戏内置图；任一项拉取失败会在日志里 `push_error`，界面保持本地内容。

## 架构红线

改动前先读 `docs/重构契约.md`：

- `src/original`（1.132 反编译）与 `src/compat`（Unity 等价层）是地基，不改；
- 桥层只做参数转换/入口转发/信号发射；
- `.gd` / `.tscn` 只做布局、赋值、信号转发、切场景；
- 原版组件的接管一律走 `Stub`（`Pump` / `Lazy` / `Scene` / `None` 必须显式声明）；
- 缺什么就让异常抛，不写 try/catch、不写静默兜底。

## 首次上传（干净历史）

远端仓库必须是**空的**（不勾 README / .gitignore / license）。本地旧历史只留在本地分支与 reflog，不会上传。

```powershell
# 1) 先改两处占位：src/autoload/在线更新.gd 的 站点、site/version.json 的 url
# 2) 建仓后执行：
.\tools\push_clean.ps1 -Remote https://github.com/<用户>/<仓库>.git
# PowerShell 拦截脚本时：
powershell -ExecutionPolicy Bypass -File .\tools\push_clean.ps1 -Remote https://github.com/<用户>/<仓库>.git
```

推送完成后：

1. Settings → Pages：Source = `Deploy from a branch`，分支 `main`，目录 `/site`；
2. Settings → Branches：给 `main` 加保护（Require pull request + Require status checks 选 `CI`）；
3. 打首版 tag：`git tag v0.7.1 && git push origin v0.7.1`（Release workflow 会校验三处版本一致并建 Release）；
4. Release 页上传安装包（附件）。
