namespace BonsPrincipiosPraticas.Solid.Liskov.QuadradoRetangulo
{
    public class Retangulo
    {
        public virtual int Altura { get; set; }
        public virtual int Largura { get; set; }

        public int CalcularArea()
        {
            return Altura * Largura;
        }
    }

    public class Quadrado : Retangulo
    {
        public override int Altura
        {
            get { return base.Altura; }
            set { base.Altura = base.Largura = value; }
        }

        public override int Largura
        {
            get { return base.Largura; }
            set { base.Largura = base.Altura = value; }
        }
    }

    public class Classe
    {
        public void MetodoQualquer(Retangulo retangulo)
        {
            retangulo.Altura = retangulo.Altura * 2;
            retangulo.Largura = retangulo.Largura * 4;

            int area = retangulo.CalcularArea();
            // Alguma operação com a área
        }
    }
}
