﻿using System;
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
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : Page
    {
        public ProductsView()
        {
            InitializeComponent();

            // this.DataContext = new ViewModels.ProductsViewModel(new FakeServices.FakeProductService());
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void ListBox_Click(object sender, RoutedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            listBox.SelectedItem = ((Button)e.OriginalSource).DataContext;
        }
    }
}
