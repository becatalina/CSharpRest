using Restaurant.ViewModels;
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
using System.Windows.Shapes;

namespace Restaurant.Views
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var vm = (ProductsViewModel)this.DataContext;
                var selected = (Product)dataGrid.SelectedItem;
                foreach (var item in vm.ShoppingCart)
                {
                    if (item.Key == selected) {
                        var newProd = (Product)item.Key;
                        vm.ShoppingCart.Remove(item.Key);
                        vm.ShoppingCart.Add(newProd, item.Value + 1);

                    }
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMenus_Click(object sender, RoutedEventArgs e)
        {
            var currentWindow = new MenuWindow();
            currentWindow.DataContext = this.DataContext;
            currentWindow.Show();
            this.Close();

        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
