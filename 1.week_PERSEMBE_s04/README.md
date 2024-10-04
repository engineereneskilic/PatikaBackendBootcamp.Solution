# Even or Odd Checker - C# Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [User Input Section](#user-input-section)
  - [Number Conversion](#number-conversion)
  - [Even or Odd Evaluation Logic](#even-or-odd-evaluation-logic)
- [Usage](#usage)
- [License](#license)

## Introduction

This simple C# console application checks whether a user-provided integer is even or odd. The application uses basic conditional statements and arithmetic operations to determine the result.

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core or .NET Framework

## Code Overview

The following sections explain the code and its logic in detail:

### User Input Section

In this section, we prompt the user to enter an integer. The input is captured as a string.

```csharp
// Kullanıcıya bir tam sayı girmesi için mesaj yazdırıyoruz
Console.WriteLine("Lütfen bir tam sayı girin:");

// Kullanıcının girdiği tam sayı bilgisini almak için bir değişken tanımlıyoruz
string kullaniciSayisi = Console.ReadLine();
```

### Number Conversion

Here, the string input from the user is converted to an integer using `int.Parse()`. This allows us to perform arithmetic operations on the input. In real-world applications, error handling should be implemented to manage invalid inputs.

```csharp
// Girdiğimiz sayıyı sayısal bir değere (int) çevirmemiz gerekiyor
int sayi = int.Parse(kullaniciSayisi);
```

### Even or Odd Evaluation Logic

This part uses the modulus operator (`%`) to determine whether the input number is even or odd. If the remainder of the division by 2 is zero, the number is even; otherwise, it is odd.

```csharp
// Mod operatörü bir sayının 2'ye bölündüğünde kalanını verir
if (sayi % 2 == 0)
{
    // Eğer sayı çift ise bu mesajı yazdırıyoruz
    Console.WriteLine("Çift sayıdır.");
}
else
{
    // Eğer sayı tek ise bu mesajı yazdırıyoruz
    Console.WriteLine("Tek sayıdır.");
}
```

## Usage

1. Run the application in a C# environment.
2. Enter an integer when prompted.
3. The program will tell you whether the number is even or odd.
4. Press any key to exit the application.

## License

This project is licensed under the MIT License.
