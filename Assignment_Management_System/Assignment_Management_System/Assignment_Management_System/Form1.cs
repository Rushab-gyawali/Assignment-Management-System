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

namespace Assignment_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(TxtPassword != null && TxtUserName != null && TxtPassword.Text != string.Empty && TxtUserName.Text != string.Empty)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-DVUVLAL\RUSHAB;Initial Catalog=Assignment_Management_System;Persist Security Info=True;User ID=sa;Password=Rushab33");
                string query = "Select * from Tbl_Users Where UserName = '" + TxtUserName.Text.Trim() + "' AND Password = '" + TxtPassword.Text.Trim() + "'";
                SqlDataAdapter adt = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    DashBoard objdashboard = new DashBoard();
                    this.Hide();
                    objdashboard.Show();
                }
                else
                {
                    MessageBox.Show("The UserName or password You have Enter do Not matched");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All input");
            }
           
        }
    }
}
