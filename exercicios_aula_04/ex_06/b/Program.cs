using System;

namespace ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int cont = 1;
            int soma = 0;
            int produto=1;

            do{
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if(num > 0){
                    cont++;
                    if(num%2 != 0){
                        soma = num + soma;
                    }
                    if(num%3 == 0 ){
                        produto = produto * num;

                    }
                }
            }while(cont <=5);
            if(produto == 1){
                produto = 0;
            }
                        Console.WriteLine($"O produto dos múltiplos de 3 digitados são: {produto}.");
                        Console.WriteLine($"A soma dos números ímpares é {soma}.");
 
        }
    }
}
