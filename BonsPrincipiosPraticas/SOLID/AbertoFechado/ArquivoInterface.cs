using System.Collections.Generic;

namespace BonsPrincipiosPraticas.Solid.AbertoFechado.ArquivoInterface
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
            foreach (IGeradorDeArquivo geradorDeArquivo in geradoresDeArquivo)
            {
                geradorDeArquivo.GerarArquivo();
            }
        }
    }
}