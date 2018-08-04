using POS.Library.Interfaces;

namespace POS.Library.Products
{
    public class Radio : ElectronicDevice
    {

        public Radio(string name, string description, float price)
        {
            Name = name;
            Description = description;
            Price = price;
            SubCategory = "Radios";
        }
    }
}
