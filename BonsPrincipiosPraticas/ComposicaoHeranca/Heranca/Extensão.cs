namespace BonsPrincipiosPraticas.ComposicaoHeranca.Heranca.Extensao
{
    public abstract class Passaro
    {
        public virtual void BotarOvo()
        {
            // Faz o pássaro botar um ovo
        }

        public virtual void Cantar()
        {
            // Faz o pássaro cantar
        }

        public virtual void Voar()
        {
            // Faz o pássaro voar
        }

        public abstract void Exibir();
    }

    public class BeijaFlor : Passaro
    {
        public override void Exibir()
        {
            // Exibe a imagem de um beija-flor
        }
    }

    public class Kiwi : Passaro
    {
        public override void Exibir()
        {
            // Exibe a imagem de um kiwi
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
            // Não faz nada, pois o cuco do relógio tipo cuco não bota ovo
        }

        public override void Exibir()
        {
            // Exibe a imagem de um relógio tipo cuco
        }

        public override void Voar()
        {
            // Não faz nada, pois o cuco do relógio tipo cuco não voa
        }
    }
}
