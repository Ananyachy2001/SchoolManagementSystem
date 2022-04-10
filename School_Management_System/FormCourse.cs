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
    public partial class FormCourse : Form
    {
        //Sql connetion with Connection string from the database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        public FormCourse()
        {
            InitializeComponent();
        }


        public void display() // method 
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Course";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCourse.DataSource = dt; // cmd to show datagridview 

            sqlConnection.Close();

        }



        private void FormCourse_Load(object sender, EventArgs e)
        {
            display();// calling display method
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }


        public void searchData(string searchableText) //method
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Course where Course_Name  LIKE '" + searchableText + "%'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCourse.DataSource = dt;
            sqlConnection.Close();
        }



        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable(); //object creation
            try //Exception Handling
            {
                if (d.Rows.Count >= 0)//using condition

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Course values( '" + txtCourseId.Text + "','" + txtCourseName.Text + "','" + txtCoursePrerequisite.Text + "')";//for user input
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Added successfully.");
                }
                else
                {
                    MessageBox.Show("Adding Failed");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();  //object creation
            try//Exception Handling
            {
                if (d.Rows.Count >= 0)  //using condition

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update  Course set Course_Name= '" + txtCourseName.Text + "',Course_Prerequisite=' " + txtCoursePrerequisite.Text + "' where Course_Id= '" + txtCourseId.Text + "'";
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

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
        
            DataTable d = new DataTable();  //object creation
            try//Exception Handling
            {
                if (d.Rows.Count >= 0)  //using condition

                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Course where Course_Id= '" + txtCourseId.Text + "'";
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
                MessageBox.Show("error");
            }


       
           
        }

        private void txtSearchCourse_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearchCourse.Text.Trim());//for searchbox in course
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// viewing selected items
            {
                DataGridViewRow row = this.dgvCourse.Rows[e.RowIndex];

                txtCourseId.Text = row.Cells[0].Value.ToString();
                txtCourseName.Text = row.Cells[1].Value.ToString();
                txtCoursePrerequisite.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void button4_Click(object sender, EventArgs e)//Back button
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
            
        }
    }
}
