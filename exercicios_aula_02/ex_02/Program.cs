using System;

namespace ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float precoTot;
            Console.WriteLine("Digite o preço total do produto: ");
            precoTot = float.Parse(Console.ReadLine());
            if(precoTot > 100){
                precoTot = precoTot - 25f;
                Console.WriteLine($"PREÇO FINAL: R${precoTot}");
            }else{
                Console.WriteLine($"PREÇO FINAL: R${precoTot}");
            }
        }
    }
}
