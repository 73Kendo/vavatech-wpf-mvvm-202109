using Bogus;
using System;
using System.Collections.Generic;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;
using Vavatech.Shop.Models.SearchCriterias;

namespace Vavatech.Shop.FakeServices
{
    // Install-Package Bogus

    public class FakeProductService : IProductService
    {
        private readonly ICollection<Product> products;

        public FakeProductService(Faker<Product> faker)
        {
            products = faker.Generate(10);
        }


        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            return products;
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get(string color)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get(decimal? fromUnitPrice, decimal? toUnitPrice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get(ProductSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
