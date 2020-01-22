using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int result= 0;
            int tab= 0;
            Console.WriteLine("Digite um número para calcularmos a tabuada:");
            tab = int.Parse(Console.ReadLine());
           for(int cont =1; cont <= 10; cont++){
                result = tab*cont;
                Console.WriteLine($"{tab}*{cont}={result}");
                }
        }
    }
}
