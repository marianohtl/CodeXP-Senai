using System;

namespace aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
       //declarando uma variável sem atribuir valor
       int num1;
       //declarando variável com atribuição de valor
       int num2 = 5;
       int num5 = 7;
       //declarando várias variáveis com o mesmo valor / tipo
       int num3, num4 = 60;
       
       //declarando várias variáveis com o mesmo valor / tipo
       int  num6 , num7 , num8;
       //variável do tipo decimal/real
       float media;
       
       // variável do tipo lógico
       bool resultado = false;

       // declarando uma string
        string nomeAlunos;

        //PULA LINHA
        Console.WriteLine();

        // Escreve na mesma linha 
        Console.Write("");

        Console.WriteLine("Bem vindos a nossa primeira aplicação!");
        Console.WriteLine("Digite seu nome: ");
        // Armazenando na variável o dado digitado pelo usuário
        nomeAlunos = Console.ReadLine();
        // Concatenação
        Console.WriteLine(nomeAlunos + ", agora digite sua primeira nota: ");
        
        //Convertendo o texto em inteiro
        num6 = int.Parse(Console.ReadLine());

        //interpolação 
        Console.WriteLine($"Sua primeira nota é {num6}");

        Console.WriteLine($"Digite sua segunda nota: ");
        num7 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite sua terceira nota: ");
        num8 = int.Parse(Console.ReadLine());

        media = (num6 + num7 + num8) /3;
        Console.WriteLine($"Sua média é "+ media);
        }
    }
}
