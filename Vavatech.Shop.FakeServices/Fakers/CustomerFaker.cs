using Bogus;
using Vavatech.Shop.Models;
using Bogus.Extensions.Poland;

namespace Vavatech.Shop.FakeServices.Fakers
{
    // Install-Package Sulmar.Bogus.Extensions.Poland
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Birthday, f => f.Person.DateOfBirth);
            RuleFor(p => p.Gender, f => (Gender) f.Person.Gender);
            RuleFor(p => p.Pesel, f => f.Person.Pesel());
            RuleFor(p => p.Photo, f => f.Person.Avatar.ToImage());
        }
    }
}
