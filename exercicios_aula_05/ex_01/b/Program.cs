using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorUm = new int[10];
            int[] vetorDois = new int[10];
            int[] vetorTres = new int[20];
        
            for(int i = 0; i < 10; i++ ){  
                   Console.WriteLine("Digite um valor para o primeiro vetor: ");
                   vetorUm[i] = int.Parse(Console.ReadLine());                
            }

            for(int i = 0; i < 10; i++ ){  
                   Console.WriteLine("Digite um valor para o segundo vetor: ");
                   vetorDois[i] = int.Parse(Console.ReadLine());                
            }

             for(int i = 0; i < 10; i++ ){        
                  vetorTres[i] = vetorUm[i];
                  vetorTres[i+10] = vetorDois[i];
            }

              for(int i = 0; i < 20; i++ ){        
               Console.WriteLine(vetorTres[i]);
            }

             
        }
    }
}
