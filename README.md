# AddCurrentPath
Add Current Path to EnvironmentVariable

[![squirrel](https://github.com/ali50m/AddCurrentPath/actions/workflows/squirrel.yml/badge.svg?branch=)](https://github.com/ali50m/AddCurrentPath/actions/workflows/squirrel.yml)

## push with tag
```
git tag 1.4.3
git push --tags
```

## package command

```
dotnet publish --configuration Release --runtime win-x86 --self-contained False --output publish -p:PublishSingleFile=true -p:DebugType=None -p:DebugSymbols=false
wingetcreate.exe new https://github.com/ali50m/AddCurrentPath/releases/download/1.4.3/AddCurrentPathSetup.exe            
winget validate --manifest .\manifests\a\ali50m\AddCurrentPath\1.4.3\                               
winget install --manifest .\manifests\a\ali50m\AddCurrentPath\1.4.3\                      
```

## squirrel params
```yml
InstallerSwitches:
  Silent: --silent
  SilentWithProgress: --silent
```