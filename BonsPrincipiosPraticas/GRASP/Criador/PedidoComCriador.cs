using System.Collections.Generic;

namespace BonsPrincipiosPraticas.GRASP.Criador.PedidoComCriador
{
    public class Pedido
    {
        private readonly List<PedidoItem> itens;

        public Pedido()
        {
            itens = new List<PedidoItem>();
        }

        public void CriarNovoPedidoItem(Produto produto)
        {
            itens.Add(new PedidoItem(produto));
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

            // Solicitamos ao objeto a criação de um novo pedido item
            pedido.CriarNovoPedidoItem(produto);
        }
    }
}
