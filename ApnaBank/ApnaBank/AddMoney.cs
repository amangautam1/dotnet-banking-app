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
    public partial class AddMoney : Form
    {
        public AddMoney()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int amount = int.Parse(txt_amt.Text);
                Account_DB acc = new Account_DB();
                acc.updatebalance(Session.user, amount, "add");
                MessageBox.Show("Amount added");

                Transaction_DB tranc = new Transaction_DB();
                tranc.date = DateTime.Now.ToString();
                tranc.desc = "Amount added";
                tranc.credit = "+"+txt_amt.Text;
                tranc.debit = "";
                tranc.balance = int.Parse(new Account_DB().getBalance(Session.user.id));
                tranc.userid = Session.user.id;
                new Transaction_DB().AddTransaction(tranc);
                this.Close();
            }catch(FormatException ex)
            {
                MessageBox.Show("Enter some amount"+ex); 
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
