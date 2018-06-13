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
    public partial class Recharges : Form
    {
        public Recharges()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(txt_amt.Text);
            string password = txt_pass.Text;
            if (password == Session.password)
            {
                Account_DB acc=new Account_DB();
                acc.updatebalance(Session.user, amt, "withdraw");
                MessageBox.Show("Recharge Successfull");
                Transaction_DB tranc = new Transaction_DB();
                tranc.date = DateTime.Now.ToString();
                tranc.desc = "recharge done to No :"+txt_number.Text;
                tranc.credit = "";
                tranc.debit = "-" + txt_amt.Text;
                tranc.balance = int.Parse(new Account_DB().getBalance(Session.user.id));
                tranc.userid = Session.user.id;
                new Transaction_DB().AddTransaction(tranc);

                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_amt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
