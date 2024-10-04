## Dependency Injection using Reflection in C#
This is a simple console application built with C# 8 that demonstrates how to implement a basic Dependency Injection (DI) mechanism using reflection. The project serves as a foundational example for understanding how DI can be done manually without using third-party libraries like Microsoft.Extensions.DependencyInjection.

### Features
- Manual Dependency Injection: Uses reflection to resolve and inject dependencies at runtime.
- Constructor Injection: Supports dependency resolution via constructor parameters.
- C# 8 Syntax: Built with modern C# 8 features for better performance and readability.
- Lightweight Implementation: No external libraries, purely built with .NET standard tools and techniques.

### Getting Started
- Prerequisites
.NET Core SDK 3.1 or later: You will need the .NET Core SDK to build and run the application.
Download the latest version of .NET SDK from here.

### Installation
1. Clone the repository:
```
git clone https://github.com/your-username/dependency-injection-reflection.git
cd dependency-injection-reflection
```

2. Build the application:
```
dotnet build
```
3. Run the application:
```
dotnet run
```

### Project Structure
- Program.cs: Entry point of the console application.
- ServiceProvider.cs: Contains the logic for resolving dependencies using reflection.
- Repositories and Services: Example services to demonstrate dependency injection.

### Example Code
See Program.cs class

### License
This project is licensed under the MIT License - see the LICENSE file for details.
