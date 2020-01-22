using System;
using ex_03.Model;

namespace ex_03.Controller
{
    public class ProdutoControllers
    {
        ProdutoModel produto = new ProdutoModel();

        public void CadastrarProduto(){
                 try{
                    Console.WriteLine("Digite o nome do produto:");
                    produto.Nome = Console.ReadLine();

                    Console.WriteLine("Digite a cor do produto:");
                    produto.Cor = Console.ReadLine();

                    Console.WriteLine("Digite a marca do produto:");
                    produto.Marca = Console.ReadLine();

                    Console.WriteLine("Digite a quantidade do produto:");
                    produto.Qntd = int.Parse(Console.ReadLine());

            }catch(Exception ex){
              Console.WriteLine("Desculpe, houve uma falha no sistema :/  "+ex);
            }
        }

        public void ReservarProduto(){
        try{
            Console.WriteLine("Deseja reservar este produto? S/N");            
            string resp = Console.ReadLine().ToUpper();
  
            if(resp == "S"){
                produto.reservado = true;
                Console.WriteLine("Produto reservado com sucesso.");
            }else{
                produto.reservado = false;

            }

            }catch(Exception ex){
              Console.WriteLine("Desculpe, houve uma falha no sistema :/  "+ex);
            }
        }

           public void ExibirProduto(){
                    Console.WriteLine($"Nome: {produto.Nome}");
                    Console.WriteLine( $"Cor: {produto.Cor}");
                    Console.WriteLine($"Marca: {produto.Marca}");
                    Console.WriteLine($"Quantidade: {produto.Qntd}");
                    Console.WriteLine($"Reservado: {produto.reservado}");
        }  
        }
}