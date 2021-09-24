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
        private readonly IMessageBoxService messageBoxService;

        public DelegateCommand PrintCommand { get; }
        public ICommand CalculateCommand { get; }
        public ICommand RemoveCommand { get; set; }

        public ProductsViewModel(IProductService productService, IMessageBoxService messageBoxService)
        {
            this.productService = productService;
            this.messageBoxService = messageBoxService;
            PrintCommand = new DelegateCommand(Print, () => CanPrint);
            CalculateCommand = new DelegateCommand(Calculate);
            RemoveCommand = new DelegateCommand(Remove);

            Products = productService.Get();
        }

        private void Remove()
        {
            var result = messageBoxService.ShowQuestion($"Czy jesteś pewień, że chcesz usunąć product {SelectedProduct.Name}?");

            if (result == DialogResult.Yes)
            {
                productService.Remove(SelectedProduct.Id);
            }
        }

        private void Print()
        {
            Trace.WriteLine($"Printing {SelectedProduct.BarCode}");
        }

        public bool IsSelectedProduct => SelectedProduct != null;

        private bool CanPrint => IsSelectedProduct;

        public void Calculate()
        {
            SelectedProduct.UnitPrice -= 100m;
        }

        public bool CanCalculate => IsSelectedProduct;




    }
}
