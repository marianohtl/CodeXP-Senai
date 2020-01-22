using System;

namespace ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            float real, dollar;
            Console.WriteLine("Digite a cotação do dollar: ");
            dollar = float.Parse(Console.ReadLine());
            Console.WriteLine("O valor em reais");
            real = float.Parse(Console.ReadLine());
            dollar = real /dollar;
            Console.WriteLine($"O valor em dollar é {dollar}");
        }
    }
}
