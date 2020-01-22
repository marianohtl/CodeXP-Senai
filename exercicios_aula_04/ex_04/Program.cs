using System;

namespace ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario =0;
            double media =0;
            double tot = 0;
            int func;
            Console.WriteLine("Deseja calcular a média de quantos funcionários?");
            func = int.Parse(Console.ReadLine());
            for(int cont=1; cont <= func; cont++){
                Console.WriteLine($"Qual o salário do funcionário {cont}?");
                salario = double.Parse(Console.ReadLine());
                tot = tot + salario;
            }
                media = tot / func;
                Console.WriteLine($"A média salarial dos {func} funcionários é {media}");
        }
        
    }
}
