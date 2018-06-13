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
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Statement_Load(object sender, EventArgs e)
        {
            Transaction_DB tranc = new Transaction_DB();
           // tranc.searchStatements(dataGridView1, "amount");
             tranc.fillGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction_DB tranc = new Transaction_DB();

            tranc.searchStatements(dataGridView1, txt_search.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
