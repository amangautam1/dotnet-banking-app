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
    public partial class WIthdraw : Form
    {
        public WIthdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(txt_wdamt.Text);
            string password = txt_wdpass.Text;
            Account_DB acc = new Account_DB();
            if (password == Session.user.password)
            {
                if (int.Parse(acc.getBalance(Session.user.id)) >= amt)
                {
                    acc.updatebalance(Session.user, amt, "withdraw");
                    MessageBox.Show("you successfully withdraw amount");

                    Transaction_DB tranc = new Transaction_DB();
                    tranc.date = DateTime.Now.ToString();
                    tranc.desc = "Amount withdraw";
                    tranc.credit = "";
                    tranc.debit = "-" + txt_wdamt.Text;
                    tranc.balance = int.Parse(new Account_DB().getBalance(Session.user.id));
                    tranc.userid = Session.user.id;
                    new Transaction_DB().AddTransaction(tranc);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insufficeint Balance");
                }
            }
            else
            {
                MessageBox.Show("incorrect Password");
            }
           
        }

        private void txt_wdpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_wdamt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
