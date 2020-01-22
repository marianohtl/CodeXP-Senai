using System;

namespace ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int vezes = 0;
            int n1=0;
            int n2=0;
            int n3=0;

            while(vezes < 20){
                
                if(vezes == 1){
                    n1++;
                }
                    Console.WriteLine(n1);
                    n2 = n1;
                    n1 = n2 + n3;
                    n3 = n2; 
                    vezes++;                   
             }
        }
    }
}


// >          n2      n1         n3

// 1º >       0        0         0
// >> 0


// 2º >       0        1         0
// >> 1


// 3º >       1        1        1
// >>  1


// 4º >       1        2        1
// >>  2


// 5º >       2        3        2
// >>  3


// 6º >       3        5        3
// >>  5


// 7º >       5        8        5
// >>  8


// n2 = n1;
// n1 = n2 + n3;
// n3 = n2; 
