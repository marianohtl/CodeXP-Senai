using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int vezes = 0;
            int n1=0;
            int n2=0;
            int n3=0;

            do{
                
                if(vezes == 1){
                    n1++;
                }
                    Console.WriteLine(n1);
                    n2 = n1;
                    n1 = n2 + n3;
                    n3 = n2; 
                    vezes++;                   
             }while(vezes < 20);
        }
    }
}
