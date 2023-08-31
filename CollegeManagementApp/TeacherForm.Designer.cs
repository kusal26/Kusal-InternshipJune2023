namespace CollegeManagementApp
{
    partial class TeacherForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTeacherAddress = new System.Windows.Forms.Label();
            this.txtTeacherAddress = new System.Windows.Forms.TextBox();
            this.lblSubjectId = new System.Windows.Forms.Label();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.TeacherGridView = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(160, 358);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 41);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTeacherAddress
            // 
            this.lblTeacherAddress.AutoSize = true;
            this.lblTeacherAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherAddress.Location = new System.Drawing.Point(25, 193);
            this.lblTeacherAddress.Name = "lblTeacherAddress";
            this.lblTeacherAddress.Size = new System.Drawing.Size(71, 20);
            this.lblTeacherAddress.TabIndex = 43;
            this.lblTeacherAddress.Text = "Address";
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.Location = new System.Drawing.Point(160, 193);
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.Size = new System.Drawing.Size(178, 22);
            this.txtTeacherAddress.TabIndex = 42;
            // 
            // lblSubjectId
            // 
            this.lblSubjectId.AutoSize = true;
            this.lblSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectId.Location = new System.Drawing.Point(25, 123);
            this.lblSubjectId.Name = "lblSubjectId";
            this.lblSubjectId.Size = new System.Drawing.Size(78, 20);
            this.lblSubjectId.TabIndex = 41;
            this.lblSubjectId.Text = "SubjectId";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(160, 165);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(178, 22);
            this.txtSubjectId.TabIndex = 40;
            this.txtSubjectId.TextChanged += new System.EventHandler(this.txtSubjectId_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(588, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 22);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(475, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 20);
            this.lblSearch.TabIndex = 38;
            this.lblSearch.Text = "Search";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(25, 72);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(53, 20);
            this.lblname.TabIndex = 37;
            this.lblname.Text = "Name";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(160, 72);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(178, 22);
            this.txtTeacherName.TabIndex = 36;
            // 
            // TeacherGridView
            // 
            this.TeacherGridView.AllowUserToAddRows = false;
            this.TeacherGridView.AllowUserToDeleteRows = false;
            this.TeacherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherGridView.Location = new System.Drawing.Point(370, 72);
            this.TeacherGridView.Name = "TeacherGridView";
            this.TeacherGridView.ReadOnly = true;
            this.TeacherGridView.RowHeadersWidth = 51;
            this.TeacherGridView.RowTemplate.Height = 24;
            this.TeacherGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeacherGridView.Size = new System.Drawing.Size(405, 361);
            this.TeacherGridView.TabIndex = 35;
            this.TeacherGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherGridView_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(29, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 41);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(263, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 41);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(149, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 41);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(29, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 41);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(160, 123);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(178, 24);
            this.comboBoxTeacher.TabIndex = 46;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTeacherAddress);
            this.Controls.Add(this.txtTeacherAddress);
            this.Controls.Add(this.lblSubjectId);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.TeacherGridView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTeacherAddress;
        private System.Windows.Forms.TextBox txtTeacherAddress;
        private System.Windows.Forms.Label lblSubjectId;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.DataGridView TeacherGridView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
    }
}