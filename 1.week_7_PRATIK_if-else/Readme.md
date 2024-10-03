# Number Comparison Program

This C# program prompts the user to enter a number, checks if the number is equal to, less than, or greater than 10, and then outputs the result accordingly.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [License](#license)

## Introduction

The purpose of this program is to receive an integer input from the user and determine its relationship with the number 10. It provides feedback indicating whether the entered number is equal to, less than, or greater than 10.

## Technologies

- C# 10.0 or higher
- .NET 6.0 SDK or later

## Code Overview

### 1. Prompt the User for Input

```csharp
Console.Write("Lütfen bir sayı değeri giriniz: ");
```

- **Explanation**: The program displays a message prompting the user to input a number.

### 2. Read and Convert the Input to an Integer

```csharp
int sayi = Convert.ToInt32(Console.ReadLine());
```

- **Explanation**: The value entered by the user is read as a string using `Console.ReadLine()`. This value is then converted to an integer using the `Convert.ToInt32()` function, and the result is stored in the `sayi` variable.

### 3. Check if the Entered Number Equals 10

```csharp
if (sayi == 10)
{
    Console.WriteLine("Sayi 10'a eşittir.");
}
```

- **Explanation**: The program checks if the value stored in `sayi` is equal to 10. If the condition is true, the message "Sayı 10'a eşittir" is displayed.

### 4. Check if the Entered Number is Less Than 10

```csharp
else if (sayi < 10)
{
    Console.WriteLine("Sayı 10'dan küçüktür");
}
```

- **Explanation**: If the previous condition is false, the program checks whether the value is less than 10. If so, it displays "Sayı 10'dan küçüktür."

### 5. If the Number is Greater Than 10

```csharp
else
{
    Console.WriteLine("Sayı 10'dan büyüktür");
}
```

- **Explanation**: If the value is neither equal to nor less than 10, the program assumes it is greater than 10 and displays "Sayı 10'dan büyüktür."

### Summary of Logic

1. The program first checks if the number is equal to 10.
2. If the number is less than 10, it outputs that the number is smaller.
3. If neither of the above conditions is met, the program outputs that the number is larger than 10.

## Usage

To run this program, follow these steps:

1. Ensure that you have .NET 6.0 SDK or later installed.
2. Copy the code into a C# file (e.g., `Program.cs`).
3. Open a terminal and navigate to the project folder.
4. Run the code using the following command:
    ```bash
    dotnet run
    ```
5. Enter a number when prompted, and the program will output whether the number is equal to, less than, or greater than 10.

## License

This project is licensed under the MIT License. Feel free to use and modify it as needed.
