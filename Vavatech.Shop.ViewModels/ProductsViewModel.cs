using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.ViewModels
{


    public class ProductsViewModel : BaseViewModel
    {
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get => products; set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        private Product selectedProduct;
        private bool isLoading;
        

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
        public ICommand LoadCommand { get; set; }

        public bool IsLoading
        {
            get => isLoading; set
            {
                isLoading = value;
                OnPropertyChanged();
            }
        }

        public ProductsViewModel(IProductService productService, IMessageBoxService messageBoxService)
        {
            this.productService = productService;
            this.messageBoxService = messageBoxService;
            PrintCommand = new DelegateCommand(Print, () => CanPrint);
            CalculateCommand = new DelegateCommand(Calculate);
            RemoveCommand = new DelegateCommand(Remove);
            LoadCommand = new DelegateCommand(async () => await LoadAsync());

            Products = new ObservableCollection<Product>();
        }

        private async Task LoadAsync()
        {
            IsLoading = true;

            var products = productService.GetAsync2();

            await foreach (var product in products)
            {
                Products.Add(product);
            }

            IsLoading = false;
        }



        //private async Task LoadAsync()
        //{
        //    IsLoading = true;

        //    Products = await productService.GetAsync();

        //    IsLoading = false;
        //}

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
