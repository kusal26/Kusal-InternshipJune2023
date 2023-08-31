using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DapperProject
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void txtNoOfSeat_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNoOfSeat.Text))
            {
                lblTotalprice.Text = string.Empty;
            }
            if (int.TryParse(txtNoOfSeat.Text, out int NoOfSeat))
            {
                var total = NoOfSeat * 300;
                lblTotalprice.Text = total.ToString();
            }
            else
            {
                lblTotalprice.Text = " ";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           }

        private void Cart_Load(object sender, EventArgs e)
        {

        }
    }
}

