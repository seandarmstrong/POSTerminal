using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class Order
    {
        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public static List<Product> orderList = new List<Product>();
        public static ProductList product = new ProductList();
        public static List<Product> productList = product.BuildList();


        public static List<Product> BuildOrderList(int userInput)
        {
            var productIndex = userInput - 1;
            foreach (var product in productList)
            {
                if (productList.IndexOf(product) == productIndex)
                {
                    orderList.Add(new Product(product.ReturnCategory(), product.ReturnName(), product.ReturnPrice(), product.ReturnDescription()));
                }
            }

            return orderList;
        }

        public static void ViewOrderCart()
        {
            var subTotal = 0f;
            foreach (var product in orderList)
            {
                Console.WriteLine("{0,-5}{1,-10}{2,-10}{3,-6}{4,-20}", (orderList.IndexOf(product) + 1), product.ReturnCategory(), product.ReturnName(), product.ReturnPrice(), product.ReturnDescription());
                subTotal = subTotal + product.ReturnPrice();
            }

            Console.WriteLine($"The current subtotal of the items in the cart is {subTotal}");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }
    }
}