# Sum of Numbers from 50 to 150 - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [Sum Calculation Logic](#sum-calculation-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application calculates and prints the sum of all integers between `50` and `150`. It demonstrates the use of loops and arithmetic operations to perform cumulative addition.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### Sum Calculation Logic

The program uses a `for` loop to iterate through all numbers between `50` and `150`. Each number is added to a cumulative sum stored in the `toplam` variable. After the loop finishes, the total sum is printed to the console.

```csharp
int toplam = 0; // Toplamı tutacak değişken

// Döngü ile 50'den 150'ye kadar sayıları geziyoruz
for (int i = 50; i <= 150; i++)
{
    // Her sayıyı toplama ekliyoruz
    toplam += i;
}

// Sonucu ekrana yazdırıyoruz
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);
```

- **`toplam` variable**: Stores the cumulative sum of all numbers from 50 to 150.
- **for loop**: The loop starts at 50 and runs until it reaches 150, adding each number to the `toplam` variable.
- **Console Output**: After the loop completes, the final sum is printed.

### Output

The output will be the sum of all numbers between 50 and 150:

```
50 ile 150 arasındaki sayıların toplamı: 10100
```

This sum represents the addition of all integers within the given range.

## Usage

1. Run the application in any C# environment.
2. The program will print the sum of numbers between `50` and `150` on the console.
3. After displaying the result, the program waits for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
