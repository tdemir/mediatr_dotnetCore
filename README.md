# mediatR_dotnet6

```bash
dotnet new sln --name StudentApi
dotnet new webapi --name StudentApi
dotnet sln StudentApi.sln add StudentApi/StudentApi.csproj
dotnet build
cd StudentApi
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 10.0.1
```

for fluent validation

```bash
dotnet add package FluentValidation.DependencyInjectionExtensions --version 11.2.0
```
