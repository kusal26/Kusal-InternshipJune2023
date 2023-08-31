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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();    
            teacherForm.ShowDialog();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();   
            resultForm.ShowDialog();
        }
    }
}
