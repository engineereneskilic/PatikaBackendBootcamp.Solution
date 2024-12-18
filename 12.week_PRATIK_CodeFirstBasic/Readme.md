
# Code First Basic

This project demonstrates a **Code First Approach** using Entity Framework Core to create a database with two independent tables: `Movies` and `Games`. The database is built programmatically, allowing changes to be reflected automatically through migrations.

---

## Table of Contents
1. [Introduction](#introduction)
2. [Technologies Used](#technologies-used)
3. [Setup Instructions](#setup-instructions)
    - [1. Database Context Configuration](#1-database-context-configuration)
    - [2. Adding Models](#2-adding-models)
    - [3. Migration and Database Creation](#3-migration-and-database-creation)
4. [Database Structure](#database-structure)
5. [Code Examples](#code-examples)
    - [DbContext Class](#dbcontext-class)
    - [Movie Model](#movie-model)
    - [Game Model](#game-model)
    - [Program.cs Configuration](#programcs-configuration)
6. [How to Run](#how-to-run)
7. [Contact](#contact)

---

## Introduction
This project is a basic implementation of the **Code First Approach** in Entity Framework Core. The database includes two independent tables:
- **Movies**: Stores information about movies such as title, genre, and release year.
- **Games**: Stores information about games such as name, platform, and rating.

The database name is set as `PatikaCodeFirstDb1`, and the tables are named `Movies` and `Games`.

---

## Technologies Used
- **C#**
- **.NET 6.0**
- **Entity Framework Core**
- **SQL Server**

---

## Setup Instructions

### 1. Database Context Configuration
Create a `DbContext` class named `PatikaFirstDbContext` that represents your database context. Add the following code:

```csharp
using Microsoft.EntityFrameworkCore;

public class PatikaFirstDbContext : DbContext
{
    public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }
}
```

**Explanation:**
- `PatikaFirstDbContext` is derived from `DbContext` and provides properties for the `Movies` and `Games` tables.
- `DbContextOptions` is used to configure the database connection.

---

### 2. Adding Models
Define the models for the `Movie` and `Game` tables as follows:

#### Movie Model:
```csharp
public class Movie
{
    public int Id { get; set; }         // Primary key
    public string Title { get; set; }  // Movie title
    public string Genre { get; set; }  // Movie genre (e.g., "Action", "Comedy")
    public int ReleaseYear { get; set; } // Release year
}
```

**Explanation:**
- The `Movie` class includes properties for `Id`, `Title`, `Genre`, and `ReleaseYear`.
- The `Id` property is automatically set as the primary key.

#### Game Model:
```csharp
public class Game
{
    public int Id { get; set; }          // Primary key
    public string Name { get; set; }     // Game name
    public string Platform { get; set; } // Platform (e.g., "PC", "Xbox")
    public decimal Rating { get; set; }  // Rating (0-10)
}
```

**Explanation:**
- The `Game` class includes properties for `Id`, `Name`, `Platform`, and `Rating`.
- The `Rating` property is a `decimal` to allow precision in game scores.

---

### 3. Migration and Database Creation
Run the following commands in the terminal to create the database:

1. **Add a migration:**
   ```bash
   dotnet ef migrations add InitialCreate
   ```

2. **Update the database:**
   ```bash
   dotnet ef database update
   ```

**Explanation:**
- `InitialCreate` is the name of the migration.
- The `update` command applies the migration to create the database and tables.

---

## Database Structure

### Movies Table
| Column Name  | Data Type | Description               |
|--------------|-----------|---------------------------|
| Id           | int       | Primary key               |
| Title        | string    | Movie title              |
| Genre        | string    | Movie genre              |
| ReleaseYear  | int       | Movie release year       |

### Games Table
| Column Name  | Data Type | Description               |
|--------------|-----------|---------------------------|
| Id           | int       | Primary key               |
| Name         | string    | Game name                |
| Platform     | string    | Platform (e.g., "PC")    |
| Rating       | decimal   | Game rating (0-10)       |

---

## Code Examples

### DbContext Class
The `DbContext` class (`PatikaFirstDbContext`) is the entry point for database communication.

```csharp
public class PatikaFirstDbContext : DbContext
{
    public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }
}
```

### Program.cs Configuration
The database connection string is configured in `Program.cs`:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PatikaFirstDbContext>(options =>
    options.UseSqlServer("Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;"));

var app = builder.Build();

app.Run();
```

**Explanation:**
- The `UseSqlServer` method sets the connection string.
- Replace `Server=.;Database=PatikaCodeFirstDb1;Trusted_Connection=True;` with your SQL Server details if needed.

---

## How to Run

1. Clone the repository.
2. Navigate to the project directory:
   ```bash
   cd "C:\Users\Enes KILIÇ\source\repos\patikabackendbootcamp\PatikaBackendBootcamp.Solution\12.week_PRATIK_CodeFirstBasic"
   ```
3. Run the following command to restore dependencies:
   ```bash
   dotnet restore
   ```
4. Apply migrations:
   ```bash
   dotnet ef database update
   ```
5. Run the project:
   ```bash
   dotnet run
   ```

---

## Contact
For questions or suggestions, feel free to reach out:

- **GitHub:** [engineereneskilic](https://github.com/engineereneskilic)
- **Email:** engineer.eneskilic@gmail.com
