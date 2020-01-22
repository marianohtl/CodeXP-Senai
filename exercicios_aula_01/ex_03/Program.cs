using System;

namespace ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario , vendasPorcento , totalRecebido;
            Console.WriteLine("Digite seu salário: ");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor das vendas: ");
            vendasPorcento = float.Parse(Console.ReadLine());
            vendasPorcento = vendasPorcento * 0.05f;
            totalRecebido = salario + vendasPorcento;
            Console.WriteLine($"Seu novo salário é {totalRecebido}");

        }
    }
}
