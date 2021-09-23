using System.Collections.Generic;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.IServices
{
    public interface ICityService
    {
        IEnumerable<City> Get();
        IEnumerable<City> Get(int countryId);
    }

}
