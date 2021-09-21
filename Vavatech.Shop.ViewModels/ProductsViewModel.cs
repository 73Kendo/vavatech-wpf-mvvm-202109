using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.ViewModels
{


    public class ProductsViewModel : BaseViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;

                PrintCommand.OnCanExecuteChanged();
            }
        }
        public IEnumerable<Product> SelectedProducts { get; set; }

        private readonly IProductService productService;
        

        public DelegateCommand PrintCommand { get; }
        public ICommand CalculateCommand { get; }

        public ProductsViewModel(IProductService productService)
        {
            this.productService = productService;

            PrintCommand = new DelegateCommand(Print, ()=>CanPrint);
            CalculateCommand = new DelegateCommand(Calculate);

            Products = productService.Get();
        }

        private void Print()
        {
            Trace.WriteLine($"Printing {SelectedProduct.BarCode}");
        }

        public bool IsSelectedProduct => SelectedProduct != null;

        private bool CanPrint => IsSelectedProduct;

        public void Calculate()
        {
            SelectedProduct.UnitPrice += 0.1m;
        }

        public bool CanCalculate => IsSelectedProduct;

        public void Remove()
        {
            throw new NotImplementedException();
        }


        
    }
}
