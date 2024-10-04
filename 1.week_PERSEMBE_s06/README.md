# Day Finder - C# Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [User Input Section](#user-input-section)
  - [Day Evaluation Logic](#day-evaluation-logic)
- [Usage](#usage)
- [License](#license)

## Introduction

This simple C# console application takes a number between 1 and 7 from the user and prints the corresponding day of the week. If the user enters a number outside of this range, the program informs them that the input is invalid.

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core or .NET Framework

## Code Overview

The following sections explain the code and its logic in detail:

### User Input Section

In this section, the user is prompted to enter a number between 1 and 7. The input is captured as a string and converted to an integer for further processing.

```csharp
// Kullanıcıya 1 ile 7 arasında bir sayı girmesi için mesaj yazdırıyoruz
Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı girin:");

// Kullanıcının girdiği sayıyı almak için bir değişken tanımlıyoruz
string kullaniciGirdisi = Console.ReadLine();
```

### Day Evaluation Logic

This part of the code uses a `switch` statement to match the input number with the corresponding day of the week:
- 1 represents Monday (Pazartesi)
- 2 represents Tuesday (Salı)
- 3 represents Wednesday (Çarşamba)
- 4 represents Thursday (Perşembe)
- 5 represents Friday (Cuma)
- 6 represents Saturday (Cumartesi)
- 7 represents Sunday (Pazar)

If the user enters a number outside of the range 1-7, the program prints "Invalid day" (Geçersiz gün).

```csharp
// Girilen sayının 1 ile 7 arasında olup olmadığını kontrol ediyoruz
switch (gunNumarasi)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz gün.");
        break;
}
```

## Usage

1. Run the application in a C# environment.
2. Enter a number between 1 and 7 when prompted.
3. The program will print the corresponding day of the week.
4. If an invalid number is entered, the program will print "Invalid day".
5. Press any key to exit the program.

## License

This project is licensed under the MIT License.
