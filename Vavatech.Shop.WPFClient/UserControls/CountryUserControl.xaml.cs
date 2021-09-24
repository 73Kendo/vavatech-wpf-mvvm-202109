using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.WPFClient.UserControls
{
    /// <summary>
    /// Interaction logic for CountryUserControl.xaml
    /// </summary>
    public partial class CountryUserControl : UserControl
    {
        public Country SelectedCountry      
        {
            get { return (Country)GetValue(SelectedCountryProperty); }
            set { SetValue(SelectedCountryProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedCountryProperty =
            DependencyProperty.Register(nameof(SelectedCountry), typeof(Country), typeof(CountryUserControl), new PropertyMetadata(OnSelectedChanged));

        private static void OnSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public CountryUserControl()
        {
            InitializeComponent();
        }
    }
}
