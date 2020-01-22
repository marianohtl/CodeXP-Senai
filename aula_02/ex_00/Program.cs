using System;

namespace aula_02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //definindo as variáveis que utilizaremos para fazer o cálculo
            float nota1, nota2, nota3, media;
            Console.WriteLine("Digite sua primeira nota:");
            nota1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite sua segunda nota:");
            nota2 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite sua terceira nota:");
            nota3 = float.Parse(Console.ReadLine());
           
            media = (nota1 + nota2 + nota3)/3f;
            
           if(media >=6){
            Console.WriteLine($"Média:{media}, Aluno aprovado.");
           }
           else if (media < 6 && media >= 4){
               Console.WriteLine($"Média:{media}, Aluno de recuperação.");
           } else{
               Console.WriteLine($"Média:{media}, Aluno reprovado.");
           }

        }
    }
}
