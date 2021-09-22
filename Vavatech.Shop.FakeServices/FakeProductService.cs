using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;
using Vavatech.Shop.Models.SearchCriterias;

namespace Vavatech.Shop.FakeServices
{


    // Install-Package Bogus

    public class FakeProductService : FakeEntityService<Product>, IProductService
    {
        public FakeProductService(Faker<Product> faker) : base(faker)
        {
        }

        public IEnumerable<Product> Get(string color)
        {
            return entities.Where(p => p.Color == color);
        }

        public IEnumerable<Product> Get(decimal? fromUnitPrice, decimal? toUnitPrice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get(ProductSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
