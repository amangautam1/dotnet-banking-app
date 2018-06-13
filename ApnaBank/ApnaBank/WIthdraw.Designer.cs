namespace ApnaBank
{
    partial class WIthdraw
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
            this.txt_wdamt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_wdpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_wdamt
            // 
            this.txt_wdamt.Location = new System.Drawing.Point(321, 9);
            this.txt_wdamt.Name = "txt_wdamt";
            this.txt_wdamt.Size = new System.Drawing.Size(140, 20);
            this.txt_wdamt.TabIndex = 1;
            this.txt_wdamt.TextChanged += new System.EventHandler(this.txt_wdamt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_wdpass
            // 
            this.txt_wdpass.Location = new System.Drawing.Point(321, 37);
            this.txt_wdpass.Name = "txt_wdpass";
            this.txt_wdpass.Size = new System.Drawing.Size(140, 20);
            this.txt_wdpass.TabIndex = 3;
            this.txt_wdpass.UseSystemPasswordChar = true;
            this.txt_wdpass.TextChanged += new System.EventHandler(this.txt_wdpass_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WIthdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_wdpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_wdamt);
            this.Controls.Add(this.label1);
            this.Name = "WIthdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_wdamt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_wdpass;
        private System.Windows.Forms.Button button1;
    }
}