# szkchm-azdev-t3-backend

> [Base project](https://github.com/AzureDevelopment/m02-backend)



## Configuration

Update connection string `kursazure` in `appsettings.Development.json`
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "ConnectionStrings": {
    "kursazure": "Server=tcp:SERVER_NAME.database.windows.net,1433;Initial Catalog=DB_NAME;Persist Security Info=False;User ID=USER_NAME;Password=USER_PASS;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  }
}
```

## Commands
```bash
dotnet restore
dotnet buid
dotnet publish -c Release
```