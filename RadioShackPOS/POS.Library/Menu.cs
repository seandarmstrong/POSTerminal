using System;
using System.IO;
using System.Collections.Generic;
using POS.Library.Interfaces;

namespace POS.Library
{
    public class Menu
    {
        private const string LIST_FORMAT = "{0, -4}{1, -20}{2, -25}{3, -10}{4,-5}";

        public static void DisplayMainMenu()
        {

            var menu = String.Format("\n{0}\n{1}\n{2}\n{3}",
                "What would you like to do?",
                "1. View products",
                "2. View Cart",
                "3. Checkout",
                "4. Leave store");
            Console.WriteLine(menu);
            UserOptions.GetMainMenuResponse();
        }

        public static void DisplayProductMenu()
        {

            var menu = new ProductList();
            List<IProductModel> productList = menu.BuildList();
            Console.WriteLine(LIST_FORMAT, "", "Category", "Name",  "Price", "Description");
            Console.WriteLine("");
               
            foreach (var item in productList)
            {
                Console.WriteLine(LIST_FORMAT, (productList.IndexOf(item) + 1), item.Category, item.Name, item.Price.ToString("C"), item.Description );
            }
        }

        /*public static void DisplayCart()
        {
            int i = 0;
            List<OrderList> cartList = Order.BuildOrderList(i);
            for (i=0; i<cartList.Count; i++)
            {
                Console.WriteLine(cartList);
            }
        }*/

        public static void DisplayPayment()
        {
            var menu = String.Format("\n{0}\n{1}\n{2}\n{3}",
                "How would you like to pay?",
                "1. Cash",
                "2. Check",
                "3. Card");
            Console.WriteLine(menu);
            UserOptions.GetPaymentOptions();

        }
    }
}