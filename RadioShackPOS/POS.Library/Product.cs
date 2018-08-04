using System;
using System.Collections.Generic;
using POS.Library.Interfaces;

namespace POS.Library
{
    public class Product : IProductModel
    {
        public string Category { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public float Price { get; private set; }

        public Product(string category, string name, float price, string description)
        {
            Category = category;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
