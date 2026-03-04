// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");
Cliente cliente = new Cliente();
Agencia agencia = new Agencia();

cliente.Nome = Console.ReadLine();
agencia.Numero = Console.ReadLine();

Console.WriteLine($"Nome do cliente: {cliente.Nome}");
Console.WriteLine($"Número do cliente:  {agencia.Numero}");