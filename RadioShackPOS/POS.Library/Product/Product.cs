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

        public string _category { get; set; }
        public string _name { get; set; }
        public float _price { get; set; }
        public string _description { get; set; }
    }
}
