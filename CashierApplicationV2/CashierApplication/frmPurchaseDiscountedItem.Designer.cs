namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblItemLabel = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblDiscountLabel = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantityLabel = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.pnlPaymentSection = new System.Windows.Forms.Panel();
            this.lblPaymentLabel = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblReceiptHeader = new System.Windows.Forms.Label();
            this.pnlReceipt = new System.Windows.Forms.Panel();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblOriginalPriceValue = new System.Windows.Forms.Label();
            this.lblDiscountOff = new System.Windows.Forms.Label();
            this.lblDiscountAmountValue = new System.Windows.Forms.Label();
            this.lblDiscountedPrice = new System.Windows.Forms.Label();
            this.lblDiscountedPriceValue = new System.Windows.Forms.Label();
            this.lblQuantityDisplay = new System.Windows.Forms.Label();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            this.pnlReceiptDivider = new System.Windows.Forms.Panel();
            this.lblTotalAmountLabel = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblSavingsValue = new System.Windows.Forms.Label();
            this.pnlChange = new System.Windows.Forms.Panel();
            this.lblChangeLabel = new System.Windows.Forms.Label();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlPaymentSection.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlReceipt.SuspendLayout();
            this.pnlChange.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(33, 38, 45);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(820, 24);
            this.menuStrip.TabIndex = 0;

            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.logoutToolStripMenuItem, this.exitApplicationToolStripMenuItem });

            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);

            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblUserInfo);
            this.pnlHeader.Location = new System.Drawing.Point(0, 24);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(820, 65);
            this.pnlHeader.TabIndex = 1;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛒  Purchase Discounted Item";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Fill in item details and compute total";

            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblUserInfo.Location = new System.Drawing.Point(580, 25);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "";

            // pnlAccent
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.pnlAccent.Location = new System.Drawing.Point(0, 89);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(820, 3);
            this.pnlAccent.TabIndex = 2;

            // pnlLeft
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlLeft.Controls.Add(this.lblItemLabel);
            this.pnlLeft.Controls.Add(this.txtItem);
            this.pnlLeft.Controls.Add(this.lblDiscountLabel);
            this.pnlLeft.Controls.Add(this.txtDiscount);
            this.pnlLeft.Controls.Add(this.lblPriceLabel);
            this.pnlLeft.Controls.Add(this.txtPrice);
            this.pnlLeft.Controls.Add(this.lblQuantityLabel);
            this.pnlLeft.Controls.Add(this.txtQuantity);
            this.pnlLeft.Controls.Add(this.btnCompute);
            this.pnlLeft.Controls.Add(this.pnlPaymentSection);
            this.pnlLeft.Location = new System.Drawing.Point(0, 92);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(340, 440);
            this.pnlLeft.TabIndex = 3;

            this.lblItemLabel.AutoSize = true;
            this.lblItemLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemLabel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblItemLabel.Location = new System.Drawing.Point(20, 20);
            this.lblItemLabel.Name = "lblItemLabel";
            this.lblItemLabel.TabIndex = 0;
            this.lblItemLabel.Text = "Item Name";

            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtItem.Location = new System.Drawing.Point(20, 38);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(295, 27);
            this.txtItem.TabIndex = 1;

            this.lblDiscountLabel.AutoSize = true;
            this.lblDiscountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiscountLabel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblDiscountLabel.Location = new System.Drawing.Point(20, 78);
            this.lblDiscountLabel.Name = "lblDiscountLabel";
            this.lblDiscountLabel.TabIndex = 2;
            this.lblDiscountLabel.Text = "Discount (%)";

            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiscount.Location = new System.Drawing.Point(20, 96);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(295, 27);
            this.txtDiscount.TabIndex = 3;

            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriceLabel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblPriceLabel.Location = new System.Drawing.Point(20, 136);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.TabIndex = 4;
            this.lblPriceLabel.Text = "Price (₱)";

            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrice.Location = new System.Drawing.Point(20, 154);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(295, 27);
            this.txtPrice.TabIndex = 5;

            this.lblQuantityLabel.AutoSize = true;
            this.lblQuantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblQuantityLabel.Location = new System.Drawing.Point(20, 194);
            this.lblQuantityLabel.Name = "lblQuantityLabel";
            this.lblQuantityLabel.TabIndex = 6;
            this.lblQuantityLabel.Text = "Quantity";

            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(20, 212);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(295, 27);
            this.txtQuantity.TabIndex = 7;

            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(20, 255);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(295, 38);
            this.btnCompute.TabIndex = 8;
            this.btnCompute.Text = "Compute Total";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

            this.pnlPaymentSection.BackColor = System.Drawing.Color.White;
            this.pnlPaymentSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentSection.Controls.Add(this.lblPaymentLabel);
            this.pnlPaymentSection.Controls.Add(this.txtPayment);
            this.pnlPaymentSection.Controls.Add(this.btnSubmit);
            this.pnlPaymentSection.Controls.Add(this.btnNewTransaction);
            this.pnlPaymentSection.Location = new System.Drawing.Point(20, 308);
            this.pnlPaymentSection.Name = "pnlPaymentSection";
            this.pnlPaymentSection.Size = new System.Drawing.Size(295, 115);
            this.pnlPaymentSection.TabIndex = 9;

            this.lblPaymentLabel.AutoSize = true;
            this.lblPaymentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaymentLabel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblPaymentLabel.Location = new System.Drawing.Point(10, 10);
            this.lblPaymentLabel.Name = "lblPaymentLabel";
            this.lblPaymentLabel.TabIndex = 0;
            this.lblPaymentLabel.Text = "Payment Received (₱)";

            this.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayment.Enabled = false;
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPayment.Location = new System.Drawing.Point(10, 28);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(270, 27);
            this.txtPayment.TabIndex = 1;

            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(10, 65);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnNewTransaction.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnNewTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTransaction.Enabled = false;
            this.btnNewTransaction.FlatAppearance.BorderSize = 0;
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewTransaction.ForeColor = System.Drawing.Color.White;
            this.btnNewTransaction.Location = new System.Drawing.Point(152, 65);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(128, 35);
            this.btnNewTransaction.TabIndex = 3;
            this.btnNewTransaction.Text = "New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);

            // pnlRight
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblReceiptHeader);
            this.pnlRight.Controls.Add(this.pnlReceipt);
            this.pnlRight.Controls.Add(this.pnlChange);
            this.pnlRight.Location = new System.Drawing.Point(345, 92);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(475, 440);
            this.pnlRight.TabIndex = 4;

            this.lblReceiptHeader.AutoSize = true;
            this.lblReceiptHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblReceiptHeader.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblReceiptHeader.Location = new System.Drawing.Point(20, 20);
            this.lblReceiptHeader.Name = "lblReceiptHeader";
            this.lblReceiptHeader.TabIndex = 0;
            this.lblReceiptHeader.Text = "Transaction Summary";

            this.pnlReceipt.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReceipt.Controls.Add(this.lblOriginalPrice);
            this.pnlReceipt.Controls.Add(this.lblOriginalPriceValue);
            this.pnlReceipt.Controls.Add(this.lblDiscountOff);
            this.pnlReceipt.Controls.Add(this.lblDiscountAmountValue);
            this.pnlReceipt.Controls.Add(this.lblDiscountedPrice);
            this.pnlReceipt.Controls.Add(this.lblDiscountedPriceValue);
            this.pnlReceipt.Controls.Add(this.lblQuantityDisplay);
            this.pnlReceipt.Controls.Add(this.lblQuantityValue);
            this.pnlReceipt.Controls.Add(this.pnlReceiptDivider);
            this.pnlReceipt.Controls.Add(this.lblTotalAmountLabel);
            this.pnlReceipt.Controls.Add(this.lblTotalAmountValue);
            this.pnlReceipt.Controls.Add(this.lblSavingsValue);
            this.pnlReceipt.Location = new System.Drawing.Point(20, 50);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.Size = new System.Drawing.Size(435, 250);
            this.pnlReceipt.TabIndex = 1;
            this.pnlReceipt.Visible = false;

            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOriginalPrice.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblOriginalPrice.Location = new System.Drawing.Point(15, 18);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.TabIndex = 0;
            this.lblOriginalPrice.Text = "Original Price:";

            this.lblOriginalPriceValue.AutoSize = true;
            this.lblOriginalPriceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOriginalPriceValue.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblOriginalPriceValue.Location = new System.Drawing.Point(280, 18);
            this.lblOriginalPriceValue.Name = "lblOriginalPriceValue";
            this.lblOriginalPriceValue.TabIndex = 1;
            this.lblOriginalPriceValue.Text = "—";

            this.lblDiscountOff.AutoSize = true;
            this.lblDiscountOff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscountOff.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblDiscountOff.Location = new System.Drawing.Point(15, 48);
            this.lblDiscountOff.Name = "lblDiscountOff";
            this.lblDiscountOff.TabIndex = 2;
            this.lblDiscountOff.Text = "Discount per Item:";

            this.lblDiscountAmountValue.AutoSize = true;
            this.lblDiscountAmountValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscountAmountValue.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblDiscountAmountValue.Location = new System.Drawing.Point(215, 48);
            this.lblDiscountAmountValue.Name = "lblDiscountAmountValue";
            this.lblDiscountAmountValue.TabIndex = 3;
            this.lblDiscountAmountValue.Text = "—";

            this.lblDiscountedPrice.AutoSize = true;
            this.lblDiscountedPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscountedPrice.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblDiscountedPrice.Location = new System.Drawing.Point(15, 78);
            this.lblDiscountedPrice.Name = "lblDiscountedPrice";
            this.lblDiscountedPrice.TabIndex = 4;
            this.lblDiscountedPrice.Text = "Discounted Price:";

            this.lblDiscountedPriceValue.AutoSize = true;
            this.lblDiscountedPriceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscountedPriceValue.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblDiscountedPriceValue.Location = new System.Drawing.Point(280, 78);
            this.lblDiscountedPriceValue.Name = "lblDiscountedPriceValue";
            this.lblDiscountedPriceValue.TabIndex = 5;
            this.lblDiscountedPriceValue.Text = "—";

            this.lblQuantityDisplay.AutoSize = true;
            this.lblQuantityDisplay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantityDisplay.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblQuantityDisplay.Location = new System.Drawing.Point(15, 108);
            this.lblQuantityDisplay.Name = "lblQuantityDisplay";
            this.lblQuantityDisplay.TabIndex = 6;
            this.lblQuantityDisplay.Text = "Quantity:";

            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantityValue.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblQuantityValue.Location = new System.Drawing.Point(280, 108);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.TabIndex = 7;
            this.lblQuantityValue.Text = "—";

            this.pnlReceiptDivider.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.pnlReceiptDivider.Location = new System.Drawing.Point(15, 138);
            this.pnlReceiptDivider.Name = "pnlReceiptDivider";
            this.pnlReceiptDivider.Size = new System.Drawing.Size(400, 2);
            this.pnlReceiptDivider.TabIndex = 8;

            this.lblTotalAmountLabel.AutoSize = true;
            this.lblTotalAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountLabel.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblTotalAmountLabel.Location = new System.Drawing.Point(15, 150);
            this.lblTotalAmountLabel.Name = "lblTotalAmountLabel";
            this.lblTotalAmountLabel.TabIndex = 9;
            this.lblTotalAmountLabel.Text = "TOTAL AMOUNT:";

            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblTotalAmountValue.Location = new System.Drawing.Point(235, 146);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.TabIndex = 10;
            this.lblTotalAmountValue.Text = "—";

            this.lblSavingsValue.AutoSize = true;
            this.lblSavingsValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSavingsValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSavingsValue.Location = new System.Drawing.Point(15, 215);
            this.lblSavingsValue.Name = "lblSavingsValue";
            this.lblSavingsValue.TabIndex = 11;
            this.lblSavingsValue.Text = "";

            this.pnlChange.BackColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.pnlChange.Controls.Add(this.lblChangeLabel);
            this.pnlChange.Controls.Add(this.lblChangeValue);
            this.pnlChange.Location = new System.Drawing.Point(20, 315);
            this.pnlChange.Name = "pnlChange";
            this.pnlChange.Size = new System.Drawing.Size(435, 80);
            this.pnlChange.TabIndex = 2;
            this.pnlChange.Visible = false;

            this.lblChangeLabel.AutoSize = true;
            this.lblChangeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblChangeLabel.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158);
            this.lblChangeLabel.Location = new System.Drawing.Point(20, 25);
            this.lblChangeLabel.Name = "lblChangeLabel";
            this.lblChangeLabel.TabIndex = 0;
            this.lblChangeLabel.Text = "CHANGE:";

            this.lblChangeValue.AutoSize = true;
            this.lblChangeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblChangeValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblChangeValue.Location = new System.Drawing.Point(200, 18);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.TabIndex = 1;
            this.lblChangeValue.Text = "—";

            // frmPurchaseDiscountedItem
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 532);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmPurchaseDiscountedItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Discounted Item";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlPaymentSection.ResumeLayout(false);
            this.pnlPaymentSection.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlReceipt.ResumeLayout(false);
            this.pnlReceipt.PerformLayout();
            this.pnlChange.ResumeLayout(false);
            this.pnlChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblItemLabel;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblDiscountLabel;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantityLabel;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel pnlPaymentSection;
        private System.Windows.Forms.Label lblPaymentLabel;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblReceiptHeader;
        private System.Windows.Forms.Panel pnlReceipt;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblOriginalPriceValue;
        private System.Windows.Forms.Label lblDiscountOff;
        private System.Windows.Forms.Label lblDiscountAmountValue;
        private System.Windows.Forms.Label lblDiscountedPrice;
        private System.Windows.Forms.Label lblDiscountedPriceValue;
        private System.Windows.Forms.Label lblQuantityDisplay;
        private System.Windows.Forms.Label lblQuantityValue;
        private System.Windows.Forms.Panel pnlReceiptDivider;
        private System.Windows.Forms.Label lblTotalAmountLabel;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblSavingsValue;
        private System.Windows.Forms.Panel pnlChange;
        private System.Windows.Forms.Label lblChangeLabel;
        private System.Windows.Forms.Label lblChangeValue;
    }
}
