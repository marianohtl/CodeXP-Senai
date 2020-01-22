using System;
using POO02.Controllers;

namespace POO02
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto01 = new ProdutoController();
            produto01.CadastrarProdutos();
            produto01.ExibirProduto();
        
           }
    }
}
