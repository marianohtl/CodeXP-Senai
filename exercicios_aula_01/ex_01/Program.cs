using System;

namespace exercicios_aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero, triplo;
            Console.WriteLine("Digite um número: ");
            numero = float.Parse(Console.ReadLine());
            triplo = numero * 3;
            Console.WriteLine($"O triplo de {numero} é {triplo}.");
        }
    }
}
