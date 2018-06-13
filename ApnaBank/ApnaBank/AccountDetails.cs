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
    public partial class AccountDetails : Form
    {
        public AccountDetails()
        {
            InitializeComponent();
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            txt_name.Text = Session.fname +" "+ Session.lname;
            Account_DB acc = new Account_DB();
            txt_balance.Text = acc.getBalance(Session.user.id);
            Console.WriteLine("id" + Session.user.id);
            datadrid_view.AutoGenerateColumns = true;
            Transaction_DB tranc = new Transaction_DB();
            tranc.fillGridTop5(datadrid_view);

            startTimer();
        }
        private void startTimer()
        {
            DateTime time = DateTime.Now;
            lbl_timer.Text = time.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_balance.Text = new Account_DB().getBalance(Session.user.id);
            Transaction_DB tranc = new Transaction_DB();
            tranc.fillGridTop5(datadrid_view);
        }
    }
}
