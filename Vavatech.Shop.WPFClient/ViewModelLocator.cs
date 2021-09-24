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
using Vavatech.Shop.WPFClient.WpfServices;

namespace Vavatech.Shop.WPFClient
{
    // Install-Package Unity
    public class ViewModelLocator
    {
        private readonly IUnityContainer container;

        public ViewModelLocator()
        {
            container = new UnityContainer();

            container.RegisterSingleton<ProductsViewModel>();

            container.RegisterSingleton<IProductService, FakeProductService>();
            container.RegisterSingleton<Faker<Product>, ProductFaker>();

            container.RegisterSingleton<CustomersViewModel>();

            container.RegisterType<ICustomerService, FakeCustomerService>();
            container.RegisterType<Faker<Customer>, CustomerFaker>();
            container.RegisterType<Faker<Coordinate>, CoordinateFaker>();

            container.RegisterSingleton<ICountryService, FakeCountryService>();
            container.RegisterSingleton<Faker<Country>, CountryFaker>();

            container.RegisterSingleton<ICityService, FakeCityService>();
            container.RegisterSingleton<Faker<City>, CityFaker>();

            container.RegisterType<Faker<Address>, AddressFaker>();

            container.RegisterType<TurbinaViewModel>();

            container.RegisterType<DashboardViewModel>();

            container.RegisterType<ShellViewModel>();

            container.RegisterType<IMessageBoxService, WpfMessageBoxService>();
        }

        // public ProductsViewModel ProductViewModel => new ProductsViewModel(new FakeProductService(new ProductFaker()));

        public IEnumerable<Product> Products => container.Resolve<IEnumerable<Product>>();

        public ProductsViewModel ProductsViewModel => container.Resolve<ProductsViewModel>();
        public CustomersViewModel CustomersViewModel => container.Resolve<CustomersViewModel>();
        public TurbinaViewModel TurbinaViewModel => container.Resolve<TurbinaViewModel>();
        public DashboardViewModel DashboardViewModel => container.Resolve<DashboardViewModel>();
        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
        public CountryViewModel CountryViewModel => container.Resolve<CountryViewModel>();



    }

   
}
