using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementApp
{
    public partial class TeacherForm : Form
    {
        private int teacherId;
        public TeacherForm()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            var context = new CollegeContext();
            TeacherGridView.DataSource = context.Teachers.ToList();
            var data=context.Subjects.ToList();
            comboBoxTeacher.DataSource = data;
            comboBoxTeacher.DisplayMember = "SubjectName";
            comboBoxTeacher.ValueMember = "SubjectId";
        }
        private bool isValid()
        {

            if (txtTeacherName.Text == "" ||  txtTeacherAddress.Text == "")
            {
                MessageBox.Show("Field cannot be empty");
                return false;
            }
            else
                return true;
        }
        private void clear()
        {
            txtSearch.Text = txtSubjectId.Text = txtTeacherAddress.Text = txtTeacherName.Text = "";
            Teacher teacher = new Teacher();
            teacher.Id = 0;
            PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try { 
                var context = new CollegeContext();
                var teacher = new Teacher()
                {
                    TeacherName = txtTeacherName.Text,
                    SubjectId = comboBoxTeacher.SelectedValue.ToString(),
                    Address = txtTeacherAddress.Text,

                };
                context.Teachers.Add(teacher);
                context.SaveChanges();
                clear();
                PopulateGridView();
                MessageBox.Show("Data Saved");
                }
                catch (Exception) { MessageBox.Show("This Course is not available\n Select Available Subject", "Invalid Course", MessageBoxButtons.OK); }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int aId = teacherId;

            {

                if (isValid())
                {
                try { 

                    using (var _context = new CollegeContext())
                    {

                        var UpdateId = _context.Teachers.Where(x => x.Id == aId).FirstOrDefault();
                        UpdateId.SubjectId = txtSubjectId.Text;
                        UpdateId.TeacherName = txtTeacherName.Text;
                        UpdateId.Address = txtTeacherAddress.Text;
                        _context.SaveChanges();
                    }
                    clear();
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
            DialogResult dialogresult = MessageBox.Show("Do you Want to Delete", "Warning", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.OK)
            {


                int aId = teacherId;
                    using (var _context = new CollegeContext())
                    {

                        var DeleteRoll = _context.Students.Where(x => x.Id == aId).FirstOrDefault();

                        _context.Students.Remove(DeleteRoll);
                        _context.SaveChanges();
                    }
                    clear();
                    PopulateGridView();
                    MessageBox.Show("Deleted successfully");
                }
            }
            else return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
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
                var searchResults = context.Teachers
                    .Where(x => x.TeacherName.Contains(searchCriteria)
                    || x.Id.ToString() == searchCriteria
                    || x.SubjectId.Contains(searchCriteria)).ToList();

                TeacherGridView.DataSource = searchResults;
                TeacherGridView.Refresh();
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            clear();
            PopulateGridView();
        }

        private void TeacherGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherId = Convert.ToInt32(TeacherGridView.SelectedRows[0].Cells[0].Value.ToString());

            txtTeacherName.Text = TeacherGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtSubjectId.Text = TeacherGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtTeacherAddress.Text = TeacherGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
        

        private void txtSubjectId_TextChanged(object sender, EventArgs e)
        {
            /*
            List<Subject> subjects;
            using (var dbContext = new CollegeContext()) // Replace with your actual DbContext class
            {
                subjects = dbContext.Subjects.ToList();
            }

            // Populate the ComboBox with the subjects
            subjectComboBox.DataSource = subjects;
            subjectComboBox.DisplayMember = "SubjectName";
            subjectComboBox.ValueMember = "SubjectId";
            */
        }

       
    }

}
