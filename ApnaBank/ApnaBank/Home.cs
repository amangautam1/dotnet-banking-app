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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ohterBracnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Coming Soon", "Sorry!", MessageBoxButtons.OK);
        }

        private void createNewUPIIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Coming Soon", "Sorry!", MessageBoxButtons.OK);



        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Session.id ==null)
            {
                LoginForm login = new LoginForm();
                login.MdiParent = this;
                login.Show();
            }
            else
            {
                AccountDetails acc = new AccountDetails();
                acc.MdiParent = this;
                acc.Show();
            }
        }

        private void addMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.id == null)
            {
                MessageBox.Show("You must ligin first");
            }
            else
            {
                AddMoney add = new AddMoney();
                add.MdiParent = this;
                add.Show();
            }
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.id == null)
            {
                MessageBox.Show("You must ligin first");
            }
            else
            {
                WIthdraw wd = new WIthdraw();
                wd.MdiParent = this;
                wd.Show();
            }
        }

        private void sameBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer t = new Transfer();
            t.MdiParent = this;
            t.Show();

        }

        private void mobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recharges rec = new Recharges();
            rec.MdiParent = this;
            rec.Show();
        }

        private void dTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recharges rec = new Recharges();
            rec.MdiParent = this;
            rec.Show();

        }

        private void dataCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recharges rec = new Recharges();
            rec.MdiParent = this;
            rec.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Session.user = null;
            MessageBox.Show("You successfully logged out");
            this.Close();
            new LoginForm().Show();
        }

        private void pospaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recharges rec = new Recharges();
            rec.MdiParent = this;
            rec.Show();
        }

        private void gasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayGas pg = new PayGas();
            pg.MdiParent = this;
            pg.Show();
        }

        private void electricityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayBill ppb = new PayBill();
            ppb.MdiParent = this;
            ppb.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountDetails acc = new AccountDetails();
            acc.MdiParent = this;
            acc.Show();
        }

        private void passbokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statement st = new Statement();
            st.MdiParent = this;
            st.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure want to delete your Account? \n You cannot withdraw your amount after deletion.","Confirm Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                new Users_DB().DeleteUser(Session.user);
                new Transaction_DB().deleteTransactions(Session.user);
                new Account_DB().DeleteAccount(Session.user);
                MessageBox.Show("Account deleted");
                this.Close();
                new LoginForm().Show();
            }
            else
            {
                MessageBox.Show("Great Move");
            }
           
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not Eligible! please contact your nearest branch","Sorry!",MessageBoxButtons.OK);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not Eligible! please contact your nearest branch", "Sorry!", MessageBoxButtons.OK);

        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not Eligible! please contact your nearest branch", "Sorry!", MessageBoxButtons.OK);

        }

        private void waterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enjoy Water Free of cost ....with Apna Bank Account", "Hurrah!", MessageBoxButtons.OK);
        }

        private void uPIToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Coming Soon", "Sorry!", MessageBoxButtons.OK);
        }

        private void homeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AccountDetails acc = new AccountDetails();
            acc.MdiParent = this;
            acc.Show();
        }
    }
}
