using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperProject
{
    public partial class ViewForm : Form
    {
        String ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Dapper;User Id=;Password=";
        private int id;

        public ViewForm()
        {
            InitializeComponent();
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvView.SelectedRows[0].Cells[0].Value.ToString());

            if (dgvView.SelectedRows[0].Cells[1].Value != null)
            {
                txtmoviename.Text =dgvView.SelectedRows[0].Cells[1].Value.ToString();

            }
            else
            {
                txtmoviename.Text = null;
            }
            if (dgvView.SelectedRows[0].Cells[2].Value != null)
            {
                txtdirector.Text = dgvView.SelectedRows[0].Cells[2].Value.ToString();


            }
            else
            {
                txtdirector.Text = null;
            }
            if (dgvView.SelectedRows[0].Cells[3].Value != null)
            {
                txtCast.Text = dgvView.SelectedRows[0].Cells[3].Value.ToString();

            }
            else
            {
                txtCast.Text = null;
            }
            if (dgvView.SelectedRows[0].Cells[4].Value != null)
            {
                txtruntime.Text = dgvView.SelectedRows[0].Cells[4].Value.ToString();

            }
            else
            {
                txtruntime.Text = null;
            }


            byte[] imageData = (byte[])(dgvView.SelectedRows[0].Cells[5].Value);

            // Create a memory stream to hold the image data
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                // Convert the image data to an Image object
                Image image = Image.FromStream(ms);

                // Assign the image to the PictureBox control
                pictureBox1.Image = image;


            }

        }
        public bool isvalid()
        {

            if (txtmoviename.Text == "")
            {
                MessageBox.Show("Movie name cannot be empty");
                return false;
            }
            if (txtCast.Text == "")
            {
                MessageBox.Show("Cast cannot be empty");
                return false;
            }
            if (txtdirector.Text == "")
            {
                MessageBox.Show("Director cannot be empty");
                return false;
            }
            if (txtruntime.Text == "")
            {
                MessageBox.Show("Duration cannot be empty");
                return false;
            }

        
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("PictureBox is Empty");
                return false;

            }

            return true;

        }
     
void clear()
        {
            pictureBox1.Image = null;
            txtCast.Text = txtruntime.Text = txtmoviename.Text = txtdirector.Text = "";
            id = 0;
        }
        void populateGridView()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var sql = "select * from MovieDescription";
                var result = connection.Query<View>(sql).ToList();
                if (result.Count > 0)
                {
                    dgvView.DataSource = result;
                }
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            populateGridView();
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {


                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = "Update MovieDescription Set MovieName=@moviename ,Director=@director,Cast=@cast,Duration=@duration where Id=@id";
                    var parameter = new { Id = id, MovieName = txtmoviename.Text, Director = txtdirector.Text, Cast = txtCast.Text, Duration = txtruntime.Text };
                    connection.Execute(sql, parameter);
                    MessageBox.Show("Updated");
                    populateGridView();
                    clear();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = "Delete from  MovieDescription where Id=@id";
                    var parameter = new { Id = id };
                    connection.Execute(sql, parameter);
                    MessageBox.Show("deleted");
                    populateGridView();
                    clear();
                }
            }
            else
                MessageBox.Show("Select Movie First");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.FastX;
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(filepath);

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                byte[] pictureData;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    pictureData = ms.ToArray();
                }

                using (var connection = new SqlConnection(ConnectionString))
                {

                    var sql = "Insert into MovieDescription (MovieName,Director,Picture,Cast,Duration) values (@moviename,@director,@picture,@cast,@Duration)";
                    var parameter = new { MovieName = txtmoviename.Text, Director = txtdirector.Text, Picture = pictureData, Cast = txtCast.Text,Duration=txtruntime.Text };
                    connection.Execute(sql, parameter);
                    MessageBox.Show("inserted succesfully");
                    clear();
                }
                populateGridView();
                clear();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            LoadMovie loadMovie = new LoadMovie();
            loadMovie.ShowDialog();
        }
    }
}
