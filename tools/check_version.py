#!/usr/bin/env python3
"""版本一致性校验.

三处必须一致:
  1. project.godot 的 application/config/version
  2. site/version.json 的 version（在线更新清单）
  3. git tag（打 tag 发布时, 形如 v0.7.2）

用法:
  python3 tools/check_version.py              # 校验 1 与 2
  python3 tools/check_version.py --tag v0.7.2 # 再校验 tag
"""

import json
import re
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent


def project_version() -> str:
    text = (ROOT / "project.godot").read_text(encoding="utf-8")
    match = re.search(r'^config/version="([^"]+)"', text, re.M)
    if not match:
        raise SystemExit("project.godot has no config/version")
    return match.group(1)


def site_version() -> str:
    data = json.loads((ROOT / "site" / "version.json").read_text(encoding="utf-8"))
    if "version" not in data:
        raise SystemExit("site/version.json has no version field")
    return str(data["version"])


def main() -> int:
    tag = None
    if "--tag" in sys.argv:
        tag = sys.argv[sys.argv.index("--tag") + 1]

    code = project_version()
    site = site_version()
    errors = []
    if code != site:
        errors.append(f"site/version.json is {site}, project.godot is {code}; sync them before release")
    if tag is not None and tag != f"v{code}":
        errors.append(f"tag is {tag}, project.godot expects v{code}")

    print(f"code:  {code}")
    print(f"site:  {site}")
    if tag is not None:
        print(f"tag:   {tag}")

    if errors:
        for error in errors:
            print(f"FAIL: {error}", file=sys.stderr)
        return 1
    print("OK: versions match")
    return 0


if __name__ == "__main__":
    sys.exit(main())
