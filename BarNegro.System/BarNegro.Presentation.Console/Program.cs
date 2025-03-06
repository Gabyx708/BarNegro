// See https://aka.ms/new-console-template for more information
using BarNegro.Dishes.Application;
using BarNegro.Dishes.Application.Interfaces;
using BarNegro.Dishes.Infrastructure;
using BarNegro.Users.Application;
using BarNegro.Users.Application.Interfaces;
using BarNegro.Users.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

//users module
builder.Services.AddUsersPersistenceServices(@"Data Source=C:\Users\Gabriel\Desktop\Dbs\users.db");
builder.Services.AddUserServices();

//dishs module
builder.Services.AddDishApplicationServices();
builder.Services.AddDishPersistenceServices(@"Data Source=C:\Users\Gabriel\Desktop\Dbs\dish.db");

using IHost host = builder.Build();


// Obtener el servicio ICreateUser desde el contenedor
var creteCategory = host.Services.GetRequiredService<ICreateCategory>();

// Usar el servicio
string descripcion;

Console.WriteLine("Ingrese la descripcion de la categoria:");

descripcion = Console.ReadLine();

var categoriaCreada = creteCategory.CreateCategory(descripcion);

Console.WriteLine($"se creo la categoria: ID {categoriaCreada.CategoryId} {categoriaCreada.Description}");

await host.RunAsync();

