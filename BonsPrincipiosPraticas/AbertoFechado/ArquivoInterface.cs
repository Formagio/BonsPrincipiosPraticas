using System.Collections.Generic;

namespace BonsPrincipiosPraticas.AbertoFechado.ArquivoInterface
{
    public interface IGeradorDeArquivo
    {
        void GerarArquivo();
    }

    public class ArquivoExcel : IGeradorDeArquivo
    {
        public void GerarArquivo()
        {
        }
    }

    public class ArquivoPdf : IGeradorDeArquivo
    {
        public void GerarArquivo()
        {
        }
    }

    public class GeradorDeArquivos
    {
        public void GerarArquivos(List<IGeradorDeArquivo> geradoresDeArquivo)
        {
            foreach (var geradorDeArquivo in geradoresDeArquivo)
            {
                geradorDeArquivo.GerarArquivo();
            }
        }
    }
}