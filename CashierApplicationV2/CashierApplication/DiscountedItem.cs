namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        // Overloaded constructor - calls base class constructor using base keyword
        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        // Override getTotalPrice - computes discounted total price
        public override double getTotalPrice()
        {
            // Convert discount percentage to decimal then compute discounted price
            double discountDecimal = this.item_discount * 0.01;
            double discountAmount = discountDecimal * this.item_price;
            this.discounted_price = this.item_price - discountAmount;

            // Multiply discounted price by quantity for total
            this.TotalPrice = this.discounted_price * this.item_quantity;
            return this.TotalPrice;
        }

        // Override setPayment - stores payment and computes change
        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
            this.change = this.payment_amount - this.TotalPrice;
        }

        // Returns the computed change
        public double getChange()
        {
            return this.change;
        }
    }
}
