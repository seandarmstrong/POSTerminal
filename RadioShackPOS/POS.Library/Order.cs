using System.Collections.Generic;

namespace POS.Library
{
    public class Order
    {
        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public List<Product> orderList = new List<Product>();
        public static ProductList product = new ProductList();
        public List<Product> productList = product.BuildList();


        public List<Product> BuildOrderList(int userInput)
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
    }
}