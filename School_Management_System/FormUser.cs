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
    public partial class FormUser : Form
    {
        //Sql connetion with Connection string from the database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        public FormUser()
        {
            InitializeComponent();
        }


        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvUser.DataSource = dt;

            sqlConnection.Close();

        }

        private void FormUser_Load(object sender, EventArgs e)
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
                    cmd.CommandText = "insert into login values( '" + txtUser.Text + "','" + txtPassword.Text + "','" + txtUserType.SelectedItem + "')";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Added successfully.");
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
                    cmd.CommandText = "update  login set password= '" + txtPassword.Text + "' where username= '" + txtUser.Text + "'";
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
                    cmd.CommandText = "delete from login where username= '" + txtUser.Text + "'";
                    cmd.ExecuteNonQuery();

                    sqlConnection.Close();
                    display();

                    MessageBox.Show("Deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }



        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUser.Rows[e.RowIndex];

                txtUser.Text = row.Cells[0].Value.ToString();
                txtPassword.Text = row.Cells[1].Value.ToString();
            }
        }



        public void searchData(string searchableText)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login where username  LIKE '" + searchableText + "%'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvUser.DataSource = dt;
            sqlConnection.Close();
        }



        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchData(txtSearchUser.Text.Trim());
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
            
        }
    }
}
