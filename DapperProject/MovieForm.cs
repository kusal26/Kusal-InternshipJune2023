using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperProject
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

       
        

       

      
      


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int id = 1;
            var moviedescription = new MovieDescription();
            moviedescription.GetId = id;
            moviedescription.ShowDialog();
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            int id = 2;
            var moviedescription=new MovieDescription();
            moviedescription.GetId = id;
            moviedescription.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int id = 3;

            var moviedescription = new MovieDescription();
            moviedescription.GetId = id;

            moviedescription.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            int id = 4;

            var moviedescription = new MovieDescription();
            moviedescription.GetId = id;

            moviedescription.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int id = 5;

            var moviedescription = new MovieDescription();
            moviedescription.GetId = id;

            moviedescription.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int id = 6;

            var moviedescription = new MovieDescription();
            moviedescription.GetId = id;

            moviedescription.ShowDialog();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int id = 7;

            var moviedescription = new MovieDescription();
            moviedescription.GetId = id;

            moviedescription.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int id = 8;

            var moviedescription = new MovieDescription();
            moviedescription.GetId = id;

            moviedescription.ShowDialog();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
