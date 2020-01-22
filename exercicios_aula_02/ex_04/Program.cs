using System;

namespace ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            float precoTot, desc;
            Console.WriteLine("Digite o preço total: ");
            precoTot = float.Parse(Console.ReadLine());
            if(precoTot >= 100 && precoTot <= 1000){
                desc = precoTot * 0.15f;
                precoTot = precoTot - desc;
                Console.WriteLine($"Seu desconto é de {desc}, o valor final da compra é R${precoTot}.");
            }else{

                Console.WriteLine($"Você não recebe desconto, o valor final da compra é R${precoTot}.");
            }
        }
    }
}
