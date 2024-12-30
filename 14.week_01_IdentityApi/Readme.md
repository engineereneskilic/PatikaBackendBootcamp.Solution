
# Pratik - JWT Authentication

This guide provides an overview of how to use the JWT Authentication system in this project. Follow the instructions below to set up and utilize the authentication system.

---

## Features

- User Registration
- User Login with JWT token generation
- Secure routes requiring JWT validation

---

## Prerequisites

- Ensure you have a valid development environment with .NET Core SDK installed.
- A configured database (e.g., SQL Server) for storing user information.

---

## Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Apply migrations to set up the database:
   ```bash
   dotnet ef database update
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

---

## Usage

### 1. Register a New User

Send a `POST` request to `/api/auth/register` with the following payload:
```json
{
  "email": "user@example.com",
  "password": "securePassword123"
}
```
**Response:**
- `200 OK` if registration is successful.
- `400 Bad Request` if the input is invalid.

---

### 2. Login to Obtain JWT

Send a `POST` request to `/api/auth/login` with the following payload:
```json
{
  "email": "user@example.com",
  "password": "securePassword123"
}
```
**Response:**
- `200 OK` with a JWT token if login is successful.
  ```json
  {
    "token": "your.jwt.token.here"
  }
  ```
- `401 Unauthorized` if email or password is incorrect.

---

### 3. Access Protected Routes

Send a `GET` request to a protected route (e.g., `/api/protected`) with the following header:
```
Authorization: Bearer your.jwt.token.here
```
**Response:**
- `200 OK` if the JWT is valid.
- `401 Unauthorized` if the token is missing or invalid.

---

## Error Handling

- **401 Unauthorized**: Returned when accessing a protected route without a valid JWT.
- **400 Bad Request**: Returned when invalid data is provided for registration or login.

---

## Additional Notes

- JWT tokens have an expiration time; ensure to refresh or re-login when necessary.
- Use HTTPS to secure communication and prevent token interception.

---

## Troubleshooting

1. **Database Errors**:
   - Ensure the database connection string in `appsettings.json` is correctly configured.

2. **Token Issues**:
   - Verify the `Issuer` and `Audience` values in the JWT configuration match the server settings.

---

For further assistance, please refer to the project documentation or contact the maintainer.
