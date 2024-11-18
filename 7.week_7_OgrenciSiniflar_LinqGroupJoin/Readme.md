# Linq Group Join - School Database Example

A C# console application demonstrating the use of **LINQ Group Join** for combining two related entities: **Students** and **Classes**, and grouping the students by their class.

---

## Table of Contents

1. [Overview](#overview)
2. [Data Structure](#data-structure)
    - [Students Table](#students-table)
    - [Classes Table](#classes-table)
3. [Code Explanation](#code-explanation)
    - [Student Class](#student-class)
    - [Class Class](#class-class)
    - [Data Initialization](#data-initialization)
    - [LINQ Group Join Query](#linq-group-join-query)
    - [Displaying Results](#displaying-results)
4. [Output](#output)
5. [How to Run](#how-to-run)
6. [License](#license)

---

## Overview

This project models a **school database** with two tables:
- **Students**: Represents individual students and their respective class IDs.
- **Classes**: Represents the classes in the school and their unique IDs.

The goal is to:
1. Group students by their class using a **Group Join** in LINQ.
2. Display each class along with the list of students in that class.

---

## Data Structure

### Students Table

| StudentId | StudentName | ClassId |
|-----------|-------------|---------|
| 1         | Ali         | 1       |
| 2         | Ayşe        | 2       |
| 3         | Mehmet      | 1       |
| 4         | Fatma       | 3       |
| 5         | Ahmet       | 2       |

### Classes Table

| ClassId | ClassName    |
|---------|--------------|
| 1       | Matematik    |
| 2       | Türkçe       |
| 3       | Kimya        |

---

## Code Explanation

### 1. Student Class

The `Student` class models the **Students** table:

```csharp
public class Student
{
    public int StudentId { get; set; }   // Unique identifier for each student
    public string StudentName { get; set; } // Name of the student
    public int ClassId { get; set; }     // Foreign key linking to the ClassId in the Classes table
}
```

### 2. Class Class

The `Class` class models the **Classes** table:

```csharp
public class Class
{
    public int ClassId { get; set; }     // Unique identifier for each class
    public string ClassName { get; set; } // Name of the class
}
```

### 3. Data Initialization

Sample data for students and classes is defined as lists:

```csharp
List<Student> students = new List<Student>
{
    new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
    new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
    new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
    new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
    new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
};

List<Class> classes = new List<Class>
{
    new Class { ClassId = 1, ClassName = "Matematik" },
    new Class { ClassId = 2, ClassName = "Türkçe" },
    new Class { ClassId = 3, ClassName = "Kimya" }
};
```

---

### 4. LINQ Group Join Query

The LINQ query groups students by their class and creates a readable structure:

```csharp
var groupJoinQuery = from cls in classes
                     join std in students on cls.ClassId equals std.ClassId into studentGroup
                     select new
                     {
                         ClassName = cls.ClassName,  // The name of the class
                         Students = studentGroup    // Grouped list of students in the class
                     };
```

Explanation:
1. `join std in students on cls.ClassId equals std.ClassId`:
   Matches each student's `ClassId` with the corresponding `ClassId` in the classes list.
2. `into studentGroup`:
   Groups all matching students under a single class.
3. `select new { ... }`:
   Constructs a new object containing the class name and the grouped students.

---

### 5. Displaying Results

The results of the LINQ query are displayed using a nested loop:

```csharp
Console.WriteLine("Classes and their Students:");
foreach (var group in groupJoinQuery)
{
    Console.WriteLine($"Class: {group.ClassName}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($"  - {student.StudentName}");
    }
}
```

---

## Output

When the program is executed, the following output is displayed:

```
Classes and their Students:
Class: Matematik
  - Ali
  - Mehmet
Class: Türkçe
  - Ayşe
  - Ahmet
Class: Kimya
  - Fatma
```

---

## How to Run

1. Copy the code into a C# Console Application project.
2. Build and run the project using an IDE like Visual Studio.
3. Observe the grouped class and student information in the console output.

---

## License

This project is licensed under the MIT License. You are free to use, modify, and distribute the code as needed.
