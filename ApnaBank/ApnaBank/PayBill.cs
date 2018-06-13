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
    public partial class PayBill : Form
    {
        public PayBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String provider = txt_provider.Text;
            String bill_num = txt_bill_number.Text;
            int amt = int.Parse(txt_amount.Text);
            String pass = txt_password.Text;
            if (pass == Session.user.password)
            {
                Account_DB acc = new Account_DB();
                acc.updatebalance(Session.user, amt, "withdraw");
                MessageBox.Show("amoutn paid");
                Transaction_DB tranc = new Transaction_DB();
                tranc.date = DateTime.Now.ToString();
                tranc.desc = "bill paid to bill No. "+bill_num;
                tranc.credit = "";
                tranc.debit = "-" + txt_amount.Text;
                tranc.balance = int.Parse(new Account_DB().getBalance(Session.user.id));
                tranc.userid = Session.user.id;
                new Transaction_DB().AddTransaction(tranc);

                this.Close();
            }
        }

        private void PayBill_Load(object sender, EventArgs e)
        {
            txt_provider.SelectedIndex = 0;
        }
    }
}
