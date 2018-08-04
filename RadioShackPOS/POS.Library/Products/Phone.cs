using POS.Library.Interfaces;

namespace POS.Library.Products
{
    public class Phone : ElectronicDevice
    {
        public Phone(string name, string description, float price)
        {
            Name = name;
            Description = description;
            Price = price;
            SubCategory = "Phones";
        }
    }
}
