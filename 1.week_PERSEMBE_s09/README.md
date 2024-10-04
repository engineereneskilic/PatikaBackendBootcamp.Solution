# Password Check - C# Console Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Explanation](#code-explanation)
  - [User Input](#user-input)
  - [Password Validation](#password-validation)
  - [Output Handling](#output-handling)
- [Usage](#usage)
- [License](#license)

## Introduction

This C# console application prompts the user to input a password and checks if it matches the predefined password `"12345"`. Based on the user's input, the program either prints "Giriş Başarılı" (Login Successful) or "Giriş Başarısız" (Login Failed).

## Technologies

- **C# Programming Language**
- **.NET Core/Framework**

## Code Explanation

### User Input

The program starts by prompting the user to enter a password. The entered password is captured using `Console.ReadLine()` and stored in a string variable.

```csharp
// Kullanıcıdan şifreyi girmesini istiyoruz
Console.WriteLine("Lütfen şifrenizi girin:");

// Kullanıcının girdiği şifreyi string olarak okuyoruz
string sifre = Console.ReadLine();
```

### Password Validation

The program checks if the entered password matches the predefined value (`"12345"`). If the password matches, it prints "Giriş Başarılı", otherwise, it prints "Giriş Başarısız".

```csharp
// Girilen şifreyi kontrol ediyoruz
if (sifre == "12345") // Şifre doğruysa
{
    // "Giriş Başarılı" mesajı yazdırıyoruz
    Console.WriteLine("Giriş Başarılı");
}
else // Şifre yanlışsa
{
    // "Giriş Başarısız" mesajı yazdırıyoruz
    Console.WriteLine("Giriş Başarısız");
}
```

### Output Handling

After checking the password, the program waits for the user to press a key before closing. This ensures that the user can see the result before the program terminates.

```csharp
// Program sonlanmadan önce bir tuşa basılmasını bekliyoruz
Console.ReadKey();
```

## Usage

1. Run the application in a C# environment.
2. When prompted, enter the password.
3. If the password is `"12345"`, the program will display "Giriş Başarılı".
4. If the password is incorrect, it will display "Giriş Başarısız".
5. Press any key to exit the application.

## License

This project is licensed under the MIT License.
