using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.FakeServices.Fakers
{
    public class CountryFaker : Faker<Country>
    {
        public CountryFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.Name, f => f.Address.Country());
            RuleFor(p => p.Code, f => f.Address.CountryCode());
        }
    }
}
