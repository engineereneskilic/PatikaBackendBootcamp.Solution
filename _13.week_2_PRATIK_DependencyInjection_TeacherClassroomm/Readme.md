
# Practical Dependency Injection Example

## Table of Contents
- [Introduction](#introduction)
- [Project Structure](#project-structure)
- [Key Components](#key-components)
  - [Interfaces](#interfaces)
  - [Models](#models)
- [Dependency Injection Implementation](#dependency-injection-implementation)
  - [Service Registration](#service-registration)
  - [Service Usage](#service-usage)
- [Usage and Output](#usage-and-output)
- [Benefits of Dependency Injection](#benefits-of-dependency-injection)
- [Future Improvements](#future-improvements)

---

## Introduction

This project demonstrates how to implement **Dependency Injection (DI)** in C#. The example uses a practical scenario with two related classes: `Teacher` and `ClassRoom`. The goal is to show how DI simplifies class interactions, reduces tight coupling, and improves testability and maintainability.

---

## Project Structure

The project is organized as follows:

```
PracticalDependencyInjection/
│
├── Interfaces/
│   └── IOgretmen.cs        # Interface for Teacher
│
├── Models/
│   ├── Teacher.cs          # Implementation of IOgretmen
│   └── ClassRoom.cs        # ClassRoom depends on IOgretmen
│
├── Program.cs              # Main entry point
│
└── PracticalDependencyInjection.sln
```

---

## Key Components

### Interfaces

#### `IOgretmen.cs`

The `IOgretmen` interface defines the contract for teacher classes, ensuring modularity and scalability.

```csharp
namespace PracticalDependencyInjection.Interfaces
{
    public interface IOgretmen
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }
}
```

### Models

#### `Teacher.cs`

The `Teacher` class implements the `IOgretmen` interface, providing basic properties and behavior.

```csharp
using PracticalDependencyInjection.Interfaces;

namespace PracticalDependencyInjection.Models
{
    public class Teacher : IOgretmen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"Teacher Name: {FirstName} {LastName}";
        }
    }
}
```

#### `ClassRoom.cs`

The `ClassRoom` class depends on an `IOgretmen` implementation to retrieve teacher information.

```csharp
using PracticalDependencyInjection.Interfaces;

namespace PracticalDependencyInjection.Models
{
    public class ClassRoom
    {
        private readonly IOgretmen _teacher;

        public ClassRoom(IOgretmen teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
```

---

## Dependency Injection Implementation

### Service Registration

In `Program.cs`, services are registered in the DI container using the `Microsoft.Extensions.DependencyInjection` library.

```csharp
using Microsoft.Extensions.DependencyInjection;
using PracticalDependencyInjection.Interfaces;
using PracticalDependencyInjection.Models;

var serviceProvider = new ServiceCollection()
    .AddTransient<IOgretmen>(provider => new Teacher("John", "Doe"))
    .AddTransient<ClassRoom>()
    .BuildServiceProvider();
```

#### Explanation:
- `AddTransient<IOgretmen>(...)`: Registers `Teacher` as the implementation of `IOgretmen`.
- `AddTransient<ClassRoom>()`: Registers `ClassRoom` in the DI container.

### Service Usage

The services are resolved through the DI container, and their methods are invoked as follows:

```csharp
var classRoom = serviceProvider.GetService<ClassRoom>();

if (classRoom != null)
{
    Console.WriteLine(classRoom.GetTeacherInfo());
}
```

---

## Usage and Output

### Running the Application

Build and run the project using your preferred IDE or the .NET CLI:

```bash
dotnet run
```

### Expected Output

The console displays:

```
Teacher Name: John Doe
```

---

## Benefits of Dependency Injection

- **Loose Coupling**: Classes depend on abstractions rather than concrete implementations.
- **Improved Testability**: Dependencies can be mocked or substituted during testing.
- **Scalability**: Adding new implementations of `IOgretmen` is seamless.
- **Maintainability**: Simplifies the management and updating of dependencies.

---

## Future Improvements

- **Unit Tests**: Add unit tests to verify the functionality of individual components.
- **Logging**: Integrate a logging library to monitor application behavior.
- **Configuration**: Allow dynamic configuration of teacher details from external sources (e.g., files, databases).
- **Web Integration**: Extend the project to a web application using ASP.NET Core.

---
