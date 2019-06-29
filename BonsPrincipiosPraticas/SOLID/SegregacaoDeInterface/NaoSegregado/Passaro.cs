namespace BonsPrincipiosPraticas.Solid.SegregacaoDeInterface.NaoSegregado
{
    public interface IPassaro
    {
        void Cantar();
        void Voar();
    }

    public class BeijaFlor : IPassaro
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

    public class Avestruz : IPassaro
    {
        public void Cantar()
        {
            // Reproduz o canto da avestruz
        }

        public void Voar()
        {
            // Não faz nada pois avestruz não sabe voar
        }
    }
}
