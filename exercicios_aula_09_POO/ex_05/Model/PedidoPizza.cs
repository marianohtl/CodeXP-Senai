namespace ex_05.Model
{
    public class PedidoPizza : PizzaModel
    {
        public string DataPedido { get; set; }
        public string EnderecoDeEntrega { get; set; }
        public string PrevisaoEntrega { get; set; }
    }
}