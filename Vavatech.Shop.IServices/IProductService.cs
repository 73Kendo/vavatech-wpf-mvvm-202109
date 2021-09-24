using System;
using System.Collections.Generic;
using System.Linq;
using Vavatech.Shop.Models;
using Vavatech.Shop.Models.SearchCriterias;

namespace Vavatech.Shop.IServices
{

    public interface IProductService : IEntityService<Product>, IEntityServiceAsync<Product>
    {
        IEnumerable<Product> Get(string color);
        IEnumerable<Product> Get(decimal? fromUnitPrice, decimal? toUnitPrice);
        IEnumerable<Product> Get(ProductSearchCriteria searchCriteria);

       // IEnumerable<Product> Get(IQueryable<Product> query);

    }

    
}
