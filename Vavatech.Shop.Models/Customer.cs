using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.Models
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public string Pesel { get; set; }
        public byte[] Photo { get; set; }
        public string Avatar { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
