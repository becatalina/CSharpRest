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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var vm = (ProductsViewModel)this.DataContext;
                var selected = (Menu)dataGrid.SelectedItem;
                foreach (var item in vm.MenuShoppingCart)
                {
                    if (item.Key == selected)
                    {
                        var newProd = (Menu)item.Key;
                        vm.MenuShoppingCart.Remove(item.Key);
                        vm.MenuShoppingCart.Add(newProd, item.Value + 1);

                    }
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            var currentWindow = new HomeWindow();
            currentWindow.DataContext = this.DataContext;
            currentWindow.Show();
            this.Close(); 
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid_Selected(object sender, RoutedEventArgs e)
        {
            try
            {
                var vm = (ProductsViewModel)this.DataContext;
                var item = vm.Menus.FirstOrDefault(m => m == dataGrid.SelectedItem);
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
