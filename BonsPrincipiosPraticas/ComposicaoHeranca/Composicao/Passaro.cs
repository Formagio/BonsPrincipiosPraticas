namespace BonsPrincipiosPraticas.ComposicaoHeranca.Composicao
{
    public abstract class Passaro
    {
        private IComportamentoDeBotarOvo comportamentoDeBotarOvo;
        private IComportamentoDeVoo comportamentoDeVoo;

        public void DefinirComportamentoDeBotarOvo(IComportamentoDeBotarOvo comportamentoDeBotarOvo)
        {
            this.comportamentoDeBotarOvo = comportamentoDeBotarOvo;
        }

        public void DefinirComportamentoDeVoo(IComportamentoDeVoo comportamentoDeVoo)
        {
            this.comportamentoDeVoo = comportamentoDeVoo;
        }

        public void BotarOvo()
        {
            // Dispara comportamento de botar ovo
            comportamentoDeBotarOvo.BotarOvo();
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

    public interface IComportamentoDeBotarOvo
    {
        void BotarOvo();
    }

    public interface IComportamentoDeVoo
    {
        void Voar();
    }

    public class ComportamentoDePassaroQueBotaOvo : IComportamentoDeBotarOvo
    {
        public void BotarOvo()
        {
            // Faz o pássaro botar um ovo
        }
    }

    public class ComportamentoDePassaroQueNaoBotaOvo : IComportamentoDeBotarOvo
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

            DefinirComportamentoDeBotarOvo(comportamentoDePassaroQueBotaOvo);
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

            DefinirComportamentoDeBotarOvo(comportamentoDePassaroQueBotaOvo);
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

            DefinirComportamentoDeBotarOvo(comportamentoDePassaroQueNaoBotaOvo);
            DefinirComportamentoDeVoo(comportamentoDePassaroQueNaoVoa);
        }

        public override void Exibir()
        {
            // Exibe a imagem de um relógio tipo cuco
        }
    }
}
