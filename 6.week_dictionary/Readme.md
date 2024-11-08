
# Dictionary Operations in C#

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Explanation](#explanation)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

## Introduction

This project demonstrates the basic usage of the `Dictionary` class in C#. A `Dictionary` is a collection of key-value pairs, where each key is unique and used to access the associated value. In this code, two dictionaries are created to store student names and country capitals, respectively. The program showcases how to add, access, update, and remove items from a dictionary.

## Technologies

- **Language**: C#
- **Framework**: .NET Core (or .NET Framework)
- **Concepts**: Collections, Dictionary, Key-Value Pairs, Conditionals, Loops

## Code Overview

### Dictionaries Used

- `Dictionary<int, string> students`: Holds student IDs as keys and student names as values.
- `Dictionary<string, string> capitals`: Stores country names as keys and their capital cities as values.

### Operations Performed

1. **Adding Elements**: Elements are added to the dictionary using the `Add` method.
2. **Accessing Elements**: Elements are accessed by their keys, returning the associated value.
3. **Checking for a Key**: Uses `ContainsKey` to check if a key exists.
4. **Removing Elements**: The `Remove` method deletes an element by key.
5. **Iterating over Elements**: Loops through the dictionary to print each key-value pair.

## Explanation

### Adding Elements

In both dictionaries, elements are added using the `Add` method. In the `students` dictionary, we add student names associated with a unique integer ID. In the `capitals` dictionary, we store country names as keys and capital cities as values.

#### Example:
```csharp
students.Add(1, "Ali"); // Adds a student with ID 1 and name "Ali"
capitals.Add("İtalya", "Roma"); // Adds a country with capital
```

### Accessing Elements

Elements in a dictionary are accessed using their keys. For example, we retrieve the name of the student with ID `1` and the capital of Germany (`"Almanya"`).

#### Example:
```csharp
string student = students[1]; // Retrieves "Ali"
string capitalOfGermany = capitals["Almanya"]; // Retrieves "Berlin"
```

### Checking for Key Existence

Before adding a new entry with an existing key, we check if the key exists using `ContainsKey`. If a student with ID `2` already exists, it prevents duplicate entries.

#### Example:
```csharp
if(students.ContainsKey(2)) {
    // Do not add if key exists, else add or update
}
```

### Removing Elements

Elements are removed from the dictionary using the `Remove` method. In the `capitals` dictionary, France's capital is removed if the key exists.

#### Example:
```csharp
capitals.Remove("Fransa"); // Removes the entry for France
```

### Iterating through a Dictionary

The `foreach` loop iterates over the dictionary to display each entry. In the `students` dictionary, all student names and IDs are printed. Similarly, in the `capitals` dictionary, all countries and capitals are listed.

#### Example:
```csharp
foreach (var item in students) {
    Console.WriteLine(item); // Displays each student ID and name
}
```

## Usage

To use this code:

1. **Create and Initialize Dictionaries**: Populate the `students` and `capitals` dictionaries.
2. **Perform Operations**:
   - Add elements to the dictionaries.
   - Access values using keys.
   - Check if a key exists before adding new entries.
   - Remove elements as needed.
   - Iterate through dictionaries to display all elements.
3. **View Output**: Observe the output printed to the console for each dictionary operation.

## Output

An example output of the code might look like this:

```plaintext
Ali
Veli
Almanya başkenti: Berlin
Fransa başkent bilgisi kaldırıldı
Ülke Türkiye başkenti: Ankara
Ülke Almanya başkenti: Berlin
Ülke İtalya başkenti: Roma
```

Explanation:
- The student with ID `1` is displayed.
- If a student with ID `2` already exists, a different name (`"Veli"`) is added with a new ID.
- Germany’s capital is retrieved and displayed.
- France's capital is removed, followed by the updated list of countries and capitals.

## License

This project is open-source and available under the MIT License.
