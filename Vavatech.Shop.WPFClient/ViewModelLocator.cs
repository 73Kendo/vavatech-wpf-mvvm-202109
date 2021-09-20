using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.FakeServices;
using Vavatech.Shop.FakeServices.Fakers;
using Vavatech.Shop.ViewModels;

namespace Vavatech.Shop.WPFClient
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {

        }

        public ProductsViewModel ProductViewModel => new ProductsViewModel(new FakeProductService(new ProductFaker()));
    }
}
