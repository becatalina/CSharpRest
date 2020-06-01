using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ViewModels
{
    public class ProductsViewModel: BaseViewModel
    {
        #region members
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();
        public ObservableCollection<Menu> Menus { get; set; } = new ObservableCollection<Menu>();
        public Dictionary<Product, int> ShoppingCart { get; set; } = new Dictionary<Product, int>();
        public Dictionary<Menu, int> MenuShoppingCart { get; set; } = new Dictionary<Menu, int>();
        
        #endregion

        public ProductsViewModel()
        {
            GetData();
        }

        #region methods

        private void GetData() {
            try
            {
                using (var db = new RestautantEntities())
                {
                    var products = from prod in db.Products select prod;
                    foreach (var prod in products)
                    {
                        Products.Add(
                            new Product() { 
                                Name = prod.Name,
                                Price = prod.Price,
                                ProductId = prod.ProductId,
                                Category = prod.Category
                            });
                    }

                    var menus = from menu in db.Menus select menu;
                    foreach (var menu in menus)
                    {
                        Menus.Add(
                            new Menu() { 
                                Name =  menu.Name,
                                Price = menu.Price,
                                MenuId = menu.MenuId,
                                MenuItems = menu.MenuItems
                            });
                    }
                }


            }
            catch (Exception e) {
                
            }
            
        }


        #endregion
    }
}
