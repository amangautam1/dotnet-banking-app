namespace ApnaBank
{
    partial class Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bf_acc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_amt_tsf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass_tsf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter beneficiary account number";
            // 
            // txt_bf_acc
            // 
            this.txt_bf_acc.Location = new System.Drawing.Point(345, 21);
            this.txt_bf_acc.Name = "txt_bf_acc";
            this.txt_bf_acc.Size = new System.Drawing.Size(131, 20);
            this.txt_bf_acc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter amoutn to transfer";
            // 
            // tx_amt_tsf
            // 
            this.tx_amt_tsf.Location = new System.Drawing.Point(345, 54);
            this.tx_amt_tsf.Name = "tx_amt_tsf";
            this.tx_amt_tsf.Size = new System.Drawing.Size(131, 20);
            this.tx_amt_tsf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your password";
            // 
            // txt_pass_tsf
            // 
            this.txt_pass_tsf.Location = new System.Drawing.Point(345, 86);
            this.txt_pass_tsf.Name = "txt_pass_tsf";
            this.txt_pass_tsf.Size = new System.Drawing.Size(131, 20);
            this.txt_pass_tsf.TabIndex = 5;
            this.txt_pass_tsf.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 169);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pass_tsf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_amt_tsf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_bf_acc);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bf_acc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_amt_tsf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass_tsf;
        private System.Windows.Forms.Button button1;
    }
}