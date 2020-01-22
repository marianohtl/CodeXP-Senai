using System;

namespace ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,n3 ,maior;
            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n3 = int.Parse(Console.ReadLine());
            
            maior = n2;
            if(n1 > n2 && n1 > n3){
                maior = n1;
            }else if (n2 > n1 && n2 > n3){
                maior = n2;
            } else{
                maior = n3;
            }
                Console.WriteLine($"O maior número digitado foi {maior}.");
        }
        }
    }

