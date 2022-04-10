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
    public partial class FormTeacher : Form
    {
        //Sql connetion with Connection string from the database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        
        public enum GenderEnum
        {
            None=0,
            Male=1,
            Female=2

        }
        
        
        
        public FormTeacher()
        {
            InitializeComponent();
            txtTeacherGender.DataSource = Enum.GetValues(typeof(GenderEnum));
        }


        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Teacher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvTeacher.DataSource = dt;

            sqlConnection.Close();

        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Teacher values( '" + txtTeacherId.Text + "','" + txtTeacherName.Text + "','" + (int)txtTeacherGender.SelectedItem + "','" + txtTeacherDOB.Text + "','" + txtTeacherMail.Text + "','" + txtTeacherPhone.Text + "','" + txtTeacherAddress.Text + "')";
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
                MessageBox.Show("Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Teacher set Teacher_Name= '" + txtTeacherName.Text + "',Teacher_Gender=' " + (int)txtTeacherGender.SelectedItem + "',Teacher_DOB=' " + txtTeacherDOB.Text + "',Teacher_Mail=' " + txtTeacherMail.Text + "',Teacher_Phone=' " + txtTeacherPhone.Text + "',Teacher_Address=' " + txtTeacherAddress.Text + "' where Teacher_Id= '" + txtTeacherId.Text + "'";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            try
            {
                if (d.Rows.Count >= 0)

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Teacher where Teacher_Id= '" + txtTeacherId.Text + "'";
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

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTeacher.Rows[e.RowIndex];

                txtTeacherId.Text = row.Cells[0].Value.ToString();
                txtTeacherName.Text = row.Cells[1].Value.ToString();
                txtTeacherGender.SelectedItem = (GenderEnum)int.Parse(row.Cells[2].Value.ToString());
                txtTeacherDOB.Text = row.Cells[3].Value.ToString();
                txtTeacherMail.Text = row.Cells[4].Value.ToString();
                txtTeacherPhone.Text = row.Cells[5].Value.ToString();
                txtTeacherAddress.Text = row.Cells[6].Value.ToString();
            }
        }

        private void txtTeacherSearch_TextChanged(object sender, EventArgs e)
        {
            //searchData(txtTeacherSearch.Text.Trim());
        }


        public void searchData(string searchableText)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Teacher where Teacher_Name  LIKE '" + searchableText  +"%'" ;
            
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvTeacher.DataSource = dt;
            sqlConnection.Close();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                searchData(txtTeacherSearch.Text.Trim());
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
