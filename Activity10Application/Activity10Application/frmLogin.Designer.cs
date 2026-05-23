namespace Activity10Application
{
    partial class frmLogin
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblLoginSub = new System.Windows.Forms.Label();
            this.lblIdLabel = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblPassLabel = new System.Windows.Forms.Label();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // pnlLeft
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Controls.Add(this.lblBrandSub);
            this.pnlLeft.Controls.Add(this.lblVersion);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(220, 420);
            this.pnlLeft.TabIndex = 0;

            this.lblBrand.AutoSize = false;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.lblBrand.Location = new System.Drawing.Point(20, 140);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(185, 65);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "🔐 Admin Portal";

            this.lblBrandSub.AutoSize = false;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158);
            this.lblBrandSub.Location = new System.Drawing.Point(20, 215);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(185, 60);
            this.lblBrandSub.TabIndex = 1;
            this.lblBrandSub.Text = "Inheritance and Polymorphism Activity";

            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(48, 54, 61);
            this.lblVersion.Location = new System.Drawing.Point(20, 395);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "v1.0  |  IT1808";

            // pnlRight
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblLoginTitle);
            this.pnlRight.Controls.Add(this.lblLoginSub);
            this.pnlRight.Controls.Add(this.lblIdLabel);
            this.pnlRight.Controls.Add(this.txtLoginId);
            this.pnlRight.Controls.Add(this.lblPassLabel);
            this.pnlRight.Controls.Add(this.txtLoginPass);
            this.pnlRight.Controls.Add(this.chkShowPass);
            this.pnlRight.Controls.Add(this.lblError);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.lblHint);
            this.pnlRight.Location = new System.Drawing.Point(220, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(380, 420);
            this.pnlRight.TabIndex = 1;

            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblLoginTitle.Location = new System.Drawing.Point(30, 45);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Sign In";

            this.lblLoginSub.AutoSize = true;
            this.lblLoginSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoginSub.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblLoginSub.Location = new System.Drawing.Point(30, 80);
            this.lblLoginSub.Name = "lblLoginSub";
            this.lblLoginSub.TabIndex = 1;
            this.lblLoginSub.Text = "Enter your credentials to continue";

            this.lblIdLabel.AutoSize = true;
            this.lblIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdLabel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblIdLabel.Location = new System.Drawing.Point(30, 115);
            this.lblIdLabel.Name = "lblIdLabel";
            this.lblIdLabel.TabIndex = 2;
            this.lblIdLabel.Text = "User ID";

            this.txtLoginId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLoginId.Location = new System.Drawing.Point(30, 133);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(315, 27);
            this.txtLoginId.TabIndex = 3;
            this.txtLoginId.TextChanged += new System.EventHandler(this.txtLoginId_TextChanged);

            this.lblPassLabel.AutoSize = true;
            this.lblPassLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassLabel.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblPassLabel.Location = new System.Drawing.Point(30, 172);
            this.lblPassLabel.Name = "lblPassLabel";
            this.lblPassLabel.TabIndex = 4;
            this.lblPassLabel.Text = "Password";

            this.txtLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLoginPass.Location = new System.Drawing.Point(30, 190);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(315, 27);
            this.txtLoginPass.TabIndex = 5;
            this.txtLoginPass.UseSystemPasswordChar = true;
            this.txtLoginPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginPass_KeyDown);
            this.txtLoginPass.TextChanged += new System.EventHandler(this.txtLoginPass_TextChanged);

            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPass.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.chkShowPass.Location = new System.Drawing.Point(30, 223);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.TabIndex = 6;
            this.chkShowPass.Text = "Show password";
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);

            this.lblError.AutoSize = false;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblError.Location = new System.Drawing.Point(30, 248);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(315, 20);
            this.lblError.TabIndex = 7;
            this.lblError.Visible = false;

            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(315, 40);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.lblHint.AutoSize = false;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(173, 181, 189);
            this.lblHint.Location = new System.Drawing.Point(30, 328);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(315, 35);
            this.lblHint.TabIndex = 9;
            this.lblHint.Text = "Hint: ID = admin01  |  Password = admin1234";

            // frmLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Portal - Login";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginSub;
        private System.Windows.Forms.Label lblIdLabel;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label lblPassLabel;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblHint;
    }
}
