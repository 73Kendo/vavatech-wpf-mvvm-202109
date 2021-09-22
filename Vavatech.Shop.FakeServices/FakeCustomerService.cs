using Bogus;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.FakeServices
{
    public class FakeCustomerService : FakeEntityService<Customer>, ICustomerService
    {
        public FakeCustomerService(Faker<Customer> faker) : base(faker)
        {
        }
    }
}
