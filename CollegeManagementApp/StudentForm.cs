using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementApp
{
    public partial class StudentForm : Form
    {
        Student std = new Student();
        private int StudentId;
        public StudentForm()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private void Clear()
        {
            txtSearch.Text = txtStudentName.Text = "";
            std.Id = 0;
            PopulateGridView();

        }
        private bool isValid()
        {

            if (txtStudentName.Text == "" /*|| txtSubjectId.Text == ""*/)
            {
                MessageBox.Show("Field cannot be empty");
                return false;
            }
            else
                return true;
        }
        private void PopulateGridView()
        {
            var context = new CollegeContext();
            var query = from students in context.Students
                        join subjects in context.Subjects
                        on students.SubjectId equals subjects.SubjectId
                        select new
                        { 
                        students.Id,
                        students.StudentName,
                        subjects.SubjectName
                        };

            StudentGridView.DataSource =query.ToList();
            //var context = new CollegeContext();
            var subject = context.Subjects.ToList();
            comboBoxStudent.DataSource = subject;
            comboBoxStudent.ValueMember = "SubjectId";
            comboBoxStudent.DisplayMember = "SubjectName";
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
           

            if (isValid())
            {
                try
                {


                    using (var _context = new CollegeContext())
                    {
                      
                        Student std = new Student()
                        {
                           // SubjectId = txtSubjectId.Text,
                        
                            SubjectId = comboBoxStudent.SelectedValue.ToString(),
                            StudentName = txtStudentName.Text


                        };
                        _context.Students.Add(std);
                        _context.SaveChanges();
                    }
                    Clear();
                    PopulateGridView();
                    MessageBox.Show("Data Saved successfully");
                }
                catch(Exception) { MessageBox.Show("This Course is not available\n Select Available Subject","Invalid Course", MessageBoxButtons.OK); }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int aId = StudentId;

            {


                if (isValid())
                {
                    try
                    {
                        using (var _context = new CollegeContext())
                        {

                            var UpdateId = _context.Students.Where(x => x.Id == aId).FirstOrDefault();
                            // UpdateId.SubjectId = txtSubjectId.Text;
                            UpdateId.SubjectId = comboBoxStudent.SelectedValue.ToString();
                            
                            UpdateId.StudentName = txtStudentName.Text;
                            _context.SaveChanges();
                        }
                        Clear();
                        PopulateGridView();
                        MessageBox.Show("Updated successfully");
                    }
                    catch (Exception) { MessageBox.Show("This Course is not available\n Select Available Subject", "Invalid Course", MessageBoxButtons.OK); }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (isValid())
                {
           DialogResult dialogresult= MessageBox.Show("Do you Want to Delete", "Warning", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                int aId = StudentId;
                    using (var _context = new CollegeContext())
                    {

                        var DeleteRoll = _context.Students.Where(x => x.Id == aId).FirstOrDefault();

                        _context.Students.Remove(DeleteRoll);
                        _context.SaveChanges();
                    }
                    Clear();
                    PopulateGridView();
                    MessageBox.Show("Deleted successfully");
                }
            }
            else
                return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchCriteria = txtSearch.Text.Trim();

            using (var context = new CollegeContext())
            {
                // Perform the search using Entity Framework
                var searchResults = context.Students
                    .Where(x => x.StudentName.Contains(searchCriteria)
                    || x.Id.ToString() == searchCriteria
                    || x.SubjectId.Contains(searchCriteria)).ToList();

                StudentGridView.DataSource = searchResults;
                StudentGridView.Refresh();
            }
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateGridView();
        }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentId = Convert.ToInt32(StudentGridView.SelectedRows[0].Cells[0].Value.ToString());

            txtStudentName.Text = StudentGridView.SelectedRows[0].Cells[1].Value.ToString();
         //   comboBoxStudent.SelectedValue = StudentGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

       

        private void txtSubjectId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
