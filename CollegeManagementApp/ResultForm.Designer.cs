namespace CollegeManagementApp
{
    partial class ResultForm
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
            this.btnSubjTeachStud = new System.Windows.Forms.Button();
            this.btnSubjTeach = new System.Windows.Forms.Button();
            this.btnSubjStud = new System.Windows.Forms.Button();
            this.ResultdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(468, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 93);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back\r\n";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubjTeachStud
            // 
            this.btnSubjTeachStud.Location = new System.Drawing.Point(319, 354);
            this.btnSubjTeachStud.Name = "btnSubjTeachStud";
            this.btnSubjTeachStud.Size = new System.Drawing.Size(116, 93);
            this.btnSubjTeachStud.TabIndex = 8;
            this.btnSubjTeachStud.Text = "OrderBy \r\nSubjects,Student ,Teacher\r\n";
            this.btnSubjTeachStud.UseVisualStyleBackColor = true;
            this.btnSubjTeachStud.Click += new System.EventHandler(this.btnSubjTeachStud_Click);
            // 
            // btnSubjTeach
            // 
            this.btnSubjTeach.Location = new System.Drawing.Point(164, 354);
            this.btnSubjTeach.Name = "btnSubjTeach";
            this.btnSubjTeach.Size = new System.Drawing.Size(126, 93);
            this.btnSubjTeach.TabIndex = 7;
            this.btnSubjTeach.Text = "OrderBy \r\nSubjects,Teacher\r\n";
            this.btnSubjTeach.UseVisualStyleBackColor = true;
            this.btnSubjTeach.Click += new System.EventHandler(this.btnSubjTeach_Click);
            // 
            // btnSubjStud
            // 
            this.btnSubjStud.Location = new System.Drawing.Point(13, 354);
            this.btnSubjStud.Name = "btnSubjStud";
            this.btnSubjStud.Size = new System.Drawing.Size(130, 93);
            this.btnSubjStud.TabIndex = 6;
            this.btnSubjStud.Text = "OrderBy \r\nSubjects,Student ";
            this.btnSubjStud.UseVisualStyleBackColor = true;
            this.btnSubjStud.Click += new System.EventHandler(this.btnSubjStud_Click);
            // 
            // ResultdataGridView
            // 
            this.ResultdataGridView.AllowUserToAddRows = false;
            this.ResultdataGridView.AllowUserToDeleteRows = false;
            this.ResultdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultdataGridView.Location = new System.Drawing.Point(1, 4);
            this.ResultdataGridView.Name = "ResultdataGridView";
            this.ResultdataGridView.ReadOnly = true;
            this.ResultdataGridView.RowHeadersWidth = 51;
            this.ResultdataGridView.RowTemplate.Height = 24;
            this.ResultdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultdataGridView.Size = new System.Drawing.Size(799, 312);
            this.ResultdataGridView.TabIndex = 5;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubjTeachStud);
            this.Controls.Add(this.btnSubjTeach);
            this.Controls.Add(this.btnSubjStud);
            this.Controls.Add(this.ResultdataGridView);
            this.Name = "ResultForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ResultdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubjTeachStud;
        private System.Windows.Forms.Button btnSubjTeach;
        private System.Windows.Forms.Button btnSubjStud;
        private System.Windows.Forms.DataGridView ResultdataGridView;
    }
}

