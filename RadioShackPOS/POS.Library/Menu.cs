using System;
using System.IO;
using System.Collections.Generic;

namespace POS.Library
{
    public class Menu
    {
        private const string LIST_FORMAT = "{0, -4}{1, -20}{2, -25}{3, -10}{4,-5}";

        public static void DisplayMainMenu()
        {

            var menu = String.Format("{0}\n{1}\n{2}\n{3}",
                "What would you like to do?",
                "1. View products",
                "2. View Cart",
                "3. Checkout",
                "3. Leave store");
            Console.WriteLine(menu);
            UserOptions.GetMainMenuResponse();
        }

        public static void DisplayProductMenu()
        {

            var menu = new ProductList();
            List<Product> productList = menu.BuildList();
                Console.WriteLine(LIST_FORMAT, "", "Category", "Name",  "Price", "Description");
            Console.WriteLine("");
               
            foreach (var item in productList)
            {
                Console.WriteLine(LIST_FORMAT, (productList.IndexOf(item) + 1), item.ReturnCategory(), item.ReturnName(), item.ReturnPrice(), item.ReturnDescription() );
            }
        }

        public static void DisplayCart()
        {
            var cart = new Order();
            int i = 0;
            List<Product> cartList = cart.BuildOrderList(i);
            for (i=0; i<cartList.Count; i++)
            {
                Console.WriteLine(cartList);
            }
        }
    }
}