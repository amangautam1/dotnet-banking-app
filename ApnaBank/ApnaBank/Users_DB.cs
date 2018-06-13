using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ApnaBank
{
    class Users_DB
    {
        public String id { get; set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String aadhar { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public bool Authenticate(Users_DB user)
        {
            string query = String.Format("select * from users where username='{0}' and 'password={1}'", user.username, user.password);
            BuisnessLogic bl = new BuisnessLogic();
            OleDbDataReader reader=bl.SelectQuery(query);
            if (reader.Read())
            {
                Users_DB ud = new Users_DB();
                ud.id = reader[0].ToString();
                ud.fname = reader[1].ToString();
                ud.lname = reader[2].ToString();
                ud.email = reader[3].ToString();
                ud.phone = reader[4].ToString();
                ud.aadhar = reader[5].ToString();
                ud.username = reader[6].ToString();
                ud.password = reader[7].ToString();
                Session.CreateSession(ud);
             return true;
            }
            else{
                return false;
            }
        }
        public void AddAccount(Users_DB user)
        {
            String query = String.Format("insert into [users]([fname],[lname],[email],[phone],[aadhar],[username],[password]) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",user.fname,user.lname,user.email,user.phone,user.aadhar,user.username,user.password);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(query);
        }
        public void ChangePassword(Users_DB user)
        {
            String queruy = String.Format("update [users] set [password]='{0}' where [id]={1}", user.password, user.id);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(queruy);
        }
        public void DeleteUser(Users_DB user)
        {
            String query = String.Format("delete from users where id={0}", user.id);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(query);
        }
        public String getID(string email)
        {
            string query = String.Format("select id from users where email='{0}'", email);
            BuisnessLogic bl = new BuisnessLogic();
            OleDbDataReader reader = bl.SelectQuery(query);
            if (reader.Read())
            {
                return (reader[0].ToString());
            }
            else
            {
                return "0";
            }
        }
    }
}
