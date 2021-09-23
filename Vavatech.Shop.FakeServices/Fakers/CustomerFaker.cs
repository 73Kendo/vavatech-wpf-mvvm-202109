using Bogus;
using Vavatech.Shop.Models;
using Bogus.Extensions.Poland;

namespace Vavatech.Shop.FakeServices.Fakers
{
    // Install-Package Sulmar.Bogus.Extensions.Poland
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker(Faker<Coordinate> coordinateFaker)
        {
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Birthday, f => f.Person.DateOfBirth);
            RuleFor(p => p.Gender, f => (Gender) f.Person.Gender);
            RuleFor(p => p.Pesel, f => f.Person.Pesel());
            // RuleFor(p => p.Photo, f => f.Person.Avatar.ToImage());
            RuleFor(p => p.Avatar, f => f.Person.Avatar);
            RuleFor(p => p.Progress, f => f.Random.Byte(0, 100));
            RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.9f));

            RuleFor(p => p.Location, f => coordinateFaker.Generate());
        }
    }

    public class CoordinateFaker : Faker<Coordinate>
    {
        public CoordinateFaker()
        {
            RuleFor(p => p.X, f => f.Random.Double(0, 650));
            RuleFor(p => p.Y, f => f.Random.Double(0, 480));
        }
    }

    //public class GpsFaker : Faker<Coordinate>
    //{
    //    public GpsFaker()
    //    {
    //        RuleFor(p => p.X, f => f.Address.Latitude());
    //        RuleFor(p => p.X, f => f.Address.Longitude());
    //    }
    //}
}
