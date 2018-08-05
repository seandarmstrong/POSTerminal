namespace POS.Library
{
    public class OrderList : Product
    {
        public OrderList(string category, string name, float price, int quantity, float total, string description) : base(category, name, price, description)
        {
            Quantity = quantity;
            Total = total;
        }

        public int Quantity { get; private set; }
        public float Total { get; private set; }
    }
}