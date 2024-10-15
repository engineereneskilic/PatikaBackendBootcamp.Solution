
# Robot and GameCharacter Simulation

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

This project simulates two primary scenarios: a Robot performing tasks and two GameCharacters engaging in combat. The Robot object can perform tasks, and the GameCharacters can attack each other, heal, and level up.

## Technologies

- C#

## Code Overview

The code consists of two classes:
1. `Robot`: Represents a robot with attributes like name, battery level, and model. It has methods to perform tasks.
2. `GameCharacter`: Represents a game character with attributes such as name, health, strength, and level. It has methods to attack, heal, and level up.

### `Robot` Class

- **Attributes**:
  - `name`: The name of the robot.
  - `batteryLevel`: Battery level of the robot.
  - `model`: The robot's model.

- **Methods**:
  - `PerformTask(task)`: Simulates performing a task and reduces the robot's battery level.

### `GameCharacter` Class

- **Attributes**:
  - `name`: The name of the character.
  - `health`: The character's health points.
  - `strength`: The character's attack strength.
  - `level`: The character's level.

- **Methods**:
  - `Attack(target)`: Attacks the target character, reducing its health by the attacker's strength.
  - `Heal(amount)`: Increases the character's health.
  - `LevelUp()`: Increases the character's level.

## Usage

Here is how the two scenarios are executed in the program:

1. A robot named `Rabot 1` is initialized with a specific battery level and model. It performs a task.
2. Two game characters, `Hero` and `Monster`, are initialized and engage in combat. The hero heals and levels up during the game.

## Explanation

### Robot Simulation

```csharp
Robot robot = new Robot(); // Bir robot objesi oluşturulur.

robot.name = "Rabot 1"; // Robotun ismi atanır.
robot.batteryLevel = 98; // Robotun batarya seviyesi belirlenir.
robot.model = "K3"; // Robotun modeli atanır.

robot.PerformTask("task 1"); // Robot bir görev gerçekleştirir.
```

In this part of the code, a new `Robot` object is created. The robot is assigned a name, battery level, and model. Then, it performs a task.

### GameCharacter Simulation

#### Hero and Monster Creation

```csharp
GameCharacter hero = new GameCharacter(); // Kahraman karakteri oluşturulur.
hero.name = "Hero"; // Karakterin ismi atanır.
hero.health = 100; // Kahramanın canı 100 olarak belirlenir.
hero.strength = 20; // Güç seviyesi atanır.
hero.level = 20; // Seviyesi atanır.

GameCharacter monster = new GameCharacter(); // Canavar karakteri oluşturulur.
monster.name = "Monster"; // Canavarın ismi atanır.
monster.health = 80; // Canavarın canı 80 olarak belirlenir.
monster.strength = 15; // Güç seviyesi atanır.
monster.level = 1; // Seviyesi atanır.
```

In this section, two `GameCharacter` objects are created: one for the hero and one for the monster. Their attributes such as name, health, strength, and level are initialized.

#### Attacking and Healing

```csharp
hero.Attack(monster); // Kahraman, canavara saldırır.

monster.Attack(hero); // Canavar, kahramana karşılık verir.

hero.Heal(10); // Kahraman kendini iyileştirir.

hero.LevelUp(); // Kahraman seviyesini artırır.

hero.Attack(monster); // Kahraman tekrar saldırır.
```

Here, the hero attacks the monster, and the monster retaliates. The hero then heals itself and levels up before attacking again.

## Output

The output of the program will vary depending on the interactions between the robot and the characters in the game simulation.

## License

This project is licensed under the MIT License.
