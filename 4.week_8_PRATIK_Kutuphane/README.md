
# Book Record Application for Patika Library

This project involves creating a Book Record application for Patika Library. The main purpose is to record books with various properties such as title, author name, page count, publisher, and the date of recording.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

The Book Record application allows users to store information about books, including the title, author's first name, last name, page count, publisher, and the date when the book was added to the system. The application includes two constructors: a default constructor and a parameterized constructor to initialize the book object.

## Technologies

- C#
- .NET Framework

## Code Overview

### Book Class
```csharp
public class Book
{
    // Kitabın adı
    public string Title { get; set; }

    // Yazarın adı
    public string AuthorFirstName { get; set; }

    // Yazarın soyadı
    public string AuthorLastName { get; set; }

    // Kitabın sayfa sayısı
    public int PageCount { get; set; }

    // Yayınevi bilgisi
    public string Publisher { get; set; }

    // Kayıt tarihi, kitap nesnesi oluşturulduğunda otomatik atanır
    public DateTime RecordDate { get; private set; }

    // Varsayılan constructor (parametresiz)
    public Book()
    {
        this.RecordDate = DateTime.Now;
        Console.WriteLine("New book created!");
    }

    // Parametre alan constructor
    public Book(string title, string authorFirstName, string authorLastName, int pageCount, string publisher)
    {
        this.Title = title;
        this.AuthorFirstName = authorFirstName;
        this.AuthorLastName = authorLastName;
        this.PageCount = pageCount;
        this.Publisher = publisher;
        this.RecordDate = DateTime.Now;
        Console.WriteLine("New book created with parameters!");
    }

    // Kitap bilgilerini ekrana yazdıran metot
    public void DisplayBookInfo()
    {
        Console.WriteLine($"Kitap: {Title}, Yazar: {AuthorFirstName} {AuthorLastName}, Sayfa Sayısı: {PageCount}, Yayınevi: {Publisher}, Kayıt Tarihi: {RecordDate}");
    }
}
```

### Usage
```csharp
// Varsayılan constructor kullanarak bir kitap oluşturuyoruz
Book defaultBook = new Book();
defaultBook.DisplayBookInfo();

// Parametreli constructor kullanarak bir kitap oluşturuyoruz
Book paramBook = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
paramBook.DisplayBookInfo();
```

## Explanation

### Class

In C#, a **class** is a blueprint for creating objects. It defines the properties and methods that the objects created from the class will have. In this project, the `Book` class represents a book entity with several properties like title, author, and publisher.

### Property

A **property** is a member of a class that provides a flexible mechanism to read, write, or compute the values of private fields. In the `Book` class, `Title`, `AuthorFirstName`, `AuthorLastName`, `PageCount`, and `Publisher` are examples of properties. They are used to encapsulate the fields and provide controlled access.

### New

The `new` keyword in C# is used to create instances of a class. In this project, the `Book` objects are created using the `new` keyword, either with the default constructor or the parameterized constructor.

### Constructor

A **constructor** is a special method in a class that is invoked when an object of the class is instantiated. It is used to initialize the object's properties. The `Book` class has two constructors: a default constructor (which doesn't take any parameters) and a parameterized constructor (which initializes the book with specific values).

## Output

When you run the application, the following output will be displayed:

```
New book created!
Kitap: , Yazar: , Sayfa Sayısı: 0, Yayınevi: , Kayıt Tarihi: [Current Date]
New book created with parameters!
Kitap: Adı Aylin, Yazar: Ayşe Kulin, Sayfa Sayısı: 398, Yayınevi: Remzi Kitabevi, Kayıt Tarihi: [Current Date]
```

## License

This project is licensed under the MIT License.
