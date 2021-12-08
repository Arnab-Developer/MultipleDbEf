Initial database create

```
dotnet ef migrations add InitialCreate -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext -o Migrations\Student

dotnet ef migrations add InitialCreate -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext -o Migrations\Person

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext
```

Add age in existing table

```
dotnet ef migrations add AddAge -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext -o Migrations\Student

dotnet ef migrations add AddAge -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext -o Migrations\Person

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext
```

See [this](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) documentation.