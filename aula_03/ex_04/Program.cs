using System;

namespace ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
        int cont = 1;
        int num = 0;
        int mult = 0;
         do{
             Console.WriteLine("Digite um número: ");
             num = int.Parse(Console.ReadLine());
             if(num%3 == 0){
                 mult =mult+ num;
             }
             cont ++;
         }while(cont <= 20);
        Console.WriteLine($"A somas dos múltiplos de 3 ficou {mult}.");
        }
    }
}
