namespace Studentmanagement
{
    partial class Form1
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
            this.Namelbl = new System.Windows.Forms.Label();
            this.Agelbl = new System.Windows.Forms.Label();
            this.Rollnolbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.Savebotton = new System.Windows.Forms.Button();
            this.CancelBotton = new System.Windows.Forms.Button();
            this.DeleteBotton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(12, 45);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(44, 16);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name";
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Location = new System.Drawing.Point(21, 101);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(32, 16);
            this.Agelbl.TabIndex = 1;
            this.Agelbl.Text = "Age";
            this.Agelbl.Click += new System.EventHandler(this.Agelbl_Click);
            // 
            // Rollnolbl
            // 
            this.Rollnolbl.AutoSize = true;
            this.Rollnolbl.Location = new System.Drawing.Point(18, 234);
            this.Rollnolbl.Name = "Rollnolbl";
            this.Rollnolbl.Size = new System.Drawing.Size(49, 16);
            this.Rollnolbl.TabIndex = 2;
            this.Rollnolbl.Text = "RollNo";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Location = new System.Drawing.Point(18, 163);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(58, 16);
            this.Addresslbl.TabIndex = 3;
            this.Addresslbl.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(127, 234);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(242, 22);
            this.txtRoll.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 163);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(127, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(242, 22);
            this.txtAge.TabIndex = 7;
            // 
            // Savebotton
            // 
            this.Savebotton.Location = new System.Drawing.Point(35, 307);
            this.Savebotton.Name = "Savebotton";
            this.Savebotton.Size = new System.Drawing.Size(115, 51);
            this.Savebotton.TabIndex = 8;
            this.Savebotton.Text = "Save";
            this.Savebotton.UseVisualStyleBackColor = true;
            this.Savebotton.Click += new System.EventHandler(this.Savebotton_Click);
            // 
            // CancelBotton
            // 
            this.CancelBotton.Location = new System.Drawing.Point(225, 423);
            this.CancelBotton.Name = "CancelBotton";
            this.CancelBotton.Size = new System.Drawing.Size(115, 51);
            this.CancelBotton.TabIndex = 9;
            this.CancelBotton.Text = "Cancel";
            this.CancelBotton.UseVisualStyleBackColor = true;
            this.CancelBotton.Click += new System.EventHandler(this.CancelBotton_Click);
            // 
            // DeleteBotton
            // 
            this.DeleteBotton.Location = new System.Drawing.Point(24, 423);
            this.DeleteBotton.Name = "DeleteBotton";
            this.DeleteBotton.Size = new System.Drawing.Size(115, 51);
            this.DeleteBotton.TabIndex = 10;
            this.DeleteBotton.Text = "Delete";
            this.DeleteBotton.UseVisualStyleBackColor = true;
            this.DeleteBotton.Click += new System.EventHandler(this.DeleteBotton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(214, 307);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(115, 51);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(375, 51);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.RowHeadersWidth = 51;
            this.StudentGridView.RowTemplate.Height = 24;
            this.StudentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGridView.Size = new System.Drawing.Size(711, 442);
            this.StudentGridView.TabIndex = 12;
            this.StudentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            this.StudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(823, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 22);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(702, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 34);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 515);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteBotton);
            this.Controls.Add(this.CancelBotton);
            this.Controls.Add(this.Savebotton);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Rollnolbl);
            this.Controls.Add(this.Agelbl);
            this.Controls.Add(this.Namelbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.Label Rollnolbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button Savebotton;
        private System.Windows.Forms.Button CancelBotton;
        private System.Windows.Forms.Button DeleteBotton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button SearchButton;
    }
}

