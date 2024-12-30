
# User Authentication API with ASP.NET Core Identity

## Table of Contents
1. [Project Overview](#project-overview)
2. [Technologies Used](#technologies-used)
3. [Prerequisites](#prerequisites)
4. [Installation Instructions](#installation-instructions)
5. [API Endpoints](#api-endpoints)
   - [Register Endpoint](#register-endpoint)
   - [Login Endpoint](#login-endpoint)
6. [Project Structure](#project-structure)
7. [Database Setup](#database-setup)
8. [Testing the API](#testing-the-api)
9. [Contributing](#contributing)

## Project Overview

This project is a **User Authentication API** built with **ASP.NET Core** and **Entity Framework Core** to provide basic user registration and login functionality. It includes password hashing, validation, and interaction with a database to store user details securely. The API exposes two endpoints for user registration and login, making use of **ASP.NET Identity** for handling authentication.

## Technologies Used

- **ASP.NET Core**: Framework for building the API.
- **Entity Framework Core**: ORM for database interaction.
- **PasswordHasher**: Used for securely hashing user passwords.
- **SQL Server**: Relational database for storing user data.
- **ASP.NET Core Identity**: Manages user authentication, roles, and claims.

## Prerequisites

Before you can run this project, you will need to have the following installed:

- **.NET 6.0 SDK** or later
- **SQL Server** (or any other database server you choose, but you'll need to configure the connection string accordingly)
- **Visual Studio** or **Visual Studio Code** for editing and running the project

## Installation Instructions

1. **Clone the repository:**

   ```bash
   git clone https://your-repository-url
   cd Your-Project-Directory
   ```

2. **Install dependencies:**

   This project uses **ASP.NET Core**, so ensure you have the required SDK installed. Run the following commands to restore the necessary packages:

   ```bash
   dotnet restore
   ```

3. **Set up the connection string:**

   In the `appsettings.json` file, update the connection string to match your database setup:

   ```json
   {
     "ConnectionStrings": {
       "Default": "Server=DESKTOP-HDU6E5A;Database=IdentityDB;Trusted_Connection=True;TrustServerCertificate=true"
     }
   }
   ```

4. **Apply migrations and update the database:**

   If this is your first time running the project, apply the migrations to set up the database schema:

   ```bash
   dotnet ef database update
   ```

## API Endpoints

### Register Endpoint

- **URL**: `/api/users/register`
- **Method**: `POST`
- **Request Body**:
  
  ```json
  {
    "email": "user@example.com",
    "password": "securePassword123"
  }
  ```

- **Response**:
  
  ```json
  {
    "message": "User registered successfully"
  }
  ```

- **Description**: This endpoint allows new users to register by providing an email and password. The password is hashed before being stored in the database.

### Login Endpoint

- **URL**: `/api/users/login`
- **Method**: `POST`
- **Request Body**:
  
  ```json
  {
    "email": "user@example.com",
    "password": "securePassword123"
  }
  ```

- **Response**:
  
  ```json
  {
    "message": "Login successful",
    "email": "user@example.com"
  }
  ```

- **Description**: This endpoint allows users to log in by providing their email and password. The password is verified against the stored hash in the database.

## Project Structure

Here is a brief overview of the project structure:

```
/_14.week_02_PRATIK_Identity
│
├── /Controllers                # Contains API controllers (e.g., UsersController)
├── /Data                       # Contains DbContext (e.g., ApplicationDbContext)
├── /Models                     # Contains the User model and other data models
├── /Models/ViewModels          # Contains view models (e.g., RegisterUserViewModel, LoginUserViewModel)
├── /Models/HelperModels        # Contains helper classes (e.g., PasswordHelper)
├── /Migrations                 # Contains Entity Framework Core migrations
├── /appsettings.json           # Configuration file for database connection
├── /Startup.cs                 # Configures services and middleware for the application
├── /Program.cs                 # Main entry point for the application
```

## Database Setup

This application uses **SQL Server** to store user credentials. You need to create a database called `IdentityDB` (or modify the connection string in `appsettings.json` if you're using a different database). You can use SQL Server Management Studio or a tool like **Azure Data Studio** to manage the database.

1. **Create a Database**:

   ```sql
   CREATE DATABASE IdentityDB;
   ```

2. **Migrate Database**:

   After setting up the connection string, run the following command to apply the migrations:

   ```bash
   dotnet ef database update
   ```

This will create the necessary tables in your database to store user information securely.

## Testing the API

You can use tools like **Postman** or **Insomnia** to test the API endpoints.

1. **Testing Registration**:
   - Method: `POST`
   - URL: `http://localhost:5000/api/users/register`
   - Body (JSON):
   
   ```json
   {
     "email": "testuser@example.com",
     "password": "TestPassword123"
   }
   ```

2. **Testing Login**:
   - Method: `POST`
   - URL: `http://localhost:5000/api/users/login`
   - Body (JSON):
   
   ```json
   {
     "email": "testuser@example.com",
     "password": "TestPassword123"
   }
   ```

## Contributing

Feel free to fork this project, open issues, and submit pull requests. If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch for your changes.
3. Commit your changes with a meaningful commit message.
4. Push your changes and submit a pull request.

---

**License**: This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
