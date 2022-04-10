namespace School_Management_System
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentID = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentGender = new System.Windows.Forms.Label();
            this.StudentDOB = new System.Windows.Forms.Label();
            this.StudentMail = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.FatherName = new System.Windows.Forms.Label();
            this.ParentPhone = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtParentPhone = new System.Windows.Forms.TextBox();
            this.StudentAddress = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.txtStudentAddress = new System.Windows.Forms.RichTextBox();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.SearchName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtStudentGender = new System.Windows.Forms.ComboBox();
            this.txtStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSectionId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentID.Location = new System.Drawing.Point(49, 60);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(64, 13);
            this.StudentID.TabIndex = 0;
            this.StudentID.Text = "Student ID :";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentName.Location = new System.Drawing.Point(32, 92);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(81, 13);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "Student Name :";
            // 
            // StudentGender
            // 
            this.StudentGender.AutoSize = true;
            this.StudentGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentGender.Location = new System.Drawing.Point(25, 130);
            this.StudentGender.Name = "StudentGender";
            this.StudentGender.Size = new System.Drawing.Size(88, 13);
            this.StudentGender.TabIndex = 2;
            this.StudentGender.Text = "Student Gender :";
            // 
            // StudentDOB
            // 
            this.StudentDOB.AutoSize = true;
            this.StudentDOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentDOB.Location = new System.Drawing.Point(37, 159);
            this.StudentDOB.Name = "StudentDOB";
            this.StudentDOB.Size = new System.Drawing.Size(76, 13);
            this.StudentDOB.TabIndex = 3;
            this.StudentDOB.Text = "Student DOB :";
            // 
            // StudentMail
            // 
            this.StudentMail.AutoSize = true;
            this.StudentMail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentMail.Location = new System.Drawing.Point(41, 194);
            this.StudentMail.Name = "StudentMail";
            this.StudentMail.Size = new System.Drawing.Size(72, 13);
            this.StudentMail.TabIndex = 4;
            this.StudentMail.Text = "Student Mail :";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(126, 57);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(176, 20);
            this.txtStudentID.TabIndex = 5;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(126, 89);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(176, 20);
            this.txtStudentName.TabIndex = 6;
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.Location = new System.Drawing.Point(126, 191);
            this.txtStudentMail.Multiline = true;
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.Size = new System.Drawing.Size(176, 20);
            this.txtStudentMail.TabIndex = 9;
            // 
            // FatherName
            // 
            this.FatherName.AutoSize = true;
            this.FatherName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FatherName.Location = new System.Drawing.Point(37, 232);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(74, 13);
            this.FatherName.TabIndex = 10;
            this.FatherName.Text = "Father Name :";
            // 
            // ParentPhone
            // 
            this.ParentPhone.AutoSize = true;
            this.ParentPhone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ParentPhone.Location = new System.Drawing.Point(35, 270);
            this.ParentPhone.Name = "ParentPhone";
            this.ParentPhone.Size = new System.Drawing.Size(78, 13);
            this.ParentPhone.TabIndex = 11;
            this.ParentPhone.Text = "Parent Phone :";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(126, 229);
            this.txtFatherName.Multiline = true;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(176, 20);
            this.txtFatherName.TabIndex = 12;
            // 
            // txtParentPhone
            // 
            this.txtParentPhone.Location = new System.Drawing.Point(126, 267);
            this.txtParentPhone.Name = "txtParentPhone";
            this.txtParentPhone.Size = new System.Drawing.Size(176, 20);
            this.txtParentPhone.TabIndex = 13;
            // 
            // StudentAddress
            // 
            this.StudentAddress.AutoSize = true;
            this.StudentAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentAddress.Location = new System.Drawing.Point(22, 307);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(91, 13);
            this.StudentAddress.TabIndex = 15;
            this.StudentAddress.Text = "Student Address :";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(356, 74);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(414, 253);
            this.dgvStudent.TabIndex = 16;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(126, 307);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(176, 91);
            this.txtStudentAddress.TabIndex = 17;
            this.txtStudentAddress.Text = "";
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(451, 41);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(319, 20);
            this.txtSearchStudent.TabIndex = 18;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            this.txtSearchStudent.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearchStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // SearchName
            // 
            this.SearchName.AutoSize = true;
            this.SearchName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchName.Location = new System.Drawing.Point(366, 44);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(78, 13);
            this.SearchName.TabIndex = 19;
            this.SearchName.Text = "Search Name :";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(369, 359);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 32);
            this.btnAddStudent.TabIndex = 20;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateStudent.Location = new System.Drawing.Point(488, 359);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(103, 32);
            this.btnUpdateStudent.TabIndex = 21;
            this.btnUpdateStudent.Text = "Update Details";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(636, 359);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteStudent.TabIndex = 22;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(28, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtStudentGender
            // 
            this.txtStudentGender.FormattingEnabled = true;
            this.txtStudentGender.Location = new System.Drawing.Point(126, 127);
            this.txtStudentGender.Name = "txtStudentGender";
            this.txtStudentGender.Size = new System.Drawing.Size(176, 21);
            this.txtStudentGender.TabIndex = 24;
            // 
            // txtStudentDOB
            // 
            this.txtStudentDOB.CustomFormat = "dd/MMM/yyyy";
            this.txtStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStudentDOB.Location = new System.Drawing.Point(126, 159);
            this.txtStudentDOB.Name = "txtStudentDOB";
            this.txtStudentDOB.Size = new System.Drawing.Size(176, 20);
            this.txtStudentDOB.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(42, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Section Id :";
            // 
            // txtSectionId
            // 
            this.txtSectionId.Location = new System.Drawing.Point(126, 411);
            this.txtSectionId.Name = "txtSectionId";
            this.txtSectionId.Size = new System.Drawing.Size(176, 20);
            this.txtSectionId.TabIndex = 27;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSectionId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentDOB);
            this.Controls.Add(this.txtStudentGender);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.StudentAddress);
            this.Controls.Add(this.txtParentPhone);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.ParentPhone);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.txtStudentMail);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.StudentMail);
            this.Controls.Add(this.StudentDOB);
            this.Controls.Add(this.StudentGender);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentID);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Database";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentGender;
        private System.Windows.Forms.Label StudentDOB;
        private System.Windows.Forms.Label StudentMail;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.Label FatherName;
        private System.Windows.Forms.Label ParentPhone;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtParentPhone;
        private System.Windows.Forms.Label StudentAddress;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.RichTextBox txtStudentAddress;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label SearchName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox txtStudentGender;
        private System.Windows.Forms.DateTimePicker txtStudentDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSectionId;
    }
}