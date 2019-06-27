using System.Collections.Generic;

namespace BonsPrincipiosPraticas.GRASP.Criador.PedidoSemCriador
{
    public class Pedido
    {
        public List<PedidoItem> Itens { get; private set; }

        public Pedido()
        {
            Itens = new List<PedidoItem>();
        }
    }

    public class PedidoItem
    {
        private readonly string nome;
        private readonly double precoUnitario;
        private readonly int quantidade;

        public PedidoItem(Produto produto)
        {
            nome = produto.Nome;
            precoUnitario = produto.Preco;
            quantidade = 1;
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criação da instância de pedido
            var pedido = new Pedido();

            // Criação de um produto
            var produto = new Produto()
            {
                Nome = "Pastel assado de frango",
                Preco = 2.50
            };

            // Criação do pedido item, violando o encapsulamento
            var pedidoItem = new PedidoItem(produto);            

            // É exposta a implementação interna do objeto pedido
            pedido.Itens.Add(pedidoItem);
        }
    }
}
