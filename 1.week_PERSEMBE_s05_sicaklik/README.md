# Temperature Check - C# Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [User Input Section](#user-input-section)
  - [Temperature Conversion](#temperature-conversion)
  - [Temperature Evaluation Logic](#temperature-evaluation-logic)
- [Usage](#usage)
- [License](#license)

## Introduction

This simple console application in C# checks the temperature entered by the user in Celsius and classifies it into three categories: "Freezing", "Normal", or "Hot", based on specific ranges.

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core or .NET Framework

## Code Overview

The following sections explain the code logic in detail:

### User Input Section

In this section, we prompt the user to enter a temperature in Celsius. The input is captured as a string, which will be converted to an integer for further processing.

```csharp
// Kullanıcıya sıcaklık değerini Celsius cinsinden girmesi için mesaj yazdırıyoruz
Console.WriteLine("Lütfen Celsius cinsinden sıcaklık değerini girin:");

// Kullanıcının girdiği sıcaklık değerini almak için bir değişken tanımlıyoruz
string kullaniciSicakligi = Console.ReadLine();
```

### Temperature Conversion

The input, which is initially a string, is converted to an integer using `int.Parse()` to allow for numeric comparison.

```csharp
// Alınan sıcaklık değerini string'ten sayısal bir değere (int) çevirmemiz gerekiyor
int sicaklik = int.Parse(kullaniciSicakligi);
```

### Temperature Evaluation Logic

This section uses conditional statements to evaluate the temperature:
- If the temperature is less than 0, the program prints "Freezing" (Donuyor).
- If the temperature is between 0 and 30 (inclusive), it prints "Normal".
- If the temperature exceeds 30, it prints "Hot" (Sıcak).

```csharp
// Eğer sıcaklık 0'dan küçükse "Donuyor" mesajını yazdırıyoruz
if (sicaklik < 0)
{
    Console.WriteLine("Donuyor.");
}
// Sıcaklık 0 ile 30 arasında ise "Normal" mesajını yazdırıyoruz
else if (sicaklik >= 0 && sicaklik <= 30)
{
    Console.WriteLine("Normal.");
}
// Sıcaklık 30'dan büyükse "Sıcak" mesajını yazdırıyoruz
else
{
    Console.WriteLine("Sıcak.");
}
```

## Usage

1. Run the application in a C# environment.
2. Enter a temperature in Celsius when prompted.
3. The program will classify the temperature as "Freezing", "Normal", or "Hot".
4. Press any key to exit the program.

## License

This project is licensed under the MIT License.
