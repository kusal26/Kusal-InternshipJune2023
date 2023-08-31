namespace DapperProject
{
    partial class LoadMovie
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
            this.dgvLoadMovie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoadMovie
            // 
            this.dgvLoadMovie.AllowUserToAddRows = false;
            this.dgvLoadMovie.AllowUserToDeleteRows = false;
            this.dgvLoadMovie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvLoadMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadMovie.Location = new System.Drawing.Point(5, 39);
            this.dgvLoadMovie.Name = "dgvLoadMovie";
            this.dgvLoadMovie.ReadOnly = true;
            this.dgvLoadMovie.RowHeadersWidth = 51;
            this.dgvLoadMovie.RowTemplate.Height = 24;
            this.dgvLoadMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadMovie.Size = new System.Drawing.Size(1084, 649);
            this.dgvLoadMovie.TabIndex = 0;
            this.dgvLoadMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadMovie_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie List";
            // 
            // LoadMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoadMovie);
            this.Name = "LoadMovie";
            this.Text = "LoadMovie";
            this.Load += new System.EventHandler(this.LoadMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoadMovie;
        private System.Windows.Forms.Label label1;
    }
}