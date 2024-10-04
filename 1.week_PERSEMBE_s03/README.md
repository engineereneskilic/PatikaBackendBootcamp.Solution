# Age Checker - C# Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [User Input Section](#user-input-section)
  - [Age Conversion and Validation](#age-conversion-and-validation)
  - [Age Evaluation Logic](#age-evaluation-logic)
- [Usage](#usage)
- [License](#license)

## Introduction

This simple console application asks the user to input their age. Depending on whether the user is 18 years or older, the application will display a message indicating whether they are an adult or a child. It is a basic demonstration of conditionals and user input handling in C#.

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core or .NET Framework

## Code Overview

The following sections provide a breakdown of the code to explain its functionality:

### User Input Section

In this part, we prompt the user to input their age. The input is captured as a string and will later be converted into an integer for validation.

```csharp
// Kullanıcıya yaşını sormak için bir mesaj yazdırıyoruz
Console.WriteLine("Lütfen yaşınızı girin:");

// Kullanıcının girdiği yaş bilgisini almak için bir değişken tanımlıyoruz
// Burada Console.ReadLine() kullanıcının girişini alır ve bunu bir string olarak döndürür
string kullaniciYasi = Console.ReadLine();
```

### Age Conversion and Validation

Here, we convert the user input (string) into an integer using `int.Parse()`. This allows us to perform numeric comparisons. If the user provides a non-numeric input, the program would throw an error, so in real-world scenarios, additional error handling would be needed.

```csharp
// Yaş bilgisini string'ten sayısal bir değere (int) çevirmemiz gerekiyor
// Bunun için int.Parse() kullanıyoruz. Kullanıcı yanlış bir değer girerse hata oluşabilir
int yas = int.Parse(kullaniciYasi);
```

### Age Evaluation Logic

In this section, we evaluate whether the user's age is 18 or older. If the user is 18 or older, the application prints "Yetişkinsiniz" (You are an adult). If the age is less than 18, the application prints "Çocuksunuz" (You are a child).

```csharp
// Kullanıcının yaşını kontrol ediyoruz
// Eğer yaş 18 veya daha büyükse, kullanıcıya "Yetişkinsiniz" mesajı gösteriyoruz
if (yas >= 18)
{
    Console.WriteLine("Yetişkinsiniz."); // Kullanıcı yetişkinse bu mesajı gösteriyoruz
}
else
{
    // Eğer yaş 18'den küçükse, kullanıcıya "Çocuksunuz" mesajı gösteriyoruz
    Console.WriteLine("Çocuksunuz."); // Kullanıcı çocuksa bu mesajı gösteriyoruz
}
```

## Usage

1. Run the application.
2. Enter your age when prompted.
3. The program will inform you whether you are considered an adult or a child based on the age input.
4. Press any key to exit the program.

## License

This project is licensed under the MIT License.
