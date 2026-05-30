namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblInputHeader = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblRatePerHour = new System.Windows.Forms.Label();
            this.txtRatePerHour = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lblResultHeader = new System.Windows.Forms.Label();
            this.pnlResultDivider = new System.Windows.Forms.Panel();
            this.lblFNLabel = new System.Windows.Forms.Label();
            this.lblFirstNameValue = new System.Windows.Forms.Label();
            this.lblLNLabel = new System.Windows.Forms.Label();
            this.lblLastNameValue = new System.Windows.Forms.Label();
            this.lblDeptLabel = new System.Windows.Forms.Label();
            this.lblDepartmentValue = new System.Windows.Forms.Label();
            this.lblJobLabel = new System.Windows.Forms.Label();
            this.lblJobTitleValue = new System.Windows.Forms.Label();
            this.pnlSalaryBox = new System.Windows.Forms.Panel();
            this.lblSalaryHeader = new System.Windows.Forms.Label();
            this.lblSalaryValue = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHistoryHeader = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.pnlSalaryBox.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(870, 65);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💼  Employee Salary Calculator";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158);
            this.lblSubtitle.Location = new System.Drawing.Point(24, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Compute basic salary for part-time employees";

            // pnlAccent
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.pnlAccent.Location = new System.Drawing.Point(0, 65);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(870, 3);
            this.pnlAccent.TabIndex = 1;

            // pnlLeft - input + result
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlLeft.Controls.Add(this.lblInputHeader);
            this.pnlLeft.Controls.Add(this.lblFirstName);
            this.pnlLeft.Controls.Add(this.txtFirstName);
            this.pnlLeft.Controls.Add(this.lblLastName);
            this.pnlLeft.Controls.Add(this.txtLastName);
            this.pnlLeft.Controls.Add(this.lblDepartment);
            this.pnlLeft.Controls.Add(this.txtDepartment);
            this.pnlLeft.Controls.Add(this.lblJobTitle);
            this.pnlLeft.Controls.Add(this.txtJobTitle);
            this.pnlLeft.Controls.Add(this.lblRatePerHour);
            this.pnlLeft.Controls.Add(this.txtRatePerHour);
            this.pnlLeft.Controls.Add(this.lblHoursWorked);
            this.pnlLeft.Controls.Add(this.txtHoursWorked);
            this.pnlLeft.Controls.Add(this.btnCompute);
            this.pnlLeft.Controls.Add(this.btnClear);
            this.pnlLeft.Controls.Add(this.pnlResult);
            this.pnlLeft.Location = new System.Drawing.Point(0, 68);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(550, 530);
            this.pnlLeft.TabIndex = 2;

            this.lblInputHeader.AutoSize = true;
            this.lblInputHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblInputHeader.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblInputHeader.Location = new System.Drawing.Point(20, 15);
            this.lblInputHeader.Name = "lblInputHeader";
            this.lblInputHeader.TabIndex = 0;
            this.lblInputHeader.Text = "Employee Information";

            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblFirstName.Location = new System.Drawing.Point(20, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name";

            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(20, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(235, 25);
            this.txtFirstName.TabIndex = 2;

            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblLastName.Location = new System.Drawing.Point(275, 45);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last name";

            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Location = new System.Drawing.Point(275, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(235, 25);
            this.txtLastName.TabIndex = 4;

            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblDepartment.Location = new System.Drawing.Point(20, 100);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department";

            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDepartment.Location = new System.Drawing.Point(20, 118);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(235, 25);
            this.txtDepartment.TabIndex = 6;

            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblJobTitle.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblJobTitle.Location = new System.Drawing.Point(275, 100);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.TabIndex = 7;
            this.lblJobTitle.Text = "Job title";

            this.txtJobTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJobTitle.Location = new System.Drawing.Point(275, 118);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(235, 25);
            this.txtJobTitle.TabIndex = 8;

            this.lblRatePerHour.AutoSize = true;
            this.lblRatePerHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRatePerHour.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblRatePerHour.Location = new System.Drawing.Point(20, 155);
            this.lblRatePerHour.Name = "lblRatePerHour";
            this.lblRatePerHour.TabIndex = 9;
            this.lblRatePerHour.Text = "Rate per hour (₱)";

            this.txtRatePerHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRatePerHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRatePerHour.Location = new System.Drawing.Point(20, 173);
            this.txtRatePerHour.Name = "txtRatePerHour";
            this.txtRatePerHour.Size = new System.Drawing.Size(235, 25);
            this.txtRatePerHour.TabIndex = 10;

            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoursWorked.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblHoursWorked.Location = new System.Drawing.Point(275, 155);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.TabIndex = 11;
            this.lblHoursWorked.Text = "Total hours worked";

            this.txtHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoursWorked.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoursWorked.Location = new System.Drawing.Point(275, 173);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(235, 25);
            this.txtHoursWorked.TabIndex = 12;

            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(20, 215);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(235, 38);
            this.btnCompute.TabIndex = 13;
            this.btnCompute.Text = "Compute Salary";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(275, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(235, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // pnlResult
            this.pnlResult.BackColor = System.Drawing.Color.White;
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.Controls.Add(this.lblResultHeader);
            this.pnlResult.Controls.Add(this.pnlResultDivider);
            this.pnlResult.Controls.Add(this.lblFNLabel);
            this.pnlResult.Controls.Add(this.lblFirstNameValue);
            this.pnlResult.Controls.Add(this.lblLNLabel);
            this.pnlResult.Controls.Add(this.lblLastNameValue);
            this.pnlResult.Controls.Add(this.lblDeptLabel);
            this.pnlResult.Controls.Add(this.lblDepartmentValue);
            this.pnlResult.Controls.Add(this.lblJobLabel);
            this.pnlResult.Controls.Add(this.lblJobTitleValue);
            this.pnlResult.Controls.Add(this.pnlSalaryBox);
            this.pnlResult.Location = new System.Drawing.Point(20, 268);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(490, 245);
            this.pnlResult.TabIndex = 15;
            this.pnlResult.Visible = false;

            this.lblResultHeader.AutoSize = true;
            this.lblResultHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultHeader.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblResultHeader.Location = new System.Drawing.Point(15, 12);
            this.lblResultHeader.Name = "lblResultHeader";
            this.lblResultHeader.TabIndex = 0;
            this.lblResultHeader.Text = "Employee Result";

            this.pnlResultDivider.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.pnlResultDivider.Location = new System.Drawing.Point(15, 35);
            this.pnlResultDivider.Name = "pnlResultDivider";
            this.pnlResultDivider.Size = new System.Drawing.Size(455, 2);
            this.pnlResultDivider.TabIndex = 1;

            this.lblFNLabel.AutoSize = true;
            this.lblFNLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFNLabel.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblFNLabel.Location = new System.Drawing.Point(15, 48);
            this.lblFNLabel.Name = "lblFNLabel";
            this.lblFNLabel.TabIndex = 2;
            this.lblFNLabel.Text = "First name:";

            this.lblFirstNameValue.AutoSize = true;
            this.lblFirstNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameValue.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblFirstNameValue.Location = new System.Drawing.Point(130, 48);
            this.lblFirstNameValue.Name = "lblFirstNameValue";
            this.lblFirstNameValue.TabIndex = 3;
            this.lblFirstNameValue.Text = "—";

            this.lblLNLabel.AutoSize = true;
            this.lblLNLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLNLabel.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblLNLabel.Location = new System.Drawing.Point(15, 75);
            this.lblLNLabel.Name = "lblLNLabel";
            this.lblLNLabel.TabIndex = 4;
            this.lblLNLabel.Text = "Last name:";

            this.lblLastNameValue.AutoSize = true;
            this.lblLastNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastNameValue.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblLastNameValue.Location = new System.Drawing.Point(130, 75);
            this.lblLastNameValue.Name = "lblLastNameValue";
            this.lblLastNameValue.TabIndex = 5;
            this.lblLastNameValue.Text = "—";

            this.lblDeptLabel.AutoSize = true;
            this.lblDeptLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeptLabel.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblDeptLabel.Location = new System.Drawing.Point(15, 102);
            this.lblDeptLabel.Name = "lblDeptLabel";
            this.lblDeptLabel.TabIndex = 6;
            this.lblDeptLabel.Text = "Department:";

            this.lblDepartmentValue.AutoSize = true;
            this.lblDepartmentValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentValue.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblDepartmentValue.Location = new System.Drawing.Point(130, 102);
            this.lblDepartmentValue.Name = "lblDepartmentValue";
            this.lblDepartmentValue.TabIndex = 7;
            this.lblDepartmentValue.Text = "—";

            this.lblJobLabel.AutoSize = true;
            this.lblJobLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJobLabel.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblJobLabel.Location = new System.Drawing.Point(15, 129);
            this.lblJobLabel.Name = "lblJobLabel";
            this.lblJobLabel.TabIndex = 8;
            this.lblJobLabel.Text = "Job title:";

            this.lblJobTitleValue.AutoSize = true;
            this.lblJobTitleValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblJobTitleValue.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblJobTitleValue.Location = new System.Drawing.Point(130, 129);
            this.lblJobTitleValue.Name = "lblJobTitleValue";
            this.lblJobTitleValue.TabIndex = 9;
            this.lblJobTitleValue.Text = "—";

            // pnlSalaryBox - highlighted salary display
            this.pnlSalaryBox.BackColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.pnlSalaryBox.Controls.Add(this.lblSalaryHeader);
            this.pnlSalaryBox.Controls.Add(this.lblSalaryValue);
            this.pnlSalaryBox.Location = new System.Drawing.Point(15, 168);
            this.pnlSalaryBox.Name = "pnlSalaryBox";
            this.pnlSalaryBox.Size = new System.Drawing.Size(455, 60);
            this.pnlSalaryBox.TabIndex = 10;

            this.lblSalaryHeader.AutoSize = true;
            this.lblSalaryHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalaryHeader.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158);
            this.lblSalaryHeader.Location = new System.Drawing.Point(15, 18);
            this.lblSalaryHeader.Name = "lblSalaryHeader";
            this.lblSalaryHeader.TabIndex = 0;
            this.lblSalaryHeader.Text = "BASIC SALARY:";

            this.lblSalaryValue.AutoSize = true;
            this.lblSalaryValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblSalaryValue.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblSalaryValue.Location = new System.Drawing.Point(215, 12);
            this.lblSalaryValue.Name = "lblSalaryValue";
            this.lblSalaryValue.TabIndex = 1;
            this.lblSalaryValue.Text = "₱ 0.00";

            // pnlRight - history panel
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblHistoryHeader);
            this.pnlRight.Controls.Add(this.lstHistory);
            this.pnlRight.Controls.Add(this.btnClearHistory);
            this.pnlRight.Location = new System.Drawing.Point(555, 68);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(315, 530);
            this.pnlRight.TabIndex = 3;

            this.lblHistoryHeader.AutoSize = true;
            this.lblHistoryHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblHistoryHeader.ForeColor = System.Drawing.Color.FromArgb(22, 27, 34);
            this.lblHistoryHeader.Location = new System.Drawing.Point(15, 15);
            this.lblHistoryHeader.Name = "lblHistoryHeader";
            this.lblHistoryHeader.TabIndex = 0;
            this.lblHistoryHeader.Text = "📋 Salary History";

            this.lstHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 15;
            this.lstHistory.Location = new System.Drawing.Point(15, 42);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(285, 436);
            this.lstHistory.TabIndex = 1;

            this.btnClearHistory.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearHistory.ForeColor = System.Drawing.Color.White;
            this.btnClearHistory.Location = new System.Drawing.Point(15, 488);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(285, 30);
            this.btnClearHistory.TabIndex = 2;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);

            // frmComputeSalary
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 598);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmComputeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary Calculator";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.pnlSalaryBox.ResumeLayout(false);
            this.pnlSalaryBox.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblInputHeader;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblRatePerHour;
        private System.Windows.Forms.TextBox txtRatePerHour;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lblResultHeader;
        private System.Windows.Forms.Panel pnlResultDivider;
        private System.Windows.Forms.Label lblFNLabel;
        private System.Windows.Forms.Label lblFirstNameValue;
        private System.Windows.Forms.Label lblLNLabel;
        private System.Windows.Forms.Label lblLastNameValue;
        private System.Windows.Forms.Label lblDeptLabel;
        private System.Windows.Forms.Label lblDepartmentValue;
        private System.Windows.Forms.Label lblJobLabel;
        private System.Windows.Forms.Label lblJobTitleValue;
        private System.Windows.Forms.Panel pnlSalaryBox;
        private System.Windows.Forms.Label lblSalaryHeader;
        private System.Windows.Forms.Label lblSalaryValue;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblHistoryHeader;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnClearHistory;
    }
}