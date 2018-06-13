namespace ApnaBank
{
    partial class AccountDetails
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
            this.txt_name = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.Label();
            this.datadrid_view = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datadrid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ,";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Location = new System.Drawing.Point(77, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(33, 13);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "name";
            this.txt_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.Location = new System.Drawing.Point(508, 13);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(153, 23);
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance :";
            // 
            // txt_balance
            // 
            this.txt_balance.AutoSize = true;
            this.txt_balance.Location = new System.Drawing.Point(77, 45);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(21, 13);
            this.txt_balance.TabIndex = 4;
            this.txt_balance.Text = "bal";
            // 
            // datadrid_view
            // 
            this.datadrid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadrid_view.Location = new System.Drawing.Point(113, 121);
            this.datadrid_view.Name = "datadrid_view";
            this.datadrid_view.Size = new System.Drawing.Size(548, 171);
            this.datadrid_view.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last 5 Transactions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datadrid_view);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "AccountDetails";
            this.Text = "AccountDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datadrid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_balance;
        private System.Windows.Forms.DataGridView datadrid_view;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}