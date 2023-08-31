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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void btnSubjStud_Click(object sender, EventArgs e)
        {
            var context = new CollegeContext();
            var showtable = from student in context.Students
                                
                            join subject in context.Subjects on student.SubjectId equals subject.SubjectId
                            orderby student.StudentName
                            select new
                            {


                                StudentId = student.Id,
                                StudentName = student.StudentName,                        
                                subjectName = subject.SubjectName,

                              



                            };

            var result = showtable.ToList();
            ResultdataGridView.DataSource = result;
        }

        private void btnSubjTeach_Click(object sender, EventArgs e)
        {
            var context = new CollegeContext();
            var showtable =// from student in context.Students
                             from teacher in context.Teachers
                             join subject in context.Subjects on teacher.SubjectId equals subject.SubjectId.Trim()
                             orderby teacher.TeacherName
                             select new
                             {


                               
                                 TeacherId = teacher.Id,
                                 TeacherName = teacher.TeacherName,
                                 TeacherAddress = teacher.Address,                   
                                 subjectName = subject.SubjectName,




                             };
            var result = showtable.ToList();
            ResultdataGridView.DataSource = result;
        }

        private void btnSubjTeachStud_Click(object sender, EventArgs e)
        {
            var context = new CollegeContext();
            var showtable = from student in context.Students
                            join teacher in context.Teachers on student.SubjectId equals teacher.SubjectId.Trim()
                            join subject in context.Subjects on student.SubjectId equals subject.SubjectId.Trim()
                             orderby student.StudentName
                            select new
                            {


                                
                                StudentName = student.StudentName,
                               
                                TeacherName = teacher.TeacherName,
                                TeacherAddress = teacher.Address,
                               
                                subjectName = subject.SubjectName,




                            };
            var result = showtable.ToList();
            ResultdataGridView.DataSource = result;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
