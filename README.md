# nuget-pkg-github-packages
Estudo para automatizar o envio de pacote nuget de forma privada, para o github packages.

```csharp
dotnet new sln -n NugetPackage
dotnet new classlib -n Calculator -o src/Calculator
dotnet new xunit -n UnitTests -o tests/UnitTests
dotnet sln add src/Calculator/ -s src
dotnet sln add tests/UnitTests/ -s tests
dotnet add tests/UnitTests/ reference src/Calculator/
dotnet add tests/UnitTests/ package AutoFixture
```