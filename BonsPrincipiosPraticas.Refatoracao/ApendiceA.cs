namespace BonsPrincipiosPraticas.Refatoracao.ApendiceA
{
    public class BudgetProduct
    {
    }

    public interface IProductContextGenerator
    {
        void GenerateContext(BudgetProduct budgetProduct);
    }

    public class ProductContextGenerator : IProductContextGenerator
    {
        public void GenerateContext(BudgetProduct budgetProduct)
        {
            // Geração do contexto do produto
        }

        // Demais métodos que dão suporte à geração do contexto
    }

    public class ProductService
    {
        private readonly IProductContextGenerator productContextGenerator;

        public ProductService(IProductContextGenerator productContextGenerator)
        {
            // Princípio da inversão de dependência: depender de uma abstração
            // e não de uma classe concreta.
            this.productContextGenerator = productContextGenerator;
        }

        public void GenerateContext(BudgetProduct budgetProduct)
        {
            // Delega a geração do contexto para uma classe especializada,
            // permitindo que a classe ProductService tenha mais coesão e menor acoplamento,
            // melhorando a manutenção.
            productContextGenerator.GenerateContext(budgetProduct);
        }
    }
}
