# Printing Even Numbers from 1 to 20 using `while` Loop - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [While Loop Logic](#while-loop-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application prints all even numbers from `1` to `20` using a `while` loop. The program demonstrates a simple approach to iterating over a range of numbers and conditionally printing only the even numbers.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### While Loop Logic

The program starts by initializing the variable `sayi` with the first even number, `2`. It then uses a `while` loop to print all even numbers up to `20` by incrementing the number by `2` on each iteration.

```csharp
int sayi = 2;  // Başlangıçta ilk çift sayı olan 2'yi ayarlıyoruz

// While döngüsü: sayi 20'ye eşit veya küçük olduğu sürece çalışır
while (sayi <= 20)
{
    // Ekrana sayıyı yazdır (çift sayı)
    Console.WriteLine(sayi);

    // Çift sayıları yazdırmak için sayıyı her seferinde 2 artırıyoruz
    sayi += 2;
}
```

- **`sayi`**: This variable stores the current number, starting with `2` (the first even number in the range). The value of `sayi` increases by `2` after each iteration.
- **`while (sayi <= 20)`**: The loop continues until the number exceeds `20`.
- **Increment by `2` (`sayi += 2`)**: Since we're only interested in even numbers, the variable `sayi` is incremented by `2` on each iteration. This ensures that only even numbers (2, 4, 6, etc.) are printed.

### Output

The program will output the even numbers between `1` and `20` as shown below:

```
2
4
6
8
10
12
14
16
18
20
```

Each even number is printed on a new line.

## Usage

1. Run the application in any C# environment.
2. The program will automatically print even numbers from `1` to `20`.
3. After printing, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
