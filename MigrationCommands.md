Initial database creation for student

```
dotnet ef migrations add InitialCreate -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext -o Migrations\Student

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext
```

Initial database creation for person

```
dotnet ef migrations add InitialCreate -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext -o Migrations\Person

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext
```

Add 'age' in existing student table

```
dotnet ef migrations add AddAge -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext -o Migrations\Student

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c StudentContext
```

Add 'age' in existing person table

```
dotnet ef migrations add AddAge -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext -o Migrations\Person

dotnet ef database update -p MultipleDbEf.Data\MultipleDbEf.Data.csproj -s MultipleDbEf.Api\MultipleDbEf.Api.csproj -c PersonContext
```

See [this](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) documentation.