using POS.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class Order
    {
        private const string CART_FORMAT = "{0, -20}{1, -25}{2, -10}{3, -10}{4, -12}{5,-5}";
        private const string MONEY_FORMAT = "{0,-15}{1,-12}";
        private const string LIST_FORMAT = "{0, -4}{1, -20}{2, -25}{3, -10}{4,-5}";

        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public static List<OrderList> orderList = new List<OrderList>();
        public static ProductList product = new ProductList();
        public static List<IProductModel> productList = product.BuildList();

        public static void DisplayProductMenu()
        {
            if (productList.Count > 0)
            {
                Console.WriteLine(LIST_FORMAT, "", "Category", "Name", "Price", "Description");
                Console.WriteLine("");

                foreach (var item in productList)
                {
                    Console.WriteLine(LIST_FORMAT, (productList.IndexOf(item) + 1), item.Category, item.Name,
                        item.Price.ToString("C"), item.Description);
                }
            }
        }

        public static List<OrderList> BuildOrderList(int userInput, int quantity)
        {
            var productIndex = userInput - 1;

            foreach (var product in productList)
            {
                if (productList.IndexOf(product) == productIndex)
                {
                    orderList.Add(new OrderList(product.Category, product.Name, product.Price, quantity, (quantity * product.Price), product.Description));
                }
            }

            return orderList;
        }

        public static int GetOrderListCount()
        {
            return orderList.Count;
        }

        public static void ShowLineTotal(int userInput, int quantity)
        {
            var productIndex = userInput - 1;

            foreach (var product in productList)
            {
                if (productList.IndexOf(product) == productIndex)
                {
                    Console.WriteLine($"{quantity} of {product.Name} have been added for a line total of {quantity * product.Price}.");
                }
            }
        }

        public static void ResetOrderList()
        {
            Console.WriteLine("Would you like to reset the cart for another transaction? (y/n)");
            if (UserOptions.ContinueAction(Console.ReadLine().ToLower().Trim()))
            {
                orderList.Clear();
            }
        }

        public static void ViewOrderCart()
        {
            var subTotal = 0f;
            Console.WriteLine("");
            Console.WriteLine(CART_FORMAT, "Category", "Name", "Price", "Quantity", "Total", "Description");
            foreach (var product in orderList)
            {
                Console.WriteLine(CART_FORMAT, product.Category, product.Name, product.Price.ToString("C"), product.GetQuantity(), product.GetTotal().ToString("C"), product.Description);
                subTotal = subTotal + product.GetTotal();
            }

            Console.WriteLine("");
            Console.WriteLine(MONEY_FORMAT, "Subtotal:", subTotal.ToString("C"));
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public static float CheckoutDisplay()
        {
            var subTotal = 0f;
            float salesTax = .06f;


            Console.WriteLine(CART_FORMAT, "Category", "Name", "Price", "Quantity", "Total", "Description");
            foreach (var product in orderList)
            {
                Console.WriteLine(CART_FORMAT, product.Category, product.Name, product.Price.ToString("C"), product.GetQuantity(), product.GetTotal().ToString("C"), product.Description);
                subTotal = subTotal + product.GetTotal();
            }
            float taxOnSale = subTotal * salesTax;
            float grandTotal = (float)Math.Round(subTotal + taxOnSale, 2);

            Console.WriteLine("");
            Console.WriteLine(MONEY_FORMAT, "Subtotal:", subTotal.ToString("C"));
            Console.WriteLine(MONEY_FORMAT, "Sales Tax:", taxOnSale.ToString("C"));
            Console.WriteLine(MONEY_FORMAT, "Grand Total:", grandTotal.ToString("C"));
            return grandTotal;
        }
    }
}