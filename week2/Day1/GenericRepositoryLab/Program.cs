using GenericRepositoryLab.Models;
using GenericRepositoryLab.Repositories;

var studentRepository = new Repository<Student>();

studentRepository.Add(new Student { Id = 1, Name = "Layth" });
studentRepository.Add(new Student { Id = 2, Name = "Ahmad" });

Console.WriteLine("Students:");
var students = studentRepository.GetAll();

foreach (var student in studentRepository.GetAll())
{
    Console.WriteLine($"{student.Id} - {student.Name}");
}

Console.WriteLine();

var productRepository = new Repository<Product>();

productRepository.Add(new Product { Id = 1, Name = "Laptop", Price = 3500 });
productRepository.Add(new Product { Id = 2, Name = "Mouse", Price = 80 });

Console.WriteLine("Products:");

foreach (var product in productRepository.GetAll())
{
    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
}

Console.WriteLine();

var foundStudent = studentRepository.Find(s => s.Id == 2);

if (foundStudent != null)
{
    Console.WriteLine($"Found Student: {foundStudent.Name}");
}