using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Vavatech.Shop.IServices;
using Vavatech.Shop.ViewModels;
using Vavatech.Shop.WPFClient.Views;
using Vavatech.Shop.WPFClient.WpfServices;

namespace Vavatech.Shop.WPFClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public ViewModelLocator ViewModelLocator { get; set; }

        //// zamiast  StartupUri="Views\ShellView.xaml" w App.xaml
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    IUnityContainer container = new UnityContainer();


        //    container.RegisterType<ShellViewModel>();

        //    container.RegisterType<IMessageBoxService, WpfMessageBoxService>();

        //    ViewModelLocator = new ViewModelLocator(container);

        //    var view = container.Resolve<ShellView>();
            
        //    view.Show();

        //}
    }
}
