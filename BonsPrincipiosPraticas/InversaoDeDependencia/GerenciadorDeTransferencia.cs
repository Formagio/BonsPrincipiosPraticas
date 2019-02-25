namespace BonsPrincipiosPraticas.InversaoDeDependencia
{
    public class GerenciadorDeTransferencia
    {
        public void Transferir(DispositivoInterno interno, DispositivoExterno externo)
        {
            var dados = interno.LerDados();
            externo.GravarDados(dados);
        }
    }

    public class DispositivoInterno
    {
        public byte[] LerDados()
        {
            // Realiza a leitura dos dados do dispositivo interno
        }
    }

    public class DispositivoExterno
    {
        public void GravarDados(byte[] dados)
        {
            // Realiza a gravação dos dados no dispositivo externo
        }
    }
}
