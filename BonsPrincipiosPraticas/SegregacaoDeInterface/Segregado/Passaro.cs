namespace BonsPrincipiosPraticas.SegregacaoDeInterface.Segregado
{
    public interface IPassaro
    {
    }

    public interface ICantor
    {
        void Cantar();
    }

    public interface IVoador
    {
        void Voar();
    }

    public class BeijaFlor : IPassaro, ICantor, IVoador
    {
        public void Cantar()
        {
            // Reproduz o canto do beija-flor
        }

        public void Voar()
        {
            // Realiza vôo como um beija-flor
        }
    }

    public class Avestruz : IPassaro, ICantor
    {
        public void Cantar()
        {
            // Reproduz o canto da avestruz
        }
    }
}
