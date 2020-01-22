using System;

namespace correcao
{
    class Program
    {
        static void Main(string[] args)
        {
            //laço condicional composto
            double nota = 0;
            int cont = 0;
            double acl = 0;
            string sair = "";
            // int alunos = 10;

            //tornando nota double em string para tornar possível a comparação
            while(sair != "sair"){
                Console.WriteLine("Digite a nota de um aluno: ");
                nota = double.Parse(Console.ReadLine());
                acl +=nota;
                cont++;
                Console.WriteLine("Pede para sair:");
                sair = Console.ReadLine().ToLower();
             
              
             }
            Console.WriteLine($"Média das notas: {acl /cont}");
        }
    }
}
