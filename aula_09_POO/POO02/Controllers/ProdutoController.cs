using System;
using System.IO;
using POO02.models;

namespace POO02.Controllers
{
    public class ProdutoController
    {

        ProdutoModel produto = new ProdutoModel();
       public void CadastrarProdutos(){
            try{
                Console.WriteLine("Digite um código:");
                produto.IdProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome do Produto:");
                produto.NomeProduto = Console.ReadLine();
            
                Console.WriteLine("Digite a Descrição do Produto:");
                produto.Descricao = Console.ReadLine();

                Console.WriteLine("Digite o Preço do Produto:");
                produto.Preco = double.Parse(Console.ReadLine());
                
                // Console.WriteLine("Digite o ID do Fornecedor:");
                // produto.fornecedor.IdFornecedor = int.Parse(Console.ReadLine());
        
                // Console.WriteLine("Digite o Nome do Fornecedor:");
                // produto.fornecedor.NomeFornecedor = Console.ReadLine();            
            }catch(Exception ex){
                Console.WriteLine("Desculpe! :( Houve um erro na aplicação.");
                SalvarErros(ex);            
            }
       }

       public void ExibirProduto(){
           Console.WriteLine(produto.IdProduto);
           Console.WriteLine(produto.NomeProduto);
           Console.WriteLine(produto.Preco);

        //    Console.WriteLine(produto.fornecedor.IdFornecedor);
        //    Console.WriteLine(produto.fornecedor.NomeFornecedor);
       }

       private void SalvarErros(Exception ex){
            StreamWriter txt = new StreamWriter("error_log.txt",true);
            txt.WriteLine("============================================");
            txt.WriteLine();
            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();
            txt.WriteLine("============================================");
            txt.Close();
       }

    }
}