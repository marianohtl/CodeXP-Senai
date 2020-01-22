using System;

namespace ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int div = 1;
            double tot = 0;
            double media =0;
            string positivos = " ";
            for(int cont =1; cont <= 20; cont++){
                Console.WriteLine("Digite um número: ");
                valor = int.Parse(Console.ReadLine());
                if(valor > 0){
                    //Acrescentado vários números 
                    positivos += valor.ToString() + " ";
                }else{
                    tot = tot + valor;
                    div++;
                }
            }
                media=tot/div;
                Console.WriteLine($"Os números positivos digitados foram {positivos}.");
                Console.WriteLine($"A média dos valores negativos digitados é {media}.");
        }
    }
}
