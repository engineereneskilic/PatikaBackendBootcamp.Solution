
# Code First Relation Project

This project demonstrates how to use the **Code First** approach with Entity Framework Core to build a relational database. The project consists of two entities, `User` and `Post`, with a one-to-many relationship between them.

## Table of Contents
- [Overview](#overview)
- [Entities](#entities)
  - [User Entity](#user-entity)
  - [Post Entity](#post-entity)
- [Database Context](#database-context)
- [Configuration](#configuration)
  - [Fluent API](#fluent-api)
- [Setup and Migration](#setup-and-migration)
- [Technologies Used](#technologies-used)
- [License](#license)

---

## Overview

This project creates a database named **`PatikaCodeFirstDb2`** with the following tables:
- **Users**
- **Posts**

Each `User` can have multiple `Posts`, but each `Post` is associated with only one `User`.

---

## Entities

### User Entity

The `User` entity represents users of the application and contains the following properties:

```csharp
public class User
{
    public int Id { get; set; } // Primary key.
    public string Username { get; set; } // The username of the user.
    public string Email { get; set; } // The email address of the user.
    public ICollection<Post> Posts { get; set; } // Navigation property for related Posts.
}
```

### Post Entity

The `Post` entity represents posts created by users and contains the following properties:

```csharp
public class Post
{
    public int Id { get; set; } // Primary key.
    public string Title { get; set; } // The title of the post.
    public string Content { get; set; } // The content of the post.
    public int UserId { get; set; } // Foreign key referencing User.
    public User User { get; set; } // Navigation property to the User entity.
}
```

---

## Database Context

The `PatikaSecondDbContext` is the `DbContext` class that manages the database connection and configuration.

```csharp
public class PatikaSecondDbContext : DbContext
{
    public DbSet<User> Users { get; set; } // Table for Users.
    public DbSet<Post> Posts { get; set; } // Table for Posts.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
            .HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId); // Configures the one-to-many relationship.
    }
}
```

---

## Configuration

### Fluent API

The relationships between `User` and `Post` are defined using Fluent API in the `OnModelCreating` method of `PatikaSecondDbContext`.

```csharp
modelBuilder.Entity<Post>()
    .HasOne(p => p.User)
    .WithMany(u => u.Posts)
    .HasForeignKey(p => p.UserId);
```

---

## Setup and Migration

### Install Entity Framework Core Tools:

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### Add Initial Migration:

```bash
dotnet ef migrations add InitialCreate
```

### Apply Migration to Database:

```bash
dotnet ef database update
```

The database `PatikaCodeFirstDb2` will now contain **Users** and **Posts** tables.

---

## Technologies Used

- **.NET 6**
- **Entity Framework Core**
- **SQL Server**
- **Code First Approach**

---

## License

This project is licensed under the MIT License.
