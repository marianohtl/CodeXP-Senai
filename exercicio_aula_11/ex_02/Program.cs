using System;
using ex_02.Controllers;

namespace ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroesControllers heroe = new HeroesControllers();

            Console.Clear();
            heroe.Menu();
            Console.Clear();
 
 
        }
    }
}
