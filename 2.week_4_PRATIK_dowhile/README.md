# While vs Do-While - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [While Loop](#while-loop)
  - [Do-While Loop](#do-while-loop)
  - [While vs Do-While Differences](#while-vs-do-while-differences)
  - [Example Input/Output](#example-input-output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application demonstrates the difference between the `while` and `do-while` loops by counting up to a user-defined limit and printing the message `"Ben bir Patika'lıyım"`. The main objective is to understand how these loops handle the conditional check differently, especially when the input is negative.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### While Loop

The `while` loop checks the condition **before** executing the block of code. If the condition is `false` from the beginning, the loop does not execute at all.

```csharp
int sayac = 0; // Sayaç başlatılıyor

// While döngüsünde koşul her şeyden önce kontrol edilir
while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım, sayaç: " + sayac);
    sayac++; // Sayaç her döngüde 1 artırılır
}
```

In this block, the loop will continue to print `"Ben bir Patika'lıyım"` as long as the counter (`sayac`) is less than or equal to the user-provided `limit`.

### Do-While Loop

The `do-while` loop executes the block of code **at least once**, even if the condition is `false`, because the condition is checked **after** the loop's body.

```csharp
sayac = 0; // Sayaç yeniden başlatılıyor

// Do-While döngüsünde en az bir kez döngü çalışır
do
{
    Console.WriteLine("Ben bir Patika'lıyım, sayaç: " + sayac);
    sayac++; // Sayaç her döngüde 1 artırılır
} while (sayac <= limit); // Koşul sonradan kontrol edilir
```

Even if the initial value of `limit` is negative, the loop will execute **at least once**, making it different from the `while` loop.

### While vs Do-While Differences

- **While Loop**: The condition is checked first. If the condition is `false`, the loop will not run at all.
- **Do-While Loop**: The condition is checked after the loop's body is executed, meaning the loop will run at least once, even if the condition is `false`.
  
#### Example Scenario:
- **Input**: `limit = 10`
  - Both loops will run from `0` to `10`.
- **Input**: `limit = -5`
  - The `while` loop does not execute because the condition (`0 <= -5`) is `false`.
  - The `do-while` loop executes once before checking the condition, printing one message even though the condition is `false`.

### Example Input/Output

#### Input: 10
- While Loop Output:
    ```
    Ben bir Patika'lıyım, sayaç: 0
    Ben bir Patika'lıyım, sayaç: 1
    ...
    Ben bir Patika'lıyım, sayaç: 10
    ```

- Do-While Loop Output:
    ```
    Ben bir Patika'lıyım, sayaç: 0
    Ben bir Patika'lıyım, sayaç: 1
    ...
    Ben bir Patika'lıyım, sayaç: 10
    ```

#### Input: -5
- While Loop Output:
    ```
    (No output)
    ```

- Do-While Loop Output:
    ```
    Ben bir Patika'lıyım, sayaç: 0
    ```

## Usage

1. Run the application in any C# environment.
2. Provide a limit value as input.
3. Observe the difference in behavior between the `while` and `do-while` loops depending on the input.

## License

This project is licensed under the MIT License.
