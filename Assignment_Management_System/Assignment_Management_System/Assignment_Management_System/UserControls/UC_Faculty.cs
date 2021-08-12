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
    public partial class UC_Faculty : UserControl
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        public UC_Faculty()
        {
            InitializeComponent();
        }

        private void GetAllTeachers()
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from Tbl_Teachers(nolock) where IsActive = 1 ", cn);
            da.Fill(dt);
            DataGridTeacher.DataSource = dt;
            cn.Close();
        }       

        private void UC_Faculty_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-DVUVLAL\RUSHAB;Initial Catalog=Assignment_Management_System;Persist Security Info=True;User ID=sa;Password=Rushab33");
            cn.Open();

            //bind data in data grid view  
            GetAllTeachers();
            Update.Enabled = false;
            Delete.Enabled = false;

            //to add data in combobox
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select RowId,Subject from tbl_subjects(nolock) where IsActive = 1", cn);
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            Combo_Faculty.DataSource = dt;
            Combo_Faculty.DisplayMember = "Subject";
            Combo_Faculty.ValueMember = "RowId";
        }

        private void ClearData()
        {
            TxtTeacher.Text = "";
            Combo_Faculty.Text = "Please select";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (Combo_Faculty.Text != string.Empty && TxtTeacher.Text != string.Empty && Combo_Faculty.Text != "Please select")
            {
                cmd = new SqlCommand("Proc_Teacher", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "Insert");
                cmd.Parameters.AddWithValue("@Subject", Combo_Faculty.Text);
                cmd.Parameters.AddWithValue("@Teacher", TxtTeacher.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllTeachers();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cn.Close();
        }

        private void DataGridTeacher_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void DataGridTeacher_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataGridTeacher.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtTeacher.Text = DataGridTeacher.Rows[e.RowIndex].Cells[1].Value.ToString();
            Combo_Faculty.Text = DataGridTeacher.Rows[e.RowIndex].Cells[2].Value.ToString();

            Add.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Combo_Faculty.Text != string.Empty && TxtTeacher.Text != string.Empty && Combo_Faculty.Text != "Please select")
            {
                cn.Open();
                cmd = new SqlCommand("Proc_Teacher", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "Update");
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@Subject", Combo_Faculty.Text);
                cmd.Parameters.AddWithValue("@Teacher", TxtTeacher.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updates successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllTeachers();
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
            if (Combo_Faculty.Text != string.Empty && TxtTeacher.Text != string.Empty && Combo_Faculty.Text != "Please select")
            {
                cn.Open();
                cmd = new SqlCommand("Proc_Teacher", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", "Delete");
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllTeachers();
                ClearData();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
