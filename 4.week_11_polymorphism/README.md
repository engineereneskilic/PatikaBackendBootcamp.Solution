
# Polymorphism Example: Geometrical Shapes

## Table of Contents
1. [Introduction](#introduction)
2. [Class Structure](#class-structure)
   - [BaseGeometrikSekil Class (Abstract)](#basegeometriksekil-class-abstract)
   - [Kare Class (Square)](#kare-class-square)
   - [Dikdortgen Class (Rectangle)](#dikdortgen-class-rectangle)
   - [DikUcgen Class (Right Triangle)](#dikucgen-class-right-triangle)
3. [Polymorphism](#polymorphism)
4. [Usage](#usage)
   - [Explanation](#explanation)
     - BaseGeometrikSekil
     - Kare
     - Dikdörtgen
     - DikUcgen
5. [Output](#output)
6. [License](#license)

---

## Introduction
This project demonstrates the principle of **polymorphism** in object-oriented programming (OOP) using C#. We will calculate the area of various geometrical shapes (square, rectangle, and right triangle) by defining a base class for common properties and methods, and extending it with specialized subclasses for each shape.

The project is designed with an **abstract base class** and **abstract methods**, allowing derived classes to implement shape-specific behavior for calculating areas.

---

## Class Structure

### BaseGeometrikSekil Class (Abstract)
The `BaseGeometrikSekil` class is an **abstract class** that defines the shared properties (`Genişlik`, `Yükseklik`) and an abstract method `AlanHesapla()` for calculating the area. 

#### Code:
```csharp
public abstract class BaseGeometrikSekil
{
    public double Genişlik { get; set; }
    public double Yükseklik { get; set; }

    // Abstract method for calculating area, to be overridden in derived classes
    public abstract double AlanHesapla();
}
```

#### Explanation:
- **Abstract Class:** `BaseGeometrikSekil` cannot be instantiated directly. It serves as a blueprint for derived classes.
- **Properties:** `Genişlik` (Width) and `Yükseklik` (Height) represent dimensions common to all geometric shapes.
- **Abstract Method:** `AlanHesapla()` must be implemented by any subclass that inherits from `BaseGeometrikSekil`. It does not have a body in the base class, enforcing derived classes to provide their own implementation.

---

### Kare Class (Square)
The `Kare` class inherits from `BaseGeometrikSekil` and implements the `AlanHesapla()` method to calculate the area of a square. 

#### Code:
```csharp
public class Kare : BaseGeometrikSekil
{
    // Override AlanHesapla to calculate the area of a square
    public override double AlanHesapla()
    {
        return Genişlik * Yükseklik;
    }
}
```

#### Explanation:
- **Inheritance:** `Kare` is a subclass of `BaseGeometrikSekil`, meaning it inherits the properties `Genişlik` and `Yükseklik`.
- **Area Calculation:** Since a square's area is calculated as `Width * Height` (which are equal in this case), the `AlanHesapla()` method implements this logic.
  
---

### Dikdortgen Class (Rectangle)
The `Dikdörtgen` class also inherits from `BaseGeometrikSekil` and provides its implementation of `AlanHesapla()` for calculating the area of a rectangle.

#### Code:
```csharp
public class Dikdörtgen : BaseGeometrikSekil
{
    // Override AlanHesapla to calculate the area of a rectangle
    public override double AlanHesapla()
    {
        return Genişlik * Yükseklik;
    }
}
```

#### Explanation:
- **Inheritance:** `Dikdörtgen` inherits `Genişlik` and `Yükseklik` properties from the base class.
- **Area Calculation:** The area of a rectangle is calculated using the same formula as a square: `Width * Height`, but in this case, the dimensions are not necessarily equal.

---

### DikUcgen Class (Right Triangle)
The `DikUcgen` class inherits from `BaseGeometrikSekil` but implements a different area calculation formula specific to right triangles.

#### Code:
```csharp
public class DikUcgen : BaseGeometrikSekil
{
    // Override AlanHesapla to calculate the area of a right triangle
    public override double AlanHesapla()
    {
        return (Genişlik * Yükseklik) / 2;
    }
}
```

#### Explanation:
- **Inheritance:** `DikUcgen` is a subclass of `BaseGeometrikSekil`.
- **Area Calculation:** The area of a right triangle is calculated as `(Width * Height) / 2`, which is implemented in the overridden `AlanHesapla()` method.

---

## Polymorphism
Polymorphism is achieved in this project by defining the `AlanHesapla()` method as abstract in the base class, and overriding it in the derived classes. This allows different shapes (square, rectangle, right triangle) to have their own implementations of how the area is calculated, while sharing the same method signature.

In this example, each shape class has its own logic for area calculation, but they all follow the same interface defined by the base class, demonstrating the power and flexibility of polymorphism.

---

## Usage

### Explanation

#### BaseGeometrikSekil:
- Abstract base class containing common properties `Genişlik` and `Yükseklik`.
- Abstract method `AlanHesapla()` enforces derived classes to provide their own area calculation logic.

#### Kare:
- Class representing a square.
- Inherits from `BaseGeometrikSekil` and implements area calculation logic: `Width * Height`.

#### Dikdörtgen:
- Class representing a rectangle.
- Inherits from `BaseGeometrikSekil` and calculates the area as `Width * Height`.

#### DikUcgen:
- Class representing a right triangle.
- Inherits from `BaseGeometrikSekil` and calculates the area using the formula `(Width * Height) / 2`.

---

## Output

The following is the output when the program is executed:

```
Kare Alanı: 25
Dikdörtgen Alanı: 24
Dik Üçgen Alanı: 6
```

---

## License
This project is licensed under the MIT License.
