using System;
using System.Collections.Generic;
using System.Linq;
using Vavatech.Shop.Models;
using Vavatech.Shop.Models.SearchCriterias;

namespace Vavatech.Shop.IServices
{
    public interface IProductService
    {
        IEnumerable<Product> Get();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Remove(int id);
        IEnumerable<Product> Get(string color);
        IEnumerable<Product> Get(decimal? fromUnitPrice, decimal? toUnitPrice);
        IEnumerable<Product> Get(ProductSearchCriteria searchCriteria);

       // IEnumerable<Product> Get(IQueryable<Product> query);
    }
}
