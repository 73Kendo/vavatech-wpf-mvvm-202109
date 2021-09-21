using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Vavatech.Shop.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public ICommand ShowServicesViewCommand { get; set; }
        public ICommand ShowProductsViewCommand { get; set; }

        private string selectedView;
        public string SelectedView
        {
            get => selectedView;
            set 
            {
                selectedView = value;

                OnPropertyChanged();
            }
        }

        public ShellViewModel()
        {
            ShowProductView();

            ShowServicesViewCommand = new DelegateCommand(ShowServicesView, CanShowServicesView);
            ShowProductsViewCommand = new DelegateCommand(ShowProductView);

        }

        private void ShowProductView()
        {
            SelectedView = "ProductsView.xaml";
        }

        private void ShowServicesView()
        {
            SelectedView = "ServicesView.xaml";
        }

        private bool CanShowServicesView()
        {
            return true;
        }
        
    }
}
