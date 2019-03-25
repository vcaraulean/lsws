# Local & Static Web Server

Run in any folder to serve files as static content.

## Prerequisites

 - [.NET Core SDK 2.2] (https://dotnet.microsoft.com/download/dotnet-core/2.2)
 
## Packaging

```
    dotnet tool install -g dotnet-warp
    dotnet-warp
```

## Running

By default web server starts on port `5000`. To use another port, specify it as parameter.

```
    .\lwssc.exe --urls=http://localhost:3003
```

