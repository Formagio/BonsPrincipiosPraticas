using System.Collections.Generic;

namespace BonsPrincipiosPraticas.Grasp.Polimorfismo
{
    public abstract class Arquivo
    {
        public abstract void Gerar();
    }

    public class ArquivoExcel : Arquivo
    {
        public override void Gerar()
        {
            // Gera arquivo em excel
        }
    }

    public class ArquivoPdf : Arquivo
    {
        public override void Gerar()
        {
            // Gera arquivo em pdf
        }
    }

    public class GeradorDeArquivos
    {
        public void GerarArquivos(List<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                arquivo.Gerar();
            }
        }
    }
}