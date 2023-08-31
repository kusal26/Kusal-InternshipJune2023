using Dapper;
using Microsoft.Data.Sql;

public class DapperClass
{

    String ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Dapper;User Id=;Password=";
    public void  checkConnection()
    {
        //SqlConnection connection = null;
        SqlConnection connection = new SqlConnection(ConnectionString);
        try
        {
            connection.Open();
            Console.WriteLine("Connection Established");
            connection.Close();
        }
        catch (Exception ex) { Console.WriteLine(ex); }
       
    }
    public void  Insert()
    {
        StudentDapperDto StdDapper = new StudentDapperDto();
        Console.Write("Name");
        StdDapper.Name = Console.ReadLine();
        Console.Write("Address");
        StdDapper.Address = Console.ReadLine();
        Console.Write("Age");
        StdDapper.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("RollNo");
        StdDapper.RollNo = Convert.ToInt32(Console.ReadLine());
        using(SqlConnection  connection = new SqlConnection(ConnectionString))
        {
            var sql = "Insert into DapperStudent (Name,Age,Address,RollNo) Values (@name,@age,@address,@rollno)";
            var student = new { Name = StdDapper.Name, Age = StdDapper.Age, Address = StdDapper.Address, StdDapper.RollNo };
            connection.Execute(sql,student);
        }

    }
    public void Update()
    {
        StudentDapperDto StdDapper = new StudentDapperDto();
        Console.Write(" Enter Id to be Updated :");
        StdDapper.Id=Convert.ToInt32(Console.ReadLine());
        Console.Write("Name : ");
        StdDapper.Name = Console.ReadLine();
        Console.Write(" Address: ");
        StdDapper.Address = Console.ReadLine();
        Console.Write("Age : ");
        StdDapper.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("RollNo : ");
        StdDapper.RollNo = Convert.ToInt32(Console.ReadLine());
        using(SqlConnection connection = new SqlConnection(ConnectionString))
        {
            var sql = "update DapperStudent SET Name = @name,Age=@age,Address=@address,Rollno=@rollno where Id=@id";
            var student = new {Id=StdDapper.Id, Name = StdDapper.Name, Age = StdDapper.Age, Address = StdDapper.Address, StdDapper.RollNo };
            connection.Execute(sql,student);

        }
    }
    public void Delete()
    {
        var StdDapper= new StudentDapperDto();
        Console.Write(" Enter Id to be Delete :");
        StdDapper.Id = Convert.ToInt32(Console.ReadLine());
        using(var connection = new SqlConnection(ConnectionString))
        {
            var sql = "Delete From DapperStudent Where Id=@id";
            var student = new { Id = StdDapper.Id };
            connection.Execute(sql,student);
        }
        Console.WriteLine("Deleted");

    }
    public void getById()
    {
        var StdDapper = new StudentDapperDto();
        Console.Write(" Enter Id to be Delete :");
        
        StdDapper.Id = Convert.ToInt32(Console.ReadLine());
        if (StdDapper.Id <= 0)
        {
            Console.WriteLine("Id doesnot Exist");
        }
        else
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var sql = "select * from DapperStudent where ID=@id";
                var student = new { Id = StdDapper.Id };
              //  connection.Execute(sql, student);
                var getdata = connection.Query(sql,student).FirstOrDefault();
                Console.WriteLine(getdata);
                //foreach(var item in getdata)
                //{
                //    Console.WriteLine(item);
                //}
                
            }
        }

    }
    public void Read()
    {
        using(SqlConnection connection = new SqlConnection(ConnectionString))
        {
            var sql = "Select * from DapperStudent";
            //connection.Open();
            var students = connection.Query(sql).ToList();
           
            
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            

        }

    }


}