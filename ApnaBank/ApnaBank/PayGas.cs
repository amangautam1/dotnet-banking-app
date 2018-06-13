using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApnaBank
{
    public partial class PayGas : Form
    {
        public PayGas()
        {
            InitializeComponent();
        }

        private void PayGas_Load(object sender, EventArgs e)
        {
            txt_provider.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(txt_amount.Text);
            String pass = txt_password.Text;
            if (pass == Session.user.password)
            {
                Account_DB acc = new Account_DB();
                acc.updatebalance(Session.user, amt, "withdraw");
                MessageBox.Show("amount paid");
                Transaction_DB tranc = new Transaction_DB();
                tranc.date = DateTime.Now.ToString();
                tranc.desc = "Gas bill paid with cust id: "+txt_cust_id.Text;
                tranc.credit = "";
                tranc.debit = "-" + txt_amount.Text;
                tranc.balance = int.Parse(new Account_DB().getBalance(Session.user.id));
                tranc.userid = Session.user.id;
                new Transaction_DB().AddTransaction(tranc);

                this.Close();
            }
        }
    }
}
