using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace CollegeManagementApp
{
    public class CollegeContext : DbContext
    {
   
        public CollegeContext()
            : base("name=CollegeContext.cs")
        {
        }



        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }

   public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        [ForeignKey("Subject")]
        public string SubjectId { get; set; } //Foreign Key
        public Subject Subject { get; set; }
    }
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        
        [ForeignKey("Subject")]
        public string SubjectId { get; set; } //Foreign Key
        public Subject Subject { get; set; }
      

        public string Address { get; set; }
    }
    public class Subject
    {
        [Key]
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
//[Problem]
//PM > Enable - Migration
//Value cannot be null.
//Parameter name: type

//[solution]
//PM > Update - Package EntityFramework
//why??