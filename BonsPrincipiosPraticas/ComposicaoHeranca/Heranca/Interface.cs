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
            // Exibe ovo do beija-flor
        }

        public void Cantar()
        {
            // Reproduz o canto do beija-flor
        }

        public override void Exibir()
        {
            // Exibe a imagem de um beija-flor
        }

        public void Voar()
        {
            // Exibe o voo do beija-flor
        }
    }

    public class Kiwi : Passaro, IPassaroCantor, IPassaroOviparo
    {
        public void BotarOvo()
        {
            // Exibe ovo do kiwi
        }

        public void Cantar()
        {
            // Reproduz o canto do kiwi
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
            // Reproduz o som do relógio cuco
        }

        public override void Exibir()
        {
            // Exibe a imagem de um relógio tipo cuco
        }
    }
}
