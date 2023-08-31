using System;
using System.Data.Entity;
using System.Linq;

namespace Studentmanagement
{
    public class StudentContext : DbContext
    {
      
        public StudentContext()
            : base("name=StudentContext")
        {
        }



         public virtual DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
       public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Rollno { get; set; }
    }
}