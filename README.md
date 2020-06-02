# commands

## myWebApp

```
dotnet new webApp -o myWebApp --no-https
```

if there are errors like the following:

```
It was not possible to find any compatible framework version
The framework 'Microsoft.AspNetCore.App', version '3.1.0' was not found.
  - No frameworks were found.

You can resolve the problem by installing the specified framework and/or SDK.

The specified framework can be found at:
  - https://aka.ms/dotnet-core-applaunch?framework=Microsoft.AspNetCore.App&framework_version=3.1.0&arch=x64&rid=arch-x64
```

install:

```
sudo pacman -S aspnet-runtime
```

## classes

```
mkdir classes
dotnet new console
```
