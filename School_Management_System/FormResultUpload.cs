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
    public partial class FormResultUpload : Form
    {
        //Sql connetion with Connection string from the database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        public FormResultUpload()
        {
            InitializeComponent();
        }

        private void FormResultUpload_Load(object sender, EventArgs e)
        {
            display();
        }


        public void display() //method
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Result";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvResultUp.DataSource = dt;

            sqlConnection.Close();

        }


        public void searchData(string searchableText) //method
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Result where Result_Id  LIKE '" + searchableText + "%'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvResultUp.DataSource = dt;
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Adding Result
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Result values( '" + txtResultId.Text + "','" + txtGrade.Text + "','" + txtStudentId.Text + "','" + txtSectionId.Text + "')";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Added successfully.");
                }
                else
                {
                    MessageBox.Show("Result is not added");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUpdateResult_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Result set Result_Grade= '" + txtGrade.Text + "' where Student_Id= '" + txtResultId.Text + "'";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {

                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Result where Result_Id= '" + txtResultId.Text + "'";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Oparetion Failed");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }




        private void txtSearchResult_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearchResult.Text.Trim());
        }

        private void txtResultId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvResultUp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// viewing selected items
            {
                DataGridViewRow row = this.dgvResultUp.Rows[e.RowIndex];

                txtResultId.Text = row.Cells[0].Value.ToString();
                txtGrade.Text = row.Cells[1].Value.ToString();
                txtStudentId.Text = row.Cells[2].Value.ToString();
                txtSectionId.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
