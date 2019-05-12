using System;

namespace BonsPrincipiosPraticas.GRASP.VariacoesProtegidas.MovimentacaoComVP
{
    public enum TipoMovimentacaoFinanceira
    {
        CONTA_PAGAR = 1,
        CONTA_RECEBER = 2,
        COBRANCA = 3
    }

    public interface IMovimentacaoFinanceira
    {
        void GerarMovimentacaoFinanceira(double valor);
    }

    public class ContaPagar : IMovimentacaoFinanceira
    {
        public void GerarMovimentacaoFinanceira(double valor)
        {
        }
    }

    public class ContaReceber : IMovimentacaoFinanceira
    {
        public void GerarMovimentacaoFinanceira(double valor)
        {
        }
    }

    public class Cobranca : IMovimentacaoFinanceira
    {
        public void GerarMovimentacaoFinanceira(double valor)
        {
        }
    }

    public static class MovimentacaoFinanceiraFactory
    {
        public static IMovimentacaoFinanceira CriarObjeto(TipoMovimentacaoFinanceira tipo)
        {
            switch (tipo)
            {
                case TipoMovimentacaoFinanceira.CONTA_PAGAR:
                    return new ContaPagar();
                case TipoMovimentacaoFinanceira.CONTA_RECEBER:
                    return new ContaReceber();
                case TipoMovimentacaoFinanceira.COBRANCA:
                    return new Cobranca();
                default:
                    throw new Exception("Tipo de operação financeira não implementado");
            }
        }
    }

    public class Financeiro
    {
        private void GerarMovimentacaoFinanceira(double valor, TipoMovimentacaoFinanceira tipo)
        {
            MovimentacaoFinanceiraFactory.CriarObjeto(tipo).GerarMovimentacaoFinanceira(valor);
        }
    }
}
