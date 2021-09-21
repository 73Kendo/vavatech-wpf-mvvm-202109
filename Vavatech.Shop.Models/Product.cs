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
        private decimal unitPrice;

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice
        {
            get => unitPrice;
            set
            {
                unitPrice = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public bool IsDiscounted { get; set; }
        public string Color { get; set; }

        public string FullName => $"{Name} [{Color}] {UnitPrice}";

        public byte[] Image { get; set; }
        public string BarCode { get; set; }



    }
}
