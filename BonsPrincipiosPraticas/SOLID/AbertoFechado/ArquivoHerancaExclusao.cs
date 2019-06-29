using System.Collections.Generic;

namespace BonsPrincipiosPraticas.Solid.AbertoFechado.ArquivoHerancaExclusao
{
    public abstract class Arquivo
    {
        public abstract void Apagar();
        public abstract void Gerar();
    }

    public class ArquivoExcel : Arquivo
    {
        public override void Apagar()
        {
        }

        public override void Gerar()
        {
        }
    }

    public class ArquivoPdf : Arquivo
    {
        public override void Apagar()
        {
        }

        public override void Gerar()
        {
        }
    }

    public class GeradorDeArquivos
    {
        public void GerarArquivos(List<Arquivo> arquivos)
        {
            foreach (Arquivo arquivo in arquivos)
            {
                arquivo.Gerar();
            }
        }
    }
}