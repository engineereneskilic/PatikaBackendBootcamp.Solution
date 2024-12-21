
# Survivor Competition API

A RESTful API developed for managing a Survivor-style competition. This API allows for the management of competitors and categories, including CRUD operations and seamless data relations between entities.

---

## Table of Contents

1. [Overview](#overview)  
   1.1 [Technologies Used](#technologies-used)  
   1.2 [Key Features](#key-features)  
2. [Installation](#installation)  
   2.1 [Prerequisites](#prerequisites)  
   2.2 [Steps to Install](#steps-to-install)  
3. [Configuration](#configuration)  
   3.1 [Database Setup](#database-setup)  
   3.2 [Environment Variables](#environment-variables)  
4. [Endpoints](#endpoints)  
   4.1 [Competitor Endpoints](#competitor-endpoints)  
   4.2 [Category Endpoints](#category-endpoints)  
5. [Sample Data](#sample-data)  
   5.1 [Categories](#categories)  
   5.2 [Competitors](#competitors)  
6. [Project Structure](#project-structure)
7. [Contributing](#contributing)
8. [License](#license)

---

## Overview

Survivor Competition API is designed to provide the necessary backend functionality for managing a competitive reality show-style application. It offers full CRUD operations and maintains relationships between competitors and their categories.

### Technologies Used

- **.NET 7**: The core framework for building this API.
- **Entity Framework Core**: For database operations.
- **SQLite**: Lightweight database for development and testing.
- **Swagger UI**: For interactive API documentation.
- **Dependency Injection**: Ensures modular and testable code.

### Key Features

- Competitor and Category management.
- Pre-seeded data for quick testing.
- Full RESTful API support for CRUD operations.
- Built-in support for data relations and validation.
- Detailed API documentation through Swagger.

---

## Installation

### Prerequisites

- [.NET SDK 7.0+](https://dotnet.microsoft.com/download)
- [SQLite Database](https://www.sqlite.org/index.html)
- Any API testing tool (e.g., [Postman](https://www.postman.com/))

### Steps to Install

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/survivor-competition-api.git
   cd survivor-competition-api
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Update the database:
   ```bash
   dotnet ef database update
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

---

## Configuration

### Database Setup

This project uses SQLite for development purposes. You can switch to other providers (e.g., SQL Server, PostgreSQL) by updating the connection string in `appsettings.json`.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=SurvivorDb.sqlite"
  }
}
```

### Environment Variables

Set the following variables in your environment or directly in `appsettings.json`:

- `ConnectionStrings:DefaultConnection`: The database connection string.

---

## Endpoints

### Competitor Endpoints

| Method | Endpoint                 | Description                 |
|--------|--------------------------|-----------------------------|
| GET    | `/api/competitors`       | Retrieve all competitors.   |
| GET    | `/api/competitors/{id}`  | Retrieve a specific competitor. |
| POST   | `/api/competitors`       | Add a new competitor.       |
| PUT    | `/api/competitors/{id}`  | Update an existing competitor. |
| DELETE | `/api/competitors/{id}`  | Remove a competitor.        |

### Category Endpoints

| Method | Endpoint                | Description                |
|--------|-------------------------|----------------------------|
| GET    | `/api/categories`       | Retrieve all categories.   |
| GET    | `/api/categories/{id}`  | Retrieve a specific category. |
| POST   | `/api/categories`       | Add a new category.        |
| PUT    | `/api/categories/{id}`  | Update an existing category. |
| DELETE | `/api/categories/{id}`  | Remove a category.         |

---

## Sample Data

### Categories

- **Ünlüler**
- **Gönüllüler**

### Competitors

| Name         | Category    |
|--------------|-------------|
| Acun Ilıcalı | Ünlüler     |
| Aleyna Avcı  | Ünlüler     |
| Ahmet Yılmaz | Gönüllüler  |
| Ayşe Kara    | Gönüllüler  |
| Mehmet Demir | Ünlüler     |

---

## Project Structure

```plaintext
SurvivorCompetitionAPI/
│
├── Controllers/
│   ├── CompetitorController.cs
│   └── CategoryController.cs
│
├── Models/
│   ├── BaseEntity.cs
│   ├── Competitor.cs
│   └── Category.cs
│
├── Data/
│   ├── SurvivorDbContext.cs
│
├── appsettings.json
├── Program.cs
└── Startup.cs
```

---

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new feature branch.
3. Commit your changes with detailed descriptions.
4. Submit a pull request.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
