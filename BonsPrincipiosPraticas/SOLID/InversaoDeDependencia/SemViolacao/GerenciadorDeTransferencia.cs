﻿namespace BonsPrincipiosPraticas.Solid.InversaoDeDependencia.SemViolacao
{
    public interface IGerenciadorDeTransferencia
    {
        void Transferir(IUnidadeExterna unidadeExterna, IUnidadeInterna unidadeInterna);
    }

    public interface IUnidadeInterna
    {
        void GravarDados(byte[] dados);
    }

    public interface IUnidadeExterna
    {
        byte[] LerDados();
    }

    public class GerenciadorDeTransferencia : IGerenciadorDeTransferencia
    {
        public void Transferir(IUnidadeExterna unidadeExterna, IUnidadeInterna unidadeInterna)
        {
            byte[] dados = unidadeExterna.LerDados();
            unidadeInterna.GravarDados(dados);
        }
    }

    public class Pendrive : IUnidadeExterna
    {
        public byte[] LerDados()
        {
            // Realiza a leitura dos dados do pendrive
            return new byte[0];
        }
    }

    public class DiscoRigido : IUnidadeInterna
    {
        public void GravarDados(byte[] dados)
        {
            // Realiza a gravação dos dados no disco rígido
        }
    }
}
