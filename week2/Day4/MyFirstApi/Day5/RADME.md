# Day 5 – Middleware Pipeline & Dependency Injection

## 📌 Overview
This project demonstrates how middleware and dependency injection work in ASP.NET Core Web API.

## 📚 Topics Covered
- Middleware Pipeline
- Custom Middleware
- Dependency Injection (DI)
- Service Registration
- Constructor Injection
- Service Lifetimes
- Controllers & Minimal APIs

## ✅ What I Implemented

### Custom Middleware
- Created a custom middleware to log each request's HTTP method and request path.
- Registered the middleware in `Program.cs`.

### Dependency Injection
- Created a service interface.
- Implemented the service.
- Registered the service using the built-in DI container.
- Injected the service into a controller using constructor injection.

### API Endpoints
#### Controller Endpoints
- GET `/api/items`
- GET `/api/items/{id}`

#### Minimal API Endpoints
- GET `/items`
- GET `/items/{id}`

## 🛠 Technologies
- .NET 10
- ASP.NET Core Web API
- Swagger
- Dependency Injection
- Middleware

## 📂 Project Structure
```
Day5/
└── MyFirstApi/
    ├── Controllers/
    ├── Middleware/
    ├── Services/
    ├── Program.cs
    ├── appsettings.json
    └── README.md
```

## 🎯 Learning Outcomes
- Understand the ASP.NET Core middleware pipeline.
- Create and register custom middleware.
- Use Dependency Injection with services.
- Inject services into controllers.
- Understand service lifetimes.
- Build clean and maintainable Web APIs.

## ✅ Status
Completed Day 5 successfully.