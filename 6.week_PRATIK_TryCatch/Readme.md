
# Try-Catch Example in C#

## Introduction
This project demonstrates a basic usage of the `try-catch` block in C#. It aims to handle potential input errors from the user when requesting a numeric input. If the user enters a valid number, the program will display the square of that number. If the user enters invalid input (like letters or symbols), the program will catch the error and prompt the user to enter a valid number.

## Technologies
- **C#**: The program is written in C# and uses the .NET Core framework.
- **.NET Core Console Application**: This is a console-based application.

## Code Overview
The code uses a loop to continuously prompt the user for input until a valid number is entered. It uses a `try-catch` block to catch `FormatException` errors when the input cannot be converted to an integer.

## Explanation
The following sections break down each part of the code with explanations for each operation.

### 1. Defining the `isValid` Flag
```csharp
bool isValid = false;
```
- The `isValid` boolean flag is initialized to `false`. This flag is used to control the loop. The loop continues until the user enters a valid numeric input.

### 2. Starting a Loop to Get Input
```csharp
while (!isValid)
{
    Console.Write("Lütfen bir sayı giriniz: ");
```
- A `while` loop is used to keep asking the user for input until a valid integer is provided.
- The message "Lütfen bir sayı giriniz: " prompts the user to enter a number.

### 3. Using `try-catch` to Handle Invalid Input
```csharp
try
{
    // Getting input from the user
    string input = Console.ReadLine();
    
    // Converting input to integer
    int number = Convert.ToInt32(input);
    
    // If the input is valid, calculate and display the square of the number
    Console.WriteLine($"Girilen sayının karesi: {number * number}");
    
    isValid = true; // Set the flag to true to exit the loop
}
catch (FormatException)
{
    // Display an error message if the input is not a valid integer
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
}
```
- The `try` block:
    - **Reads the input**: Using `Console.ReadLine()`, the program receives input from the user.
    - **Converts the input**: `Convert.ToInt32(input)` attempts to convert the input to an integer.
    - **Calculates the square**: If the conversion is successful, the square of the number is calculated and displayed.
    - **Sets `isValid` to `true`**: This exits the loop since a valid number has been entered.
- The `catch` block:
    - **Handles invalid input**: If `Convert.ToInt32(input)` fails (for example, if the input is "abc" instead of a number), a `FormatException` is thrown. 
    - **Displays an error message**: The message "Geçersiz giriş! Lütfen bir sayı giriniz." is shown to inform the user of the mistake.

### 4. Ending the Program
- When a valid number is entered, `isValid` is set to `true`, which ends the loop and the program terminates after displaying the square of the number.

## Usage
1. **Run the Program**: Start the application in a .NET Core-compatible environment.
2. **Input**: Enter any valid integer. If the input is not an integer, an error message will be displayed, and the program will ask for input again.
3. **Expected Output**:
    - **Valid Input**: If a valid number (e.g., `5`) is entered, the program will display `25` (the square of `5`).
    - **Invalid Input**: If an invalid input (e.g., `abc`) is entered, the program will display "Geçersiz giriş! Lütfen bir sayı giriniz." and ask for a new input.

### Example
```plaintext
Lütfen bir sayı giriniz: abc
Geçersiz giriş! Lütfen bir sayı giriniz.
Lütfen bir sayı giriniz: 7
Girilen sayının karesi: 49
```

## Output
- **Valid Input**:
    ```plaintext
    Lütfen bir sayı giriniz: 8
    Girilen sayının karesi: 64
    ```
- **Invalid Input**:
    ```plaintext
    Lütfen bir sayı giriniz: hello
    Geçersiz giriş! Lütfen bir sayı giriniz.
    ```

## License
This project is open-source and available under the MIT License.
