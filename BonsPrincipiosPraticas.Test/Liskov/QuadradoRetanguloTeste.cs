using BonsPrincipiosPraticas.Solid.Liskov.QuadradoRetangulo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BonsPrincipiosPraticas.Solid.Liskov.Test
{
    [TestClass]
    public class QuadradoRetanguloTeste
    {
        [TestMethod]
        public void RetanguloTeste()
        {
            var r1 = new Retangulo
            {
                Altura = 4,
                Largura = 5
            };

            var r2 = new Retangulo
            {
                Largura = 5,
                Altura = 4
            };

            Assert.IsTrue(r1.Altura == r2.Altura && r1.Largura == r2.Largura);
        }

        [TestMethod]
        public void QuadradoTeste()
        {
            var r1 = new Quadrado
            {
                Altura = 4,
                Largura = 5
            };

            var r2 = new Quadrado
            {
                Largura = 5,
                Altura = 4
            };

            Assert.IsTrue(r1.Altura == r2.Altura && r1.Largura == r2.Largura);
        }
    }
}
