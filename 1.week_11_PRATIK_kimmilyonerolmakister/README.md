# Kim Milyoner Olmak İster? - C# Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [Question and Answer Definition](#question-and-answer-definition)
  - [Correct Answer Counter](#correct-answer-counter)
  - [Question 1 Flow](#question-1-flow)
  - [Question 2 Flow](#question-2-flow)
  - [Result Evaluation](#result-evaluation)
- [Usage](#usage)
- [License](#license)

## Introduction

This application asks the user 3 questions and determines whether they win the grand prize based on the number of correct answers. The application is written without using loops or two-dimensional arrays.

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core or .NET Framework

## Code Overview

Below is the code written in C#:

```csharp
using System;

class Program
{
    static void Main()
    {
        // Soruları ve cevapları tanımlama
        // Soru 1
        string soru1 = "Kızınca tüküren hayvan hangisidir?";
        string cevap1A = "a) Lama"; // Seçenek A
        string cevap1B = "b) Deve"; // Seçenek B
        string dogruCevap1 = "a"; // Doğru cevap (A seçeneği)

        // Soru 2
        string soru2 = "Dünya'ya en yakın gezegen hangisidir?";
        string cevap2A = "a) Venüs"; // Seçenek A
        string cevap2B = "b) Mars"; // Seçenek B
        string dogruCevap2 = "a"; // Doğru cevap (A seçeneği)

        // Soru 3
        string soru3 = "5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?";
        string cevap3A = "a) 7"; // Seçenek A
        string cevap3B = "b) 12"; // Seçenek B
        string dogruCevap3 = "b"; // Doğru cevap (B seçeneği)

        // Doğru cevap sayısını tutmak için bir değişken oluşturuyoruz
        int dogruSayisi = 0;

        // Soru 1'i soruyoruz
        Console.WriteLine($"Soru 1: {soru1}"); // Soruyu yazdır
        Console.WriteLine(cevap1A); // Seçenek A'yı yazdır
        Console.WriteLine(cevap1B); // Seçenek B'yi yazdır
        Console.Write("Cevabınızı girin (A veya B): "); // Kullanıcıdan cevap bekliyoruz
        string cevap1 = Console.ReadLine().Trim().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

        // Kullanıcının cevabını kontrol et
        if (cevap1 == dogruCevap1) // Cevap doğruysa
        {
            Console.WriteLine("Doğru cevap!"); // Kullanıcıya doğru cevap olduğunu bildir
            dogruSayisi++; // Doğru cevap sayısını artır
        }
        else // Cevap yanlışsa
        {
            Console.WriteLine("Yanlış cevap!"); // Kullanıcıya yanlış cevap olduğunu bildir
        }

        // Soru 2'yi soruyoruz
        Console.WriteLine($"Soru 2: {soru2}"); // Soruyu yazdır
        Console.WriteLine(cevap2A); // Seçenek A'yı yazdır
        Console.WriteLine(cevap2B); // Seçenek B'yi yazdır
        Console.Write("Cevabınızı girin (A veya B): "); // Kullanıcıdan cevap bekliyoruz
        string cevap2 = Console.ReadLine().Trim().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

        // Kullanıcının cevabını kontrol et
        if (cevap2 == dogruCevap2) // Cevap doğruysa
        {
            Console.WriteLine("Doğru cevap!"); // Kullanıcıya doğru cevap olduğunu bildir
            dogruSayisi++; // Doğru cevap sayısını artır
        }
        else // Cevap yanlışsa
        {
            Console.WriteLine("Yanlış cevap!"); // Kullanıcıya yanlış cevap olduğunu bildir
        }

        // Kullanıcıya 3. soru sorulmaz, sonuç kontrolü yapıyoruz
        // Doğru cevap sayısına göre büyük ödül kazanıp kazanmadığını kontrol ediyoruz
        if (dogruSayisi >= 2) // Eğer kullanıcının doğru cevap sayısı 2 veya daha fazla ise
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!"); // Kullanıcıya ödül kazandığını bildir
        }
        else // Kullanıcının doğru cevap sayısı 2'den az ise
        {
            Console.WriteLine("Üzgünüm, büyük ödülü kazanamadınız."); // Kullanıcıya ödülü kazanamadığını bildir
        }

        // Programın bitişi
        Console.WriteLine("Çıkmak için bir tuşa basın..."); // Kullanıcıya çıkmak için bir tuşa basmasını söyle
        Console.ReadKey(); // Kullanıcının bir tuşa basmasını bekle
    }
}
```

### Question and Answer Definition

In this section, we define the questions and their corresponding answer options:

```csharp
// Soruları ve cevapları tanımlama
// Soru 1
string soru1 = "Kızınca tüküren hayvan hangisidir?";
string cevap1A = "a) Lama"; // Seçenek A
string cevap1B = "b) Deve"; // Seçenek B
string dogruCevap1 = "a"; // Doğru cevap (A seçeneği)

// Soru 2
string soru2 = "Dünya'ya en yakın gezegen hangisidir?";
string cevap2A = "a) Venüs"; // Seçenek A
string cevap2B = "b) Mars"; // Seçenek B
string dogruCevap2 = "a"; // Doğru cevap (A seçeneği)

// Soru 3
string soru3 = "5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?";
string cevap3A = "a) 7"; // Seçenek A
string cevap3B = "b) 12"; // Seçenek B
string dogruCevap3 = "b"; // Doğru cevap (B seçeneği)
```

### Correct Answer Counter

A variable to keep track of the number of correct answers:

```csharp
// Doğru cevap sayısını tutmak için bir değişken oluşturuyoruz
int dogruSayisi = 0;
```

### Question 1 Flow

The flow for the first question is as follows:

```csharp
// Soru 1'i soruyoruz
Console.WriteLine($"Soru 1: {soru1}"); // Soruyu yazdır
Console.WriteLine(cevap1A); // Seçenek A'yı yazdır
Console.WriteLine(cevap1B); // Seçenek B'yi yazdır
Console.Write("Cevabınızı girin (A veya B): "); // Kullanıcıdan cevap bekliyoruz
string cevap1 = Console.ReadLine().Trim().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

// Kullanıcının cevabını kontrol et
if (cevap1 == dogruCevap1) // Cevap doğruysa
{
    Console.WriteLine("Doğru cevap!"); // Kullanıcıya doğru cevap olduğunu bildir
    dogruSayisi++; // Doğru cevap sayısını artır
}
else // Cevap yanlışsa
{
    Console.WriteLine("Yanlış cevap!"); // Kullanıcıya yanlış cevap olduğunu bildir
}
```

### Question 2 Flow

The flow for the second question is similar:

```csharp
// Soru 2'yi soruyoruz
Console.WriteLine($"Soru 2: {soru2}"); // Soruyu yazdır
Console.WriteLine(cevap2A); // Seçenek A'yı yazdır
Console.WriteLine(cevap2B); // Seçenek B'yi yazdır
Console.Write("Cevabınızı girin (A veya B): "); // Kullanıcıdan cevap bekliyoruz
string cevap2 = Console.ReadLine().Trim().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

// Kullanıcının cevabını kontrol et
if (cevap2 == dogruCevap2) // Cevap doğruysa
{
    Console.WriteLine("Doğru cevap!"); // Kullanıcıya doğru cevap olduğunu bildir
    dogruSayisi++; // Doğru cevap sayısını artır
}
else // Cevap yanlışsa
{
    Console.WriteLine("Yanlış cevap!"); // Kullanıcıya yanlış cevap olduğunu bildir
}
```

### Result Evaluation

Finally, we evaluate the results based on the correct answer count:

```csharp
// Kullanıcıya 3. soru sorulmaz, sonuç kontrolü yapıyoruz
// Doğru cevap sayısına göre büyük ödül kazanıp kazanmadığını kontrol ediyoruz
if (dogruSayisi >= 2) // Eğer kullanıcının doğru cevap sayısı 2 veya daha fazla ise
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!"); // Kullanıcıya ödül kazandığını bildir
}
else // Kullanıcının doğru cevap sayısı 2'den az ise
{
    Console.WriteLine("Üzgünüm, büyük ödülü kazanamadınız."); // Kullanıcıya ödülü kazanamadığını bildir
}
```

## Usage

1. Run the application.
2. Read each question and select one of the given options.
3. Have a chance to win 1 Million TL by answering two questions correctly!

## License

This project is licensed under the MIT License.
