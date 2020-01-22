using System;

namespace ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int acl = 0;
            int idade = 0;
           for(int cont=0; cont <=10; cont++){
               Console.WriteLine("Qual a sua idade?");
               idade = int.Parse(Console.ReadLine());
               if(idade > 50){
                   acl = acl + 1;
               }
           }
           Console.WriteLine($"Temos {acl} pessoas com mais de 50 anos.");
        }
    }
}
