namespace BonsPrincipiosPraticas.GRASP.VariacoesProtegidas.MovimentacaoSemVP
{
    public enum TipoMovimentacaoFinanceira
    {
        CONTA_PAGAR = 1,
        CONTA_RECEBER = 2,
        COBRANCA = 3
    }

    public class ContaPagar
    {
        public void GerarContaPagar(double valor)
        {
        }
    }

    public class ContaReceber
    {
        public void GerarContaReceber(double valor)
        {
        }
    }

    public class Cobranca
    {
        public void GerarCobranca(double valor)
        {
        }
    }

    public class Financeiro
    {
        private void GerarMovimentacaoFinanceira(double valor, TipoMovimentacaoFinanceira tipo)
        {
            switch (tipo)
            {
                case TipoMovimentacaoFinanceira.CONTA_PAGAR:
                    new ContaPagar().GerarContaPagar(valor);
                    break;
                case TipoMovimentacaoFinanceira.CONTA_RECEBER:
                    new ContaReceber().GerarContaReceber(valor);
                    break;
                case TipoMovimentacaoFinanceira.COBRANCA:
                    new Cobranca().GerarCobranca(valor);
                    break;
            }
        }
    }
}
