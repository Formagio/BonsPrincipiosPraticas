using System.Collections.Generic;

namespace BonsPrincipiosPraticas.Solid.AbertoFechado.ArquivoHeranca
{
    public abstract class Arquivo
    {
        public abstract void Gerar();
    }

    public class ArquivoExcel : Arquivo
    {
        public override void Gerar()
        {
        }
    }

    public class ArquivoPdf : Arquivo
    {
        public override void Gerar()
        {
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