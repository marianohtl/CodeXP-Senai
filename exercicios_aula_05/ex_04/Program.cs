using System;

namespace ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorDez = new int[10];
            int x;

            Console.WriteLine("Vamos gerar um vetor aleatório, digite um número: ");
            x =  int.Parse(Console.ReadLine());    
            for(int i = 0; i < 10; i++ ){  
                   vetorDez[i] = i * x;                
            }
            
            for(int i = 0; i < 10; i++ ){  
                   Console.WriteLine(vetorDez[i]);                
            }
        }
    }
}
