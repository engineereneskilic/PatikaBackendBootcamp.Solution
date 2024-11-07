
# Coffee List Application

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Explanation](#explanation)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

## Introduction

This project allows users to create a list of their favorite coffee types by entering 5 coffee names through the console. Once the list is created, the application displays each coffee name one by one using a `foreach` loop.

## Technologies

- **Language**: C#
- **Development Environment**: .NET Core SDK
- **Concepts**: Lists, Console Input/Output, Iteration (foreach loop)

## Code Overview

### Coffee List Collection
The application begins by creating an empty list to store the coffee names. It then prompts the user five times to input a coffee name, which is added to the list.

### Displaying Coffee Names
After collecting all coffee names, the application iterates over the list using a `foreach` loop and displays each coffee name in the console.

## Explanation

This application provides an example of working with lists in C#. It demonstrates:
- **List Creation**: Initializing and populating a list based on user input.
- **User Interaction**: Collecting data from the user via console input.
- **Iteration with foreach**: Displaying each item in the list using a `foreach` loop.

## Usage

1. Run the application.
2. Enter a coffee name when prompted until all 5 names are entered.
3. After entering all names, the application displays the list of coffee names.

## Output

Below is an example of what the output might look like:

```
Please enter the name of coffee #1: Latte
Please enter the name of coffee #2: Espresso
Please enter the name of coffee #3: Cappuccino
Please enter the name of coffee #4: Americano
Please enter the name of coffee #5: Mocha

Your Coffee List:
- Latte
- Espresso
- Cappuccino
- Americano
- Mocha
```

## License

This project is licensed under the MIT License.
