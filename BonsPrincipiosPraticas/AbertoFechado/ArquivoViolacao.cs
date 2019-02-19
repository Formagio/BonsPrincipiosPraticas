using System.Collections.Generic;

namespace BonsPrincipiosPraticas.AbertoFechado.ArquivoViolacao
{
    public class Arquivo
    {
    }

    public class ArquivoExcel : Arquivo
    {
        public void GerarPlanilha()
        {
        }
    }

    public class ArquivoPdf : Arquivo
    {
        public void GerarPdf()
        {
        }
    }

    public class GeradorDeArquivos
    {
        public void GerarArquivos(List<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                switch (arquivo)
                {
                    case ArquivoExcel arquivoExcel:
                        arquivoExcel.GerarPlanilha();
                        break;
                    case ArquivoPdf arquivoPdf:
                        arquivoPdf.GerarPdf();
                        break;
                }
            }
        }
    }
}