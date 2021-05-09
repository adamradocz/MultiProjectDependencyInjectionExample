# MultiProject Dependency Injection Example
Using dependency injection in multiple .NET Core projects

Structure:
- Console Applocation
- Class Library

## Requirements
- [.NET 5](https://dotnet.microsoft.com/download/dotnet/)

## Console Applocation

The application should reference the Microsoft.Extensions.DependencyInjection NuGet package.

## Class Library

The library should reference the Microsoft.Extensions.DependencyInjection.Abstractions NuGet package to get the IServiceCollection interface. We reference the interface to and not the implementation, so it can be used by any other Dependency Injection Container that implements this interface.

