using POO02.Models;

namespace POO02.models
{
    public class ProdutoModel
    {
         // get - set / propriedade para podermos manipular produtos fora dessa classe
        public int IdProduto{get;set;}

        //atributo
        public string NomeProduto{get;set;}

        public string Descricao{get;set;}

        public double Preco{get;set;}

        public FornecedoresModel fornecedor{get;set;}
    }
}