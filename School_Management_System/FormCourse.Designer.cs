namespace School_Management_System
{
    partial class FormCourse
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
            this.courseId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coursePrerequisite = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCoursePrerequisite = new System.Windows.Forms.TextBox();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCourse = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // courseId
            // 
            this.courseId.AutoSize = true;
            this.courseId.BackColor = System.Drawing.SystemColors.Control;
            this.courseId.Location = new System.Drawing.Point(52, 82);
            this.courseId.Name = "courseId";
            this.courseId.Size = new System.Drawing.Size(60, 13);
            this.courseId.TabIndex = 0;
            this.courseId.Text = "Course ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name :";
            // 
            // coursePrerequisite
            // 
            this.coursePrerequisite.AutoSize = true;
            this.coursePrerequisite.BackColor = System.Drawing.SystemColors.Menu;
            this.coursePrerequisite.Location = new System.Drawing.Point(3, 165);
            this.coursePrerequisite.Name = "coursePrerequisite";
            this.coursePrerequisite.Size = new System.Drawing.Size(109, 13);
            this.coursePrerequisite.TabIndex = 2;
            this.coursePrerequisite.Text = "Course PreRequisite :";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(118, 82);
            this.txtCourseId.Multiline = true;
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(214, 20);
            this.txtCourseId.TabIndex = 4;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(118, 121);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(214, 20);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtCoursePrerequisite
            // 
            this.txtCoursePrerequisite.Location = new System.Drawing.Point(118, 165);
            this.txtCoursePrerequisite.Name = "txtCoursePrerequisite";
            this.txtCoursePrerequisite.Size = new System.Drawing.Size(214, 20);
            this.txtCoursePrerequisite.TabIndex = 6;
            // 
            // dgvCourse
            // 
            this.dgvCourse.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Location = new System.Drawing.Point(419, 82);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.Size = new System.Drawing.Size(331, 258);
            this.dgvCourse.TabIndex = 8;
            this.dgvCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourse_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(352, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Course Name:";
            // 
            // txtSearchCourse
            // 
            this.txtSearchCourse.Location = new System.Drawing.Point(469, 42);
            this.txtSearchCourse.Name = "txtSearchCourse";
            this.txtSearchCourse.Size = new System.Drawing.Size(281, 20);
            this.txtSearchCourse.TabIndex = 10;
            this.txtSearchCourse.TextChanged += new System.EventHandler(this.txtSearchCourse_TextChanged);
            this.txtSearchCourse.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearchCourse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddCourse.Location = new System.Drawing.Point(373, 383);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(91, 31);
            this.btnAddCourse.TabIndex = 11;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateCourse.Location = new System.Drawing.Point(508, 383);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(91, 31);
            this.btnUpdateCourse.TabIndex = 12;
            this.btnUpdateCourse.Text = "Update Details";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteCourse.Location = new System.Drawing.Point(632, 383);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(91, 31);
            this.btnDeleteCourse.TabIndex = 13;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(21, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 31);
            this.button4.TabIndex = 14;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtSearchCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.txtCoursePrerequisite);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.coursePrerequisite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseId);
            this.Name = "FormCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Database";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label coursePrerequisite;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCoursePrerequisite;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button button4;
    }
}