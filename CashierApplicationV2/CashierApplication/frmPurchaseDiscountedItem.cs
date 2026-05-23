using System;
using System.Windows.Forms;
using ItemNamespace;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem currentItem = null;
        private Cashier loggedInCashier;

        // Constructor accepts the logged-in cashier
        public frmPurchaseDiscountedItem(Cashier cashier)
        {
            InitializeComponent();
            this.loggedInCashier = cashier;

            // Display logged-in user info in the header
            lblUserInfo.Text = "👤  " + cashier.getFullName() + "  |  " + cashier.getDepartment();
        }

        // Compute button - calculates total discounted price
        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Please enter the item name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItem.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please enter the price.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                MessageBox.Show("Please enter the discount.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter the quantity.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            double price, discount;
            int quantity;

            if (!double.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!double.TryParse(txtDiscount.Text, out discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Please enter a valid discount (0-100).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Create a DiscountedItem object using the overloaded constructor
            currentItem = new DiscountedItem(txtItem.Text, price, quantity, discount);

            // Call the overridden getTotalPrice method (polymorphism - runtime)
            double totalAmount = currentItem.getTotalPrice();

            // Calculate breakdown values
            double discountDecimal = discount * 0.01;
            double discountAmountPerItem = price * discountDecimal;
            double discountedPricePerItem = price - discountAmountPerItem;
            double totalSavings = discountAmountPerItem * quantity;

            // Update receipt labels
            lblOriginalPriceValue.Text = "₱ " + price.ToString("F2");
            lblDiscountAmountValue.Text = "- ₱ " + discountAmountPerItem.ToString("F2") + " (" + discount + "%)";
            lblDiscountedPriceValue.Text = "₱ " + discountedPricePerItem.ToString("F2");
            lblQuantityValue.Text = "x " + quantity;
            lblTotalAmountValue.Text = "₱ " + totalAmount.ToString("F2");
            lblSavingsValue.Text = "You save ₱ " + totalSavings.ToString("F2") + "!";

            // Show receipt and enable payment
            pnlReceipt.Visible = true;
            txtPayment.Enabled = true;
            btnSubmit.Enabled = true;
            btnNewTransaction.Enabled = true;
            txtPayment.Focus();
        }

        // Submit button - computes the change
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPayment.Text))
            {
                MessageBox.Show("Please enter the payment amount.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPayment.Focus();
                return;
            }

            double payment;
            if (!double.TryParse(txtPayment.Text, out payment) || payment <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPayment.Focus();
                return;
            }

            if (payment < currentItem.TotalPrice)
            {
                MessageBox.Show("Payment is insufficient. Total is ₱" + currentItem.TotalPrice.ToString("F2"),
                    "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPayment.Focus();
                return;
            }

            // Call the overridden setPayment method (polymorphism - runtime)
            currentItem.setPayment(payment);
            lblChangeValue.Text = "₱ " + currentItem.getChange().ToString("F2");
            pnlChange.Visible = true;
            btnSubmit.Enabled = false;
        }

        // New Transaction button - resets the form
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            txtItem.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtQuantity.Clear();
            txtPayment.Clear();

            lblOriginalPriceValue.Text = "—";
            lblDiscountAmountValue.Text = "—";
            lblDiscountedPriceValue.Text = "—";
            lblQuantityValue.Text = "—";
            lblTotalAmountValue.Text = "—";
            lblSavingsValue.Text = "";
            lblChangeValue.Text = "—";

            pnlReceipt.Visible = false;
            pnlChange.Visible = false;
            txtPayment.Enabled = false;
            btnSubmit.Enabled = false;
            btnNewTransaction.Enabled = false;
            currentItem = null;
            txtItem.Focus();
        }

        // MenuStrip - Logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLoginAccount loginForm = new frmLoginAccount();
                loginForm.Show();
                this.Close();
            }
        }

        // MenuStrip - Exit Application
        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
