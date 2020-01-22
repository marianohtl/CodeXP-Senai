using System;

namespace ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco, percentual, final;
            Console.WriteLine("Qual o preço do teu produto?");
            preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o % de acréscimo que deseja acrescentar sobre a sua mercadoria?");
            percentual = float.Parse(Console.ReadLine());
            percentual = preco * (percentual/100);
            final = preco + percentual;
            Console.WriteLine($"O valor da sua compra são R${final}");
        }
    }
}
