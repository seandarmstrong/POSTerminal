using System;
using System.IO;
using System.Collections.Generic;

namespace POS.Library
{
    public class Menu
    {
        private const string LIST_FORMAT = "{0, -6}{1, -8}{2, -13}{3, -18}{4,-35}";

        public static void DisplayMainMenu()
        {

            var menu = String.Format("{0}\n{1}\n{2}\n{3}",
                "What would you like to do?",
                "1. View products",
                "2. View Cart",
                "3. Checkout",
                "3. Leave store");
            Console.WriteLine(menu);
            UserOptions.MainMenueOptions();
        }

        public static void DisplayProductMenu()
        {
            var menu = new ProductList();
            List<Product> productList = menu.BuildList();
                Console.WriteLine("\nVIEW ALL TASKS");
                Console.WriteLine(LIST_FORMAT, "Category", "Name", "Description", "Price", "Description");
               
            foreach (var item in productList)
            {
                Console.WriteLine(LIST_FORMAT, (productList.IndexOf(item) + 1), item.ReturnCategory(), item.ReturnName(), item.ReturnDescription(), item.ReturnPrice());
            }
        }

        public static void DisplayPaymentMethods()
        {

        }
    }
}