namespace WordGuessApplication
{
    partial class frmGuessWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWord = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWrongGuess = new System.Windows.Forms.Label();
            this.lstWrongGuess = new System.Windows.Forms.ListBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(109, 40);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(250, 37);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "GUESS WORD";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(107, 101);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(262, 29);
            this.txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(152, 153);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(140, 35);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWrongGuess
            // 
            this.lblWrongGuess.AutoSize = true;
            this.lblWrongGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongGuess.ForeColor = System.Drawing.Color.Red;
            this.lblWrongGuess.Location = new System.Drawing.Point(474, 9);
            this.lblWrongGuess.Name = "lblWrongGuess";
            this.lblWrongGuess.Size = new System.Drawing.Size(106, 17);
            this.lblWrongGuess.TabIndex = 3;
            this.lblWrongGuess.Text = "Wrong Guess";
            // 
            // lstWrongGuess
            // 
            this.lstWrongGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWrongGuess.FormattingEnabled = true;
            this.lstWrongGuess.ItemHeight = 16;
            this.lstWrongGuess.Location = new System.Drawing.Point(460, 40);
            this.lstWrongGuess.Name = "lstWrongGuess";
            this.lstWrongGuess.Size = new System.Drawing.Size(142, 148);
            this.lstWrongGuess.TabIndex = 4;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(50, 17);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score";
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.Location = new System.Drawing.Point(457, 191);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(100, 17);
            this.lblAttempts.TabIndex = 6;
            this.lblAttempts.Text = "Total Attemp";
            // 
            // frmGuessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 211);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lstWrongGuess);
            this.Controls.Add(this.lblWrongGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblWord);
            this.Name = "frmGuessWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Word";
            this.Load += new System.EventHandler(this.frmGuessWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWrongGuess;
        private System.Windows.Forms.ListBox lstWrongGuess;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAttempts;
    }
}

