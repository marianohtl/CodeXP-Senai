using System;
using ex_01.Controller;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosController  aluno01= new AlunosController();
           aluno01.CadastrarAluno();
           aluno01.EscreverInformacoes();

        }
    }
}
