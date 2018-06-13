using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
namespace ApnaBank
{
   
    class BuisnessLogic
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        public void openConnection()
        {
            string strusers = ConfigurationManager.ConnectionStrings["ApnaBank.Properties.Settings.ApnaBankConnectionString"].ToString();
            conn = new OleDbConnection(strusers);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        } 
        public void closeConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public OleDbDataReader SelectQuery(string query)
        {
            openConnection();
            cmd = new OleDbCommand(query, conn);
            OleDbDataReader rec = cmd.ExecuteReader();
            return rec;
        }
        public void NonQuery(String query)
        {
            openConnection();
            cmd = new OleDbCommand(query, conn);
            cmd.ExecuteNonQuery();
            closeConnection();
        }
        public DataSet Adapter(string query)
        {
            openConnection();
            cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            closeConnection();
            return ds;
            /* dissconnected database access*/
        }
    }

}
