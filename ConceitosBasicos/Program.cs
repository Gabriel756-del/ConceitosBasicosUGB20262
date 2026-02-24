// See https://aka.ms/new-console-template for more information
int idade;
bool idadeValidade = false;
while(!idadeValidade)
{
    Console.Write("Digite a sua idade: ");
    try
    {
        idade = Convert.ToInt32(Console.ReadLine());
        idadeValidade = true;
        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é o menor de idade.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("O valor informado deve ser em algarismos algébricos. NÚMEROS");
    }
}


