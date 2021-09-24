using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;
using Vavatech.Shop.Models.SearchCriterias;

namespace Vavatech.Shop.DbServices
{
    public class DbProductService : IProductService
    {
        private readonly DbConnection connection;

        public DbProductService(DbConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            throw new NotImplementedException();
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
            string sql = "SELECT TOP 1000 .... WHERE Name LIKE @Name";

            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@Name", searchCriteria.NameFrom);
            command.Parameters.AddWithValue("@Color", searchCriteria.Color);

            ICollection<Product> products = new List<Product>();

            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                Product product = new Product
                {
                    Name = reader.GetString(0),
                    Color = reader.GetString(1),
                };

                products.Add(product);
            }

            return products;
        }

        public Task<IEnumerable<Product>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<Product> GetAsync2(CancellationToken cancellationToken = default, IProgress<int> progress = null)
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
