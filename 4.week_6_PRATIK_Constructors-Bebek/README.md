
# Baby Class and Constructor Practice

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction
In this project, we define a `Bebek` class that represents a baby with properties such as `Doğum Tarihi`, `Ad`, and `Soyad`. The goal is to implement two constructors for the `Bebek` class:

1. A default constructor that does not take any parameters.
2. An alternative constructor that accepts `Ad` and `Soyad` parameters and initializes the respective properties.

In both constructors, a message "Ingaaaa" will be displayed to simulate a baby crying when a new `Bebek` object is created. The `Doğum Tarihi` will also be set to the current time.

## Technologies
- C#
- .NET Framework
- Visual Studio (or any preferred C# IDE)

## Code Overview

### 1. Baby Class Definition
We start by defining the `Bebek` class that contains the following properties:
- `Doğum Tarihi`
- `Ad`
- `Soyad`

```csharp
public class Bebek
{
    public DateTime DogumTarihi { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    // Default Constructor
    public Bebek()
    {
        DogumTarihi = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    // Constructor with parameters
    public Bebek(string ad, string soyad) : this()
    {
        Ad = ad;
        Soyad = soyad;
    }
}
```

### 2. Main Program
In the main program, we create two instances of the `Bebek` class using the two different constructors.

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Using the default constructor
        Bebek bebek1 = new Bebek();
        bebek1.Ad = "Ali";
        bebek1.Soyad = "Yılmaz";
        Console.WriteLine($"Bebek 1: {bebek1.Ad} {bebek1.Soyad}, Doğum Tarihi: {bebek1.DogumTarihi}");

        // Using the constructor with parameters
        Bebek bebek2 = new Bebek("Ayşe", "Kaya");
        Console.WriteLine($"Bebek 2: {bebek2.Ad} {bebek2.Soyad}, Doğum Tarihi: {bebek2.DogumTarihi}");

        Console.ReadKey();
    }
}
```

## Usage
1. Clone this repository or copy the code.
2. Open the project in Visual Studio or your preferred C# environment.
3. Compile and run the project.

## Explanation
The project demonstrates the use of constructors in C#. 
- The default constructor initializes the `Doğum Tarihi` property to the current date and time.
- The alternative constructor accepts parameters to initialize the `Ad` and `Soyad` properties.
- Both constructors print "Ingaaaa" when a `Bebek` object is created, simulating a baby's cry.

## Output
The expected output of the program is:

```
Ingaaaa
Bebek 1: Ali Yılmaz, Doğum Tarihi: 16/10/2024 11:25:00 AM
Ingaaaa
Bebek 2: Ayşe Kaya, Doğum Tarihi: 16/10/2024 11:25:01 AM
```

## License
This project is licensed under the MIT License - see the LICENSE file for details.
