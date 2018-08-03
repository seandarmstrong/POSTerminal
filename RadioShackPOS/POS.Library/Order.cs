using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class Order
    {
        private float _subTotal { get; set; }
        private float _salesTax = .06f;
        private float _grandTotal { get; set; }

        public List<Product> orderList = new List<Product>();

        public List<Product> BuildList()
        {
            string[] str = System.IO.File.ReadAllText(@"C:\Users\armst\Documents\Grand_Circus\POS_Terminal\POSTerminal\RadioShackPOS\POS.Library\products.txt")
                .Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);

            for (int i = 0; i < str.Length; i++)
            {
                string[] s = str[i].Split(',');

                orderList.Add(new Product(s[0], s[1], Convert.ToSingle(s[2]), s[3]));
            }

            return orderList;
        }
    }
}