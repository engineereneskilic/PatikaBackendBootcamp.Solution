
# Product Management Console Application

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

This project is a basic console application for managing products such as laptops and phones. 
It allows users to perform operations such as displaying product details, selling products, 
and restocking products.

## Technologies

- C#
- .NET Core

## Code Overview

### Classes and Methods

The project has a `Product` class that models the basic properties of a product such as name, price, and stock.

- **Fields:**
  - `name`: Stores the name of the product.
  - `price`: Stores the price of the product. It has validation to ensure the price is non-negative.
  - `stock`: Stores the stock quantity of the product. It has validation to ensure the stock is non-negative.

- **Methods:**
  - `DisplayProduct()`: Displays the product's current details.
  - `SellProduct(int quantity)`: Decreases the stock by the given quantity if sufficient stock is available.
  - `RestockProduct(int quantity)`: Increases the stock by the given quantity.

## Usage

To use the application, simply run the console program. The program will display product details, sell a certain amount, and restock products based on the hardcoded data in the `Main` method.

### Example Usage

```csharp
Product laptop = new Product();
laptop.Name = "Laptop";
laptop.Price = 10000;
laptop.Stock = 10;

Product phone = new Product();
phone.Name = "Telefon";
phone.Price = 500;
phone.Stock = 20;

laptop.DisplayProduct();
phone.DisplayProduct();

laptop.SellProduct(2);
phone.SellProduct(5);

laptop.RestockProduct(5);
phone.RestockProduct(10);
```

## Explanation

### 1. Product Class

This class models the product and includes methods to interact with it. 
The properties are encapsulated with validation to ensure the correctness of product data.

#### Methods Breakdown:

- `DisplayProduct()`: This method outputs the product's name, price, and stock to the console.
  
- `SellProduct(int quantity)`: This method decreases the stock if the requested quantity is available. It prints whether the sale was successful or if there was insufficient stock.

- `RestockProduct(int quantity)`: This method increases the stock by the specified amount and outputs the new stock value.

### 2. Main Method

In the `Main` method, two products (laptop and phone) are created, displayed, sold, and restocked.

- **Create Products:** Objects `laptop` and `phone` are instantiated from the `Product` class.
- **Display:** The details of both products are displayed using the `DisplayProduct` method.
- **Sell Products:** Both products are sold using the `SellProduct` method, with the stock reducing accordingly.
- **Restock:** Both products are restocked using the `RestockProduct` method, with the stock increasing.

## Output

The output of the program is displayed in the console and shows the product details, successful sales, and stock updates.

### Example Output

```
Ürün Laptop, Fiyat 10000, Stock 10
Ürün Telefon, Fiyat 500, Stock 20
2 adet Laptop satıldı. Kalan stok 8
5 adet Telefon satıldı. Kalan stok 15
5 adet Laptop stoğa eklendi. Güncel stok miktarı 13
10 adet Telefon stoğa eklendi. Güncel stok miktarı 25
```

## License

This project is open-source and free to use.
