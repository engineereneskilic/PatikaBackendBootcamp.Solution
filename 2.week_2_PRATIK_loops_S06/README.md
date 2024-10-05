# Sum of Odd and Even Numbers from 1 to 120 - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [Odd and Even Number Logic](#odd-and-even-number-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application calculates and prints the sum of all odd and even numbers between `1` and `120` separately. It demonstrates how to use loops and conditional statements to differentiate between odd and even numbers.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### Odd and Even Number Logic

The program uses a `for` loop to iterate through numbers between `1` and `120`. During each iteration, it checks whether the number is odd or even and adds it to the respective sum variable (`tekToplam` for odd and `ciftToplam` for even). 

```csharp
int tekToplam = 0;   // Tek sayıların toplamını tutmak için
int ciftToplam = 0;  // Çift sayıların toplamını tutmak için

// 1 ile 120 arasındaki tüm sayıları döngü ile geziyoruz
for (int i = 1; i <= 120; i++)
{
    // Çift sayılar için
    if (i % 2 == 0)
    {
        ciftToplam += i;  // Çift toplamı artırma
    }
    else
    {
        // Tek sayılar için
        tekToplam += i;   // Tek toplamı artırma
    }
}
```

- **`tekToplam`**: This variable holds the sum of all odd numbers.
- **`ciftToplam`**: This variable holds the sum of all even numbers.
- **`for loop`**: Iterates through numbers from `1` to `120`, checking each number's parity (odd or even).
- **Condition (`if (i % 2 == 0)`)**: Checks whether the number is even (i.e., divisible by 2 without a remainder). If it is, the number is added to the `ciftToplam`. Otherwise, it's added to the `tekToplam`.

### Output

The output will display the sum of both odd and even numbers separately:

```
Tek sayıların toplamı: 3600
Çift sayıların toplamı: 3660
```

Here, the sum of odd numbers between `1` and `120` is `3600`, and the sum of even numbers is `3660`.

## Usage

1. Run the application in any C# environment.
2. The program will calculate and print the sum of odd and even numbers separately for the range from `1` to `120`.
3. After displaying the results, the program waits for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
