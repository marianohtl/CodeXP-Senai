using System;
using exercicios_aula_08.Controllers;

namespace exercicios_aula_08
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoaController pessoa01 = new PessoaController();

            pessoa01.CadastrarPessoa();
            pessoa01.CalcularIMC();

        }
    }
}
