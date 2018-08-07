using POS.Library.Interfaces;

namespace POS.Library
{
    public class Product : IProductModel
    {
        //PROPS
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public float Price { get; }

        //constructor
        public Product(string category, string name, float price, string description)
        {
            Category = category;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
