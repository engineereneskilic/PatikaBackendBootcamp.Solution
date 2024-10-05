# Sum of Numbers between 50 and 150 using `while` Loop - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [While Loop Logic](#while-loop-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application calculates and prints the sum of all numbers between `50` and `150` using a `while` loop. It demonstrates basic control flow and accumulation of values in a simple C# program.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### While Loop Logic

The program begins by initializing a variable `toplam` to hold the sum of the numbers and starts with `50`. The `while` loop continues to run until the current number exceeds `150`. During each iteration, the current number is added to the total.

```csharp
int toplam = 0;  // Toplamı saklayacak değişkeni başlatıyoruz

int sayi = 50;   // Başlangıç sayısı 50 olarak ayarlandı

// While döngüsü: sayi 150'ye eşit veya küçük olduğu sürece çalışır
while (sayi <= 150)
{
    // Mevcut sayıyı toplam değişkenine ekliyoruz
    toplam += sayi;

    // Sayıyı bir artırıyoruz, böylece bir sonraki sayıya geçiyoruz
    sayi++;
}
```

- **`toplam`**: This variable is used to accumulate the sum of the numbers. It starts at `0`.
- **`sayi`**: This variable tracks the current number being added to the total, starting at `50`.
- **`while (sayi <= 150)`**: The loop runs as long as `sayi` is less than or equal to `150`.
- **Accumulating Total (`toplam += sayi`)**: In each iteration, the current value of `sayi` is added to `toplam`.
- **Increment by `1` (`sayi++`)**: After adding the current number to the total, `sayi` is incremented by `1` to move to the next number.

### Output

When the program is executed, it will output the sum of all numbers between `50` and `150` as follows:

```
50 ile 150 arasındaki sayıların toplamı: 7575
```

### Usage

1. Run the application in any C# environment.
2. The program will calculate the sum of all numbers between `50` and `150`.
3. After displaying the result, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
