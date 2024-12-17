# 🎵 **Crazy Musicians API**  
*An ASP.NET Core Web API for managing a fictional group of quirky and entertaining musicians.*

---

## 🚀 **Table of Contents**
1. [About the Project](#about-the-project)
2. [Features](#features)
3. [Technologies Used](#technologies-used)
4. [Project Structure](#project-structure)
5. [Endpoints Overview](#endpoints-overview)
    - [GET - Retrieve All Musicians](#get---retrieve-all-musicians)
    - [GET - Search Musicians](#get---search-musicians)
    - [GET - Retrieve Musician by ID](#get---retrieve-musician-by-id)
    - [POST - Add a New Musician](#post---add-a-new-musician)
    - [PUT - Update a Musician](#put---update-a-musician)
    - [PATCH - Update FunTrait Field](#patch---update-funtrait-field)
    - [DELETE - Remove a Musician](#delete---remove-a-musician)
6. [How to Run the Project](#how-to-run-the-project)
7. [Request and Response Examples](#request-and-response-examples)
8. [License](#license)

---

## 📝 **About the Project**
The **Crazy Musicians API** is a RESTful Web API built using **ASP.NET Core**. It manages a collection of fictional musicians with unique characteristics, enabling CRUD operations such as creating, reading, updating, and deleting records. The project is designed to demonstrate clean code practices, structured routing, and validation.

---

## ⭐ **Features**
- Retrieve all musicians.
- Search musicians by name using query parameters.
- Retrieve a musician's details by ID.
- Add a new musician with validation.
- Update entire musician records.
- Partially update a musician's "FunTrait" field.
- Delete musicians by ID.

---

## 🛠️ **Technologies Used**
- **.NET Core 6.0** - Framework for building the Web API.
- **C#** - Programming language.
- **Visual Studio 2022** - Development environment.

---

## 📂 **Project Structure**

```plaintext
CrazyMusiciansAPI/
│
├── Controllers/
│   └── MusiciansController.cs       # Main controller handling API endpoints.
│
└── Models/
    └── Musician.cs                  # Data model representing a musician entity.
```

---

## 🔗 **Endpoints Overview**

### **GET - Retrieve All Musicians**
- **Route**: `GET /api/musicians`  
- **Description**: Fetches all musicians in the list.  
- **Response Example**:
```json
[
    {
        "id": 1,
        "name": "Ahmet Çalgı",
        "profession": "Famous Instrument Player",
        "funTrait": "Always plays the wrong notes, but very entertaining"
    }
]
```

---

### **GET - Search Musicians**
- **Route**: `GET /api/musicians/search?name={value}`  
- **Description**: Searches for musicians by their name using the `[FromQuery]` attribute.  
- **Response Example**:
```json
[
    {
        "id": 2,
        "name": "Zeynep Melodi",
        "profession": "Popular Melody Writer",
        "funTrait": "Songs are often misunderstood, but very popular"
    }
]
```

---

### **GET - Retrieve Musician by ID**
- **Route**: `GET /api/musicians/{id}`  
- **Description**: Retrieves a musician's details based on their unique ID.  
- **Response Example**:
```json
{
    "id": 3,
    "name": "Cemil Akor",
    "profession": "Crazy Chordist",
    "funTrait": "Frequently changes chords, but surprisingly talented"
}
```

---

### **POST - Add a New Musician**
- **Route**: `POST /api/musicians`  
- **Description**: Adds a new musician to the list. Ensures that the `Name` is not empty.  
- **Request Body Example**:
```json
{
    "name": "Ebru Nota",
    "profession": "Creative Composer",
    "funTrait": "Writes upside-down notes"
}
```
- **Response Example**:
```json
{
    "id": 4,
    "name": "Ebru Nota",
    "profession": "Creative Composer",
    "funTrait": "Writes upside-down notes"
}
```

---

### **PUT - Update a Musician**
- **Route**: `PUT /api/musicians/{id}`  
- **Description**: Updates all fields of a musician. Ensures that the `Name` is valid.  
- **Request Body Example**:
```json
{
    "name": "Cemil Akor",
    "profession": "Master Chordist",
    "funTrait": "Now composes magical chords"
}
```

---

### **PATCH - Update FunTrait Field**
- **Route**: `PATCH /api/musicians/{id}`  
- **Description**: Partially updates the `FunTrait` field of a musician.  
- **Request Body**: A string with the new `FunTrait`.  
- **Request Example**:
```json
"Now plays perfect notes!"
```
- **Response Example**:
```json
{
    "id": 1,
    "name": "Ahmet Çalgı",
    "profession": "Famous Instrument Player",
    "funTrait": "Now plays perfect notes!"
}
```

---

### **DELETE - Remove a Musician**
- **Route**: `DELETE /api/musicians/{id}`  
- **Description**: Deletes a musician record based on the provided ID.  
- **Response**: `204 No Content`

---

## ⚙️ **How to Run the Project**

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/CrazyMusiciansAPI.git
   ```

2. **Navigate to the Project Directory**:
   ```bash
   cd CrazyMusiciansAPI
   ```

3. **Run the Project**:
   - Open the project in **Visual Studio**.
   - Press `F5` to start the development server.

4. **Test the API**:
   - Use tools like **Postman** or **Swagger UI** to test the endpoints.

---

## 📬 **Request and Response Examples**

### 1. **Add a New Musician**
- **Request**:
```http
POST /api/musicians
Content-Type: application/json

{
    "name": "Ali Ritim",
    "profession": "Rhythm Expert",
    "funTrait": "Plays rhythms using spoons!"
}
```

- **Response**:
```json
{
    "id": 5,
    "name": "Ali Ritim",
    "profession": "Rhythm Expert",
    "funTrait": "Plays rhythms using spoons!"
}
```

### 2. **Search Musician by Name**
- **Request**:
```http
GET /api/musicians/search?name=Ali
```
- **Response**:
```json
[
    {
        "id": 5,
        "name": "Ali Ritim",
        "profession": "Rhythm Expert",
        "funTrait": "Plays rhythms using spoons!"
    }
]
```

---

## 📄 **License**
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Happy Coding! 🎸**  
*Developed with ❤️ by [Your Name](https://github.com/yourusername)*
