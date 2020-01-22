using System;

namespace ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
         float salario, divida, sobra;
         Console.WriteLine("Digite o seu salário:");
         salario =  float.Parse(Console.ReadLine());
         Console.WriteLine("Digite suas dívidas:");
         divida =  float.Parse(Console.ReadLine());
         sobra = salario - divida; 
         Console.WriteLine($"Você recebe R${salario}, e possui R${divida} de dívidas, pagando suas dívidas, sobra para ti R${sobra}.");
        }
    }
}
