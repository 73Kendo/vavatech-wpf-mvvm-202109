using Bogus;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.FakeServices.Fakers
{
    public class CityFaker : Faker<City>
    {
        public CityFaker(ICountryService countryService)
        {
            var countries = countryService.Get();

            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.Name, f => f.Address.City());
            RuleFor(p => p.Country, f=>f.PickRandom(countries));
        }
    }
}
