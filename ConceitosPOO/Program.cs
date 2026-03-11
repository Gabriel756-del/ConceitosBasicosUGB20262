// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Primeiro Acesso ao Banco");
Cliente cliente;
Console.WriteLine("Informe o nome do cliente:");
string nome = Console.ReadLine();
Console.WriteLine("Informe o CPF do cliente:");
string cpf = Console.ReadLine();
cliente = new Cliente(nome, cpf);
//cliente.Nome = "Gabriel";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");
Agencia agencia = new Agencia(123);
agencia.Nome = "UGBVR";
agencia.Telefone = "(24)3345-1700";
Console.WriteLine("Dados da agencia: ");
Console.WriteLine("Numero: " + agencia.Numero);
Console.WriteLine("Nome: " + agencia.Nome);
Console.WriteLine("Telefone: " + agencia.Telefone);
Console.WriteLine("Informe o número da conta:");
long numero = Convert.ToInt64 (Console.ReadLine());
Console.WriteLine($"Informe o saldo inicial da conta {numero}:");
decimal saldoInicial = Convert.ToDecimal (Console.ReadLine()); // Or decimal.Parse
Conta conta = new Conta(numero, saldoInicial);
//imprimir os dados da conta
Console.WriteLine($"A conta número {conta.Numero}, possui saldo {conta.Saldo}");
//depositar 1000 na conta
conta.Deposito(1000);
//exibir saldo
Console.WriteLine($"A conta número {conta.Numero} possui saldo {conta.Saldo}");
//sacar 500 da conta
conta.Saque(500);
//exibir saldo
Console.WriteLine($"A conta número {conta.Numero}, possui saldo {conta.Saldo}");