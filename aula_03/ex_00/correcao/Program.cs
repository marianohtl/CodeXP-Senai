using System;

namespace correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            //laço contado for incremento
            for(int cont = 1; cont <= 100; cont ++){
                    if(cont %2 != 0){
                        Console.WriteLine("FOR 0 - 100 "+cont);
                    }
            }
            //Decremento 
            for(int cont = 100; cont >= 0; cont --){
                if(cont%2 != 0){
                    Console.WriteLine("FOR 100 - 0 " + cont);
                }
            }

        }
    }
}