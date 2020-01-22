namespace listas.Models
{
    public class ProdutoModel
    {          
      
        public int IdProduto{get;set;}
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        
        // Sobrecarga
        // Utilizamos sobrecarga para poder instanciar
        // Passando ou não os atributos/parâmetros/argumentos
        public ProdutoModel() {
        }
        public ProdutoModel(int IdProduto, string nomeproduto, string descricao, double preco){
            this.IdProduto = IdProduto;
            this.NomeProduto = nomeproduto;
            this.Descricao = descricao;
            this.Preco = preco;
        }
    }

}