using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DapperProject
{
    
    public partial class LoadMovie : Form
    {
        String ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Dapper;User Id=;Password=";

        int numberofrow;
        int id;
        public LoadMovie()
        {
            InitializeComponent();
        }
        void populategridview()
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString)) 
            {
                var sql = "select * from MovieDescription";
                var result=conn.Query<LoadMovieModel>(sql).ToList();
                 numberofrow=result.Count();
                
                dgvLoadMovie.DataSource = result;
            }
        }
        void clear()
        {
            id = 0;
        }
        private void dgvLoadMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvLoadMovie.SelectedRows[0].Cells[0].Value.ToString());
            MovieDescription movieDescription = new MovieDescription();
            movieDescription.GetId = id;
            movieDescription.ShowDialog();

        }

        private void LoadMovie_Load(object sender, EventArgs e)
        {
            populategridview();
            //DataGridViewRow[] dgvrow=new DataGridViewRow[8];
            //DataGridViewColumn[] dgvcolumn=new DataGridViewColumn[8];

            for (int i = 0;i<numberofrow;i++)
                {
            DataGridViewRow row = dgvLoadMovie.Rows[i];
            
            row.Height =150;
                row.DefaultCellStyle.Font = new Font("Arial",18);
              

            }
            
            
           DataGridViewColumn column1 = dgvLoadMovie.Columns[1];
            column1.Width = 200;
                DataGridViewColumn column = dgvLoadMovie.Columns[2];
              //  column.Width = 300;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

            clear();
            

        }
    }
}
