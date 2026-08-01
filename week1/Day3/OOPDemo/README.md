# Day 3 - Object-Oriented Programming (OOP) Basics

## Overview

On Day 3, I learned the fundamentals of Object-Oriented Programming (OOP) using C#. Instead of writing everything inside a single file, I organized the project into multiple classes. This makes the code easier to understand, maintain, and reuse.

The project demonstrates how to create custom classes, instantiate objects, define properties, create methods, and use constructors.

---

# Objectives

The objectives of this day were:

- Understand the concept of Object-Oriented Programming.
- Learn how to create custom classes.
- Create objects from classes.
- Work with properties.
- Create methods inside classes.
- Learn how constructors work.
- Organize code into multiple files.

---

# Project Structure

```
Day3
│
├── OOPDemo
│   ├── Program.cs
│   ├── Person.cs
│   ├── Student.cs
│   ├── Car.cs
│   └── OOPDemo.csproj
```

Each class has its own responsibility.

---

# Person Class

The Person class represents a human.

It contains:

- Name
- Age
- Introduce() method

Example:

```csharp
public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}
```

This class stores information about a person and prints it using the Introduce() method.

---

# Student Class

The Student class represents another custom object.

It contains basic information such as:

- Name
- Age

It was created to practice creating multiple classes inside one project.

---

# Car Class

The Car class demonstrates how constructors work.

Properties:

- Brand
- Model

Constructor:

```csharp
public Car(string brand, string model)
{
    Brand = brand;
    Model = model;
}
```

The constructor initializes the object when it is created.

Example:

```csharp
Car car = new Car("Toyota", "Corolla");
```

---

# Program.cs

Inside Program.cs I created objects from different classes.

Example:

```csharp
Person person = new Person();

person.Name = "Abdelrahman";
person.Age = 22;

person.Introduce();

Student student = new Student();

student.Name = "Ali";
student.Age = 20;

Car car = new Car("Toyota", "Corolla");

Console.WriteLine($"{car.Brand} {car.Model}");
```

This demonstrates how objects interact with different classes.

---

# Concepts Learned

During this day I learned:

- Classes
- Objects
- Properties
- Methods
- Constructors
- Object Initialization
- Code Organization
- Reusability
- Encapsulation basics

---

# Expected Output

```
Hi, I'm Abdelrahman and I'm 22 years old.
Toyota Corolla
```

---

# What I Learned

By the end of this exercise I understood that:

- Every object is created from a class.
- A class acts as a blueprint.
- Properties store object data.
- Methods define object behavior.
- Constructors initialize objects when they are created.
- Splitting code into multiple classes improves readability and maintainability.

---

# Summary

This project introduced the core concepts of Object-Oriented Programming in C#. It showed how to create multiple classes, instantiate objects, assign values to properties, call methods, and initialize objects using constructors. These concepts form the foundation for building larger and more maintainable C# applications.

---

# Status

✅ Day 3 Completed Successfully