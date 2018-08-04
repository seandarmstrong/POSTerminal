using System;
using System.Collections.Generic;
using POS.Library.Interfaces;

namespace POS.Library
{
    public class Order
    {
        private const string LIST_FORMAT = "{0, -4}{1, -20}{2, -25}{3, -10}{4,-5}";

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
            Console.WriteLine(LIST_FORMAT, "", "Category", "Name", "Price", "Description");
            foreach (var product in orderList)
            {
                Console.WriteLine(LIST_FORMAT, (orderList.IndexOf(product) + 1), product.Category, product.Name, product.Price, product.Description);
                subTotal = subTotal + product.Price;
            }

            Console.WriteLine($"\nThe current subtotal of the items in the cart is {subTotal}.\n");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }
        
        public static float CheckoutDisplay()
        {
            var subTotal = 0f;
            float salesTax = .06f;
            float taxOnSale = subTotal * salesTax;
            float grandTotal = subTotal + taxOnSale;

            Console.WriteLine(LIST_FORMAT, "", "Category", "Name", "Price", "Description");
            foreach (var product in orderList)
            {
                Console.WriteLine(LIST_FORMAT, (orderList.IndexOf(product) + 1), product.Category, product.Name, product.Price, product.Description);
                subTotal = subTotal + product.Price;
                
            }
            
            Console.WriteLine($"\n The sales tax on this purchase is {taxOnSale}. Your total price for this transaction will be {grandTotal}.\n");
            return grandTotal;
        }
    }
}