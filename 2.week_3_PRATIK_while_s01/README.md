# Printing a Message 10 Times using `while` Loop - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [While Loop Logic](#while-loop-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application prints the message `"Kendime inanıyorum, ben bu yazılım işini hallederim!"` ten times using a `while` loop. The program demonstrates how to utilize loops to repeat an action multiple times in C#.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### While Loop Logic

The program initializes a counter variable (`sayac`) at `1`, and repeatedly prints the message until the counter reaches `10`. The `while` loop is used here to ensure that the message is printed the desired number of times.

```csharp
int sayac = 1;  // Sayaç başlangıç değeri 1

// While döngüsü 10 kez çalışacak şekilde ayarlanmıştır
while (sayac <= 10)
{
    // Mesajı ekrana yazdırıyoruz
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");

    // Sayaç her döngü sonunda 1 artırılır
    sayac++; 
}
```

- **`sayac`**: This is a counter variable that keeps track of how many times the message has been printed.
- **`while (sayac <= 10)`**: This is the loop condition. As long as the counter (`sayac`) is less than or equal to `10`, the loop will continue.
- **Incrementing the counter (`sayac++`)**: After printing the message, the counter is incremented by `1`. This ensures that the loop eventually stops when the counter reaches `10`.

### Output

The output will display the message ten times:

```
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
```

Here, the message is repeated exactly `10` times.

## Usage

1. Run the application in any C# environment.
2. The program will automatically print the message ten times.
3. After printing, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
