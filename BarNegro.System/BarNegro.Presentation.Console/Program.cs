// See https://aka.ms/new-console-template for more information
using BarNegro.Users.Application;
using BarNegro.Users.Application.Interfaces;
using BarNegro.Users.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddPersistenceServices();
builder.Services.AddUserServices();

using IHost host = builder.Build();


// Obtener el servicio ICreateUser desde el contenedor
var createUserService = host.Services.GetRequiredService<ICreateUser>();

// Usar el servicio
string id, nombre, apellido;

Console.WriteLine("Ingrese el DNI:");
id = Console.ReadLine();

Console.WriteLine("\nIngrese el Nombre:");
nombre = Console.ReadLine();

Console.WriteLine("\nIngrese el Apellido:");
apellido = Console.ReadLine();

// Llamar a la operación para crear el usuario
var user =  createUserService.CreateWaiter(id, nombre, apellido);

Console.WriteLine($"CREADO: {user.Name} {user.LastName}");

await host.RunAsync();

