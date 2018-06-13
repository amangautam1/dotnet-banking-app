namespace ApnaBank
{
    partial class ChangePassword
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
            this.btn_cng_pass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_curr_pass = new System.Windows.Forms.TextBox();
            this.txt_new_pass = new System.Windows.Forms.TextBox();
            this.txt_conf_newpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cng_pass
            // 
            this.btn_cng_pass.Location = new System.Drawing.Point(274, 136);
            this.btn_cng_pass.Name = "btn_cng_pass";
            this.btn_cng_pass.Size = new System.Drawing.Size(168, 23);
            this.btn_cng_pass.TabIndex = 0;
            this.btn_cng_pass.Text = "Change Passsword";
            this.btn_cng_pass.UseVisualStyleBackColor = true;
            this.btn_cng_pass.Click += new System.EventHandler(this.btn_cng_pass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter New Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Current Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-enter new Password :";
            // 
            // txt_curr_pass
            // 
            this.txt_curr_pass.Location = new System.Drawing.Point(274, 24);
            this.txt_curr_pass.Name = "txt_curr_pass";
            this.txt_curr_pass.Size = new System.Drawing.Size(168, 20);
            this.txt_curr_pass.TabIndex = 5;
            this.txt_curr_pass.UseSystemPasswordChar = true;
            // 
            // txt_new_pass
            // 
            this.txt_new_pass.Location = new System.Drawing.Point(274, 59);
            this.txt_new_pass.Name = "txt_new_pass";
            this.txt_new_pass.Size = new System.Drawing.Size(168, 20);
            this.txt_new_pass.TabIndex = 6;
            this.txt_new_pass.UseSystemPasswordChar = true;
            // 
            // txt_conf_newpass
            // 
            this.txt_conf_newpass.Location = new System.Drawing.Point(274, 95);
            this.txt_conf_newpass.Name = "txt_conf_newpass";
            this.txt_conf_newpass.Size = new System.Drawing.Size(168, 20);
            this.txt_conf_newpass.TabIndex = 7;
            this.txt_conf_newpass.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 265);
            this.Controls.Add(this.txt_conf_newpass);
            this.Controls.Add(this.txt_new_pass);
            this.Controls.Add(this.txt_curr_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cng_pass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cng_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_curr_pass;
        private System.Windows.Forms.TextBox txt_new_pass;
        private System.Windows.Forms.TextBox txt_conf_newpass;
    }
}