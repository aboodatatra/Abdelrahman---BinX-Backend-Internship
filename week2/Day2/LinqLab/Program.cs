using LinqLab.Models;

var customers = new List<Customer>
{
    new Customer { Id = 1, Name = "Ahmed" },
    new Customer { Id = 2, Name = "Ali" },
    new Customer { Id = 3, Name = "Sara" },
    new Customer { Id = 4, Name = "Mona" },
    new Customer { Id = 5, Name = "Omar" },
    new Customer { Id = 6, Name = "Lina" }
};

var orders = new List<Order>
{
    new Order
    {
        Id = 1,
        CustomerId = 1,
        Amount = 500,
        Items = new List<OrderItem>
        {
            new OrderItem { Id = 1, ProductName = "Laptop", Quantity = 1 },
            new OrderItem { Id = 2, ProductName = "Mouse", Quantity = 2 }
        }
    },

    new Order
    {
        Id = 2,
        CustomerId = 2,
        Amount = 200,
        Items = new List<OrderItem>
        {
            new OrderItem { Id = 3, ProductName = "Keyboard", Quantity = 1 }
        }
    },

    new Order
    {
        Id = 3,
        CustomerId = 1,
        Amount = 300,
        Items = new List<OrderItem>
        {
            new OrderItem { Id = 4, ProductName = "Monitor", Quantity = 1 }
        }
    },

    new Order
    {
        Id = 4,
        CustomerId = 3,
        Amount = 150,
        Items = new List<OrderItem>
        {
            new OrderItem { Id = 5, ProductName = "USB", Quantity = 3 }
        }
    },

    new Order
    {
        Id = 5,
        CustomerId = 4,
        Amount = 700,
        Items = new List<OrderItem>
        {
            new OrderItem { Id = 6, ProductName = "Printer", Quantity = 1 }
        }
    },

    new Order
    {
        Id = 6,
        CustomerId = 5,
        Amount = 250,
        Items = new List<OrderItem>
        {
            new OrderItem { Id = 7, ProductName = "Headset", Quantity = 2 }
        }
    }
};

Console.WriteLine("========== GroupBy ==========");

var grouped = orders
    .GroupBy(o => o.CustomerId)
    .Select(g => new
    {
        CustomerId = g.Key,
        Total = g.Sum(o => o.Amount)
    });

foreach (var g in grouped)
{
    Console.WriteLine($"Customer {g.CustomerId} -> Total = {g.Total}");
}

Console.WriteLine();

Console.WriteLine("========== Join ==========");

var joined = customers.Join(
    orders,
    c => c.Id,
    o => o.CustomerId,
    (c, o) => new
    {
        c.Name,
        o.Amount
    });

foreach (var item in joined)
{
    Console.WriteLine($"{item.Name} -> {item.Amount}");
}

Console.WriteLine();

Console.WriteLine("========== SelectMany ==========");

var items = orders.SelectMany(o => o.Items);

foreach (var item in items)
{
    Console.WriteLine($"{item.ProductName} - Qty: {item.Quantity}");
}

Console.WriteLine();

Console.WriteLine("========== Deferred Execution ==========");

var expensiveOrders = orders.Where(o => o.Amount >= 300);

orders.Add(new Order
{
    Id = 7,
    CustomerId = 6,
    Amount = 900,
    Items = new List<OrderItem>
    {
        new OrderItem
        {
            Id = 8,
            ProductName = "Tablet",
            Quantity = 1
        }
    }
});

foreach (var order in expensiveOrders)
{
    Console.WriteLine($"Order {order.Id} -> {order.Amount}");
}