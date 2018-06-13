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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users_DB user = new Users_DB();
            user.username = txt_uname.Text;
            user.password = txt_pass.Text;
            bool res=user.Authenticate(user);
            if (res)
            {
                MessageBox.Show("Login Successfull");
             
                new Home().Show();
                this.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp siup = new SignUp();
            //siup.MdiParent =new  Home();
            siup.Show();
        }
    }
}
