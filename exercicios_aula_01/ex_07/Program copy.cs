using System;

namespace exercicios_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float passageiros, value;
            float passagem = 4.30f;
            Console.WriteLine("Digite a quantidade de passageiros: ");
            passageiros = float.Parse(Console.ReadLine());
            value =  passageiros * passagem;
            Console.WriteLine($"O valor total a ser arrecadado foi {value}.");
        }
    }
}
