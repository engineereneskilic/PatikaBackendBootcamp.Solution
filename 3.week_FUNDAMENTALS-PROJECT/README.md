# C# Fundamentals Project

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

This C# console application project demonstrates three core features:
1. A Random Number Guessing Game
2. A Calculator
3. Average Calculation

Each feature is implemented as a separate method, and the user can choose which one to execute from the main menu.

## Technologies

- C#
- .NET Core

## Code Overview

### 1. Random Number Guessing Game

The user must guess a randomly generated number between 1 and 100. The program provides feedback on whether the guess is too high or too low. The user has 5 attempts to guess correctly.

```csharp
static void RandomNumberGuessingGame()
{
    Random random = new Random(); 
    int targetNumber = random.Next(1, 101); 
    int remainingAttempts = 5; 
    bool isGuessed = false; 

    Console.WriteLine("\nRandom Number Guessing Game");
    Console.WriteLine("Guess the number between 1 and 100!");

    while (remainingAttempts > 0 && !isGuessed)
    {
        Console.Write("Enter your guess: ");
        int userGuess = Convert.ToInt32(Console.ReadLine()); 

        if (userGuess < targetNumber)
        {
            Console.WriteLine("Higher! Try again.");
        }
        else if (userGuess > targetNumber)
        {
            Console.WriteLine("Lower! Try again.");
        }
        else
        {
            isGuessed = true; 
            Console.WriteLine("Congratulations! You've guessed the number.");
        }

        remainingAttempts--; 
        Console.WriteLine($"Remaining attempts: {remainingAttempts}");
    }

    if (!isGuessed)
    {
        Console.WriteLine($"Out of attempts! The correct number was {targetNumber}.");
    }
}
```

### 2. Calculator

This feature allows the user to perform basic arithmetic operations: addition, subtraction, multiplication, and division. The user inputs two numbers and selects an operation to perform.

```csharp
static void Calculator()
{
    Console.WriteLine("\nCalculator");

    Console.Write("Enter the first number: ");
    double firstNumber = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double secondNumber = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Select an operation:");
    Console.WriteLine("+ for Addition");
    Console.WriteLine("- for Subtraction");
    Console.WriteLine("* for Multiplication");
    Console.WriteLine("/ for Division");
    Console.Write("Your choice: ");
    char operation = Console.ReadKey().KeyChar;
    Console.WriteLine();

    double result = 0;

    switch (operation)
    {
        case '+':
            result = firstNumber + secondNumber;
            break;
        case '-':
            result = firstNumber - secondNumber;
            break;
        case '*':
            result = firstNumber * secondNumber;
            break;
        case '/':
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
            break;
        default:
            Console.WriteLine("Invalid operation selected.");
            return;
    }

    Console.WriteLine($"Result: {result}");
}
```

### 3. Average Calculation

The user inputs three grades, and the program calculates their average and assigns a letter grade.

```csharp
static void AverageCalculation()
{
    Console.WriteLine("\nAverage Calculation");

    double grade1 = GetValidGrade("Enter the first grade (0-100): ");
    double grade2 = GetValidGrade("Enter the second grade (0-100): ");
    double grade3 = GetValidGrade("Enter the third grade (0-100): ");

    double average = (grade1 + grade2 + grade3) / 3;

    string letterGrade = GetLetterGrade(average);

    Console.WriteLine($"Average: {average}");
    Console.WriteLine($"Letter Grade: {letterGrade}");
}

static double GetValidGrade(string prompt)
{
    double grade;
    while (true)
    {
        Console.Write(prompt);
        grade = Convert.ToDouble(Console.ReadLine());
        if (grade >= 0 && grade <= 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid grade! Please enter a grade between 0 and 100.");
        }
    }
    return grade;
}

static string GetLetterGrade(double average)
{
    if (average >= 90)
        return "AA";
    else if (average >= 85)
        return "BA";
    else if (average >= 80)
        return "BB";
    else if (average >= 75)
        return "CB";
    else if (average >= 70)
        return "CC";
    else if (average >= 65)
        return "DC";
    else if (average >= 60)
        return "DD";
    else if (average >= 55)
        return "FD";
    else
        return "FF";
}
```

## Usage

### Running the Application

1. Compile the C# code in your preferred development environment.
2. Run the application and follow the on-screen instructions.
3. Choose between the Random Number Guessing Game, Calculator, or Average Calculation feature.

```bash
dotnet run
```

### Example Usage

- For the guessing game, you will be prompted to guess a number between 1 and 100.
- The calculator allows you to perform basic arithmetic operations by entering two numbers and selecting an operation.
- The average calculation will prompt you to enter three grades and will return both the numerical average and a letter grade.

## Output

Sample outputs vary based on user interaction:

**Random Number Guessing Game:**
```
Enter your guess: 50
Higher! Try again.
Remaining attempts: 4
```

**Calculator:**
```
Enter the first number: 25
Enter the second number: 5
Select an operation: *
Result: 125
```

**Average Calculation:**
```
Enter the first grade: 85
Enter the second grade: 90
Enter the third grade: 78
Average: 84.33
Letter Grade: BB
```

## License

This project is licensed under the MIT License.
