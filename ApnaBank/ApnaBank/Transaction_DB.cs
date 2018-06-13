using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace ApnaBank
{
    class Transaction_DB
    {
        public string date { get; set; }
        public string desc { get; set; }
        public string credit { get; set; }
        public string debit { get; set; }
        public string userid { get; set; }
        public int balance { get; set; }
        public void AddTransaction(Transaction_DB transc)
        {
            String query = String.Format("insert into transactions(date_and_time,description, credit, debit,balance,userid) values('{0}','{1}','{2}','{3}','{4}',{5})", transc.date, transc.desc, transc.credit, transc.debit, transc.balance,transc.userid);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(query);
        }
        public void fillGrid(DataGridView GV)
        {
            string query = String.Format("select transaction_id,date_and_time,description,credit,debit,balance from transactions where userid={0}",Session.user.id);
            BuisnessLogic bl = new BuisnessLogic();
            DataSet ds = bl.Adapter(query);
            GV.DataSource = ds.Tables[0];
        }
        public void fillGridTop5(DataGridView GV)
        {
            string query = String.Format("SELECT top 5 date_and_time,description,credit,debit,balance FROM Transactions  where userid={0} order by date_and_time desc", Session.user.id);
            BuisnessLogic bl = new BuisnessLogic();
            DataSet ds = bl.Adapter(query);
            GV.DataSource = ds.Tables[0];
        }
        public void searchStatements(DataGridView GV,String search)
        {
           
            String query = String.Format("SELECT  transaction_id,date_and_time,description,credit,debit,balance from [Transactions] where ([description] like '%" + @search+ "%' or [date_and_time] like '%" + @search + "%') and userid={0}",Session.user.id);
            Console.WriteLine(query);
            BuisnessLogic bl = new BuisnessLogic();
            DataSet ds = bl.Adapter(query);
            GV.DataSource = ds.Tables[0];
        }
        public void deleteTransactions(Users_DB user)
        {
            String query = String.Format("delete from transactions where userid={0}", user.id);
            BuisnessLogic bl = new BuisnessLogic();
            bl.NonQuery(query);
        }

    }
}
