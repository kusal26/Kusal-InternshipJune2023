namespace ConsoleApp;

public class DayTwo
{
    public void GetPersons()
    {
        var people = GetPeople();

        foreach (var person in people)
        {
            Console.WriteLine($"{person.Id}. " +
                $"{person.FirstName} {person.LastName} " +
                $"- {person.Age}");
        }

        Console.WriteLine("\nFetch people via Constructor\n");

        foreach (var person in GetPeopleUsingCtor())
        {
            Console.WriteLine(person.ToString());
        }
    }

    private List<Person> GetPeople()
    {
        return new List<Person>
        {
            new Person
            {
                Id = 1,
                FirstName = "Dot",
                LastName = "Net",
                Age = 20
            },
            new Person
            {
                Id = 2,
                FirstName = "C",
                LastName = "#",
                Age = 15
            }
        };
    }

    private List<Person> GetPeopleUsingCtor()
    {
        return new List<Person>
        {
            new Person(1, "Dot","Net", 40),
            new Person(2, "C","#", 30),
            new Person(3, "F","#", 10),
            new Person(4, "Visual","Basic", 50)
        };
    }

    /*
     Create a new class Student (child of Person) that will have
        - Field Of Study (Engg., IT, CSIT....)
        - Semester
        - College
     */
    public void GetStudent()
    {
        foreach(var student in GetStudents())
        {
           Console.WriteLine($"{student.College}\t" +$"{ student.Faculty}\t"+$" {student.Semester } ");
            
        }
        Console.WriteLine("\nfetching student via constructor");

        //using constructor
        foreach(var student in GetStudentsviaConst())
        {
            Console.WriteLine(student.ToString());
        }
        
    }
    


    private List<Student> GetStudents()
    {
        return new List<Student>
        {
            new Student
            {
                College="Ascol",
                Faculty="BSC CSIT",
                Semester="foruth"
            },
            new Student
            {
                College="NCC",
                Faculty="BIT",
                Semester="first"

            }
        };
    }
    //using constructor
    
    private List<Student> GetStudentsviaConst()
    {
        return new List<Student>
        {
            new Student(college:"RR",faculty:"Science",semester:"sixth"),
            new Student(college:"PK",faculty:"BBA",semester:"Third")
        
        }; 
    }
}
