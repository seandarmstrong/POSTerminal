using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class ProductList
    {
        public  List<Product> productList = new List<Product>();

        public  List<Product> BuildList()
        {
            string[] str = System.IO.File.ReadAllText(@"C:\Users\armst\Documents\Grand_Circus\POS_Terminal\POSTerminal\RadioShackPOS\POS.Library\products.txt")
                .Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);

            foreach (var t in str)
            {
                string[] s = t.Split(',');

                productList.Add(new Product(s[0], s[1], Convert.ToSingle(s[2]), s[3]));
            }

            return productList;
        }
    }
}