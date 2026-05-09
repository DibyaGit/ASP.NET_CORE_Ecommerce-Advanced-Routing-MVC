# E-Commerce Advanced Routing System

## Project Overview

This project is a functional E-Commerce web application built using ASP.NET Core MVC. The primary focus is the implementation of sophisticated routing architectures to manage product catalogs, secure checkout processes, and enforce strict data validation via custom route constraints.

---

## Core Features

### Complex Product Routing

Implemented professional URL structures like:

```bash
/Products/{category}/{id}
```

This allows the application to dynamically serve product data based on department and unique product identifiers.

---

### User-State Dynamic Routing

Developed logic to monitor user status (Guest vs. Logged-in users).

Unauthorized users attempting to access the checkout process are automatically redirected to the login portal, ensuring a secure purchasing flow.

Example:

```bash
/Checkout?status=guest
```

---

### Custom Filtering Constraints

Created a custom `IRouteConstraint` to validate e-commerce search parameters.

The application only processes requests for recognized departments such as:

* Electronics
* Clothing
* Books

Invalid categories automatically return a `404 Not Found` response.

---

## Technical Implementation

| Technology    | Description                                                        |
| ------------- | ------------------------------------------------------------------ |
| Architecture  | ASP.NET Core MVC                                                   |
| Routing Logic | Dynamic redirection using `RedirectToAction`                       |
| Validation    | Custom `IRouteConstraint` with centralized mapping in `Program.cs` |
| Language      | C#                                                                 |
| IDE           | Visual Studio                                                      |

---

## Project Structure

```bash
ECommerceRoutingSystem/
│
├── Controllers/
├── Models/
├── Views/
├── Constraints/
├── wwwroot/
├── Program.cs
└── appsettings.json
```

---

## How to Run the Project

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/ECommerceRoutingSystem.git
```

---

### 2. Open in Visual Studio

* Launch Visual Studio
* Open the project solution file (`.sln`)
* Restore dependencies if prompted

---

### 3. Run the Application

Press:

```bash
Ctrl + F5
```

or click:

```bash
Start Without Debugging
```

---

## Routing Demonstrations

### Product Catalog Routing

Navigate to:

```bash
/Products/Clothing/101
```

Example:

```bash
https://localhost:5001/Products/Clothing/101
```

---

### Checkout Access Protection

Navigate to:

```bash
/Checkout?status=guest
```

Guest users will be redirected automatically.

---

### Route Constraint Validation

Valid Route:

```bash
/Products/Filter/electronics/under-500
```

Invalid Route:

```bash
/Products/Filter/pizza/10
```

Invalid categories will return:

```bash
404 Not Found
```

---

## Key Concepts Covered

* ASP.NET Core MVC Routing
* Attribute Routing
* Custom Route Constraints
* Dynamic Redirection
* Query String Handling
* Secure Navigation Flow
* URL Pattern Design
* Reusable Routing Logic

---

## Future Enhancements

* Authentication & Authorization
* Database Integration with Entity Framework Core
* Product Search & Pagination
* Shopping Cart Module
* Admin Dashboard
* REST API Integration

---

