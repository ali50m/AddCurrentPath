# AddCurrentPath
Add Current Path to EnvironmentVariable

## push with tag
```
git tag <tagname>
git push --tags
```

## package command

```
dotnet publish --configuration Release --runtime win-x86 --self-contained False --output publish -p:PublishSingleFile=true -p:DebugType=None -p:DebugSymbols=false
wingetcreate.exe new https://github.com/ali50m/AddCurrentPath/releases/download/1.0.8/AddCurrentPath.Setup.exe            
winget validate --manifest .\manifests\a\ali50m\AddCurrentPath\1.0.8\                               
winget install --manifest .\manifests\a\ali50m\AddCurrentPath\1.0.8\                      
```