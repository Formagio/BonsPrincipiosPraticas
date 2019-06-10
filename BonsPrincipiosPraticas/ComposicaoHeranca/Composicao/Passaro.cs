namespace BonsPrincipiosPraticas.ComposicaoHeranca.Composicao
{
    public abstract class Passaro
    {
        protected IComportamentoDeVoo comportamentoDeVoo;

        public void Cantar()
        {
            // Faz o pássaro cantar
        }

        public void DefinirComportamentoDeVoo(IComportamentoDeVoo comportamentoDeVoo)
        {
            this.comportamentoDeVoo = comportamentoDeVoo;
        }

        public abstract void Exibir();        
    }

    public interface IComportamentoDeVoo
    {
        void RealizarVoo();
    }

    public class ComportamentoDePassaroQueVoa : IComportamentoDeVoo
    {
        public void RealizarVoo()
        {
            // Faz o pássaro voar
        }
    }

    public class ComportamentoDePassaroQueNaoVoa : IComportamentoDeVoo
    {
        public void RealizarVoo()
        {
            // Não faz nada pois o pássaro não voa
        }
    }

    public class BeijaFlor : Passaro
    {
        public override void Exibir()
        {
            // Exibe a imagem de um beija-flor
        }
    }
}
