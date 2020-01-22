using System;

namespace ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,maior;
            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());
            maior = n2;
            if(n1 > n2){
                maior = n1;
            }
                Console.WriteLine($"O maior número é {maior}.");
        }
    }
}
