using System;
using System.Collections.Generic;
using listas.Models;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos nossa classe com o método construtor passando os parâmetros
            ProdutoModel produto = new ProdutoModel(1,"Batata", "Amarela", 3.5);
            //chamamos um atributo do objeto instanciado
            Console.WriteLine(produto.NomeProduto);     

            //Instanciamos nossa classe 
            //Sem passar parâmetros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();

            //Alimentamos nosso objeto que estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Banana";
            produto_sobrecarga.Descricao = "Amarela";
            produto_sobrecarga.Preco = 5.50;

            Console.WriteLine(produto_sobrecarga);     


            //Chamamos a nossa lista que vai ser do Objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            //Adicionamos objetos instanciados e atribuímos em nossa lista
            prod.Add(new ProdutoModel(1, "Abacaxi", "Marron",2.30));
            prod.Add(new ProdutoModel(2, "Mexirica", "Marron",3.30));
            prod.Add(new ProdutoModel(3, "Pastel", "Marron",4.30));
            prod.Add(new ProdutoModel(4, "Água de Coco", "Marron",5.30));
            prod.Add(new ProdutoModel(5, "Morango", "Marron",6.30));
            prod.Add(new ProdutoModel(6, "Mojang", "Marron",7.30));
        
            // Lemos os dados do nosso da nossa lista 
            foreach (ProdutoModel p in prod){
                Console.WriteLine(p.IdProduto);        
                Console.WriteLine(p.NomeProduto);        
                Console.WriteLine(p.Descricao);        
                Console.WriteLine(p.Preco);      
                Console.WriteLine();      
                  
            }

            Console.WriteLine(prod[4].NomeProduto);     
        }
    }
}
