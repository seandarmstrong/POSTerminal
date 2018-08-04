using System;
using System.Collections.Generic;
using POS.Library.Interfaces;

namespace POS.Library
{
    public class Order
    {
        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public static List<IProductModel> orderList = new List<IProductModel>();
        public static ProductList product = new ProductList();
        public static List<IProductModel> productList = product.BuildList();


        public static List<IProductModel> BuildOrderList(int userInput)
        {
            var productIndex = userInput - 1;
            foreach (var product in productList)
            {
                if (productList.IndexOf(product) == productIndex)
                {
                    orderList.Add(new Product(product.Category, product.Name, product.Price, product.Description));
                }
            }

            return orderList;
        }

        public static void ViewOrderCart()
        {
            var subTotal = 0f;
            foreach (var product in orderList)
            {
                Console.WriteLine("{0,-5}{1,-10}{2,-10}{3,-6}{4,-20}", (orderList.IndexOf(product) + 1), product.Category, product.Name, product.Price, product.Description);
                subTotal = subTotal + product.Price;
            }

            Console.WriteLine($"The current subtotal of the items in the cart is {subTotal}");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }
    }
}