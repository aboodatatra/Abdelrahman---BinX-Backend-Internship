# Week 2 - Day 1: Generic Repository Lab

## 📌 Overview

This project is part of the BinX Backend .NET Internship (Week 2 - Day 1).

The goal of this lab was to understand how Generics work in C# by building a reusable Generic Repository. Instead of creating separate repositories for every model, a single generic repository was implemented to support multiple reference types while maintaining clean and reusable code.

---

# 🎯 Objectives

- Understand Generic Classes.
- Learn how to create a reusable Repository<T>.
- Apply Generic Constraints using `where T : class`.
- Use `Predicate<T>` to search for objects.
- Return data safely using `IReadOnlyList<T>`.
- Test the repository with different models.

---

# 📂 Project Structure

```
GenericRepositoryLab
│
├── Models
│   ├── Student.cs
│   └── Product.cs
│
├── Repositories
│   └── Repository.cs
│
├── Program.cs
│
├── GenericRepositoryLab.csproj
│
└── README.md
```

---

# 🛠 What I Built

## Generic Repository

Created a reusable generic repository that supports any reference type.

Implemented:

- Add(T item)
- GetAll()
- Find(Predicate<T>)

---

## Models

Created two different models:

### Student

Properties:

- Id
- Name

### Product

Properties:

- Id
- Name
- Price

The repository was tested successfully using both models.

---

# 💻 Program Output

```
Students:
1 - Abdelrahman
2 - Ahmad

Products:
1 - Laptop - 3500
2 - Mouse - 80

Found Student: Ahmad
```

---

# 📖 What I Learned

During this lab I learned:

### 1. Generic Classes

Instead of creating:

```
StudentRepository
ProductRepository
EmployeeRepository
```

I can simply create:

```
Repository<T>
```

and reuse it for any class.

---

### 2. Generic Constraints

Using:

```csharp
where T : class
```

restricts the repository to work only with reference types.

---

### 3. Predicate<T>

Predicate<T> makes searching flexible.

Example:

```csharp
studentRepository.Find(s => s.Id == 2);
```

No need to write a separate search method for every model.

---

### 4. IReadOnlyList<T>

Returning IReadOnlyList prevents external code from modifying the internal collection.

Example:

```csharp
var students = repository.GetAll();
```

Trying to execute:

```csharp
students.Add(...);
```

results in an error because IReadOnlyList is read-only.

This protects the repository's internal data.

---

# ⚠ Problems I Faced

## 1. Multiple Projects

Initially I accidentally created two Console projects inside Day1.

Solution:

- Removed the unnecessary project.
- Kept only GenericRepositoryLab.

---

## 2. Incorrect Folder Structure

Repository.cs was initially placed outside the Repositories folder.

Solution:

Moved Repository.cs into:

```
Repositories/
```

to keep the project organized.

---

## 3. Folder Naming

Initially the folder was named:

```
Repository
```

It was renamed to:

```
Repositories
```

for better project structure.

---

## 4. Understanding IReadOnlyList

At first I expected GetAll() to return a normal List.

After testing:

```csharp
students.Add(...)
```

I discovered that IReadOnlyList intentionally prevents modifications.

This helped me understand encapsulation and data protection.

---

# 🚀 Skills Practiced

- C#
- .NET Console Applications
- Generics
- Generic Constraints
- Predicate<T>
- IReadOnlyList<T>
- Clean Project Structure
- Object-Oriented Programming
- Repository Pattern Basics

---

# 📌 Conclusion

This lab introduced one of the most important concepts in C#:
Generics.

By creating a Generic Repository, I learned how to write reusable, maintainable, and type-safe code while avoiding duplication.

I also gained a better understanding of repository design, collection safety, and generic programming, which are fundamental concepts for building scalable .NET backend applications.

---

**Internship:** BinX Backend .NET Internship

**Week:** 2

**Day:** 1

**Student:** Abdelrahman