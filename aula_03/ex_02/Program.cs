using System;

namespace aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int pop = 0;
            int tot = 0;
              for(int cont=1; cont <= 10; cont++){
                Console.WriteLine("Quantas pessoas tem nesta cidade?");
                pop = int.Parse(Console.ReadLine());
                tot = tot + pop;
              }
                Console.WriteLine($"O total de pessoas nesta cidade é {tot}.");
        }
    }
}
