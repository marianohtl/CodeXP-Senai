using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
           ImprimirDia();
        }
        /// <summary>
        /// função sem retorno, que devolve o dia da semana
        /// </summary>
          static void ImprimirDia(){
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
    }
}
