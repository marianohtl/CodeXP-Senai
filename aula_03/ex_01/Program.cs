using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            float alt = 0f;
            float media = 0f;
            for(int cont=1; cont <= 15; cont++){
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();
                Console.WriteLine("Qual é a sua altura?");
                alt = float.Parse(Console.ReadLine());
                media = media + alt;          
            }
            media = media/15f;
            Console.WriteLine(media);
        }
    }
}
