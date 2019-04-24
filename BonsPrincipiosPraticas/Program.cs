using BonsPrincipiosPraticas.GRASP.Criador.PedidoSemCriador;

namespace BonsPrincipiosPraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos a instancia de pedido
            Pedido pedido = new Pedido();

            //Criamos um produto
            Produto produto = new Produto()
            {
                Nome = "Fatia de Pizza",
                Preco = 3.50
            };            

            //Criamos o pedido item, violando o encapsulamento
            PedidoItem pedidoItem = new PedidoItem(produto);

            //E ficamos sabendo a implementacao interna do objeto pedido
            pedido.getItens().add(pedidoItem);
        }
    }
}
