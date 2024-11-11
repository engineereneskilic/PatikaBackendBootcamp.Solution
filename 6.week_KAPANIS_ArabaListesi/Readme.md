
# Car Factory - Car Production Simulation

This is a simple C# console application that simulates a car production process in a car factory. Users can create car objects with various properties and store them in a list. After creating multiple cars, the program will display each car's serial number and brand.

## Table of Contents
1. [Introduction](#introduction)
2. [Technologies](#technologies)
3. [Code Overview](#code-overview)
4. [Explanation](#explanation)
   - [Car Class](#car-class)
   - [Main Method](#main-method)
       - [Initial Prompt](#initial-prompt)
       - [Creating a Car Object](#creating-a-car-object)
       - [Setting Car Properties](#setting-car-properties)
       - [Validating Door Count](#validating-door-count)
       - [Adding Car to the List](#adding-car-to-the-list)
       - [Repeating the Process](#repeating-the-process)
       - [Displaying the List of Cars](#displaying-the-list-of-cars)
5. [Usage](#usage)
6. [Output](#output)
7. [License](#license)

---

## Introduction

The purpose of this project is to simulate a car production process in a car factory. The user can produce multiple car objects, each with specific properties. For each car, a production date is automatically assigned, and users are prompted to enter other properties like the serial number, brand, model, color, and door count. The program also validates certain inputs and displays the list of all produced cars at the end.

## Technologies

This project is developed using:
- C#
- .NET Core Console Application

## Code Overview

The code is organized as follows:
1. **Car Class**: Defines the properties of a car, including production date, serial number, brand, model, color, and door count.
2. **Main Method**: Contains the main logic for user interaction and car production.
3. **Door Count Validation**: Ensures valid numerical input for door count, using exception handling.

## Explanation

### Car Class

```csharp
class Car
{
    public DateTime ProductionDate { get; } = DateTime.Now; // The production date is automatically set to the current date and time.
    public string SerialNumber { get; set; } // Car's serial number, assigned by user input.
    public string Brand { get; set; } // Car's brand, assigned by user input.
    public string Model { get; set; } // Car's model, assigned by user input.
    public string Color { get; set; } // Car's color, assigned by user input.
    public int DoorCount { get; set; } // The number of doors, validated as an integer.
}
```

The `Car` class represents a car object with various properties. The `ProductionDate` property is automatically set to the current date when the car is created, while other properties are set based on user input.

### Main Method
The `Main` method manages the entire car production flow, guiding the user through each step of car creation. Here’s a breakdown of each part of the process:

#### Initial Prompt
```csharp
Console.WriteLine("Would you like to produce a car? (e/h)");
string answer = Console.ReadLine().Trim().ToLower();
```

The program first prompts the user to decide if they would like to create a car. The input is made case-insensitive by converting it to lowercase.

#### Creating a Car Object
```csharp
Car newCar = new Car();
```

If the user chooses to create a car, a new `Car` object is instantiated. This new object will later be populated with user input.

#### Setting Car Properties
For each car, the program prompts the user to set the following properties:

```csharp
Console.Write("Serial Number: ");
newCar.SerialNumber = Console.ReadLine();

Console.Write("Brand: ");
newCar.Brand = Console.ReadLine();

Console.Write("Model: ");
newCar.Model = Console.ReadLine();

Console.Write("Color: ");
newCar.Color = Console.ReadLine();
```

Each property (except for the production date, which is automatically set) is obtained directly from the user via console input.

#### Validating Door Count
To ensure the door count is a valid number, the program uses a `try-catch` block with a `goto` statement for re-prompting if invalid input is detected.

```csharp
SetDoorCount:
try
{
    Console.Write("Door Count: ");
    newCar.DoorCount = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Invalid input! Please enter a numerical value.");
    goto SetDoorCount;
}
```

If the user enters a non-numerical value for the door count, an error message is displayed, and the program returns to the prompt to re-request the door count.

#### Adding Car to the List
```csharp
cars.Add(newCar);
```

Once all details are entered and validated, the car is added to the `cars` list, which stores all produced car objects.

#### Repeating the Process
After creating a car, the program asks the user if they would like to create another car:

```csharp
Console.WriteLine("Would you like to create another car? (e/h)");
string anotherCarAnswer = Console.ReadLine().Trim().ToLower();
```

If the answer is 'e', the process restarts from the beginning; otherwise, the program moves to the next step.

#### Displaying the List of Cars
After the user is finished creating cars, the program displays the serial number and brand of each car in the `cars` list.

```csharp
Console.WriteLine("
Produced Cars:");
foreach (var car in cars)
{
    Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}");
}
```

This step provides a summary of all cars produced during the session.

## Usage

1. **Run the Program**: Run the code in a .NET Core-compatible environment.
2. **Enter Car Details**: The program will prompt you to enter details for each car.
3. **Decide to Continue**: After entering the car details, the program asks if you want to create another car.
4. **View All Cars**: When finished, the program will display all the produced cars, showing each car's serial number and brand.

## Output

Example output when running the program:

```yaml
Would you like to produce a car? (e/h)
> e
Serial Number: 12345
Brand: Toyota
Model: Corolla
Color: Blue
Door Count: 4
Would you like to create another car? (e/h)
> e
Serial Number: 67890
Brand: Honda
Model: Civic
Color: Red
Door Count: 4
Would you like to create another car? (e/h)
> h

Produced Cars:
Serial Number: 12345, Brand: Toyota
Serial Number: 67890, Brand: Honda
```

## License

This project is for educational purposes and does not have a specified license. You are free to use and modify the code for personal use.
