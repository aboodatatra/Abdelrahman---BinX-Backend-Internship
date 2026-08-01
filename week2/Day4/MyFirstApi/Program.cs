using MyFirstApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Custom Middleware
app.UseMiddleware<RequestLoggingMiddleware>();

// Configure HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

// Minimal API - GET All Items
var items = new List<string>
{
    "Laptop",
    "Mouse",
    "Keyboard"
};

app.MapGet("/items", () => items);

// Minimal API - GET Item By Id
app.MapGet("/items/{id:int}", (int id) =>
{
    if (id < 0 || id >= items.Count)
        return Results.NotFound();

    return Results.Ok(items[id]);
});

app.Run();