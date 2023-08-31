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
    public partial class Signup : Form
    {
        String ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Dapper;User Id=;Password=";
        public Signup()
        {
            InitializeComponent();
        }
        bool isvalid()
        {
            if(txtEmail.Text=="")
            {
                MessageBox.Show("Email cannot be empty");
                return false;
            }
            if (txtUsername.Text == "")
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
                        if (result1 != null)
                        {

                            MessageBox.Show("Account Exist Already");

                            //MessageBox.Show(result2);
                        }
                        else
                        {
                            var sql = "Insert into UserCredential (Username,Password,Email) VALUES (@username,@password,@email)";

                            var parameter2 = new { Username = txtUsername.Text, Password = txtPassword.Text, Email = txtEmail.Text };
                            // var result2=
                            connection.Execute(sql, parameter2);
                            DialogResult dialogresult = MessageBox.Show("Signed Up ", "signup", MessageBoxButtons.OK);
                            if (dialogresult == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }


                }
            }
        }

        private void txtpasswordAgain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
