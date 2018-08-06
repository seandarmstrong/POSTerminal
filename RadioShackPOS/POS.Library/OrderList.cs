namespace POS.Library
{
    public class OrderList : Product
    {
        public OrderList(string category, string name, float price, int quantity, float total, string description) : base(category, name, price, description)
        {
            Quantity = quantity;
            Total = total;
        }

        private int Quantity { get; set; }
        private float Total { get; set; }

        public int GetQuantity()
        {
            return Quantity;
        }

        public float GetTotal()
        {
            return Total;
        }
    }
}