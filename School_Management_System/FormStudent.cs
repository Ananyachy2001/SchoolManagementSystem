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
    public partial class FormStudent : Form
    {
        //Sql connetion with Connection string from the database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");

        public enum GenderEnum
        {
            None = 0,
            Male = 1,
            Female = 2

        }

        public FormStudent()
        {
            InitializeComponent();
            txtStudentGender.DataSource = Enum.GetValues(typeof(GenderEnum));
        }


        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvStudent.DataSource = dt;

            sqlConnection.Close();

        }



        public void searchData(string searchableText)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where Student_Name  LIKE '" + searchableText + "%'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvStudent.DataSource = dt;
            sqlConnection.Close();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Student values( '" + txtStudentID.Text + "','" + txtStudentName.Text + "','" + (int)txtStudentGender.SelectedItem + "','" + txtStudentDOB.Text + "','" + txtStudentMail.Text + "','" + txtFatherName.Text + "','" + txtParentPhone.Text + "','" + txtStudentAddress.Text + "','" + txtSectionId.Text + "')";
                    cmd.ExecuteNonQuery();


                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Added successfully.");
                }
                else
                {
                    MessageBox.Show("Adding error");
                }
            }
            catch
            {
                MessageBox.Show(" Can't add two students with the same ID");
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Student set Student_Name= '" + txtStudentName.Text + "',Student_Gender=' " + (int)txtStudentGender.SelectedItem + "',Student_DOB=' " + txtStudentDOB.Text + "',Student_Mail=' " + txtStudentMail.Text + "',Father_Name=' " + txtFatherName.Text + "',Parent_Phone=' " + txtParentPhone.Text + "',Student_Address=' " + txtStudentAddress.Text + "' where Student_Id= '" + txtStudentID.Text + "'";
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

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count == 1)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Student where Student_Id= '" + txtStudentID.Text + "'";
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
           // if (e.KeyCode == Keys.Enter)
            //{
           //     searchData(txtTeacherSearch.Text.Trim());
           // }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearchStudent.Text.Trim());
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStudent.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtStudentName.Text = row.Cells[1].Value.ToString();
                txtStudentGender.SelectedItem = (GenderEnum)int.Parse(row.Cells[2].Value.ToString());
                txtStudentDOB.Text = row.Cells[3].Value.ToString();
                txtStudentMail.Text = row.Cells[4].Value.ToString();
                txtFatherName.Text = row.Cells[5].Value.ToString();
                txtParentPhone.Text = row.Cells[6].Value.ToString();
                txtStudentAddress.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
            
        }
    }
}
