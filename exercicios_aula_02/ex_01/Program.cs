using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
           float sal, desp, saldo;
           Console.WriteLine("Digite seu salário:");
           sal = float.Parse(Console.ReadLine());
           Console.WriteLine("Digite sua dívida:");
           desp = float.Parse(Console.ReadLine());
           saldo = sal - desp;
            if(saldo < 0){
               Console.WriteLine("Seu saldo final é negativo.");
               Console.WriteLine($"Saldo final: {saldo}");
            }else{
               Console.WriteLine("Seu saldo final é positivo.");
               Console.WriteLine($"Saldo final: {saldo}");

            }
        }
    }
}
