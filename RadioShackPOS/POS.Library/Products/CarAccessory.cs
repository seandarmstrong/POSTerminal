using POS.Library.Interfaces;

namespace POS.Library.Products
{
    class CarAccessory : Interfaces.IProductModel
    {
        public string Category { get; private set; } = "Car Accessories";

        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string SubCategory { get; private set; }

        public CarAccessory(string name, string description, float price)
        {
            Name = name;
            Description = description;
            Price = price;
            SubCategory = "Car Accessories";
        }
    }
}