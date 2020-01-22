using System;

namespace ex_00
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cubo = 0;
            for (int cont = 1; cont <= 100; cont++){
                cubo = cont *  cont * cont;
                Console.WriteLine($"O número {cont} elevado ao cubo é {cubo}.");
            }
        }
    }
}
