using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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

        public Task<IEnumerable<Product>> GetAsync()
        {
            return Task.Run(()=>Get());

            // Nie tworzy osobnego Taska
            // return Task.FromResult(100);
        }

        public async IAsyncEnumerable<Product> GetAsync2(CancellationToken cancellationToken = default, IProgress<int> progress = default)
        {
            int counter = 0;

            foreach (var item in entities)
            {
                //if (cancellationToken.IsCancellationRequested)
                //{
                //    break;
                //}

                cancellationToken.ThrowIfCancellationRequested();

                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);

                progress?.Report(counter++);

                yield return item;
            }
        }
    }
}
