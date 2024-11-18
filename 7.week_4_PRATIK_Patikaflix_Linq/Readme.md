
# Patikaflix Project - TV Series Management System

## Table of Contents

1. [Introduction](#introduction)
2. [Technologies](#technologies)
3. [Code Overview](#code-overview)
    - [Classes](#classes)
    - [Main Program](#main-program)
4. [Execution Steps](#execution-steps)
5. [Output](#output)
6. [License](#license)

## Introduction

The **Patikaflix Project** is a TV series management system where the goal is to create and manage a list of TV shows. These shows have different attributes such as their name, release year, genre, director, and platform. The system allows you to filter and list specific shows based on certain conditions. 

In this version, the focus is on **comedy shows**, and we extract only the **Dizi Adı**, **Türü**, and **Yönetmenler** properties for each comedy show and display them sorted by **Dizi Adı** and **Yönetmenler**.

## Technologies

- **C#** - The main programming language used to implement the project.
- **.NET Core** - Framework used to run the application.
- **Visual Studio** - IDE for development and execution.

## Code Overview

### Classes

1. **Dizi Class**  
   This class represents the basic properties of a TV series. The attributes include the name, year of release, genre, start year, director, and platform.

   ```csharp
   public class Dizi
   {
       public string DiziAdi { get; set; }
       public int Yili { get; set; }
       public string Turu { get; set; }
       public int BaslamaYili { get; set; }
       public string Yonetmenler { get; set; }
       public string Platform { get; set; }
   }
   ```

   - **DiziAdi**: The name of the series.
   - **Yili**: The year the series was released.
   - **Turu**: The genre(s) of the series.
   - **BaslamaYili**: The year the series started airing.
   - **Yonetmenler**: The directors of the series.
   - **Platform**: The platform on which the series is broadcasted.

2. **KomediDizi Class**  
   This class is designed for filtering out the comedy TV series. Only **DiziAdi**, **Turu**, and **Yonetmenler** properties are stored here.

   ```csharp
   public class KomediDizi
   {
       public string DiziAdi { get; set; }
       public string Turu { get; set; }
       public string Yonetmenler { get; set; }
   }
   ```

### Main Program

The `Program` class is the main entry point of the application. Here's an overview of the code logic:

1. **List of TV Shows**  
   We start by creating a list of **Dizi** objects containing the details of various TV shows.

   ```csharp
   List<Dizi> diziler = new List<Dizi>
   {
       new Dizi { DiziAdi = "Avrupa Yakası", Yili = 2004, Turu = "Komedi", BaslamaYili = 2004, Yonetmenler = "Yiğit Aksu", Platform = "Kanal D" },
       new Dizi { DiziAdi = "Yalan Dünya", Yili = 2012, Turu = "Komedi", BaslamaYili = 2012, Yonetmenler = "Gülseren Buda", Platform = "Fox TV" },
       new Dizi { DiziAdi = "Jet Sosyete", Yili = 2018, Turu = "Komedi", BaslamaYili = 2018, Yonetmenler = "Gülseren Buda", Platform = "Tv8" },
       new Dizi { DiziAdi = "Dadı", Yili = 2006, Turu = "Komedi", BaslamaYili = 2006, Yonetmenler = "Yusuf Pirhasan", Platform = "Kanal D" },
       new Dizi { DiziAdi = "Belalı Baldız", Yili = 2007, Turu = "Komedi", BaslamaYili = 2007, Yonetmenler = "Yiğit Aksu", Platform = "Kanal D" },
       new Dizi { DiziAdi = "Arka Sokaklar", Yili = 2004, Turu = "Polisiye, Dram", BaslamaYili = 2004, Yonetmenler = "Orhan Oğuz", Platform = "Kanal D" },
       new Dizi { DiziAdi = "Aşk-ı Memnu", Yili = 2008, Turu = "Dram, Romantik", BaslamaYili = 2008, Yonetmenler = "Hilal Saral", Platform = "Kanal D" },
       new Dizi { DiziAdi = "Muhtesem Yüzyıl", Yili = 2011, Turu = "Tarihi, Dram", BaslamaYili = 2011, Yonetmenler = "Mercan Çilingiroğlu", Platform = "Star TV" },
       new Dizi { DiziAdi = "Yaprak Dökümü", Yili = 2006, Turu = "Dram", BaslamaYili = 2006, Yonetmenler = "Serdar Akar", Platform = "Kanal D" }
   };
   ```

2. **Filtering Comedy Series**  
   After creating the list of series, we filter out only the **Komedi** type series into a new list of **KomediDizi** objects.

   ```csharp
   List<KomediDizi> komediDiziler = diziler
       .Where(d => d.Turu.Contains("Komedi"))
       .Select(d => new KomediDizi
       {
           DiziAdi = d.DiziAdi,
           Turu = d.Turu,
           Yonetmenler = d.Yonetmenler
       })
       .ToList();
   ```

# 3. **Sorting and Displaying Data**  
   The filtered list of comedy series is then sorted first by **DiziAdi** and then by **Yonetmenler**, and displayed on the console.

   ```csharp
   var sortedList = komediDiziler
       .OrderBy(d => d.DiziAdi)
       .ThenBy(d => d.Yonetmenler)
       .ToList();

   Console.WriteLine("Comedy Series (Sorted by Title and Director):
");

   foreach (var dizi in sortedList)
   {
       Console.WriteLine($"Dizi Adı: {dizi.DiziAdi} | Türü: {dizi.Turu} | Yönetmenler: {dizi.Yonetmenler}");
   }
   ```

---

## Execution Steps

1. Clone or download the repository.
2. Open the **Patikaflix_Project.cs** file in a C# environment, such as Visual Studio or Visual Studio Code.
3. Build and run the project.
4. The program will display the filtered and sorted comedy TV series in the console.

---

## Output

After running the program, the output will look like this:

```
Comedy Series (Sorted by Title and Director):

Dizi Adı: Avrupa Yakası | Türü: Komedi | Yönetmenler: Yiğit Aksu
Dizi Adı: Belalı Baldız | Türü: Komedi | Yönetmenler: Yiğit Aksu
Dizi Adı: Dadı | Türü: Komedi | Yönetmenler: Yusuf Pirhasan
Dizi Adı: Jet Sosyete | Türü: Komedi | Yönetmenler: Gülseren Buda
Dizi Adı: Yalan Dünya | Türü: Komedi | Yönetmenler: Gülseren Buda
```

The **Comedy Series** are sorted first by the **Dizi Adı** (show name) and then by the **Yönetmenler** (directors), as required.

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
