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
