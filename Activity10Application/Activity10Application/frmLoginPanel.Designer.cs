namespace Activity10Application
{
    partial class frmAdminPanel
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlUpdatePass = new System.Windows.Forms.Panel();
            this.lblUpdatePassTitle = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.pnlUpdateName = new System.Windows.Forms.Panel();
            this.lblUpdateNameTitle = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlUpdatePass.SuspendLayout();
            this.pnlUpdateName.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 60);
            this.pnlHeader.TabIndex = 0;

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";

            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(490, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlAccent
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.pnlAccent.Location = new System.Drawing.Point(0, 60);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(600, 3);
            this.pnlAccent.TabIndex = 1;

            // pnlBody
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.pnlUpdatePass);
            this.pnlBody.Controls.Add(this.pnlUpdateName);
            this.pnlBody.Location = new System.Drawing.Point(0, 63);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(600, 290);
            this.pnlBody.TabIndex = 2;

            // pnlUpdatePass
            this.pnlUpdatePass.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlUpdatePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdatePass.Controls.Add(this.lblUpdatePassTitle);
            this.pnlUpdatePass.Controls.Add(this.lblNewPass);
            this.pnlUpdatePass.Controls.Add(this.txtNewPassword);
            this.pnlUpdatePass.Controls.Add(this.lblConfirmPass);
            this.pnlUpdatePass.Controls.Add(this.txtConfirmPassword);
            this.pnlUpdatePass.Controls.Add(this.btnUpdatePassword);
            this.pnlUpdatePass.Location = new System.Drawing.Point(20, 20);
            this.pnlUpdatePass.Name = "pnlUpdatePass";
            this.pnlUpdatePass.Size = new System.Drawing.Size(265, 245);
            this.pnlUpdatePass.TabIndex = 0;

            this.lblUpdatePassTitle.AutoSize = true;
            this.lblUpdatePassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUpdatePassTitle.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblUpdatePassTitle.Location = new System.Drawing.Point(12, 12);
            this.lblUpdatePassTitle.Name = "lblUpdatePassTitle";
            this.lblUpdatePassTitle.TabIndex = 0;
            this.lblUpdatePassTitle.Text = "🔑 Update Password";

            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblNewPass.Location = new System.Drawing.Point(12, 50);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "New Password";

            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(12, 68);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(238, 25);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;

            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPass.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblConfirmPass.Location = new System.Drawing.Point(12, 108);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.TabIndex = 3;
            this.lblConfirmPass.Text = "Confirm Password";

            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 126);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(238, 25);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            this.btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePassword.Location = new System.Drawing.Point(12, 175);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(238, 38);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);

            // pnlUpdateName
            this.pnlUpdateName.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlUpdateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateName.Controls.Add(this.lblUpdateNameTitle);
            this.pnlUpdateName.Controls.Add(this.lblNewName);
            this.pnlUpdateName.Controls.Add(this.txtNewName);
            this.pnlUpdateName.Controls.Add(this.btnUpdateName);
            this.pnlUpdateName.Location = new System.Drawing.Point(310, 20);
            this.pnlUpdateName.Name = "pnlUpdateName";
            this.pnlUpdateName.Size = new System.Drawing.Size(265, 245);
            this.pnlUpdateName.TabIndex = 1;

            this.lblUpdateNameTitle.AutoSize = true;
            this.lblUpdateNameTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUpdateNameTitle.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblUpdateNameTitle.Location = new System.Drawing.Point(12, 12);
            this.lblUpdateNameTitle.Name = "lblUpdateNameTitle";
            this.lblUpdateNameTitle.TabIndex = 0;
            this.lblUpdateNameTitle.Text = "✏️ Update Admin Name";

            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewName.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblNewName.Location = new System.Drawing.Point(12, 50);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.TabIndex = 1;
            this.lblNewName.Text = "New Admin Name";

            this.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewName.Location = new System.Drawing.Point(12, 68);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(238, 25);
            this.txtNewName.TabIndex = 2;

            this.btnUpdateName.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnUpdateName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateName.FlatAppearance.BorderSize = 0;
            this.btnUpdateName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateName.ForeColor = System.Drawing.Color.White;
            this.btnUpdateName.Location = new System.Drawing.Point(12, 115);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(238, 38);
            this.btnUpdateName.TabIndex = 3;
            this.btnUpdateName.Text = "Update Name";
            this.btnUpdateName.UseVisualStyleBackColor = false;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);

            // lblMessage
            this.lblMessage.AutoSize = false;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(20, 365);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(555, 25);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;

            // frmAdminPanel
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Portal - Dashboard";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlUpdatePass.ResumeLayout(false);
            this.pnlUpdatePass.PerformLayout();
            this.pnlUpdateName.ResumeLayout(false);
            this.pnlUpdateName.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlUpdatePass;
        private System.Windows.Forms.Label lblUpdatePassTitle;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Panel pnlUpdateName;
        private System.Windows.Forms.Label lblUpdateNameTitle;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.Label lblMessage;
    }
}
