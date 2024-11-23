
# Customer Orders View in ASP.NET MVC

This project demonstrates how to create a **Customer Orders View** in an ASP.NET MVC application. The view displays customer details along with their associated orders in a tabular format. It also handles scenarios where no orders are available for a customer.

---

## Table of Contents

1. [Overview](#overview)
2. [Code Explanation](#code-explanation)
   - [CustomerOrderViewModel](#customerorderviewmodel)
   - [View Layout](#view-layout)
   - [Orders Table](#orders-table)
3. [Output](#output)
4. [How to Use](#how-to-use)
5. [License](#license)

---

## Overview

The purpose of this view is to:
- Display customer information (ID, name, and email).
- Show a table of the customer's orders, including details such as:
  - Order ID
  - Product name
  - Price (formatted as currency)
  - Quantity
- Handle cases where no orders are associated with the customer.

---

## Code Explanation

### CustomerOrderViewModel

The `CustomerOrderViewModel` serves as the data model for this view. It combines customer details and their orders in one cohesive structure.

```csharp
public class CustomerOrderViewModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
}

public class Customer
{
    public int CustomerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}

public class Order
{
    public int OrderID { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

---

### View Layout

The layout file, `_Layout.cshtml`, is used as a shared layout for the application. The `CustomerOrders.cshtml` view is rendered within this layout.

The **Customer Information** section displays:
- The customer ID.
- The customer's full name.
- The customer's email address.

```html
@model CustomerOrderViewModel
@{
    Layout = "_Layout";
}

<h1>Customer Orders</h1>

<div>
    <h2>Customer Information</h2>
    <p><strong>ID:</strong> @Model.Customer.CustomerID</p>
    <p><strong>Name:</strong> @Model.Customer.FirstName @Model.Customer.LastName</p>
    <p><strong>Email:</strong> @Model.Customer.Email</p>
</div>
```

---

### Orders Table

The **Orders Table** section lists:
- Order ID
- Product name
- Price
- Quantity

If no orders are available, a message is displayed in the table.

```html
<div>
    <h2>Orders</h2>
    <table border="1" style="width: 100%; text-align: left;">
        <thead>
            <tr>
                <th>Order ID</th>
                <th>Product Name</th>
                <th>Price</th>
                <th>Quantity</th>
            </tr>
        </thead>
        <tbody>
            @if (Model.Orders != null && Model.Orders.Any())
            {
                foreach (var order in Model.Orders)
                {
                    <tr>
                        <td>@order.OrderID</td>
                        <td>@order.ProductName</td>
                        <td>@order.Price.ToString("C")</td>
                        <td>@order.Quantity</td>
                    </tr>
                }
            }
            else
            {
                <tr>
                    <td colspan="4" style="text-align: center;">No orders available.</td>
                </tr>
            }
        </tbody>
    </table>
</div>
```

---

## Output

### Scenario 1: Customer with Orders

If the customer has orders, the table is populated as follows:

```
Customer Information:
ID: 1
Name: John Doe
Email: john.doe@example.com

Orders:
| Order ID | Product Name       | Price     | Quantity |
|----------|--------------------|-----------|----------|
| 101      | Laptop             | $1,200.00| 1        |
| 102      | Mouse              | $25.00   | 2        |
```

### Scenario 2: Customer without Orders

If the customer has no orders, the following message is displayed:

```
Customer Information:
ID: 2
Name: Jane Smith
Email: jane.smith@example.com

Orders:
No orders available.
```

---

## How to Use

1. **Add the ViewModel Classes**:
   - Include the `CustomerOrderViewModel`, `Customer`, and `Order` classes in your project.

2. **Create the View**:
   - Add the `CustomerOrders.cshtml` file to the appropriate views folder in your ASP.NET MVC project.

3. **Controller**:
   - Populate the `CustomerOrderViewModel` in your controller action and pass it to the view:
     ```csharp
     public ActionResult CustomerOrders()
     {
         var customer = new Customer
         {
             CustomerID = 1,
             FirstName = "John",
             LastName = "Doe",
             Email = "john.doe@example.com"
         };

         var orders = new List<Order>
         {
             new Order { OrderID = 101, ProductName = "Laptop", Price = 1200m, Quantity = 1 },
             new Order { OrderID = 102, ProductName = "Mouse", Price = 25m, Quantity = 2 }
         };

         var viewModel = new CustomerOrderViewModel
         {
             Customer = customer,
             Orders = orders
         };

         return View(viewModel);
     }
     ```

4. **Run the Application**:
   - Navigate to the `CustomerOrders` view and see the results.

---

## License

This project is licensed under the MIT License. Feel free to use and modify it.

