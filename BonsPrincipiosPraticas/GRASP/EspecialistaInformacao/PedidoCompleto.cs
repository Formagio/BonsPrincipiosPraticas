using System;
using System.Collections.Generic;
using System.Linq;

namespace BonsPrincipiosPraticas.GRASP.EspecialistaInformacao.PedidoCompleto
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

        public double CalcularValorTotal()
        {
            return itens.Sum(item => item.Quantidade * item.PrecoUnitario);
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

    class Program
    {
        static void Main(string[] args)
        {
            // Criamos a instância de pedido
            var pedido = new Pedido();

            // Criamos os produtos
            var pastelAssadoDeFrango = new Produto()
            {
                Nome = "Pastel assado de frango",
                Preco = 2.50
            };

            var pastelFritoDeCarne = new Produto()
            {
                Nome = "Pastel frito de carne",
                Preco = 1.50
            };

            // Solicitamos ao objeto a criação dos itens do pedido
            pedido.CriarNovoPedidoItem(pastelAssadoDeFrango);
            pedido.CriarNovoPedidoItem(pastelFritoDeCarne);

            // Solicitamos o cálculo do valor total
            Console.Write($"Valor total do pedido: {pedido.CalcularValorTotal()}");
        }
    }
}
