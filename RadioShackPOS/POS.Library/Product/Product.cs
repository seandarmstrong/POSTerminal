using System;
using System.Collections.Generic;

namespace POS.Library
{
    public class Product
    {
        public Product(string category, string name, float price, string description)
        {
            _category = category;
            _name = name;
            _price = price;
            _description = description;
        }

        private string _category { get; set; }
        private string _name { get; set; }
        private float _price { get; set; }
        private string _description { get; set; }

        public List<Product> orderList = new List<Product>();

        public List<Product> BuildList()
        {
            string[] str = System.IO.File.ReadAllText(@"C:\Users\armst\Documents\Grand_Circus\POS_Terminal\POSTerminal\RadioShackPOS\POS.Library\products.txt")
                .Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);

            foreach (var t in str)
            {
                string[] s = t.Split(',');

                orderList.Add(new Product(s[0], s[1], Convert.ToSingle(s[2]), s[3]));
            }

            return orderList;
        }

        public string ReturnCategory()
        {
            return _category;
        }

        public string ReturnName()
        {
            return _name;
        }

        public float ReturnPrice()
        {
            return _price;
        }

        public string ReturnDescription()
        {
            return _description;
        }
    }
}
