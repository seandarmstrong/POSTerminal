using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class Order
    {
        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public void CheckList()
        {
            var product = new ProductList();
            List<Product> productList = product.BuildList();

            foreach (var i in productList)
            {
                Console.WriteLine(i.ReturnName());
            }
        }
    }
}