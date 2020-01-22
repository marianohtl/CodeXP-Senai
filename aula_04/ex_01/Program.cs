using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] serie1 = new string[10];
            string[] serie2 = new string[10];

            for(int i =0; i <= 9; i++){
                Console.WriteLine("Digite o nome de uma série: ");
                serie1[i] = Console.ReadLine();
            }

            for(int i =0; i <= 9; i++){
                serie2[i] = serie1[i];
            }

            for(int i = 0; i <= 9; i++){
                Console.Write(serie2[i] +" ");
            }

        }
    }
}
