# Month Days Calculation - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [User Input](#user-input)
  - [Switch Logic for Days Calculation](#switch-logic-for-days-calculation)
  - [Invalid Input Handling](#invalid-input-handling)
- [Usage](#usage)
- [License](#license)

## Introduction

This simple console application asks the user to input a month number (1-12) and calculates how many days are in that month. It handles leap year exceptions for February (28 days) and provides appropriate error messages for invalid inputs.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### User Input

The program starts by prompting the user to enter a month number, which is then converted from a string to an integer using `Convert.ToInt32()`.

```csharp
// Kullanıcıdan ay numarasını istemek için mesaj yazdırıyoruz
Console.WriteLine("Ay no: ");

// Kullanıcının girdiği değeri alıyoruz ve tam sayıya çeviriyoruz
int ay = Convert.ToInt32(Console.ReadLine());
```

### Switch Logic for Days Calculation

A `switch` statement is used to determine the number of days for each month. The program handles February (28 days) and groups the months with 31 days for cleaner code. If an invalid month number is provided, an error message is displayed.

```csharp
// Ay numarasına göre gün sayısını belirleyen switch yapısını başlatıyoruz
switch (ay)
{
    case 2:
        adet = 28;
        break;
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        adet = 31;
        break;
    default:
        Console.WriteLine("Geçersiz bir ay numarası girdiniz !");
        Console.ReadKey();
        return;
}
```

### Invalid Input Handling

If the user enters a number outside the range of 1 to 12, the program gracefully handles the invalid input by displaying an error message and terminating after waiting for a key press.

```csharp
// Geçersiz bir ay numarası girildiğinde hata mesajı gösteriliyor
Console.WriteLine("Geçersiz bir ay numarası girdiniz !");
Console.ReadKey();
return;
```

## Usage

1. Run the application in a C# environment.
2. When prompted, enter a month number between 1 and 12.
3. The program will display the number of days in the entered month.
4. If an invalid month number is entered, an error message will appear.
5. Press any key to exit the application.

## License

This project is licensed under the MIT License.
