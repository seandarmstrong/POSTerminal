using POS.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class Order
    {
        private const string CART_FORMAT = "{0, -20}{1, -25}{2, -10}{3, -10}{4, -12}{5,-5}";
        private const string MONEY_FORMAT = "{0,-15}{1,-12}";

        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public static List<OrderList> orderList = new List<OrderList>();
        public static ProductList product = new ProductList();
        public static List<IProductModel> productList = product.BuildList();


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

        public static int OrderListCount()
        {
            return orderList.Count;
        }

        public static void ViewOrderCart()
        {
            var subTotal = 0f;
            Console.WriteLine("");
            Console.WriteLine(CART_FORMAT, "Category", "Name", "Price", "Quantity", "Total", "Description");
            foreach (var product in orderList)
            {
                Console.WriteLine(CART_FORMAT, product.Category, product.Name, product.Price.ToString("C"), product.Quantity, product.Total.ToString("C"), product.Description);
                subTotal = subTotal + product.Total;
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
                Console.WriteLine(CART_FORMAT, product.Category, product.Name, product.Price.ToString("C"), product.Quantity, product.Total.ToString("C"), product.Description);
                subTotal = subTotal + product.Total;
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