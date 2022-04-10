namespace School_Management_System
{
    partial class FormResultUpload
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
            this.resultId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.Label();
            this.sectionId = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtSectionId = new System.Windows.Forms.TextBox();
            this.dgvResultUp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateResult = new System.Windows.Forms.Button();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.txtResultId = new System.Windows.Forms.TextBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultUp)).BeginInit();
            this.SuspendLayout();
            // 
            // resultId
            // 
            this.resultId.AutoSize = true;
            this.resultId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultId.Location = new System.Drawing.Point(34, 64);
            this.resultId.Name = "resultId";
            this.resultId.Size = new System.Drawing.Size(57, 13);
            this.resultId.TabIndex = 0;
            this.resultId.Text = "Result ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade :";
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.studentId.Location = new System.Drawing.Point(31, 152);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(64, 13);
            this.studentId.TabIndex = 2;
            this.studentId.Text = "Student ID :";
            // 
            // sectionId
            // 
            this.sectionId.AutoSize = true;
            this.sectionId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sectionId.Location = new System.Drawing.Point(31, 194);
            this.sectionId.Name = "sectionId";
            this.sectionId.Size = new System.Drawing.Size(60, 13);
            this.sectionId.TabIndex = 3;
            this.sectionId.Text = "Section ID:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(104, 102);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(181, 20);
            this.txtGrade.TabIndex = 5;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(104, 152);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(181, 20);
            this.txtStudentId.TabIndex = 6;
            // 
            // txtSectionId
            // 
            this.txtSectionId.Location = new System.Drawing.Point(104, 194);
            this.txtSectionId.Name = "txtSectionId";
            this.txtSectionId.Size = new System.Drawing.Size(181, 20);
            this.txtSectionId.TabIndex = 7;
            // 
            // dgvResultUp
            // 
            this.dgvResultUp.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvResultUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultUp.Location = new System.Drawing.Point(387, 81);
            this.dgvResultUp.Name = "dgvResultUp";
            this.dgvResultUp.Size = new System.Drawing.Size(357, 273);
            this.dgvResultUp.TabIndex = 8;
            this.dgvResultUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultUp_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(384, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Result :";
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.Location = new System.Drawing.Point(470, 30);
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.Size = new System.Drawing.Size(274, 20);
            this.txtSearchResult.TabIndex = 10;
            this.txtSearchResult.TextChanged += new System.EventHandler(this.txtSearchResult_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(387, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Upload Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateResult
            // 
            this.btnUpdateResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateResult.Location = new System.Drawing.Point(530, 387);
            this.btnUpdateResult.Name = "btnUpdateResult";
            this.btnUpdateResult.Size = new System.Drawing.Size(91, 31);
            this.btnUpdateResult.TabIndex = 12;
            this.btnUpdateResult.Text = "Update Result";
            this.btnUpdateResult.UseVisualStyleBackColor = false;
            this.btnUpdateResult.Click += new System.EventHandler(this.btnUpdateResult_Click);
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteResult.Location = new System.Drawing.Point(653, 387);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(91, 31);
            this.btnDeleteResult.TabIndex = 13;
            this.btnDeleteResult.Text = "Delete Result";
            this.btnDeleteResult.UseVisualStyleBackColor = false;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // txtResultId
            // 
            this.txtResultId.Location = new System.Drawing.Point(104, 61);
            this.txtResultId.Name = "txtResultId";
            this.txtResultId.Size = new System.Drawing.Size(181, 20);
            this.txtResultId.TabIndex = 14;
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.SystemColors.Control;
            this.btnEXIT.Location = new System.Drawing.Point(27, 12);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(68, 34);
            this.btnEXIT.TabIndex = 15;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // FormResultUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.txtResultId);
            this.Controls.Add(this.btnDeleteResult);
            this.Controls.Add(this.btnUpdateResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultUp);
            this.Controls.Add(this.txtSectionId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.sectionId);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultId);
            this.Name = "FormResultUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResultUpload";
            this.Load += new System.EventHandler(this.FormResultUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.Label sectionId;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtSectionId;
        private System.Windows.Forms.DataGridView dgvResultUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateResult;
        private System.Windows.Forms.Button btnDeleteResult;
        private System.Windows.Forms.TextBox txtResultId;
        private System.Windows.Forms.Button btnEXIT;
    }
}