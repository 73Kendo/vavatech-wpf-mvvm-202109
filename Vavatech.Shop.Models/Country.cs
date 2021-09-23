using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class City : BaseEntity
    {
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
