namespace BonsPrincipiosPraticas.ComposicaoHeranca.Composicao
{
    public abstract class Passaro
    {
        private IComportamentoDeOvo comportamentoDeOvo;
        private IComportamentoDeVoo comportamentoDeVoo;

        public void DefinirComportamentoDeOvo(IComportamentoDeOvo comportamentoDeOvo)
        {
            this.comportamentoDeOvo = comportamentoDeOvo;
        }

        public void DefinirComportamentoDeVoo(IComportamentoDeVoo comportamentoDeVoo)
        {
            this.comportamentoDeVoo = comportamentoDeVoo;
        }

        public void BotarOvo()
        {
            // Dispara comportamento de botar ovo
            comportamentoDeOvo.BotarOvo();
        }

        public void Cantar()
        {
            // Faz o pássaro cantar
        }

        public void Voar()
        {
            // Dispara comportamento de voar
            comportamentoDeVoo.Voar();
        }

        public abstract void Exibir();        
    }

    public interface IComportamentoDeOvo
    {
        void BotarOvo();
    }

    public interface IComportamentoDeVoo
    {
        void Voar();
    }

    public class ComportamentoDePassaroQueBotaOvo : IComportamentoDeOvo
    {
        public void BotarOvo()
        {
            // Faz o pássaro botar um ovo
        }
    }

    public class ComportamentoDePassaroQueNaoBotaOvo : IComportamentoDeOvo
    {
        public void BotarOvo()
        {
            // Não faz nada pois o pássaro não bota ovo
        }
    }

    public class ComportamentoDePassaroQueVoa : IComportamentoDeVoo
    {
        public void Voar()
        {
            // Faz o pássaro voar
        }
    }

    public class ComportamentoDePassaroQueNaoVoa : IComportamentoDeVoo
    {
        public void Voar()
        {
            // Não faz nada pois o pássaro não voa
        }
    }

    public class BeijaFlor : Passaro
    {
        public BeijaFlor()
        {
            var comportamentoDePassaroQueBotaOvo = new ComportamentoDePassaroQueBotaOvo();
            var comportamentoDePassaroQueVoa = new ComportamentoDePassaroQueVoa();

            DefinirComportamentoDeOvo(comportamentoDePassaroQueBotaOvo);
            DefinirComportamentoDeVoo(comportamentoDePassaroQueVoa);
        }

        public override void Exibir()
        {
            // Exibe a imagem de um beija-flor
        }
    }

    public class Kiwi : Passaro
    {
        public Kiwi()
        {
            var comportamentoDePassaroQueBotaOvo = new ComportamentoDePassaroQueBotaOvo();
            var comportamentoDePassaroQueNaoVoa = new ComportamentoDePassaroQueNaoVoa();

            DefinirComportamentoDeOvo(comportamentoDePassaroQueBotaOvo);
            DefinirComportamentoDeVoo(comportamentoDePassaroQueNaoVoa);
        }

        public override void Exibir()
        {
            // Exibe a imagem de um kiwi
        }
    }

    public class CucoRelogio : Passaro
    {
        public CucoRelogio()
        {
            var comportamentoDePassaroQueNaoBotaOvo = new ComportamentoDePassaroQueNaoBotaOvo();
            var comportamentoDePassaroQueNaoVoa = new ComportamentoDePassaroQueNaoVoa();

            DefinirComportamentoDeOvo(comportamentoDePassaroQueNaoBotaOvo);
            DefinirComportamentoDeVoo(comportamentoDePassaroQueNaoVoa);
        }

        public override void Exibir()
        {
            // Exibe a imagem de um relógio tipo cuco
        }
    }
}
