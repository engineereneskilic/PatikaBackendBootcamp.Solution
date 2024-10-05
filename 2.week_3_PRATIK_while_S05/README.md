# Sum of Odd and Even Numbers between 1 and 120 using `while` Loop - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [While Loop Logic](#while-loop-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application calculates and prints the sums of odd and even numbers between `1` and `120` using a `while` loop. It demonstrates the use of conditionals and loops in a simple C# program.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### While Loop Logic

The program begins by initializing two variables, `tekToplam` and `ciftToplam`, to hold the sums of odd and even numbers, respectively. The counting starts from `1`, and the `while` loop continues until the current number exceeds `120`.

```csharp
int tekToplam = 0;   // Tek sayıların toplamını saklayacak değişken
int ciftToplam = 0;  // Çift sayıların toplamını saklayacak değişken

int sayi = 1;        // Sayıyı 1'den başlatıyoruz

// While döngüsü: sayi 120'ye eşit veya küçük olduğu sürece çalışır
while (sayi <= 120)
{
    // Sayının çift olup olmadığını kontrol ediyoruz
    if (sayi % 2 == 0) // Eğer sayının 2'ye bölümünden kalan 0 ise
    {
        ciftToplam += sayi; // Sayıyı çift toplamına ekliyoruz
    }
    else // Eğer sayı tek ise
    {
        tekToplam += sayi; // Sayıyı tek toplamına ekliyoruz
    }

    // Sayıyı bir artırıyoruz, böylece bir sonraki sayıya geçiyoruz
    sayi++;
}
```

- **`tekToplam`**: This variable accumulates the total of all odd numbers between `1` and `120`. It starts at `0`.
- **`ciftToplam`**: This variable accumulates the total of all even numbers between `1` and `120`. It also starts at `0`.
- **`while (sayi <= 120)`**: The loop continues to run as long as `sayi` is less than or equal to `120`.
- **Conditional Check (`if (sayi % 2 == 0)`)**: This checks whether the current number is even by seeing if the remainder when divided by `2` is `0`.
- **Adding to Totals**: Depending on whether the number is odd or even, it is added to the respective total.

### Output

When the program is executed, it will output the sums of odd and even numbers between `1` and `120` as follows:

```
1 ile 120 arasındaki tek sayıların toplamı: 3600
1 ile 120 arasındaki çift sayıların toplamı: 7260
```

### Usage

1. Run the application in any C# environment.
2. The program will calculate the sums of all odd and even numbers between `1` and `120`.
3. After displaying the results, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
