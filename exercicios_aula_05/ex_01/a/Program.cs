using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] vetorUm = new int[10];
           int[] vetorDois = new int[20];
           int[] vetorTres = new int[20];
           int ii = 0;
           int iii = 10;
           int iiii = 0;
           int iiiii = 10;
           int iiiiii = 0;

           for(int i = 0; i < 60; i++ ){  
               if(i < 10){
                //    Console.WriteLine("O índice está na posição  "+ii);
                   Console.WriteLine("Digite um valor para o primeiro vetor: ");
                   vetorUm[ii] = int.Parse(Console.ReadLine());
                   vetorDois[ii] = 0;
                   ii++;
                }

               if(i >= 10 && i < 20){
                // Console.WriteLine("O índice está na posição  "+ii);
                   Console.WriteLine("Digite um valor para o segunto vetor: ");
                   vetorDois[iii] = int.Parse(Console.ReadLine());
                   iii++;
                }
                
                if(i > 19 && i < 30){
                   vetorTres[iiii] = vetorUm[iiii];
                   iiii++;
                }
                if(i > 29 && i < 40){
                   vetorTres[iiiii] = vetorDois[iiiii];
                   iiiii++;
                }
                if(i > 39 && i < 60){
                    Console.Write(vetorTres[iiiiii]);
                    iiiiii++;
                }
               }
           }
        }
    }

