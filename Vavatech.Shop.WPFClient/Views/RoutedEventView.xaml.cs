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

namespace Vavatech.Shop.WPFClient.Views
{
    /// <summary>
    /// Interaction logic for RoutedEventView.xaml
    /// </summary>
    public partial class RoutedEventView : Page
    {
        public RoutedEventView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 was Clicked");

            e.Handled = true;
        }

        private void UniformGrid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("UniformGrid Clicked");
        }

        private void Page_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Page Clicked");
        }
    }
}
