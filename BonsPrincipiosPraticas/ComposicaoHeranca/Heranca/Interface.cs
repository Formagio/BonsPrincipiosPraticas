namespace BonsPrincipiosPraticas.ComposicaoHeranca.Heranca.Interface
{
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

    public class BeijaFlor : IPassaroCantor, IPassaroOviparo, IPassaroVoador
    {
        public void BotarOvo()
        {
            // Exibe ovo do beija-flor
        }

        public void Cantar()
        {
            // Reproduz o canto do beija-flor
        }

        public void Voar()
        {
            // Exibe o voo do beija-flor
        }
    }

    public class Kiwi : IPassaroCantor, IPassaroOviparo
    {
        public void BotarOvo()
        {
            // Exibe ovo do kiwi
        }

        public void Cantar()
        {
            // Reproduz o canto do kiwi
        }
    }

    public class CucoRelogio : IPassaroCantor
    {
        public void Cantar()
        {
            // Reproduz o som do relógio cuco
        }
    }
}
