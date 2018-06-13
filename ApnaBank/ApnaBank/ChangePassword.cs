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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_cng_pass_Click(object sender, EventArgs e)
        {
            Users_DB user = new Users_DB();
            String currpass = txt_curr_pass.Text;
            String new_pass = txt_new_pass.Text;
            if (currpass == Session.user.password)
            {
                if (new_pass == txt_conf_newpass.Text)
                {
                    user.password = new_pass;
                    user.id = Session.user.id;
                    user.ChangePassword(user);
                    MessageBox.Show("Password Succesfully Changed");
                   
                }
                else
                {
                    MessageBox.Show("New Password and Confirm password didnt match");

                }
            }
            else
            {
                MessageBox.Show("Incorrect current password");
            }
        }
    }
}
