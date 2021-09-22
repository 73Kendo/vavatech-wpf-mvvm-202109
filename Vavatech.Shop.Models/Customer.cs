using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.Models
{
    public class Customer : BaseEntity
    {
        private string firstName;
        private string lastName;
        private byte progress;
        private bool isRemoved;

        public string FirstName
        {
            get => firstName; set
            {
                firstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => lastName; set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public string Pesel { get; set; }
        public byte[] Photo { get; set; }
        public string Avatar { get; set; }
        public byte Progress
        {
            get => progress; set
            {
                progress = value;
                OnPropertyChanged();
            }
        }

        public bool IsRemoved
        {
            get => isRemoved; set
            {
                isRemoved = value;
                OnPropertyChanged();
            }
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
