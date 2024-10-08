# First Method Application (Pratik - İlk Metot Uygulaması)

This C# console application demonstrates the use of methods by defining and calling four different methods. These methods range from returning values to accepting parameters, showcasing the flexibility of methods in C#.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

The program has four main methods: 
1. A `void` method that prints a favorite song lyric.
2. A method that returns the remainder when dividing a random number by 2.
3. A method that multiplies two user-provided numbers and returns the result.
4. A `void` method that accepts a name and surname and prints a welcome message.

## Technologies

- C# 10.0 or higher
- .NET 6.0 SDK or later

## Code Overview

### 1. Void Method to Print a Favorite Song Lyric

```csharp
void PrintFavoriteSongLyric()
{
    Console.WriteLine("Sevdiğiniz şarkının sözünü buraya yazın: 'Bazen ne yaparsan yap olmuyor!'");
}

- **Explanation**: This method prints a string containing a favorite song lyric to the console. The method does not return any value.

### 2. Method That Returns Remainder of a Random Number Divided by 2

```csharp
int GetRandomNumberMod2()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretir.
    return randomNumber % 2; // Sayının 2'ye bölümünden kalanı döndürür.
}
```
- **Explanation**: This method generates a random number between 1 and 100, calculates the remainder when the number is divided by 2, and returns the result. This demonstrates the use of basic mathematical operations in C#

### 3. Method to Multiply Two Numbers and Return the Result

```csharp
int MultiplyTwoNumbers(int number1, int number2)
{
    return number1 * number2;
}
```
- **Explanation**: This method takes two integer parameters, multiplies them, and returns the result. It is useful for demonstrating how methods can accept parameters and return calculated values.
### 4. Void Method That Accepts Name and Surname and Prints a Welcome Message

```csharp
void PrintWelcomeMessage(string firstName, string lastName)
{
    Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}");
}
```
- **Explanation**: This method accepts two string parameters: the first name and the last name. It then prints a formatted welcome message using the provided name and surname.

  ## Usage

To run this program, follow these steps:

1. Ensure that you have .NET 6.0 SDK or later installed.
2. Copy the code into a C# file (e.g., `Program.cs`).
3. Open a terminal and navigate to the project folder.
4. Run the code using the following command:
    ```bash
    dotnet run
    ```
5. Follow the prompts to enter your vacation preferences.

### Example Usage

## Explanation

This application helps beginners understand the following key concepts in C#:

1. Void methods that do not return any values.
2. Methods that accept parameters and return results.
3. Basic console I/O for interacting with users.
4. Using random number generation and basic mathematical operations.

## Output

The program will display results similar to the following based on the user's inputs:

```
İsminizi giriniz: Enes
Soyisminizi giriniz: Kılıç
Hoş Geldiniz Enes Kılıç
```

## License

This project is licensed under the MIT License. Feel free to use and modify it as needed.
  
