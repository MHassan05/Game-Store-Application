# GameStore Application

Comprehensive C# WinForms Game Store with a normalized SQL Server backend, role-based authentication, shopping cart and order processing, payment integration, and automated real-time inventory management.

## Features

* **Normalized Database**: Users, Genres, Platforms, Games, Orders, OrderDetails, Payments, Inventory, Cart.
* **WinForms UI**: Intuitive browsing, cart management, order placement, and order history.
* **Role-Based Authentication**: Admin and customer roles with different access levels.
* **Real-Time Inventory**: Automatic stock updates on orders and refunds.
* **Modular Design**: Easily extendable architecture for new features.

## Installation

1. Clone the repository:

   ```bash
   https://github.com/MHassan05/Game-Store-Application.git
   ```
2. Open `GameStore.sln` in Visual Studio.
3. Update the connection string in `App.config` to point to your SQL Server instance.
4. Build and run the solution.

## Usage

* **Admin**: Manage inventory
* **Customer**: Browse games, add to cart, place orders, make payments.

## Schema Overview

```sql
Users, Genres, Platforms, Games
Games_Genre, Games_Platform
Inventory
Orders -> OrderDetails
Payment
Cart
```

## Contributing
- [m-rajab24](https://github.com/m-rajab24)
- [Hamza-s2004](https://github.com/Hamza-s2004)

**Other Contributions are welcome! Please fork the repository and submit a pull request.**

