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
    public partial class SubjectForm : Form
    {
        private string subjectId;
        public SubjectForm()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtSubjectName.Text = txtSubjectId.Text = "";
            Subject sub = new Subject();
            
            PopulateGridView();
        }
        private void PopulateGridView()
        {
            var context = new CollegeContext();
            SubjectGridView.DataSource = context.Subjects.ToList();
        }
        private bool isValid()
        {

            if (txtSubjectName.Text == "" || txtSubjectId.Text == "")
            {
                MessageBox.Show("Field cannot be empty");
                return false;
            }
            else
                return true;
        }
        private void SubjectForm_Load(object sender, EventArgs e)
        {
            clear();
            PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                { 
                var context = new CollegeContext();
                var subject = new Subject()
                {

                    SubjectName = txtSubjectName.Text,
                    SubjectId = txtSubjectId.Text,


                };
                context.Subjects.Add(subject);
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

           var aId = subjectId;

            {


                if (isValid())
                {
                    try { 

                    using (var _context = new CollegeContext())
                    {

                        var UpdateId = _context.Subjects.Where(x => x.SubjectId == aId).FirstOrDefault();
                        UpdateId.SubjectName = txtSubjectName.Text;
                        UpdateId.SubjectId = txtSubjectId.Text;

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
            if (dialogresult == DialogResult.Yes)
            {
                var aId = subjectId;
                    using (var _context = new CollegeContext())
                    {

                        var Did = _context.Subjects.Where(x => x.SubjectId == aId).FirstOrDefault();

                        _context.Subjects.Remove(Did);
                        _context.SaveChanges();
                    }
                    clear();
                    PopulateGridView();
                    MessageBox.Show("Deleted successfully");
                }
            }
            else return;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchCriteria = txtSearch.Text.Trim();

            using (var context = new CollegeContext())
            {
                // Perform the search using Entity Framework
                var searchResults = context.Subjects
                    .Where(x => x.SubjectName.Contains(searchCriteria)
                     || x.SubjectId.Contains(searchCriteria))
                    .ToList();

                SubjectGridView.DataSource = searchResults;
                SubjectGridView.Refresh();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void SubjectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectId = SubjectGridView.SelectedRows[0].Cells[0].Value.ToString();

            txtSubjectName.Text = SubjectGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtSubjectId.Text = SubjectGridView.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
