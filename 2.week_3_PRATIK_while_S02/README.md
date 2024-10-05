# Printing Numbers from 1 to 20 using `while` Loop - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [While Loop Logic](#while-loop-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application prints numbers from `1` to `20` using a `while` loop. The application demonstrates how to implement a simple loop structure to iterate over a range of numbers and print them sequentially.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### While Loop Logic

The program begins by initializing a variable (`sayi`) with the value `1`, and then uses a `while` loop to print the numbers up to `20`.

```csharp
int sayi = 1;  // Sayı başlangıç değeri 1

// While döngüsü sayi 20'den küçük veya eşit olduğu sürece çalışır
while (sayi <= 20)
{
    // Ekrana sayıyı yazdır
    Console.WriteLine(sayi);

    // sayi değeri her seferinde 1 artırılır
    sayi++;
}
```

- **`sayi`**: This variable stores the current number to be printed. It starts at `1` and increments by `1` in each iteration.
- **`while (sayi <= 20)`**: This condition ensures that the loop continues running as long as the number (`sayi`) is less than or equal to `20`.
- **Incrementing the number (`sayi++`)**: After printing the current number, the counter is incremented by `1`. This process continues until the counter reaches `21`, at which point the loop terminates.

### Output

The output will display the numbers from `1` to `20`:

```
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
```

Each number is printed on a new line, starting from `1` and ending at `20`.

## Usage

1. Run the application in any C# environment.
2. The program will automatically print the numbers from `1` to `20`.
3. After printing, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
