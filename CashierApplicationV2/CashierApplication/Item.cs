namespace ItemNamespace
{
    public abstract class Item
    {
        // Protected members - accessible by derived class
        protected string item_name;
        protected double item_price;
        protected int item_quantity;

        // Private member - not accessible by derived class
        private double total_price;

        // Constructor
        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        // Property for total_price
        public double TotalPrice
        {
            get { return this.total_price; }
            set { this.total_price = value; }
        }

        // Abstract methods - must be implemented by derived class
        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);
    }
}
