# Library Management System - Book - Author - Linq Join

A C# console application to demonstrate the use of LINQ join for combining data from two related entities: **Authors** and **Books**, and displaying their combined information in a readable format.

---

## Table of Contents

1. [Overview](#overview)
2. [Data Structure](#data-structure)
3. [Code Explanation](#code-explanation)
    - [Author Class](#author-class)
    - [Book Class](#book-class)
    - [Data Initialization](#data-initialization)
    - [LINQ Join Query](#linq-join-query)
    - [Displaying Results](#displaying-results)
4. [Output](#output)
5. [How to Run](#how-to-run)
6. [License](#license)

---

## Overview

This project illustrates how relational data can be modeled in C# and queried using LINQ. It simulates a simple library management system where:
- **Authors** represent the writers of books.
- **Books** are linked to authors using a foreign key (`AuthorId`).
  
The main objective is to fetch and display each book's title along with its author's name using LINQ's **join** operation.

---

## Data Structure

The application uses two data models:
1. `Author` class: Represents the **Authors** table.
2. `Book` class: Represents the **Books** table.

---

## Code Explanation

### 1. Author Class

The `Author` class defines the structure of the **Authors** table:

```csharp
public class Author
{
    public int AuthorId { get; set; } // Unique identifier for each author.
    public string Name { get; set; }  // The name of the author.
}
```

### 2. Book Class

The `Book` class defines the structure of the **Books** table:

```csharp
public class Book
{
    public int BookId { get; set; }   // Unique identifier for each book.
    public string Title { get; set; } // The title of the book.
    public int AuthorId { get; set; } // Foreign key linking to the AuthorId in the Authors table.
}
```

### 3. Data Initialization

Sample data is populated into two lists: `authors` and `books`. These lists mimic database tables.

```csharp
List<Author> authors = new List<Author>
{
    new Author { AuthorId = 1, Name = "Orhan Pamuk" },
    new Author { AuthorId = 2, Name = "Elif Şafak" },
    new Author { AuthorId = 3, Name = "Ahmet Ümit" }
};

List<Book> books = new List<Book>
{
    new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
    new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
    new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
    new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
};
```

### 4. LINQ Join Query

The LINQ query combines the `books` and `authors` lists to fetch the desired data.

```csharp
var query = from book in books
            join author in authors
            on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,    // The title of the book
                AuthorName = author.Name   // The name of the book's author
            };
```

### 5. Displaying Results

The query results are displayed in the console using a `foreach` loop.

```csharp
Console.WriteLine("Books and Authors:");
foreach (var item in query)
{
    Console.WriteLine($"Book: {item.BookTitle}, Author: {item.AuthorName}");
}
```

---

## Output

The following output is displayed when the program runs:

```
Books and Authors:
Book: Kar, Author: Orhan Pamuk
Book: İstanbul, Author: Orhan Pamuk
Book: 10 Minutes 38 Seconds in This Strange World, Author: Elif Şafak
Book: Beyoğlu Rapsodisi, Author: Ahmet Ümit
```

---

## How to Run

1. Copy the code into a new C# Console Application project.
2. Build and run the project using an IDE like Visual Studio.
3. View the results in the console output.

---

## License

This project is licensed under the MIT License. Feel free to use and modify it.
