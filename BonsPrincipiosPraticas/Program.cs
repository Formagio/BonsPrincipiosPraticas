using BonsPrincipiosPraticas.GRASP.Criador.PedidoSemCriador;

namespace BonsPrincipiosPraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void ExemploSemCriador()
        {
            // Criamos um produto
            var produto = new Produto()
            {
                Nome = "Fatia de Pizza",
                Preco = 3.50
            };

            // Criamos um pedido item
            var pedidoItem = new PedidoItem(produto);

            // Criamos a instancia de pedido
            var pedido = new Pedido();

            // E ficamos sabendo a implementacao interna do objeto pedido
            pedido.Itens.Add(pedidoItem);
        }
    }
}
