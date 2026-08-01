List<Person> people = new List<Person>()
{
    new Person { Name = "Ali", Age = 20 },
    new Person { Name = "Ahmad", Age = 24 },
    new Person { Name = "Sara", Age = 18 },
    new Person { Name = "Omar", Age = 30 },
    new Person { Name = "Lina", Age = 26 },
    new Person { Name = "Yousef", Age = 19 },
    new Person { Name = "Noor", Age = 22 },
    new Person { Name = "Mona", Age = 28 }
};
var adults = people.Where(p => p.Age > 22);

Console.WriteLine("People older than 22:");

foreach (var person in adults)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}
var names = people.Select(p => p.Name);

Console.WriteLine("\nAll Names:");

foreach (var name in names)
{
    Console.WriteLine(name);
}
var count = people.Count(p => p.Age > 22);

Console.WriteLine($"\nNumber of people older than 22: {count}");
string result = await GetDataAsync();

Console.WriteLine(result);
try
{
    Console.Write("\nEnter your age: ");

    string input = Console.ReadLine();

    int age = int.Parse(input);

    Console.WriteLine($"Your age is {age}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input! Please enter numbers only.");
}
static async Task<string> GetDataAsync()
{
    Console.WriteLine("\nLoading data...");

    await Task.Delay(3000);

    return "Data loaded successfully!";
}