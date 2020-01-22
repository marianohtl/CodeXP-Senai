using System;

namespace ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] A = new string[15];
            String[] B = new string[15];
            String[] C  = new string[30];
        
            for(int i = 0; i < 15; i++ ){  
                   Console.WriteLine("Digite uma palavra: ");
                   A[i] = Console.ReadLine();                
            }

            for(int i = 0; i < 15; i++ ){  
                Console.WriteLine("Digite uma palavra: ");
                B[i] = Console.ReadLine();                
            }

             for(int i = 0; i < 15; i++ ){        
                  C[i] = A[i];
                  C[i+15] = B[i];
            }

              for(int i = 0; i < 30; i++ ){        
               Console.WriteLine(C[i]);
            }

        }
    }
}
