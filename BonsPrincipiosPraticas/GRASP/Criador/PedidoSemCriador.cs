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
            // Criamos a instância de pedido
            var pedido = new Pedido();

            // Criamos um produto
            var produto = new Produto()
            {
                Nome = "Pastel assado de frango",
                Preco = 2.50
            };

            // Criamos o pedido item, violando o encapsulamento
            var pedidoItem = new PedidoItem(produto);            

            // E ficamos sabendo a implementação interna do objeto pedido
            pedido.Itens.Add(pedidoItem);
        }
    }
}
