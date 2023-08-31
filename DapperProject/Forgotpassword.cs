using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DapperProject
{
    public partial class Forgotpassword : Form
    {
        String ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Dapper;User Id=;Password=";

        public Forgotpassword()
        {
            InitializeComponent();
        }
        bool isvalid()
        {
            if(txtUsername.Text=="")
            {
                MessageBox.Show("Username cannot be empty");
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
                return false;
            }
            if (txtpasswordAgain.Text == "")
            {
                MessageBox.Show("Password Again field cannot be empty");
                return false;
            }
            return true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {


                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    if (txtPassword.Text != txtpasswordAgain.Text)
                    {
                        MessageBox.Show("Password and Password Again should be same");

                    }
                    else
                    {
                        var isUserPresent = "Select * from UserCredential where Username=@username";
                        // var result = connection.QueryFirstOrDefault<userCredential>(sql, new { Username = txtPassword.Text, Password = txtPassword.Text });
                        var parameter1 = new { Username = txtUsername.Text };
                        var result1 = connection.Query<userCredential>(isUserPresent, parameter1).FirstOrDefault();
                        if (result1 == null)
                        {

                            MessageBox.Show("Account Dost not Exist");

                            //MessageBox.Show(result2);
                        }
                        else
                        {
                            var sql = "Update UserCredential Set Password=@password where Username=@username";

                            var parameter2 = new { Username = txtUsername.Text, Password = txtPassword.Text };
                            // var result2=
                            connection.Execute(sql, parameter2);
                            DialogResult dialogresult = MessageBox.Show("Password is Changed ", "Forgot password", MessageBoxButtons.OK);
                            if (dialogresult == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }


                }
            }

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                txtUsername.BackColor = Color.Red;
            }
            else
            {
                txtUsername.BackColor = SystemColors.Window;
            }
        }

        private void Forgotpassword_Load(object sender, EventArgs e)
        {

        }
    }
}
