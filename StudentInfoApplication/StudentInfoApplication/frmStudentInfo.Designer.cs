namespace StudentInfoApplication
{
    partial class frmStudentInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblStudentIdList = new System.Windows.Forms.Label();
            this.lblFirstNameList = new System.Windows.Forms.Label();
            this.lblLastNameList = new System.Windows.Forms.Label();
            this.lstStudentId = new System.Windows.Forms.ListBox();
            this.lstFirstName = new System.Windows.Forms.ListBox();
            this.lstLastName = new System.Windows.Forms.ListBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Information";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.lblSubtitle.Location = new System.Drawing.Point(28, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(279, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Enter student details and click Submit to add record";
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlInput.Controls.Add(this.lblStudentId);
            this.pnlInput.Controls.Add(this.txtStudentId);
            this.pnlInput.Controls.Add(this.lblLastName);
            this.pnlInput.Controls.Add(this.txtLastName);
            this.pnlInput.Controls.Add(this.lblFirstName);
            this.pnlInput.Controls.Add(this.txtFirstName);
            this.pnlInput.Controls.Add(this.btnSubmit);
            this.pnlInput.Controls.Add(this.btnClear);
            this.pnlInput.Location = new System.Drawing.Point(0, 70);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(700, 110);
            this.pnlInput.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblStudentId.Location = new System.Drawing.Point(25, 15);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(73, 15);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID *";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStudentId.Location = new System.Drawing.Point(25, 35);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(180, 27);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblLastName.Location = new System.Drawing.Point(225, 15);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name *";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLastName.Location = new System.Drawing.Point(225, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblFirstName.Location = new System.Drawing.Point(425, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First name *";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFirstName.Location = new System.Drawing.Point(425, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 27);
            this.txtFirstName.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(625, 33);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(55, 30);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(625, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 25);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlDivider.Location = new System.Drawing.Point(0, 180);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(700, 3);
            this.pnlDivider.TabIndex = 2;
            // 
            // lblStudentIdList
            // 
            this.lblStudentIdList.AutoSize = true;
            this.lblStudentIdList.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentIdList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblStudentIdList.Location = new System.Drawing.Point(25, 195);
            this.lblStudentIdList.Name = "lblStudentIdList";
            this.lblStudentIdList.Size = new System.Drawing.Size(102, 19);
            this.lblStudentIdList.TabIndex = 3;
            this.lblStudentIdList.Text = "Student ID List";
            // 
            // lblFirstNameList
            // 
            this.lblFirstNameList.AutoSize = true;
            this.lblFirstNameList.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblFirstNameList.Location = new System.Drawing.Point(255, 195);
            this.lblFirstNameList.Name = "lblFirstNameList";
            this.lblFirstNameList.Size = new System.Drawing.Size(103, 19);
            this.lblFirstNameList.TabIndex = 4;
            this.lblFirstNameList.Text = "First Name List";
            // 
            // lblLastNameList
            // 
            this.lblLastNameList.AutoSize = true;
            this.lblLastNameList.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastNameList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblLastNameList.Location = new System.Drawing.Point(480, 195);
            this.lblLastNameList.Name = "lblLastNameList";
            this.lblLastNameList.Size = new System.Drawing.Size(101, 19);
            this.lblLastNameList.TabIndex = 5;
            this.lblLastNameList.Text = "Last Name List";
            // 
            // lstStudentId
            // 
            this.lstStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstStudentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstStudentId.FormattingEnabled = true;
            this.lstStudentId.ItemHeight = 17;
            this.lstStudentId.Location = new System.Drawing.Point(25, 220);
            this.lstStudentId.Name = "lstStudentId";
            this.lstStudentId.Size = new System.Drawing.Size(200, 189);
            this.lstStudentId.TabIndex = 6;
            // 
            // lstFirstName
            // 
            this.lstFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstFirstName.FormattingEnabled = true;
            this.lstFirstName.ItemHeight = 17;
            this.lstFirstName.Location = new System.Drawing.Point(245, 220);
            this.lstFirstName.Name = "lstFirstName";
            this.lstFirstName.Size = new System.Drawing.Size(200, 189);
            this.lstFirstName.TabIndex = 7;
            // 
            // lstLastName
            // 
            this.lstLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstLastName.FormattingEnabled = true;
            this.lstLastName.ItemHeight = 17;
            this.lstLastName.Location = new System.Drawing.Point(465, 220);
            this.lstLastName.Name = "lstLastName";
            this.lstLastName.Size = new System.Drawing.Size(200, 189);
            this.lstLastName.TabIndex = 8;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblRecordCount.Location = new System.Drawing.Point(25, 418);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(55, 15);
            this.lblRecordCount.TabIndex = 9;
            this.lblRecordCount.Text = "0 records";
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 445);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lstLastName);
            this.Controls.Add(this.lstFirstName);
            this.Controls.Add(this.lstStudentId);
            this.Controls.Add(this.lblLastNameList);
            this.Controls.Add(this.lblFirstNameList);
            this.Controls.Add(this.lblStudentIdList);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblStudentIdList;
        private System.Windows.Forms.Label lblFirstNameList;
        private System.Windows.Forms.Label lblLastNameList;
        private System.Windows.Forms.ListBox lstStudentId;
        private System.Windows.Forms.ListBox lstFirstName;
        private System.Windows.Forms.ListBox lstLastName;
        private System.Windows.Forms.Label lblRecordCount;
    }
}
