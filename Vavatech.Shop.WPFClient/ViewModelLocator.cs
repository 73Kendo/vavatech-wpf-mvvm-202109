using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Vavatech.Shop.FakeServices;
using Vavatech.Shop.FakeServices.Fakers;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;
using Vavatech.Shop.ViewModels;

namespace Vavatech.Shop.WPFClient
{
    // Install-Package Unity
    public class ViewModelLocator
    {
        private readonly IUnityContainer container;

        public ViewModelLocator()
        {
            container = new UnityContainer();

            // container.RegisterType<ProductsViewModel>();

            container.RegisterSingleton<ProductsViewModel>();

            container.RegisterType<IProductService, FakeProductService>();
            container.RegisterType<Faker<Product>, ProductFaker>();

            container.RegisterType<ShellViewModel>();
        }

        // public ProductsViewModel ProductViewModel => new ProductsViewModel(new FakeProductService(new ProductFaker()));

        public ProductsViewModel ProductsViewModel => container.Resolve<ProductsViewModel>();
        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();


    }

   
}
