namespace POS.Library.Products
{
    public class Cable : ElectronicDevice
    {
        public Cable(string name, string description, float price)
        {
            Name = name;
            Description = description;
            Price = price;
            SubCategory = "Cables";
        }
    }
}
