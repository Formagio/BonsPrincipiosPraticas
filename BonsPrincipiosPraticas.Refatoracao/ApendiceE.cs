using BonsPrincipiosPraticas.Refatoracao.ApendiceD;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BonsPrincipiosPraticas.Refatoracao.ApendiceE
{
    public class ApiController
    {
    }

    public class CitiesController : ApiController
    {
        private readonly IContext context;

        public CitiesController(IContext context)
        {
            // Princípio da inversão de dependência: depender de uma abstração
            // e não de uma classe concreta.
            this.context = context;
        }

        public async Task<List<City>> GetCities()
        {
            var citiesFactory = new CitiesFactory(context);
            return await citiesFactory.Read();
        }
    }
}
