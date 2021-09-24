using System.Collections.Generic;
using System.Threading.Tasks;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.IServices
{
    public interface IEntityService<TEntity>
        where TEntity : BaseEntity
    {
        IEnumerable<TEntity> Get();

        

        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }

    public interface IEntityServiceAsync<TEntity>
        where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAsync();

        IAsyncEnumerable<TEntity> GetAsync2();

    }

    
}
