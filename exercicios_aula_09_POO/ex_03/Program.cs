using System;
using ex_03.Controller;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoControllers produto01 = new ProdutoControllers();
        
             produto01.CadastrarProduto();

             produto01.ReservarProduto();

             produto01.ExibirProduto();
        }
    }
}
