using System;
using System.Collections.Generic;

namespace Vavatech.Shop.Models
{
    public class Order : BaseEntity
    {
        public IEnumerable<OrderDetail> Details { get; set; }
    }

    public class OrderDetail : BaseEntity
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
    }



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
