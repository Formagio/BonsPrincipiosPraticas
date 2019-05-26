namespace BonsPrincipiosPraticas.ComposicaoHeranca.Heranca.Extensao
{
    public abstract class Passaro
    {
        public abstract void BotarOvo();

        public abstract void Cantar();

        public abstract void Voar();        
    }

    public class BeijaFlor : Passaro
    {
        public override void BotarOvo()
        {
            // Exibe ovo do beija-flor
        }

        public override void Cantar()
        {
            // Reproduz o canto do beija-flor
        }

        public override void Voar()
        {
            // Exibe o voo do beija-flor
        }
    }

    public class Kiwi : Passaro
    {
        public override void BotarOvo()
        {
            // Exibe ovo do kiwi
        }

        public override void Cantar()
        {
            // Reproduz o canto do kiwi
        }

        public override void Voar()
        {
            // Não faz nada, pois o kiwi não voa
        }
    }

    public class CucoRelogio : Passaro
    {
        public override void BotarOvo()
        {
            // Não faz nada, pois o cuco de relógio não bota ovo
        }

        public override void Cantar()
        {
            // Reproduz o som do relógio cuco
        }

        public override void Voar()
        {
            // Não faz nada, pois o cuco do relógio não voa
        }
    }
}
