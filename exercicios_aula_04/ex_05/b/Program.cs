using System;

namespace ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int n1=0;
            int n2=0;
            int n3=0;

            for(int vezes = 0; vezes < 20;vezes++){
                
                if(vezes == 1){
                    n1++;
                }
                    Console.WriteLine(n1);
                    n2 = n1;
                    n1 = n2 + n3;
                    n3 = n2;
             }
        }
    }
}
// n2 é igual a n1  &&  n3 é igual a n2  que é igual a n1