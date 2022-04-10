namespace School_Management_System
{
    partial class FormTeacher
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
            this.teacherId = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.Label();
            this.teacherGender = new System.Windows.Forms.Label();
            this.teacherDOB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherPhone = new System.Windows.Forms.Label();
            this.teacherAddress = new System.Windows.Forms.Label();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherMail = new System.Windows.Forms.TextBox();
            this.txtTeacherPhone = new System.Windows.Forms.TextBox();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTeacherDOB = new System.Windows.Forms.DateTimePicker();
            this.txtTeacherGender = new System.Windows.Forms.ComboBox();
            this.txtTeacherAddress = new System.Windows.Forms.RichTextBox();
            this.search = new System.Windows.Forms.Label();
            this.txtTeacherSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherId
            // 
            this.teacherId.AutoSize = true;
            this.teacherId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherId.Location = new System.Drawing.Point(24, 56);
            this.teacherId.Name = "teacherId";
            this.teacherId.Size = new System.Drawing.Size(65, 13);
            this.teacherId.TabIndex = 0;
            this.teacherId.Text = "Teacher Id :";
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherName.Location = new System.Drawing.Point(16, 88);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(84, 13);
            this.teacherName.TabIndex = 1;
            this.teacherName.Text = "Teacher Name :";
            // 
            // teacherGender
            // 
            this.teacherGender.AutoSize = true;
            this.teacherGender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherGender.Location = new System.Drawing.Point(16, 121);
            this.teacherGender.Name = "teacherGender";
            this.teacherGender.Size = new System.Drawing.Size(91, 13);
            this.teacherGender.TabIndex = 2;
            this.teacherGender.Text = "Teacher Gender :";
            // 
            // teacherDOB
            // 
            this.teacherDOB.AutoSize = true;
            this.teacherDOB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherDOB.Location = new System.Drawing.Point(20, 159);
            this.teacherDOB.Name = "teacherDOB";
            this.teacherDOB.Size = new System.Drawing.Size(79, 13);
            this.teacherDOB.TabIndex = 3;
            this.teacherDOB.Text = "Teacher DOB :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teacher Mail :";
            // 
            // teacherPhone
            // 
            this.teacherPhone.AutoSize = true;
            this.teacherPhone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherPhone.Location = new System.Drawing.Point(16, 234);
            this.teacherPhone.Name = "teacherPhone";
            this.teacherPhone.Size = new System.Drawing.Size(87, 13);
            this.teacherPhone.TabIndex = 5;
            this.teacherPhone.Text = "Teacher Phone :";
            // 
            // teacherAddress
            // 
            this.teacherAddress.AutoSize = true;
            this.teacherAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherAddress.Location = new System.Drawing.Point(9, 267);
            this.teacherAddress.Name = "teacherAddress";
            this.teacherAddress.Size = new System.Drawing.Size(94, 13);
            this.teacherAddress.TabIndex = 6;
            this.teacherAddress.Text = "Teacher Address :";
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(110, 53);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(182, 20);
            this.txtTeacherId.TabIndex = 7;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(110, 88);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(182, 20);
            this.txtTeacherName.TabIndex = 8;
            // 
            // txtTeacherMail
            // 
            this.txtTeacherMail.Location = new System.Drawing.Point(112, 192);
            this.txtTeacherMail.Name = "txtTeacherMail";
            this.txtTeacherMail.Size = new System.Drawing.Size(182, 20);
            this.txtTeacherMail.TabIndex = 11;
            // 
            // txtTeacherPhone
            // 
            this.txtTeacherPhone.Location = new System.Drawing.Point(112, 231);
            this.txtTeacherPhone.Name = "txtTeacherPhone";
            this.txtTeacherPhone.Size = new System.Drawing.Size(182, 20);
            this.txtTeacherPhone.TabIndex = 12;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(321, 81);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.Size = new System.Drawing.Size(470, 286);
            this.dgvTeacher.TabIndex = 14;
            this.dgvTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacher_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(51, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Teacher";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(186, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(334, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 37);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTeacherDOB
            // 
            this.txtTeacherDOB.CustomFormat = "dd-MMM-yyyy";
            this.txtTeacherDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTeacherDOB.Location = new System.Drawing.Point(110, 159);
            this.txtTeacherDOB.Name = "txtTeacherDOB";
            this.txtTeacherDOB.Size = new System.Drawing.Size(185, 20);
            this.txtTeacherDOB.TabIndex = 18;
            // 
            // txtTeacherGender
            // 
            this.txtTeacherGender.FormattingEnabled = true;
            this.txtTeacherGender.Location = new System.Drawing.Point(110, 121);
            this.txtTeacherGender.Name = "txtTeacherGender";
            this.txtTeacherGender.Size = new System.Drawing.Size(182, 21);
            this.txtTeacherGender.TabIndex = 19;
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.Location = new System.Drawing.Point(112, 267);
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.Size = new System.Drawing.Size(182, 128);
            this.txtTeacherAddress.TabIndex = 20;
            this.txtTeacherAddress.Text = "";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search.Location = new System.Drawing.Point(313, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(72, 13);
            this.search.TabIndex = 21;
            this.search.Text = "Search Name";
            // 
            // txtTeacherSearch
            // 
            this.txtTeacherSearch.Location = new System.Drawing.Point(391, 41);
            this.txtTeacherSearch.Name = "txtTeacherSearch";
            this.txtTeacherSearch.Size = new System.Drawing.Size(400, 20);
            this.txtTeacherSearch.TabIndex = 22;
            this.txtTeacherSearch.TextChanged += new System.EventHandler(this.txtTeacherSearch_TextChanged);
            this.txtTeacherSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtTeacherSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(22, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtTeacherSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtTeacherAddress);
            this.Controls.Add(this.txtTeacherGender);
            this.Controls.Add(this.txtTeacherDOB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.txtTeacherPhone);
            this.Controls.Add(this.txtTeacherMail);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.teacherAddress);
            this.Controls.Add(this.teacherPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teacherDOB);
            this.Controls.Add(this.teacherGender);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.teacherId);
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher database";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teacherId;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Label teacherGender;
        private System.Windows.Forms.Label teacherDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label teacherPhone;
        private System.Windows.Forms.Label teacherAddress;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherMail;
        private System.Windows.Forms.TextBox txtTeacherPhone;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker txtTeacherDOB;
        private System.Windows.Forms.ComboBox txtTeacherGender;
        private System.Windows.Forms.RichTextBox txtTeacherAddress;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox txtTeacherSearch;
        private System.Windows.Forms.Button btnBack;
    }
}