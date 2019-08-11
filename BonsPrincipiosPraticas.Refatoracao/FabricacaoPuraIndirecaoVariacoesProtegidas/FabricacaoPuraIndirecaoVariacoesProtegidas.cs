using System;

namespace BonsPrincipiosPraticas.Refatoracao.FabricacaoPuraIndirecaoVariacoesProtegidas
{
    public class CalcSnippet
    {
        public int AccountId { get; set; }
    }

    public interface IBudgetCalcConsumer
    {
        void ConsumeCalcStatus(CalcSnippet calcSnippet);
    }

    public interface IAccountMongoApplicationContext
    {
    }

    public interface ICalculationService
    {
        void UpdateCalc(CalcSnippet calcSnippet);
    }

    public interface IDependencyResolver : IDisposable
    {
        IDependencyResolver BeginLifetimeScope<T>(params object[] parameters);

        T Resolve<T>();
    }

    public class BudgetCalcConsumer : IBudgetCalcConsumer
    {
        private readonly IDependencyResolver dependencyResolver;

        public BudgetCalcConsumer(IDependencyResolver dependencyResolver)
        {
            this.dependencyResolver = dependencyResolver;
        }

        public void ConsumeCalcStatus(CalcSnippet calcSnippet)
        {
            using (IDependencyResolver dr = dependencyResolver.BeginLifetimeScope<IAccountMongoApplicationContext>(calcSnippet.AccountId))
            {
                dr.Resolve<ICalculationService>().UpdateCalc(calcSnippet);
            }
        }
    }
}
