﻿namespace BonsPrincipiosPraticas.InversaoDeDependencia.ComViolacao
{
    public class GerenciadorDeTransferencia
    {
        public void Transferir(Pendrive pendrive, DiscoRigido discoRigido)
        {
            var dados = pendrive.LerDados();
            discoRigido.GravarDados(dados);
        }
    }

    public class Pendrive
    {
        public byte[] LerDados()
        {
            // Realiza a leitura dos dados do pendrive
        }
    }

    public class DiscoRigido
    {
        public void GravarDados(byte[] dados)
        {
            // Realiza a gravação dos dados no disco rígido
        }
    }
}
