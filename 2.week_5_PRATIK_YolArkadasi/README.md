
# Vacation Planning Program

This C# program allows users to plan a vacation by selecting a destination and calculating the total cost based on various parameters.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

The purpose of this program is to help users plan a vacation by selecting a destination (Bodrum, Marmaris, or Çeşme) and calculating the total cost based on the selected location, number of people, and travel method. It provides a user-friendly interface to input data and outputs the total cost of the vacation.

## Technologies

- C# 10.0 or higher
- .NET 6.0 SDK or later

## Code Overview

### 1. Start the Program Loop

```csharp
while (true)
{
    // Loop continuously until the user decides to exit
}
```

- **Explanation**: This initiates an infinite loop that allows the program to run continuously until the user decides to exit.

### 2. Define Initial Prices

```csharp
int bodrumPrice = 4000;
int marmarisPrice = 3000;
int cesmePrice = 5000;
```

- **Explanation**: These variables store the base accommodation prices for each destination. The prices are defined as integer values.

### 3. Get User Input for Location

```csharp
string locationInput = Console.ReadLine().ToLower();
```

- **Explanation**: The program prompts the user to input their desired vacation location and converts the input to lowercase for case-insensitive comparison.

### 4. Validate the User Input

```csharp
if (locationInput != "bodrum" && locationInput != "marmaris" && locationInput != "çeşme")
{
    Console.WriteLine("Hatalı bir lokasyon girdiniz. Lütfen Bodrum, Marmaris veya Çeşme lokasyonlarından birini giriniz.");
    continue; // Repeat the loop until a valid location is entered
}
```

- **Explanation**: This block checks if the entered location is valid. If not, it prompts the user to enter a valid location and continues the loop.

### 5. Get Number of People

```csharp
int numberOfPeople = Convert.ToInt32(Console.ReadLine());
```

- **Explanation**: This line reads the number of people from user input and converts it from a string to an integer.

### 6. Provide Information About the Selected Location

```csharp
if (selectedLocation == "bodrum")
{
    Console.WriteLine("Bodrum, tarihi yerleri ve sahilleri ile ünlü. Eğlenceli bir tatil geçirebilirsiniz.");
}
else if (selectedLocation == "marmaris")
{
    Console.WriteLine("Marmaris, doğal güzellikleri ve koyları ile harika bir tatil yeridir.");
}
else
{
    Console.WriteLine("Çeşme, plajları ve sıcak atmosferi ile tatilcilerin favori noktalarından biridir.");
}
```

- **Explanation**: Depending on the selected location, the program provides a brief description to the user.

### 7. Get Travel Option

```csharp
string travelOption = Console.ReadLine();
```

- **Explanation**: The program prompts the user to choose a travel option (by road or air) and stores the selection.

### 8. Calculate Travel Costs

```csharp
if (travelOption == "1")
{
    travelCost = 1500 * numberOfPeople; // Road cost
}
else if (travelOption == "2")
{
    travelCost = 4000 * numberOfPeople; // Air cost
}
```

- **Explanation**: Depending on the user's choice, this calculates the total travel cost based on the number of people.

### 9. Calculate Total Cost

```csharp
int totalCost = locationPrice + travelCost;
```

- **Explanation**: This adds the accommodation cost (based on the selected location) to the travel cost to get the total vacation cost.

### 10. Display the Results

```csharp
Console.WriteLine($"Toplam tatil maliyeti: {totalCost} TL
");
```

- **Explanation**: Finally, the program outputs the total vacation cost to the user.

## Usage

To run this program, follow these steps:

1. Ensure that you have .NET 6.0 SDK or later installed.
2. Copy the code into a C# file (e.g., `Program.cs`).
3. Open a terminal and navigate to the project folder.
4. Run the code using the following command:
    ```bash
    dotnet run
    ```
5. Follow the prompts to enter your vacation preferences.

### Example User

- A user enters "Marmaris" for the location, "3" for the number of people, and chooses option "1" for travel by road.

## Explanation

1. The program starts by asking the user for a location and checks if it's valid.
2. Then it asks for the number of people planning to go on vacation.
3. After collecting the necessary information, it calculates the total cost based on the chosen location and travel method.
4. Finally, it displays the total vacation cost to the user.

## Output

The program will display results similar to the following based on the user's inputs:

```
Seçilen lokasyon: MARMARIS
Toplam kişi sayısı: 3
Ulaşım maliyeti: 4500 TL
Konaklama maliyeti: 9000 TL
Toplam tatil maliyeti: 13500 TL
```

## License

This project is licensed under the MIT License. Feel free to use and modify it as needed.
