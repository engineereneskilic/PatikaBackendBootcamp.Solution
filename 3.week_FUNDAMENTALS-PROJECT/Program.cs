using System;

namespace _3.week_FUNDAMENTALS_PROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region userMenu
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
            #endregion
        }

        /// Implements the Random Number Guessing Game
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


        /// Implements a basic calculator functionality

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
    }


}


