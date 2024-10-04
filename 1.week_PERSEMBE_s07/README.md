# Grade Evaluator - C# Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [User Input Section](#user-input-section)
  - [Grade Evaluation Logic](#grade-evaluation-logic)
  - [Error Handling](#error-handling)
  - [Exit Message](#exit-message)
- [Usage](#usage)
- [License](#license)

## Introduction

This simple console application in C# allows the user to input a grade between 0 and 100, and evaluates the grade into three categories: "Failing", "Average", or "Successful", based on predefined ranges.

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core or .NET Framework

## Code Overview

The following sections explain the code and its logic in detail:

### User Input Section

The user is prompted to input a grade between 0 and 100. The input is initially captured as a string, and then converted to an integer for further processing.

```csharp
// Kullanıcıya 0 ile 100 arasında bir not girmesi için mesaj yazdırıyoruz
Console.WriteLine("Lütfen 0 ile 100 arasında bir not girin:");

// Kullanıcının girdiği notu almak için bir değişken tanımlıyoruz
string kullaniciNotu = Console.ReadLine();

// Girilen notu sayısal bir değere (int) çevirmemiz gerekiyor
int not = int.Parse(kullaniciNotu);
```

### Grade Evaluation Logic

The program checks if the entered grade is within the valid range (0-100). Based on the input:
- A grade between 0 and 60 is classified as "Failing" (Başarısız).
- A grade between 61 and 80 is classified as "Average" (Orta).
- A grade between 81 and 100 is classified as "Successful" (Başarılı).

```csharp
// Girilen notun geçerli olup olmadığını kontrol ediyoruz (0 ile 100 arasında olmalı)
if (not >= 0 && not <= 100)
{
    // Notun aralığını kontrol ediyoruz ve başarı durumunu belirliyoruz
    if (not <= 60)
    {
        Console.WriteLine("Başarısız"); // Eğer not 0 ile 60 arasında ise "Başarısız" yazdırıyoruz
    }
    else if (not >= 61 && not <= 80)
    {
        Console.WriteLine("Orta"); // Eğer not 61 ile 80 arasında ise "Orta" yazdırıyoruz
    }
    else if (not >= 81 && not <= 100)
    {
        Console.WriteLine("Başarılı"); // Eğer not 81 ile 100 arasında ise "Başarılı" yazdırıyoruz
    }
}
else
{
    // Eğer not 0 ile 100 arasında değilse geçersiz giriş olduğunu belirtiyoruz
    Console.WriteLine("Geçersiz not.");
}
```

### Error Handling

The program also ensures that if the user enters a grade outside the valid range (0-100), it will display an error message. This ensures robustness in case of invalid input.

```csharp
// Eğer not 0 ile 100 arasında değilse geçersiz giriş olduğunu belirtiyoruz
Console.WriteLine("Geçersiz not.");
```

### Exit Message

Before the program exits, it waits for the user to press any key, providing a smooth exit experience.

```csharp
// Program sonlanmadan önce kullanıcıdan bir tuşa basmasını bekliyoruz
Console.WriteLine("Çıkmak için bir tuşa basın...");
Console.ReadKey(); // Konsolu kapatmadan önce kullanıcının bir tuşa basmasını bekliyoruz
```

## Usage

1. Run the application in a C# environment.
2. When prompted, enter a grade between 0 and 100.
3. The program will classify the grade as "Failing", "Average", or "Successful".
4. If an invalid grade is entered, the program will notify you with an error message.
5. Press any key to exit the program.

## License

This project is licensed under the MIT License.
