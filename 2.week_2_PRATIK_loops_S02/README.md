# Print Numbers from 1 to 20 - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [Number Printing Logic](#number-printing-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application prints the numbers from `1` to `20` sequentially. It's a simple demonstration of using a loop to automate the printing of consecutive numbers.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### Number Printing Logic

We use a `for` loop to iterate through the numbers from `1` to `20`. On each iteration, the current value of the loop counter (`i`) is printed to the console.

```csharp
for (int i = 1; i <= 20; i++)
{
    // Her döngüde mevcut sayıyı yazdırıyoruz
    Console.WriteLine(i);
}
```

- **for loop**: The loop starts with `i = 1` and runs as long as `i` is less than or equal to `20`.
- The `Console.WriteLine(i)` statement within the loop prints each number during the iteration.
  
### Output

The output will be a list of numbers from 1 to 20, printed line by line, like this:

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

Each number is displayed on a new line, making it easy to visualize the progression from 1 to 20.

## Usage

1. Run the application in any C# environment.
2. The numbers from 1 to 20 will be printed sequentially to the console.
3. After the number `20` is printed, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
