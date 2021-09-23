using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public Customer SelectedCustomer { get; set; }
    }
}
