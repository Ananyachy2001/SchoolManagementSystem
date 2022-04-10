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
    public partial class formLogin : Form
    {


        public formLogin()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Sql connetion with Connection string from the database
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from login where username='" + txtName.Text.Trim() + "' and password= '" + txtPassword.Text.Trim() + "' "; //query run
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);//connecting the query with sqlConnection
            DataTable dt = new DataTable();//object creation
            sqlDataAdapter.Fill(dt);
            string cmbItemValue = txtUserType.SelectedItem.ToString();//UserType Selection

            if (dt.Rows.Count == 1)// nested if
            {
                for(int i =0;i<dt.Rows.Count; i++)// using loop for index
                {
                    if(dt.Rows[i]["userType"].ToString()==cmbItemValue)
                    {
                        
                            if (txtUserType.SelectedIndex == 0)
                        {
                            FormMain F = new FormMain();//object creation of FormMain
                            F.Show();   //to show FormMain
                            this.Hide();    //to hide loginForm
                            

                        }
                        if(txtUserType.SelectedIndex == 1)
                        {
                            FormResultUpload FRU = new FormResultUpload();
                            FRU.Show();
                            
                            this.Hide();    //to hide loginForm
                            
                        }
                        if (txtUserType.SelectedIndex == 2)
                        {
                            FormResult FR = new FormResult();
                            FR.Show();
                            this.Hide();    //to hide loginForm
                            
                        }

                    }

                }



            }
            else
            {
                MessageBox.Show("Check your username and password");
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
