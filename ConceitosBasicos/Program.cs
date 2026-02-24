// See https://aka.ms/new-console-template for more information
int idade;
Console.Write("Digite a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());
if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é o menor de idade.");
}
