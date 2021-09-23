using Bogus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.FakeServices
{
    public class FakeCountryService : ICountryService
    {
        private readonly IEnumerable<Country> countries;

        public FakeCountryService(Faker<Country> faker)
        {
            countries = faker.Generate(20);
        }


        public IEnumerable<Country> Get() => countries;
    }
}
