### Q1
Below is the `.csproj` file content confirming all four required properties (`OutputType`, `TargetFramework`, `ImplicitUsings`, and `Nullable`) are present:

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

### Q2
- No, #region and #endregion do not change the compiled output.
- We use them to collapse and expand parts of code to keep the file clean and organized.

### Q3
- We use /// XML doc comments above classes, methods, or properties when building reusable code or libraries to provide IntelliSense tooltips in the IDE.

### Q4 
- C# is a strictly OOP language where every variable must belong to a class or struct.
- The closest equivalent is a public static field inside a class, which can be accessed from anywhere using the class name.