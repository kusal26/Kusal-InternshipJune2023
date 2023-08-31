using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperProject
{
    public partial class Login : Form
    {
        String ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Dapper;User Id=;Password=";
        public Login()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtPassword.Text = txtUsername.Text = "";
        }
        bool isvalid()
        {
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
            
            return true;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {



                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    var sql = "Select * from UserCredential where Username=@username and Password=@password";

                    var adminsql = "Select * from Admin where Username=@username and Password=@password";
                    var parameter = new { Username = txtUsername.Text, Password = txtPassword.Text };
                    var result = connection.Query<userCredential>(sql, parameter).FirstOrDefault();
                    var resultAdmin = connection.Query<AdminCredential>(adminsql, parameter).FirstOrDefault();

                    //  string password=result.Password;
                    if (resultAdmin != null && resultAdmin.UserName == txtUsername.Text)
                    {
                        var viewform = new ViewForm();
                        this.Hide();
                        viewform.ShowDialog();
                        this.Close();
                    }
                    else if (result != null && result.Username == txtUsername.Text)
                    {

                        //MovieForm movieForm = new MovieForm();
                        //this.Hide();
                        //movieForm.ShowDialog();

                        //this.Close();
                        LoadMovie loadMovie = new LoadMovie();
                        this.Hide();
                        loadMovie.ShowDialog();
                        this.Close();

                    }
                    else
                        MessageBox.Show("Incorrect Details");
                    clear();
                }
            }
            
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
                
            
          
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==' ')
            {
                e.Handled = true; 
                txtUsername.BackColor = Color.Red;
            }
            else
            {
                txtUsername.BackColor = SystemColors.Window;
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Forgotpassword forgotpassword = new Forgotpassword();
            forgotpassword.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            clear();
        }
    }
}
