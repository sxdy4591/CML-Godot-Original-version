# First upload: collapse local history into one commit and force-push.
# The remote repository must be empty.
# Usage:
#   .\tools\push_clean.ps1 -Remote https://github.com/<user>/<repo>.git
# Old main is replaced; other local branches (backup-*/archive-*) stay local and are not pushed.

param(
    [Parameter(Mandatory = $true)][string]$Remote,
    [string]$Message = "Initial commit: China - Mao's Legacy [Godot port]"
)

$ErrorActionPreference = "Stop"

# Run from the repository root (the script lives in tools/), no matter where it was invoked.
Set-Location -LiteralPath (Split-Path -Parent $PSScriptRoot)

git checkout --orphan clean-main
if ($LASTEXITCODE -ne 0) { throw "git checkout --orphan failed" }

git add -A
git commit -m $Message
if ($LASTEXITCODE -ne 0) { throw "git commit failed" }

git branch -D main 2>$null
git branch -m main

$remotes = git remote
if ($remotes -contains "origin") {
    git remote set-url origin $Remote
} else {
    git remote add origin $Remote
}

git push -u origin main --force
if ($LASTEXITCODE -ne 0) { throw "git push failed (check remote url and credentials)" }

Write-Host "Done: main pushed as a single commit. Next: Settings -> Pages -> Source = GitHub Actions."
