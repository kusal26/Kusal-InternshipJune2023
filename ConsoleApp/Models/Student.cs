class Student
{
    public string Faculty { set; get; }
    public string College { set; get; }
    public string Semester { set; get; }

    public Student()
    {

    }
    public Student(string faculty,string college,string semester)
    {
        College = college;
        Faculty = faculty;
        Semester = semester;


    }
    public override string ToString()
    {
        return $"{College} {Faculty}  {Semester}";
    }



}
