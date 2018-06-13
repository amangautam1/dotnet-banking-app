using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ApnaBank
{
    class Account_DB
    {
        private string id { get; set; }
        private string userid { get; set; }
        private string balance { get; set; } 

        public void insertBalanceForNew(Users_DB user,int bal)
        {
            String query = String.Format("insert into account(userid,balance) values ({0},{1})", user.id, bal);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(query);
        } 
        public void updatebalance(Users_DB user,int amt,String mode)
        {
            if (mode == "add")
            {
                String query = String.Format("update account set balance=balance + {0} where userid={1}", amt,user.id);
                Console.Write(query);
                BuisnessLogic bl = new BuisnessLogic();
                bl.NonQuery(query);

            }
            if (mode == "withdraw")
            {
                String query = String.Format("update account set balance=balance - {0} where userid={1}", amt, user.id);
                BuisnessLogic bl = new BuisnessLogic();
                bl.NonQuery(query);
            }
           
        }
        public void transfer(Users_DB user,int beneficiary,int amt)
        {
            string q1 = String.Format("update account set balance =balance - {0} where userid ={1}", amt, user.id);
            string q2=String.Format("update account set balance =balance + {0} where userid ={1}", amt, beneficiary);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(q1);
            bl.NonQuery(q2);
        }
        public String getBalance(string id)
        {
            string query = String.Format("select balance from Account where userid={0}", @id);
            Console.WriteLine(query);
            BuisnessLogic bl = new BuisnessLogic();
            OleDbDataReader reader = bl.SelectQuery(query);
            if (reader.Read()){
                return (reader[0].ToString());
            }
            else
            {
                Console.WriteLine("Error");
                return "0";
            }
        }

        public void DeleteAccount(Users_DB user)
        {
            String query = String.Format("delete from Account where userid={0}", user.id);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(query);
        }
    }
}
