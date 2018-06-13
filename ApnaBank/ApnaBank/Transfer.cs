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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(tx_amt_tsf.Text);
            int benefociary = int.Parse(txt_bf_acc.Text);
            String password = txt_pass_tsf.Text;
            if (password == Session.password)
            {
                Account_DB acc = new Account_DB();
                if(amount<=int.Parse(acc.getBalance(Session.user.id)))
                acc.transfer(Session.user, benefociary, amount);
                MessageBox.Show("Successfullly trasfered");

                Transaction_DB tranc = new Transaction_DB();
                tranc.date = DateTime.Now.ToString();
                tranc.desc = "Amout tranferres to user id :"+txt_bf_acc.Text;
                tranc.credit = "";
                tranc.debit = "-" + tx_amt_tsf.Text;
                tranc.balance = int.Parse(new Account_DB().getBalance(Session.user.id));
                tranc.userid = Session.user.id;
                tranc.AddTransaction(tranc);
                tranc.desc = "Amount recieved from account no. " + Session.user.id;
                tranc.credit = "+" + tx_amt_tsf.Text;
                tranc.debit = "";
                tranc.balance= int.Parse(new Account_DB().getBalance(txt_bf_acc.Text));
                tranc.userid = txt_bf_acc.Text;
                tranc.AddTransaction(tranc);
                this.Close();
             
            }
        }
    }
}
