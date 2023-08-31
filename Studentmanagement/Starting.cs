using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentmanagement
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private Form PreviousForm;
      //  bool isstartButtonClicked = false;
        

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            PreviousForm = this;
            form.FormClosed += Form_FormClosed;
            form.Show();
            this.Hide();
            /*
            isstartButtonClicked = true;
            panel2.Visible = true;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            */

        }
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isstartButtonClicked==false)
            {
                return;
            }
            panel2.Width += 3;
            if(panel2.Width>800)
            {
                timer1.Stop();
                Form1 form = new Form1();
               PreviousForm = this;
               form.FormClosed += Form_FormClosed;
                form.Show();
                this.Hide();

                
            }
        }
        */
        
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Close();
        }

    }
}
