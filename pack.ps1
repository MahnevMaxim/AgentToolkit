# Builds all AgentShared packages and publishes them to the local feed (a folder of .nupkg files).
# Usage:  .\pack.ps1
$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $MyInvocation.MyCommand.Path
$feed = Join-Path $root 'feed'
New-Item -ItemType Directory -Force -Path $feed | Out-Null

$projects = @(
    'Agent.Mvvm\Agent.Mvvm.csproj'
    'Agent.Core\Agent.Core.csproj'
    'Agent.Models\Agent.Models.csproj'
)

foreach ($p in $projects) {
    $csproj = Join-Path $root $p
    Write-Host "Packing $csproj ..."
    dotnet pack $csproj -c Release -o $feed --nologo
    if ($LASTEXITCODE -ne 0) { throw "dotnet pack failed for $p" }
}

Write-Host "Packages published to $feed"
