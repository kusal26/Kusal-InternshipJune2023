using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
 using System.IO;
using System.Windows.Forms;

    

namespace DapperProject
{
    public partial class MovieDescription : Form
    {
        String ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Dapper;User Id=;Password=";

        public MovieDescription()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCast_Click(object sender, EventArgs e)
        {

        }

        private void panelPay1_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void panelpay2_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void panelpay3_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }
      
        public int GetId { get;set; }
        private void MovieDescription_Load(object sender, EventArgs e)
        {




            int id = GetId;

            
            
            
            using (var connection = new SqlConnection(ConnectionString) )
            {
                var sql = "Select * from MovieDescription where Id=@id";
                var parameter = new {Id=id};
                var movies=connection.Query<MoviesModel>(sql,parameter).FirstOrDefault();
                if( movies != null ) 
                { 
                //int Id = movies.Id;
                
                string Duration = movies.Duration;
                string MovieName = movies.MovieName;
                string Director=movies.Director;
                byte[] Picture = movies.Picture;
                string Cast=movies.Cast;
              
                    lblMovieName.Text = MovieName;
                lblDuration.Text = Duration;
                lblCast.Text = Cast;
                if (Picture != null)
                {
                    using (MemoryStream pictureStream = new MemoryStream(Picture))
                    {
                        PictureBoxNowShowing.Image = Image.FromStream(pictureStream);
                    }
                }

              }
            

            }
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
