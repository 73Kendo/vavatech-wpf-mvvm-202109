using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.Models
{

    public class Coordinate : Base
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Customer : BaseEntity, IDataErrorInfo, INotifyDataErrorInfo
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

        public Coordinate Location { get; set; }

        public IEnumerable<Product> LikedProducts { get; set; }

        public Address WorkAddress { get; set; }
        public Address HomeAddress  { get; set; }

        #region IDataErrorInfo

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(FirstName))
                {
                    if (string.IsNullOrEmpty(this.FirstName))
                    {
                        return "Tekst nie może być jest pusty";
                    }
                }

                if (columnName == nameof(LastName))
                {
                    if (string.IsNullOrEmpty(this.LastName))
                    {
                        return "Tekst nie może być jest pusty";
                    }
                }


                return string.Empty;

            }
        }

        public string Error => string.Empty;

        #endregion

        #region INotifyDataErrorInfo

        // https://kmatyaszek.github.io/wpf%20validation/2019/03/13/wpf-validation-using-inotifydataerrorinfo.html
        public bool HasErrors => false;

        public IEnumerable GetErrors(string propertyName)
        {
            return null;
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        #endregion  


    }

    public enum Gender
    {
        Male,
        Female
    }


    public class Address : Base
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
    }
}
