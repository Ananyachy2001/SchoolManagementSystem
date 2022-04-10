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


namespace School_Management_System
{
    public partial class FormSection : Form
    {
        //Sql connetion with Connection string from the database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        public FormSection()
        {
            InitializeComponent();
        }

        private void FormSection_Load(object sender, EventArgs e)
        {
            display();
        }


        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Section";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSection.DataSource = dt;
            sqlConnection.Close();

        }


        public void searchData(string searchableText)
        {


            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Section where Section_Name  LIKE '" + searchableText + "%'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSection.DataSource = dt;
            sqlConnection.Close();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();

            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Section values( '" + txtSectionId.Text + "','" + txtSectionName.Text + "','" + txtSectionTime.Text + "','" + txtCourseId.Text + "','" + txtTeacherId.Text + "')";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Added successfully.");
                }
                else
                {
                    MessageBox.Show("Check your input again");
                }
            }
            catch { 

                MessageBox.Show("Can't add more than one Teacher"); }


            }

        private void btnUpdateSection_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                

                if (d.Rows.Count >= 0)
                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Section set Section_Name= '" + txtSectionName.Text + "',Teacher_Id= '" + txtTeacherId.Text + "',Section_Time=' " + txtSectionTime.Text + "' where Section_Id= '" + txtSectionId.Text + "'";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update Failed.");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {

                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Section where Section_id= '" + txtSectionId.Text + "'";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Operation Failed.");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


        }

        private void txtSearchSection_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearchSection.Text.Trim());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
            
        }

        private void dgvSection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSection.Rows[e.RowIndex];

                txtSectionId.Text = row.Cells[0].Value.ToString();
                txtSectionName.Text = row.Cells[1].Value.ToString();
                txtSectionTime.Text = row.Cells[2].Value.ToString();
                txtCourseId.Text = row.Cells[3].Value.ToString();
                txtTeacherId.Text = row.Cells[4].Value.ToString();
             
            }
        }
    }
}
