# Day 4 - C# Fundamentals III: Collections & LINQ Basics

## Learning Objectives

During Day 4 I learned how to work with collections in C#, use LINQ to query data, write asynchronous methods with async/await, and handle exceptions properly.

---

## Topics Covered

- List<T>
- LINQ (Where, Select, Count)
- Async / Await
- Task.Delay
- Exception Handling
- Try/Catch
- FormatException

---

## What I Built

### 1. List of Objects

I created a List<Person> containing eight different people with different names and ages.

Example:

- Ali (20)
- Ahmad (24)
- Sara (18)
- Omar (30)
- Lina (26)
- Yousef (19)
- Noor (22)
- Mona (28)

---

### 2. LINQ Filter

I filtered people older than 22 years.

Example:

```csharp
var adults = people.Where(p => p.Age > 22);
```

Output:

```
Ahmad - 24
Omar - 30
Lina - 26
Mona - 28
```

---

### 3. LINQ Projection

I selected only the names from the list.

Example:

```csharp
var names = people.Select(p => p.Name);
```

Output:

```
Ali
Ahmad
Sara
Omar
Lina
Yousef
Noor
Mona
```

---

### 4. LINQ Aggregation

I counted how many people are older than 22.

Example:

```csharp
var count = people.Count(p => p.Age > 22);
```

Output:

```
Number of people older than 22: 4
```

---

### 5. Async/Await

I created an asynchronous method using Task.Delay to simulate an I/O operation.

Example:

```csharp
await Task.Delay(3000);
```

The program waits for three seconds and then prints:

```
Data loaded successfully!
```

---

### 6. Exception Handling

I used try/catch to safely parse user input.

```csharp
try
{
    int age = int.Parse(input);
}
catch (FormatException)
{
    Console.WriteLine("Invalid input!");
}
```

This prevents the application from crashing when invalid input is entered.

---

## What I Learned

- How to use List<T>
- How to query collections with LINQ
- Difference between filtering and selecting
- How Count works
- How async/await works
- Why Task.Delay simulates asynchronous work
- How to catch specific exceptions
- Why FormatException should be handled

---

## Technologies Used

- C#
- .NET SDK
- VS Code
- Git
- GitHub

---

## Status

Day 4 completed successfully.