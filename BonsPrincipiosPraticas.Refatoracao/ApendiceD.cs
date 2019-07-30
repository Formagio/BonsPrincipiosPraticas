using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsPrincipiosPraticas.Refatoracao.ApendiceD
{
    public static class ListExtensions
    {
        public static Task<List<City>> ToListAsync(this List<City> cities)
        {
            return Task.FromResult(cities);
        }

        public static Task<City> FindAsync(this List<City> cities, int id)
        {
            return Task.FromResult(cities.FirstOrDefault(c => c.Id == id));
        }

        public static Task<City> FirstOrDefaultAsync(this List<City> cities, Func<City, bool> expression)
        {
            return Task.FromResult(cities.FirstOrDefault(expression));
        }
    }

    public class City
    {
        public int Id { get; set; }
        public int SpecificCountryCode { get; set; }
    }

    public interface IContext
    {
        List<City> Cities { get; }
        Task SaveChangesAsync();
    }

    public interface ICitiesFactory
    {
    }

    public class CitiesFactory : ICitiesFactory
    {
        private readonly IContext context;

        public CitiesFactory(IContext context)
        {
            // Princípio da inversão de dependência: depender de uma abstração
            // e não de uma classe concreta.
            this.context = context;
        }

        public Task Create(City city)
        {
            context.Cities.Add(city);
            return context.SaveChangesAsync();
        }

        public Task<List<City>> Read()
        {
            return context.Cities.ToListAsync();
        }

        public Task<City> Read(int id)
        {
            return context.Cities.FindAsync(id);
        }

        public Task<City> GetCityByIbgeId(int idIbge)
        {
            return context.Cities.FirstOrDefaultAsync(x => x.SpecificCountryCode == idIbge);
        }
    }
}
