using Bogus;
using System.Collections.Generic;
using System.Linq;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.FakeServices
{
    public class FakeCityService : ICityService
    {
        private readonly IEnumerable<City> cities;

        public FakeCityService(Faker<City> faker)
        {
            cities = faker.Generate(100);
        }

        public IEnumerable<City> Get()
        {
            return cities;
        }

        public IEnumerable<City> Get(int countryId)
        {
            return cities.Where(c => c.Country.Id == countryId);
        }
    }
}
