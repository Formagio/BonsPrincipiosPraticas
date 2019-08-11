namespace BonsPrincipiosPraticas.Refatoracao.ResponsabilidadeUnicaAltaCoesaoBaixoAcoplamento
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
}
