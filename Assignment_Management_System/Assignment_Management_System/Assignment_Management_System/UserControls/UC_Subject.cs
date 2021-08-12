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

namespace Assignment_Management_System.UserControls
{
    public partial class UC_Subject : UserControl
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        //SqlDataReader dr;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public UC_Subject()
        {
            InitializeComponent();
        }

        private void UC_Subject_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-DVUVLAL\RUSHAB;Initial Catalog=Assignment_Management_System;Persist Security Info=True;User ID=sa;Password=Rushab33");
            cn.Open();
            //bind data in data grid view  
            GetAllSubjects();
            Update.Enabled = false;
            Delete.Enabled = false;
        }

        private void GetAllSubjects() 
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from Tbl_Subjects (nolock) where IsActive = 1", cn);
            da.Fill(dt);
            DataGridSubject.DataSource = dt;
            cn.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(TxtDescription.Text != string.Empty && TxtSubject.Text != string.Empty)
            {
                cmd = new SqlCommand("Proc_subject", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "Insert");
                cmd.Parameters.AddWithValue("@Subject", TxtSubject.Text);
                cmd.Parameters.AddWithValue("@Description", TxtDescription.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllSubjects();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (TxtDescription.Text != string.Empty && TxtSubject.Text != string.Empty)
            {
                cn.Open();
                cmd = new SqlCommand("Proc_subject", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "Update");
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@Subject", TxtSubject.Text);
                cmd.Parameters.AddWithValue("@Description", TxtDescription.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updates successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllSubjects();
                ClearData();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TxtDescription.Text != string.Empty && TxtSubject.Text != string.Empty)
            {
                cn.Open();
                cmd = new SqlCommand("Proc_subject", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "Delete");
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllSubjects();
                ClearData();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearData()
        {
            TxtDescription.Text = "";
            TxtSubject.Text = "";
        }

        private void DataGridSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridSubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DataGridSubject_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataGridSubject.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtSubject.Text = DataGridSubject.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtDescription.Text = DataGridSubject.Rows[e.RowIndex].Cells[2].Value.ToString();

            Add.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;
        }

        private void TxtSubject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
