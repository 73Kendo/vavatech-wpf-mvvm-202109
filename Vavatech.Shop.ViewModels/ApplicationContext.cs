using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.ViewModels
{

    // Nie traktować tego miejsca na zmienne globalne
    public class ApplicationContext
    {
        public Customer SelectedCustomer { get; set; }

        public Product SelectedProduct { get; set; }

        // DbContext Pool (Class Pool)
    }
}
