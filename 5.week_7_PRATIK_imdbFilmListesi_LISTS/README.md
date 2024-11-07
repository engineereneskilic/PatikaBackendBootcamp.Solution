
# IMDB Film List Management System

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Explanation](#explanation)
  - [Class Definitions](#class-definitions)
  - [Main Program Flow](#main-program-flow)
  - [User Input Handling](#user-input-handling)
  - [Output Filtering](#output-filtering)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

## Introduction

This project provides a simple console-based system for managing a list of movies with IMDb ratings. The user can add multiple movies with their respective IMDb scores and then filter or display these movies based on specific conditions. The project incorporates core principles of object-oriented programming and user interaction through console input.

## Technologies

- **Programming Language**: C#
- **Framework**: .NET Core SDK
- **Concepts**: Lists, Loops, Object-Oriented Programming

## Code Overview

### Class Definitions

#### Film Class
The `Film` class represents a movie with the following properties:

- `double ImdbRating`: The IMDb rating of the film.
- `string Name`: The name of the film.

This class provides getter and setter methods for encapsulating the properties, ensuring secure access to the attributes.

### Main Program Flow

1. **Initialization**: The main program initializes an empty list of `Film` objects.
2. **User Input Loop**: The program enters a loop where it repeatedly prompts the user to enter the name and IMDb rating of a film.
3. **Continuation Check**: After each movie entry, the user is asked if they want to add another movie.
4. **Termination**: If the user chooses not to add another movie, the program exits the loop and proceeds to display the results.

### User Input Handling

- The program captures the user’s input for both the film name and IMDb rating.
- The input for the IMDb rating is validated to ensure that it falls within an acceptable range (typically 0 to 10).

### Output Filtering

At the end of the program, it displays:

1. **All Films**: A list of all movies entered by the user.
2. **Films with IMDb Rating Between 4 and 9**: A filtered list of movies with ratings between 4 and 9.
3. **Films Starting with 'A'**: A list of movies whose names start with the letter 'A'.

## Usage

1. Run the application.
2. Follow the prompts to enter movie names and IMDb ratings.
3. After each entry, confirm whether you want to add more movies.
4. At the end, the program will display the filtered movie lists.

## Output

Sample Output:
```
Enter movie name: Inception
Enter IMDb rating: 8.8
Do you want to add another movie? (Y/N): Y

Enter movie name: Avatar
Enter IMDb rating: 7.8
Do you want to add another movie? (Y/N): N

All Movies:
- Inception (IMDb: 8.8)
- Avatar (IMDb: 7.8)

Movies with IMDb Rating Between 4 and 9:
- Inception (IMDb: 8.8)
- Avatar (IMDb: 7.8)

Movies Starting with 'A':
- Avatar (IMDb: 7.8)
```

## License

This project is licensed under the MIT License.
