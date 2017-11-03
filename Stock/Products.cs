using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock
{
    public partial class Products : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
    
        public Products()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=ANDRE-PC\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            sda = new SqlDataAdapter(@"select * from Products", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
