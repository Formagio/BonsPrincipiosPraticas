namespace BonsPrincipiosPraticas.InversaoDeDependencia.SemViolacao
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
            var dados = unidadeExterna.LerDados();
            unidadeInterna.GravarDados(dados);
        }
    }

    public class Pendrive : IUnidadeExterna
    {
        public byte[] LerDados()
        {
            // Realiza a leitura dos dados do pendrive
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
