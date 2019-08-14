using System.Collections.Generic;

namespace BonsPrincipiosPraticas.GRASP.EspecialistaInformacao.PedidoIncompleto
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
        public string Nome { get; private set; }
        public double PrecoUnitario { get; private set; }
        public int Quantidade { get; private set; }

        public PedidoItem(Produto produto)
        {
            Nome = produto.Nome;
            PrecoUnitario = produto.Preco;
            Quantidade = 1;
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
