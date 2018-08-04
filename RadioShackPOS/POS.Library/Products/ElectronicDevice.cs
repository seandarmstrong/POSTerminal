using POS.Library.Interfaces;

namespace POS.Library.Products
{
    public class ElectronicDevice : Interfaces.IProductModel
    {
        
        
        public string Category { get; private set; } = "Electronics";
        public string SubCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
