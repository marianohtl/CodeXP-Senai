using System;

namespace ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int maior =0;
            int indice = 0;
            for(int i = 0; i < 10; i++ ){  
                Console.WriteLine("Digite um valor para o primeiro vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if(i == 0){
                    maior = vetor[i];                
                }

                if(maior < vetor[i]){
                    maior = vetor[i];
                    indice = i + 1;                
                }
                
            }
           Console.WriteLine($"O maior número é {maior} na posição {indice}.");
     
        }
            
    }
}
