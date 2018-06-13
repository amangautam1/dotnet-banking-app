namespace ApnaBank
{
    partial class PayGas
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cust_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_provider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(294, 126);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(185, 20);
            this.txt_password.TabIndex = 18;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pay Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(294, 93);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(185, 20);
            this.txt_amount.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount :";
            // 
            // txt_cust_id
            // 
            this.txt_cust_id.Location = new System.Drawing.Point(294, 57);
            this.txt_cust_id.Name = "txt_cust_id";
            this.txt_cust_id.Size = new System.Drawing.Size(185, 20);
            this.txt_cust_id.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter customer id :";
            // 
            // txt_provider
            // 
            this.txt_provider.FormattingEnabled = true;
            this.txt_provider.Items.AddRange(new object[] {
            "Select ",
            "Indane",
            "Bharat Gas",
            "Other"});
            this.txt_provider.Location = new System.Drawing.Point(294, 21);
            this.txt_provider.Name = "txt_provider";
            this.txt_provider.Size = new System.Drawing.Size(185, 21);
            this.txt_provider.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Gas provider :";
            // 
            // PayGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 261);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cust_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_provider);
            this.Controls.Add(this.label1);
            this.Name = "PayGas";
            this.Text = "PayGas";
            this.Load += new System.EventHandler(this.PayGas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cust_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_provider;
        private System.Windows.Forms.Label label1;
    }
}