# Self-Confidence Affirmation Program - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [Repetition Logic](#repetition-logic)
  - [Output](#output)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application prints the following affirmation message 10 times: 

> "Kendime inanıyorum, ben bu yazılım işini hallederim!"

This program helps boost self-confidence by repeatedly affirming positive beliefs about one's ability to succeed in software development.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### Repetition Logic

We use a `for` loop to print the message 10 times. The loop runs from `1` to `10`, and during each iteration, the message is printed once.

```csharp
int tekrarSayisi = 10; // Mesajın kaç kez yazdırılacağını belirleyen değişken

for (int i = 1; i <= tekrarSayisi; i++)
{
    // Her döngüde mesajı ekrana yazdırıyoruz
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
```

- **for loop**: The loop starts with `i = 1` and continues as long as `i` is less than or equal to `tekrarSayisi`, which is set to 10. 
- The `Console.WriteLine()` statement within the loop is executed on each iteration, printing the message.
  
### Output

Each iteration prints the same affirmation message, reinforcing self-belief and determination. Here's what the output looks like:

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

## Usage

1. Run the application in any C# environment.
2. The message "Kendime inanıyorum, ben bu yazılım işini hallederim!" will be printed 10 times.
3. After the 10th message, the program will wait for the user to press a key before exiting.

## License

This project is licensed under the MIT License.
