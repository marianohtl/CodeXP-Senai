using System;

namespace ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            for(int cont =1; cont < n; cont++){
                
                if(cont%5 == 0){
                    Console.WriteLine(cont);
                }
            }
    }
}
}