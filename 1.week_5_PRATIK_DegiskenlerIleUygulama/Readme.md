# User Information and Purchase Point Calculation Program

This repository contains a C# program that collects user information and calculates the earned points based on the total price of two purchased products.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [License](#license)

## Introduction

This program collects user information such as Turkish ID number, name, surname, telephone number, age, and the prices of two purchased products. Based on the total price, it calculates the earned points as a percentage of the total purchase, set by default to 10%.

## Technologies

- C# 10.0 or higher
- .NET 5.0 SDK or later

## Code Overview

### 1. Define the Earned Points Percentage

```csharp
const decimal EARNED_PATH_POINTS_PERCENTAGE = 0.1m; // %10
```

- **Explanation**: This line declares a constant variable named `EARNED_PATH_POINTS_PERCENTAGE` and sets its value to 0.1, which represents 10%. This value will be used to calculate the earned points based on the total price of the products purchased.

### 2. Greet the User

```csharp
Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");
```

- **Explanation**: This line displays a message to the user, prompting them to enter their information.

### 3. Collect User's Turkish ID Number

```csharp
Console.Write("T.C Kimlik Numarası: ");
string turkishIDNumber = Console.ReadLine();
```

- **Explanation**: The program asks the user to input their Turkish ID number. The input is read as a string and stored in the variable `turkishIDNumber`. It is stored as a string to conserve memory since it will not be used for numerical calculations.

### 4. Collect User's Name

```csharp
Console.Write("Adı: ");
string name = Console.ReadLine();
```

- **Explanation**: The program prompts the user for their first name, which is also stored as a string in the variable `name`.

### 5. Collect User's Surname

```csharp
Console.Write("Soyadı: ");
string surname = Console.ReadLine();
```

- **Explanation**: Similar to the previous step, the program asks for the user's surname and stores it in the `surname` variable.

### 6. Collect User's Telephone Number

```csharp
Console.Write("Telefon Numarası: ");
string telephoneNumber = Console.ReadLine();
```

- **Explanation**: The program prompts the user to enter their telephone number, which is stored as a string in `telephoneNumber`. 

### 7. Collect User's Age

```csharp
Console.Write("Yaş: ");
string age = Console.ReadLine();
```

- **Explanation**: The program asks for the user's age. The input is taken as a string and stored in the `age` variable for later use if needed.

### 8. Collect the Price of the First Purchased Product

```csharp
Console.Write("İlk aldığı Ürünün Fiyatı: ");
decimal firstPurchasedProductPrice = Convert.ToDecimal(Console.ReadLine());
```

- **Explanation**: The program prompts the user to input the price of their first purchased product. The input is converted to a `decimal` type and stored in `firstPurchasedProductPrice` for precise monetary representation.

### 9. Collect the Price of the Second Purchased Product

```csharp
Console.Write("İkinci aldığı Ürünün Fiyatı: ");
decimal secondPurchasedProductPrice = Convert.ToDecimal(Console.ReadLine());
```

- **Explanation**: This step is similar to the previous one, where the program collects the price of the second purchased product and stores it as a `decimal` in `secondPurchasedProductPrice`.

### 10. Calculate the Total Price of Both Products

```csharp
decimal firstAndSecondProductTotalPrice = firstPurchasedProductPrice + secondPurchasedProductPrice;
```

- **Explanation**: Here, the program calculates the total price of both products by adding the two previously collected prices. The result is stored in `firstAndSecondProductTotalPrice`.

### 11. Calculate the Discounted Points Earned

```csharp
decimal discountedPriceforPatika = firstAndSecondProductTotalPrice * EARNED_PATH_POINTS_PERCENTAGE;
```

- **Explanation**: This line calculates the earned points based on the total price of the products and the predefined percentage. The result is stored in `discountedPriceforPatika`.

### 12. Display User Information and Calculated Points

```csharp
Console.WriteLine("-------------------------------------------------------------------------------------");
Console.WriteLine(turkishIDNumber + " Tc numaralı " + name + " " + surname + " isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine(telephoneNumber + " telefon numarasına bildirim gönderilmiştir.");
Console.WriteLine($"{firstAndSecondProductTotalPrice} toplam harcama karşılığı kazanılan {(EARNED_PATH_POINTS_PERCENTAGE * 100).ToString("0.#")}% patika puan miktarı -> {discountedPriceforPatika.ToString("0.#")} 'dir.");
```

- **Explanation**: 
    - This section displays a line separator for better readability.
    - It then outputs a message confirming the user’s registration with their Turkish ID number, name, and surname.
    - Next, it informs the user that a notification has been sent to their telephone number.
    - Finally, it displays the total amount spent and the corresponding earned points, formatted to show one decimal place.

### Important Notes

- The `decimal` type is used for financial calculations to prevent rounding errors.
- Turkish ID and telephone numbers are collected as strings for efficient storage, as they are not used for calculations.

## Usage

To use this code in your project:

1. Ensure that you have .NET 6.0 SDK or later installed.
2. Copy the code into a C# file (e.g., `Program.cs`).
3. Open a terminal and navigate to the project folder.
4. Run the code using the following command:
    ```bash
    dotnet run
    ```
5. Follow the prompts to enter the required information. The program will display the calculated results.

## License

This project is licensed under the MIT License. Feel free to use and modify it as needed.
