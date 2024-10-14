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

### Display the Menu
Section where three applications are listed for the user to choose.
```csharp
// Display the menu for the user to choose an option
Console.WriteLine("Welcome to the C# Fundamentals Project!");
Console.WriteLine("Please choose an option:");
Console.WriteLine("1 - Random Number Guessing Game");
Console.WriteLine("2 - Calculator");
Console.WriteLine("3 - Average Calculation");
Console.Write("Your choice: ");

// Read user input and convert it to an integer
int userChoice = Convert.ToInt32(Console.ReadLine());

// Execute the selected option based on user input
switch (userChoice)
{
    case 1:
        RandomNumberGuessingGame();
        break;
    case 2:
        Calculator();
        break;
    case 3:
        AverageCalculation();
        break;
    default:
        Console.WriteLine("Invalid choice! Please select a valid option.");
        break;
} 
```
### 1. Random Number Guessing Game

The user must guess a randomly generated number between 1 and 100. The program provides feedback on whether the guess is too high or too low. The user has 5 attempts to guess correctly.

```csharp
#region RandomGuessingGame
static void RandomNumberGuessingGame()
{
    Random random = new Random(); // Random number generator
    int targetNumber = random.Next(1, 101); // Generate a random number between 1 and 100
    int remainingAttempts = 5; // Number of attempts the user has
    bool isGuessed = false; // Flag to check if the number was guessed

    Console.WriteLine("\nRandom Number Guessing Game");
    Console.WriteLine("Guess the number between 1 and 100!");

    // Loop until the user runs out of attempts or guesses correctly
    while (remainingAttempts > 0 && !isGuessed)
    {
        Console.Write("Enter your guess: ");
        int userGuess = Convert.ToInt32(Console.ReadLine()); // Read user input

        // Check the user's guess against the target number
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
            isGuessed = true; // User guessed correctly
            Console.WriteLine("Congratulations! You've guessed the number.");
        }

        remainingAttempts--; // Decrement the number of remaining attempts
        Console.WriteLine($"Remaining attempts: {remainingAttempts}");
    }

    // If the user did not guess correctly within the attempts, reveal the number
    if (!isGuessed)
    {
        Console.WriteLine($"Out of attempts! The correct number was {targetNumber}.");
    }
}
#endregion
```

### 2. Calculator

This feature allows the user to perform basic arithmetic operations: addition, subtraction, multiplication, and division. The user inputs two numbers and selects an operation to perform.

```csharp
#region Calculator
static void Calculator()
{
    Console.WriteLine("\nCalculator");

    // Prompt user for the first number
    Console.Write("Enter the first number: ");
    double firstNumber = Convert.ToDouble(Console.ReadLine());

    // Prompt user for the second number
    Console.Write("Enter the second number: ");
    double secondNumber = Convert.ToDouble(Console.ReadLine());

    // Prompt user to select an operation
    Console.WriteLine("Select an operation:");
    Console.WriteLine("+ for Addition");
    Console.WriteLine("- for Subtraction");
    Console.WriteLine("* for Multiplication");
    Console.WriteLine("/ for Division");
    Console.Write("Your choice: ");
    char operation = Console.ReadKey().KeyChar; // Read the operation input
    Console.WriteLine();

    double result = 0; // Variable to store the result
    // Perform the selected operation
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
            // Check for division by zero
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return; // Exit the method
            }
            break;
        default:
            Console.WriteLine("Invalid operation selected.");
            return; // Exit the method
    }

    // Display the result of the calculation
    Console.WriteLine($"Result: {result}");
}
#endregion
```

### 3. Average Calculation

The user inputs three grades, and the program calculates their average and assigns a letter grade.

```csharp
 #region Average Calculation
 /// Calculates the average of three grades and assigns a letter grade
 static void AverageCalculation()
 {
     Console.WriteLine("\nAverage Calculation");

     // Prompt user for grades and validate the input
     double grade1 = GetValidGrade("Enter the first grade (0-100): ");
     double grade2 = GetValidGrade("Enter the second grade (0-100): ");
     double grade3 = GetValidGrade("Enter the third grade (0-100): ");

     // Calculate the average of the grades
     double average = (grade1 + grade2 + grade3) / 3;

     // Determine the letter grade based on the average
     string letterGrade = GetLetterGrade(average);

     // Display the average and letter grade
     Console.WriteLine($"Average: {average}");
     Console.WriteLine($"Letter Grade: {letterGrade}");
 } 
 #endregion


 /// Gets a valid grade input from the user

 static double GetValidGrade(string prompt)
 {
     double grade;
     while (true)
     {
         Console.Write(prompt);
         grade = Convert.ToDouble(Console.ReadLine()); // Read user input
         if (grade >= 0 && grade <= 100) // Check if grade is valid
         {
             break; // Valid input, exit the loop
         }
         else
         {
             Console.WriteLine("Invalid grade! Please enter a grade between 0 and 100.");
         }
     }
     return grade; // Return valid grade
 }


 /// Gets the letter grade corresponding to the average


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
         return "FF"; // Default case for average below 55
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
