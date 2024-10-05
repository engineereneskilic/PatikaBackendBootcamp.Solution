# Print Even Numbers from 1 to 20 - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [Even Number Logic](#even-number-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application prints the even numbers between `1` and `20`. It uses a simple loop combined with a condition to filter out odd numbers, showcasing basic control structures in C#.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### Even Number Logic

To print only the even numbers between `1` and `20`, we use a `for` loop that iterates through all numbers in this range. Inside the loop, a condition checks whether each number is divisible by `2`. If the number is divisible by `2` (i.e., the remainder when divided by `2` is zero), it is considered an even number and is printed.

```csharp
for (int i = 1; i <= 20; i++)
{
    // Eğer sayı 2'ye tam bölünüyorsa çift sayıdır
    if (i % 2 == 0)
    {
        // Çift sayıyı ekrana yazdırıyoruz
        Console.WriteLine(i);
    }
}
```

- **for loop**: The loop runs from `1` to `20`, checking each number.
- **Condition (`if (i % 2 == 0)`)**: This checks if the number is divisible by `2`. If it is, the number is printed as a "çift sayı" (even number).
  
### Output

The output will be a list of even numbers between 1 and 20, printed line by line:

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

These are all the even numbers between 1 and 20, with each number appearing on a new line.

## Usage

1. Run the application in any C# environment.
2. The even numbers between 1 and 20 will be printed sequentially to the console.
3. After the last even number `20` is printed, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
