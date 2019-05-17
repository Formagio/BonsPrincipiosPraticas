namespace BonsPrincipiosPraticas.Solid.SegregacaoDeInterface.Segregado
{
    public interface IPassaro
    {
    }

    public interface IPassaroCantor
    {
        void Cantar();
    }

    public interface IPassaroVoador
    {
        void Voar();
    }

    public class BeijaFlor : IPassaro, IPassaroCantor, IPassaroVoador
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

    public class Avestruz : IPassaro, IPassaroCantor
    {
        public void Cantar()
        {
            // Reproduz o canto da avestruz
        }
    }
}
