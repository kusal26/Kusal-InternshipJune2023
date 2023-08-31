using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentmanagement
{
    public partial class Form1 : Form
    {
        Student std = new Student();

        public int StudentRoll;

        public Form1()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtAge.Text = txtAddress.Text = txtName.Text = txtRoll.Text = txtSearch.Text = "";
            std.Id = 0;
            std.Rollno = 0;
            PopulateDataGridView();


        }

  
        bool isEmpty()
        {
            if(txtAge.Text =="" && txtRoll.Text =="" && txtAge.Text ==""&& txtAddress.Text == "")
            {
                MessageBox.Show("Fields cannot be empty");
                return true;


            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
                return true;
            }
            if (txtRoll.Text == "")
                {
                MessageBox.Show("Roll cannot be empty");
                return true;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("Age cannot be empty");
                return true;
            }
                if (txtAddress.Text == "") 
            {
                MessageBox.Show("Address cannot be empty");
                return true;
            }
           
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {

            using (StudentContext context = new StudentContext())
            {
                StudentGridView.DataSource = context.Students.ToList();
            }
        }
        bool notValid()
            {


            var myAge = int.TryParse(txtAge.Text, out int myage);



            if (myAge is false)

            {
                MessageBox.Show("Invalid Age ");

                return true;
            }
            return false;
        }
        bool isDuplicate()
        {
            //   var myRollNo = int.TryParse(txtRoll.Text, out int aRollno);

            var myRollNo = int.TryParse(txtRoll.Text, out int aRollno);

            if (myRollNo is false)
            {
                MessageBox.Show("Invalid Roll No");

                return true;
            }
            else
            {
                   using (var context = new StudentContext())
                {
                    bool isduplicate = context.Students.Where(x => x.Rollno == aRollno).Any();
                    MessageBox.Show("Roll No is already existed");

                    return isduplicate;
                }
            }
           
         

           
            

           
            
           

        }
        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentRoll = Convert.ToInt32(StudentGridView.SelectedRows[0].Cells[4].Value.ToString());

            txtName.Text = StudentGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtAge.Text = StudentGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = StudentGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtRoll.Text = StudentGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        

        private void Savebotton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                
                return;

            }
            else if (notValid())
            {
                
                return;
            }
            if (isDuplicate())
            {
                return;
            }

            else
            {



                using (StudentContext _context = new StudentContext())
                {
                    Student std = new Student()
                    {
                        Name = txtName.Text,
                        Age = Convert.ToInt32(txtAge.Text),
                        Rollno = Convert.ToInt32(txtRoll.Text),
                        Address = txtAddress.Text


                    };
                    _context.Students.Add(std);
                    _context.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Data Saved successfully");
            }
            
        
     

        }
      

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int aRoll = StudentRoll;
            if (isEmpty())
            {

                return;

            }
            else if (notValid())
            {

                return;
            }
            if (isDuplicate())
            {
                return;
            }
            else
            {


                

                    using (StudentContext _context = new StudentContext())
                    {

                        var UpdateId = _context.Students.Where(x => x.Rollno == aRoll).FirstOrDefault();
                        UpdateId.Name = txtName.Text;
                        UpdateId.Age = Convert.ToInt32(txtAge.Text);
                        UpdateId.Address = txtAddress.Text;
                        UpdateId.Rollno = Convert.ToInt32((txtRoll.Text));
                        _context.SaveChanges();
                    }
                    Clear();
                    PopulateDataGridView();
                    MessageBox.Show("Updated successfully");
                }
            
        }

      

        private void DeleteBotton_Click(object sender, EventArgs e)
        {

            int aRoll = StudentRoll;
            if (isEmpty())
            {

                return;

            }
          
           else
            {
                using (StudentContext _context = new StudentContext())
                {

                    var DeleteRoll = _context.Students.Where(x => x.Rollno == aRoll).FirstOrDefault();

                    _context.Students.Remove(DeleteRoll);
                    _context.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Deleted successfully");
            }
        }
        private void CancelBotton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            var searchCriteria = txtSearch.Text.Trim();

            using (var context = new StudentContext())
            {
                // Perform the search using Entity Framework
                var searchResults = context.Students
                    .Where(x => x.Name.Contains(searchCriteria)
                    || x.Rollno.ToString() == searchCriteria
                    || x.Address.Contains(searchCriteria)).ToList();

                StudentGridView.DataSource = searchResults;
                StudentGridView.Refresh();
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
           
            
 


        }
       

        private void Agelbl_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
