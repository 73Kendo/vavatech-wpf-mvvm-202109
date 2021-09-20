using System;
using System.Collections.Generic;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.ViewModels
{

    public abstract class BaseViewModel
    {

    }


    public class ProductsViewModel : BaseViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Product SelectedProduct { get; set; }
        public IEnumerable<Product> SelectedProducts { get; set; }

        private readonly IProductService productService;

        public ProductsViewModel(IProductService productService)
        {
            this.productService = productService;

            Products = productService.Get();
        }

        public void Calculate()
        {
            throw new NotImplementedException();
        }

        public bool CanCalculate()
        {
            return true;
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
