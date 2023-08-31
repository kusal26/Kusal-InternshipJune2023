namespace DapperProject
{
    partial class ViewForm
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
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.Label();
            this.lblmoviename = new System.Windows.Forms.Label();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.txtdirector = new System.Windows.Forms.TextBox();
            this.txtruntime = new System.Windows.Forms.TextBox();
            this.txtmoviename = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 12);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(1067, 511);
            this.dgvView.TabIndex = 0;
            this.dgvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(975, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 122);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Director";
            // 
            // txtDuration
            // 
            this.txtDuration.AutoSize = true;
            this.txtDuration.BackColor = System.Drawing.Color.Transparent;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.ForeColor = System.Drawing.Color.White;
            this.txtDuration.Location = new System.Drawing.Point(10, 662);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(85, 25);
            this.txtDuration.TabIndex = 17;
            this.txtDuration.Text = "Duration";
            // 
            // lblmoviename
            // 
            this.lblmoviename.AutoSize = true;
            this.lblmoviename.BackColor = System.Drawing.Color.Transparent;
            this.lblmoviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoviename.ForeColor = System.Drawing.Color.White;
            this.lblmoviename.Location = new System.Drawing.Point(10, 536);
            this.lblmoviename.Name = "lblmoviename";
            this.lblmoviename.Size = new System.Drawing.Size(122, 25);
            this.lblmoviename.TabIndex = 18;
            this.lblmoviename.Text = "Movie Name";
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(138, 622);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(219, 22);
            this.txtCast.TabIndex = 11;
            // 
            // txtdirector
            // 
            this.txtdirector.Location = new System.Drawing.Point(138, 582);
            this.txtdirector.Name = "txtdirector";
            this.txtdirector.Size = new System.Drawing.Size(219, 22);
            this.txtdirector.TabIndex = 12;
            // 
            // txtruntime
            // 
            this.txtruntime.Location = new System.Drawing.Point(138, 659);
            this.txtruntime.Name = "txtruntime";
            this.txtruntime.Size = new System.Drawing.Size(219, 22);
            this.txtruntime.TabIndex = 13;
            // 
            // txtmoviename
            // 
            this.txtmoviename.Location = new System.Drawing.Point(138, 536);
            this.txtmoviename.Name = "txtmoviename";
            this.txtmoviename.Size = new System.Drawing.Size(219, 22);
            this.txtmoviename.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(818, 662);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 49);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(818, 529);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 49);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(818, 602);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 49);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(658, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "upload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(363, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(40)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1091, 743);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblmoviename);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.txtdirector);
            this.Controls.Add(this.txtruntime);
            this.Controls.Add(this.txtmoviename);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvView);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDuration;
        private System.Windows.Forms.Label lblmoviename;
        private System.Windows.Forms.TextBox txtCast;
        private System.Windows.Forms.TextBox txtdirector;
        private System.Windows.Forms.TextBox txtruntime;
        private System.Windows.Forms.TextBox txtmoviename;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}