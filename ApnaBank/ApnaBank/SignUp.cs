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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users_DB user = new Users_DB();
           
            user.fname = txt_fname.Text;
            user.lname = txt_lname.Text;
            user.email = txt_email.Text;
            user.phone = txt_phone.Text;
            user.aadhar = txt_aadhar.Text;
            user.username = txt_username.Text;
            if (txt_password.Text == txt_conf_password.Text)
            {
                user.password = txt_password.Text;
                user.AddAccount(user);
                MessageBox.Show("Account succesfullly created! you can log in now");
                MessageBox.Show("You ge]ot 500rs credit as your welcome gift.");
                Account_DB acc = new Account_DB();
                user.id = new Users_DB().getID(user.email);
                acc.insertBalanceForNew(user, 500);
                this.Close();
                new LoginForm().Show();
              
            }
            else
            {
                MessageBox.Show("password didnt match!!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
