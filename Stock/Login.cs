using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            userbox.Text = "";
            passbox.Text = "";
            userbox.Focus();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANDRE-PC\\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [username],[password] FROM[dbo].[Login] where username = '"+ userbox.Text +"' and password = '"+ passbox.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain stockmain = new StockMain();
                stockmain.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearbutton_Click(sender, e);
            } 
        }
    }
}
