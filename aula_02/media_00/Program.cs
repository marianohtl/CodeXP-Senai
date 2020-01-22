using System;

namespace media_00
{
    class Program
    {
        static void Main(string[] args)
        {
             //grandes espaçamentos para números reais _ Declarando Notas Atribuídas
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite sua primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota:");
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3)/3;

            //utiizando estruturas de repetição 

            if (media >= 6){
            Console.WriteLine($"Média:{media} - Aluno aprovado!");
            }else{
            Console.WriteLine($"Média:{media} - Aluno reprovado!");
            }

        }
    }
}
