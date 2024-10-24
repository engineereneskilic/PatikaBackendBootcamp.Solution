
# Inheritance Example: BaseKisi, Ogrenci, and Ogretmen Classes

This project demonstrates the basic concepts of inheritance in C# by creating a base class `BaseKisi`, and two derived classes `Ogrenci` and `Ogretmen`. Each class has its own properties and methods, with the derived classes extending the functionality of the base class. Additionally, encapsulation is used to organize properties and methods.

## Table of Contents

1. [Overview](#overview)
2. [Class Structure](#class-structure)
    - [BaseKisi Class](#basekisi-class)
    - [Ogrenci Class](#ogrenci-class)
    - [Ogretmen Class](#ogretmen-class)
3. [Usage](#usage)
    - [Creating an Ogrenci Object](#creating-an-ogrenci-object)
    - [Creating an Ogretmen Object](#creating-an-ogretmen-object)
4. [Code Explanation](#code-explanation)
    - [BaseKisi Class Explanation](#basekisi-class-explanation)
    - [Ogrenci Class Explanation](#ogrenci-class-explanation)
    - [Ogretmen Class Explanation](#ogretmen-class-explanation)
5. [License](#license)

---

## Overview

This project demonstrates how inheritance works in C# by defining a base class `BaseKisi` with common properties (`Ad` and `Soyad`) and methods (`KisiBilgileriYazdir`). Then, we extend the base class to create two derived classes: `Ogrenci` and `Ogretmen`. Each derived class adds its own unique properties and methods while reusing the base class features.

## Class Structure

### BaseKisi Class

The `BaseKisi` class represents a generic person with basic information such as:

- **Properties**:
  - `Ad`: The first name of the person.
  - `Soyad`: The last name of the person.

- **Method**:
  - `KisiBilgileriYazdir()`: This method prints the first and last name of the person to the console.

### Ogrenci Class

The `Ogrenci` class inherits from `BaseKisi` and represents a student. It extends the base class with additional functionality:

- **Properties**:
  - `OgrenciNumarasi`: The student's ID number.

- **Method**:
  - `OgrenciBilgileriYazdir()`: This method first calls the `KisiBilgileriYazdir()` method from the `BaseKisi` class to print the student's name, and then it prints the student's ID.

### Ogretmen Class

The `Ogretmen` class also inherits from `BaseKisi` and represents a teacher. It includes:

- **Properties**:
  - `Maas`: The salary of the teacher.

- **Method**:
  - `OgretmenBilgileriYazdir()`: This method calls the `KisiBilgileriYazdir()` method from `BaseKisi` to print the teacher's name, and then prints the salary.

## Usage

### Creating an Ogrenci Object

To create an instance of the `Ogrenci` class and set its properties:

```csharp
Ogrenci ogrenci = new Ogrenci();
ogrenci.Ad = "Ali";
ogrenci.Soyad = "Yılmaz";
ogrenci.OgrenciNumarasi = 12345;
ogrenci.OgrenciBilgileriYazdir();
```

This will output the following to the console:

```
Ad: Ali, Soyad: Yılmaz
Öğrenci Numarası: 12345
```

### Creating an Ogretmen Object

To create an instance of the `Ogretmen` class and set its properties:

```csharp
Ogretmen ogretmen = new Ogretmen();
ogretmen.Ad = "Ayşe";
ogretmen.Soyad = "Kara";
ogretmen.Maas = 5000;
ogretmen.OgretmenBilgileriYazdir();
```

This will output the following to the console:

```
Ad: Ayşe, Soyad: Kara
Maaş: 5000 TL
```

## Code Explanation

### BaseKisi Class Explanation

The `BaseKisi` class is the base class that contains the common properties `Ad` and `Soyad` and a method to print them to the console. This class serves as the foundation for both `Ogrenci` and `Ogretmen` classes.

- **Properties**:
  - `Ad`: A `string` property representing the person's first name.
  - `Soyad`: A `string` property representing the person's last name.

- **Method**:
  - `KisiBilgileriYazdir()`: Prints the first and last name of the person to the console.

### Ogrenci Class Explanation

The `Ogrenci` class inherits from `BaseKisi` and adds the `OgrenciNumarasi` property. It also has a method that prints the student's name and ID number.

- **Properties**:
  - `OgrenciNumarasi`: An `int` property representing the student's ID number.

- **Method**:
  - `OgrenciBilgileriYazdir()`: First calls the base class method to print the student's name, then prints the student's ID number.

### Ogretmen Class Explanation

The `Ogretmen` class inherits from `BaseKisi` and adds the `Maas` property, which represents the teacher's salary. It has a method to print both the teacher's name and salary.

- **Properties**:
  - `Maas`: A `decimal` property representing the teacher's salary.

- **Method**:
  - `OgretmenBilgileriYazdir()`: Calls the base class method to print the teacher's name and prints the salary to the console.

---

## License
This project is licensed under the MIT License - see the LICENSE file for details.

