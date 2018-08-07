namespace POS.Library
{
    public class OrderList : Product
    {
        //constructor
        public OrderList(string category, string name, float price, int quantity, float total, string description) : base(category, name, price, description)
        {
            Quantity = quantity;
            Total = total;
        }

        //PROP
        private int Quantity { get; set; }
        private float Total { get; set; }

        //this function returns the private property Quantity
        public int GetQuantity()
        {
            return Quantity;
        }

        //this function returns the private propery Total
        public float GetTotal()
        {
            return Total;
        }
    }
}