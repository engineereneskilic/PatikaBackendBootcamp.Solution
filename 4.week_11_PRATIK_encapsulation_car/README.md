
# Encapsulation Example - Car Class

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [Class Definition](#class-definition)
  - [Properties](#properties)
  - [Constructor](#constructor)
  - [Encapsulation](#encapsulation)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

## Introduction

This project demonstrates the concept of encapsulation in C# using a simple `Car` class. The class includes properties such as `Brand`, `Model`, `Color`, and `DoorCount`. The focus is on encapsulating the `DoorCount` property to ensure that it only accepts valid values, specifically 2 or 4. If any other value is entered, a warning message is displayed, and the value is set to -1.

## Technologies

- C#
- .NET Core SDK

## Code Overview

### Class Definition

The `Car` class defines the basic structure for creating car objects with the following properties:

- `Brand`: The brand of the car (e.g., BMW, Toyota).
- `Model`: The model of the car (e.g., X5, Corolla).
- `Color`: The color of the car.
- `DoorCount`: The number of doors on the car. This property is encapsulated to ensure only valid values are allowed.

### Properties

The properties allow for both getting and setting values, with special handling for the `DoorCount` property:

```csharp
public string Brand { get; set; }
public string Model { get; set; }
public string Color { get; set; }

private int doorCount;
public int DoorCount
{
    get { return doorCount; }
    set
    {
        // Allow only 2 or 4 doors, otherwise set to -1 and display warning
        if (value == 2 || value == 4)
        {
            doorCount = value;
        }
        else
        {
            Console.WriteLine("Invalid door count! Setting DoorCount to -1.");
            doorCount = -1;
        }
    }
}
```

### Constructor

The constructor is used to initialize the car object with values for `Brand`, `Model`, `Color`, and `DoorCount`:

```csharp
public Car(string brand, string model, string color, int doorCount)
{
    Brand = brand;
    Model = model;
    Color = color;
    DoorCount = doorCount; // Encapsulation is applied here
}
```

### Encapsulation

The encapsulation for `DoorCount` ensures that the car can only have either 2 or 4 doors. If any other number is assigned, a warning is displayed and the value is set to -1:

```csharp
public int DoorCount
{
    get { return doorCount; }
    set
    {
        if (value == 2 || value == 4)
        {
            doorCount = value;
        }
        else
        {
            Console.WriteLine("Invalid door count! Setting DoorCount to -1.");
            doorCount = -1;
        }
    }
}
```

## Usage

You can create `Car` objects and test the encapsulation by assigning various values for the `DoorCount`:

```csharp
Car car1 = new Car("Toyota", "Corolla", "Red", 4);
car1.DisplayCarInfo();

Car car2 = new Car("BMW", "X5", "Black", 3); // Invalid door count, should set to -1
car2.DisplayCarInfo();
```

## Output

When the `Car` objects are created, the console will display information about the cars, including the door count validation:

```
Car Info: Brand = Toyota, Model = Corolla, Color = Red, Door Count = 4
Invalid door count! Setting DoorCount to -1.
Car Info: Brand = BMW, Model = X5, Color = Black, Door Count = -1
```

## License

This project is licensed under the MIT License.
