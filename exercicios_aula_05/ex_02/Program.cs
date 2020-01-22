using System;

namespace ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
             String[] Nome = new string[12];
             String[] Cor = new string[12];
             int[] Tamanho = new int[12];
             double[] Preco = new double[12];

             for(int i = 0; i < 12; i++ ){  
                   Console.WriteLine("Digite o nome do produto: ");
                   Nome[i] = Console.ReadLine();                
                   Console.WriteLine("Digite a cor do produto: ");
                   Cor[i] = Console.ReadLine();                
                   Console.WriteLine("Digite o tamanho do produto: a");
                   Tamanho[i] = int.Parse(Console.ReadLine());
                   Console.WriteLine("Digite o preço do produto: R$");                
                   Preco[i] = double.Parse(Console.ReadLine());                
            }

            for(int i = 0; i < 12; i++ ){        
            Console.WriteLine($"Nome: {Nome[i]}");
            Console.WriteLine($"Cor: {Cor[i]}");
            Console.WriteLine($"Tamanho: {Tamanho[i]}");
            Console.WriteLine($"Preço: {Preco[i]}");
            
            }
        }
    }
}
