using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.FakeServices
{
    public class FakeEntityService<TEntity> : IEntityService<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IEnumerable<TEntity> entities;

        public FakeEntityService(Faker<TEntity> faker)
        {
            // entities = faker.Generate(20);

            entities = faker.GenerateLazy(20);

            foreach (var entity in entities)
            {

            }
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));

            return entities;
        }


        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
