namespace BonsPrincipiosPraticas.ComposicaoHeranca.Heranca.Interface
{
    public abstract class Passaro
    {
        public abstract void Exibir();
    }

    public interface IPassaroCantor
    {
        void Cantar();
    }

    public interface IPassaroOviparo
    {
        void BotarOvo();
    }

    public interface IPassaroVoador
    {
        void Voar();
    }

    public class BeijaFlor : Passaro, IPassaroCantor, IPassaroOviparo, IPassaroVoador
    {
        public void BotarOvo()
        {
            // Faz o pássaro botar um ovo
        }

        public void Cantar()
        {
            // Faz o pássaro cantar
        }

        public override void Exibir()
        {
            // Exibe a imagem de um beija-flor
        }

        public void Voar()
        {
            // Faz o pássaro voar
        }
    }

    public class Kiwi : Passaro, IPassaroCantor, IPassaroOviparo
    {
        public void BotarOvo()
        {
            // Faz o pássaro botar um ovo
        }

        public void Cantar()
        {
            // Faz o pássaro
        }

        public override void Exibir()
        {
            // Exibe a imagem de um kiwi
        }
    }

    public class CucoRelogio : Passaro, IPassaroCantor
    {
        public void Cantar()
        {
            // Faz o pássaro cantar
        }

        public override void Exibir()
        {
            // Exibe a imagem de um relógio tipo cuco
        }
    }
}
