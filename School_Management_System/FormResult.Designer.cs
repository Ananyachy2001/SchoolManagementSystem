namespace School_Management_System
{
    partial class FormResult
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(339, 117);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(432, 244);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Student ID : ";
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.Location = new System.Drawing.Point(123, 126);
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.Size = new System.Drawing.Size(184, 20);
            this.txtSearchResult.TabIndex = 3;
            this.txtSearchResult.TextChanged += new System.EventHandler(this.txtSearchResult_TextChanged);
            this.txtSearchResult.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearchResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(679, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearchResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResult);
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResult";
            this.Load += new System.EventHandler(this.FormResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.Button btnExit;
    }
}