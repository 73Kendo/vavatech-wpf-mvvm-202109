using System;

namespace Vavatech.Shop.Models
{

    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsDiscounted { get; set; }
        public string Color { get; set; }
        public byte[] Image { get; set; }

       
    }
}
