# Simple Calculator - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [User Input](#user-input)
  - [Operation Selection](#operation-selection)
  - [Calculations and Error Handling](#calculations-and-error-handling)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application allows users to perform basic arithmetic operations. The user is prompted to enter two numbers and an operation (+, -, *, /). The application calculates the result based on the chosen operation and displays it. If the user enters an invalid operation, an error message is shown.

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### User Input

The program begins by prompting the user for two numbers. Each number is read as a string and converted to a double for calculation.

```csharp
// Kullanıcıdan ilk sayıyı girmesini istiyoruz
Console.WriteLine("Birinci sayıyı girin:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

// Kullanıcıdan ikinci sayıyı girmesini istiyoruz
Console.WriteLine("İkinci sayıyı girin:");
double sayi2 = Convert.ToDouble(Console.ReadLine());
```

### Operation Selection

After obtaining the numbers, the program prompts the user to enter the desired arithmetic operation. This input is also read as a string.

```csharp
// Kullanıcıdan hangi işlemi yapmak istediğini sormak için mesaj yazdırıyoruz
Console.WriteLine("Yapmak istediğiniz işlemi girin (+, -, *, /):");
string islem = Console.ReadLine();
```

### Calculations and Error Handling

Using a `switch` statement, the program performs the specified operation. Each case handles one arithmetic operation. Special attention is given to the division operation to prevent division by zero errors. The final result is displayed only once after all operations are complete.

```csharp
switch (islem)
{
    case "+":
        sonuc = sayi1 + sayi2; // Toplama işlemi
        break;
    case "-":
        sonuc = sayi1 - sayi2; // Çıkarma işlemi
        break;
    case "*":
        sonuc = sayi1 * sayi2; // Çarpma işlemi
        break;
    case "/":
        if (sayi2 != 0) 
        {
            sonuc = sayi1 / sayi2; // Bölme işlemi
        }
        else
        {
            Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
            Console.ReadKey();
            return; // Hata durumunda programı sonlandırıyoruz
        }
        break;
    default:
        Console.WriteLine("Geçersiz işlem");
        Console.ReadKey();
        return; // Hata durumunda programı sonlandırıyoruz
}

// Tüm işlemler tamamlandıktan sonra sonucu yazdırıyoruz
Console.WriteLine("Sonuç: " + sonuc);
```

## Usage

1. Run the application in a C# environment.
2. Enter the first number when prompted.
3. Enter the second number.
4. Choose an arithmetic operation (+, -, *, /).
5. The program will display the result of the operation.
6. If an invalid operation is entered or an attempt to divide by zero occurs, an error message will be shown.
7. Press any key to exit the application.

## License

This project is licensed under the MIT License.
