namespace School_Management_System
{
    partial class FormSection
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
            this.sectionId = new System.Windows.Forms.Label();
            this.sectionName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSectionId = new System.Windows.Forms.TextBox();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.txtSectionTime = new System.Windows.Forms.TextBox();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            this.searchSection = new System.Windows.Forms.Label();
            this.txtSearchSection = new System.Windows.Forms.TextBox();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnUpdateSection = new System.Windows.Forms.Button();
            this.btnDeleteSection = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.teacherId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionId
            // 
            this.sectionId.AutoSize = true;
            this.sectionId.BackColor = System.Drawing.SystemColors.Control;
            this.sectionId.Location = new System.Drawing.Point(26, 66);
            this.sectionId.Name = "sectionId";
            this.sectionId.Size = new System.Drawing.Size(60, 13);
            this.sectionId.TabIndex = 0;
            this.sectionId.Text = "Section ID:";
            // 
            // sectionName
            // 
            this.sectionName.AutoSize = true;
            this.sectionName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sectionName.Location = new System.Drawing.Point(12, 108);
            this.sectionName.Name = "sectionName";
            this.sectionName.Size = new System.Drawing.Size(80, 13);
            this.sectionName.TabIndex = 1;
            this.sectionName.Text = "Section Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Section Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(26, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course ID :";
            // 
            // txtSectionId
            // 
            this.txtSectionId.Location = new System.Drawing.Point(92, 63);
            this.txtSectionId.Name = "txtSectionId";
            this.txtSectionId.Size = new System.Drawing.Size(202, 20);
            this.txtSectionId.TabIndex = 4;
            // 
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(92, 105);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(202, 20);
            this.txtSectionName.TabIndex = 5;
            // 
            // txtSectionTime
            // 
            this.txtSectionTime.Location = new System.Drawing.Point(92, 160);
            this.txtSectionTime.Name = "txtSectionTime";
            this.txtSectionTime.Size = new System.Drawing.Size(202, 20);
            this.txtSectionTime.TabIndex = 6;
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(92, 212);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(202, 20);
            this.txtCourseId.TabIndex = 7;
            // 
            // dgvSection
            // 
            this.dgvSection.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSection.Location = new System.Drawing.Point(370, 78);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.Size = new System.Drawing.Size(372, 236);
            this.dgvSection.TabIndex = 10;
            this.dgvSection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSection_CellContentClick);
            // 
            // searchSection
            // 
            this.searchSection.AutoSize = true;
            this.searchSection.Location = new System.Drawing.Point(326, 33);
            this.searchSection.Name = "searchSection";
            this.searchSection.Size = new System.Drawing.Size(83, 13);
            this.searchSection.TabIndex = 11;
            this.searchSection.Text = "Search Section:";
            // 
            // txtSearchSection
            // 
            this.txtSearchSection.Location = new System.Drawing.Point(415, 30);
            this.txtSearchSection.Name = "txtSearchSection";
            this.txtSearchSection.Size = new System.Drawing.Size(327, 20);
            this.txtSearchSection.TabIndex = 12;
            this.txtSearchSection.TextChanged += new System.EventHandler(this.txtSearchSection_TextChanged);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Location = new System.Drawing.Point(370, 360);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(93, 32);
            this.btnAddSection.TabIndex = 13;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnUpdateSection
            // 
            this.btnUpdateSection.Location = new System.Drawing.Point(512, 360);
            this.btnUpdateSection.Name = "btnUpdateSection";
            this.btnUpdateSection.Size = new System.Drawing.Size(93, 32);
            this.btnUpdateSection.TabIndex = 14;
            this.btnUpdateSection.Text = "Update Section";
            this.btnUpdateSection.UseVisualStyleBackColor = true;
            this.btnUpdateSection.Click += new System.EventHandler(this.btnUpdateSection_Click);
            // 
            // btnDeleteSection
            // 
            this.btnDeleteSection.Location = new System.Drawing.Point(649, 360);
            this.btnDeleteSection.Name = "btnDeleteSection";
            this.btnDeleteSection.Size = new System.Drawing.Size(93, 32);
            this.btnDeleteSection.TabIndex = 15;
            this.btnDeleteSection.Text = "Delete";
            this.btnDeleteSection.UseVisualStyleBackColor = true;
            this.btnDeleteSection.Click += new System.EventHandler(this.btnDeleteSection_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 32);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(92, 274);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(202, 20);
            this.txtTeacherId.TabIndex = 9;
            // 
            // teacherId
            // 
            this.teacherId.AutoSize = true;
            this.teacherId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherId.Location = new System.Drawing.Point(22, 277);
            this.teacherId.Name = "teacherId";
            this.teacherId.Size = new System.Drawing.Size(70, 13);
            this.teacherId.TabIndex = 8;
            this.teacherId.Text = "Teacher  ID :";
            // 
            // FormSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSection);
            this.Controls.Add(this.btnUpdateSection);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.txtSearchSection);
            this.Controls.Add(this.searchSection);
            this.Controls.Add(this.dgvSection);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.teacherId);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.txtSectionTime);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.txtSectionId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sectionName);
            this.Controls.Add(this.sectionId);
            this.Name = "FormSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSection";
            this.Load += new System.EventHandler(this.FormSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sectionId;
        private System.Windows.Forms.Label sectionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSectionId;
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.TextBox txtSectionTime;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.DataGridView dgvSection;
        private System.Windows.Forms.Label searchSection;
        private System.Windows.Forms.TextBox txtSearchSection;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnUpdateSection;
        private System.Windows.Forms.Button btnDeleteSection;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label teacherId;
    }
}