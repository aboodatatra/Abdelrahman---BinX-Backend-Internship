# Week 3 - Day 1

## REST API Design Principles & Resource Modeling

### Learning Objectives

- Understand what makes an API RESTful.
- Apply proper resource naming conventions.
- Use HTTP methods correctly.
- Return appropriate HTTP status codes.
- Apply API versioning.

---

# Project Domain

**Order Management System**

This project provides a RESTful API for managing customers, products, categories, and orders.

---

# Core Resources

- Customers
- Orders
- Products
- Categories

---

# Primary Resource

The primary resource for this API is **Orders**.

---

# Orders Endpoints

| HTTP Method | Endpoint | Description |
|-------------|----------|-------------|
| GET | /api/v1/orders | Retrieve all orders |
| GET | /api/v1/orders/{id} | Retrieve a specific order by ID |
| POST | /api/v1/orders | Create a new order |
| PUT | /api/v1/orders/{id} | Update an existing order |
| DELETE | /api/v1/orders/{id} | Delete an order |

---

# Nested Resource

Customers can have multiple orders.

| HTTP Method | Endpoint | Description |
|-------------|----------|-------------|
| GET | /api/v1/customers/{id}/orders | Retrieve all orders for a specific customer |

---

# HTTP Status Codes

| Endpoint | Success | Error |
|----------|---------|-------|
| GET /api/v1/orders | 200 OK | 500 Internal Server Error |
| GET /api/v1/orders/{id} | 200 OK | 404 Not Found |
| POST /api/v1/orders | 201 Created | 400 Bad Request |
| PUT /api/v1/orders/{id} | 200 OK | 404 Not Found |
| DELETE /api/v1/orders/{id} | 204 No Content | 404 Not Found |
| GET /api/v1/customers/{id}/orders | 200 OK | 404 Not Found |

---

# API Versioning

This project uses URL versioning.

Current Version

```
/api/v1/
```

Future Version

```
/api/v2/
```

---

# REST Resource Map

```text
Order Management API

Customers
│
└── GET /api/v1/customers/{id}/orders

Orders
│
├── GET      /api/v1/orders
├── GET      /api/v1/orders/{id}
├── POST     /api/v1/orders
├── PUT      /api/v1/orders/{id}
└── DELETE   /api/v1/orders/{id}

Products

Categories
```

---

# REST Principles Applied

- Resources are named using plural nouns.
- HTTP methods represent actions.
- URLs do not contain verbs.
- Proper HTTP status codes are used.
- URL versioning is implemented.
- Resources are organized logically.

---

# Tools Used

- ASP.NET Core Web API
- Postman
- Notion

---

# What I Learned

- REST API design principles.
- Resource modeling.
- Designing RESTful endpoints.
- Proper use of HTTP methods.
- HTTP status codes.
- API versioning.
- Organizing resources using REST conventions.