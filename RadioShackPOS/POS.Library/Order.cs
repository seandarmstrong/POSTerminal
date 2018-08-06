using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class Order
    {
        private const string CART_FORMAT = "{0, -20}{1, -25}{2, -10}{3, -10}{4, -12}{5,-5}";
        private const string MONEY_FORMAT = "{0,-15}{1,12}";
        private const string LIST_FORMAT = "{0, -4}{1, -20}{2, -25}{3, -10}{4,-5}";
        private const string RECEIPT_FORMAT = "{0,-25}{1,-20}{2,-20}{3,-25}";

        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }
        private float _taxOnSale { get; set; }

        public static List<OrderList> orderList = new List<OrderList>();

        public ProductList Catalog;

        public Order()
        {
            Catalog = new ProductList();
        }

        public List<OrderList> BuildOrderList(int userInput, int quantity)
        {
            var productIndex = userInput - 1;
            var listOfProducts = Catalog.GetProducts();

            foreach (var product in listOfProducts)
            {
                if (listOfProducts.IndexOf(product) == productIndex)
                {
                    orderList.Add(new OrderList(product.Category, product.Name, product.Price, quantity, (quantity * product.Price), product.Description));
                }
            }

            return orderList;
        }

        public int GetOrderListCount()
        {
            return orderList.Count;
        }

        public void ShowLineTotal(int userInput, int quantity)
        {
            var productIndex = userInput - 1;
            var listOfProducts = Catalog.GetProducts();
            foreach (var product in listOfProducts)
            {
                if (listOfProducts.IndexOf(product) == productIndex)
                {
                    Console.WriteLine("{0} {1}(s) have been added for a line total of {2:C}.", quantity, product.Name, quantity * product.Price);
                }
            }
        }

        public void ResetOrderList()
        {
            var userOptions = new UserOptions();
            Console.WriteLine("Would you like to reset the cart for another transaction? (y/n)");
            if (userOptions.ContinueAction(Console.ReadLine().ToLower().Trim()))
            {
                orderList.Clear();
                _subTotal = 0;
            }
        }

        public void ViewOrderCart()
        {
            _subTotal = 0f;
            Console.WriteLine("");
            Console.WriteLine(CART_FORMAT, "Category", "Name", "Price", "Quantity", "Total", "Description");
            foreach (var product in orderList)
            {
                Console.WriteLine(CART_FORMAT, product.Category, product.Name, product.Price.ToString("C"), product.GetQuantity(), product.GetTotal().ToString("C"), product.Description);
                _subTotal = _subTotal + product.GetTotal();
            }

            Console.WriteLine("");
            Console.WriteLine(MONEY_FORMAT, "Subtotal:", _subTotal.ToString("C"));
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public void CheckoutDisplay()
        {
            Console.WriteLine(CART_FORMAT, "Category", "Name", "Price", "Quantity", "Total", "Description");
            foreach (var product in orderList)
            {
                Console.WriteLine(CART_FORMAT, product.Category, product.Name, product.Price.ToString("C"), product.GetQuantity(), product.GetTotal().ToString("C"), product.Description);
                _subTotal = _subTotal + product.GetTotal();
            }
            _taxOnSale = _subTotal * _salesTax;
            _grandTotal = (float)Math.Round(_subTotal + _taxOnSale, 2);
            Console.WriteLine("");
            Console.WriteLine(MONEY_FORMAT, "Subtotal:", _subTotal.ToString("C"));
            Console.WriteLine(MONEY_FORMAT, "Sales Tax:", _taxOnSale.ToString("C"));
            Console.WriteLine(MONEY_FORMAT, "Grand Total:", _grandTotal.ToString("C"));
        }

        public float GetGrandTotal()
        {
            _subTotal = 0f;
            _salesTax = .06f;

            foreach (var product in orderList)
            {
                //Console.WriteLine(CART_FORMAT, product.Category, product.Name, product.Price.ToString("C"), product.GetQuantity(), product.GetTotal().ToString("C"), product.Description);
                _subTotal = _subTotal + product.GetTotal();
            }
            _taxOnSale = _subTotal * _salesTax;
            _grandTotal = (float)Math.Round(_subTotal + _taxOnSale, 2);
            return _grandTotal;
        }
        public static void ReceiptDisplay()

        {
            var subTotal = 0f;
            float salesTax = .06f;

            Console.WriteLine(RECEIPT_FORMAT, "Name", "Price", "Quantity", "Total");
            foreach (var product in orderList)
            {
                Console.WriteLine(RECEIPT_FORMAT, product.Name, product.Price.ToString("C"), product.GetQuantity(), product.GetTotal().ToString("C"));
                subTotal = subTotal + product.GetTotal();
            }

            float taxOnSale = subTotal * salesTax;
            float grandTotal = (float)Math.Round(subTotal + taxOnSale, 2);
            Console.WriteLine("");
            Console.WriteLine(MONEY_FORMAT, "Subtotal:", subTotal.ToString("C"));
            Console.WriteLine(MONEY_FORMAT, "Sales Tax:", taxOnSale.ToString("C"));
            Console.WriteLine(MONEY_FORMAT, "Grand Total:", grandTotal.ToString("C"));
            Console.WriteLine();
        }
    }
}