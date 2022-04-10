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
    public partial class FormMain : Form
    {
        //Sql connetion with Connection string from the database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTeacher_Click(object sender, EventArgs e)//
        {
            FormTeacher FormTeacher = new FormTeacher();
            FormTeacher.Show();
            this.Hide();
            
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FormStudent FormStudent = new FormStudent();
            FormStudent.Show();
            this.Hide();
            
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            FormCourse FormCourse = new FormCourse();
            FormCourse.Show();
            this.Hide();
            
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            FormSection FormSection = new FormSection();
            FormSection.Show();
            this.Hide();
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            FormResult FormResult = new FormResult();
            FormResult.Show();
            this.Hide();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUser FormUser = new FormUser();
            FormUser.Show();
            this.Hide();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
