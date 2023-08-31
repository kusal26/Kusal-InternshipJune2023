public class SelfPracticeADO
{
    private static string _connectionstring = "Server=(localdb)\\MSSQLLocalDB;Database=Intern;User Id=;Password=;";
    public void CheckConnection()
    {
       try
        {
            SqlConnection conn = new SqlConnection(_connectionstring);
            conn.Open();
            Console.WriteLine("Connection is established");
            conn.Close();

        }
        catch(Exception ex) {
            Console.WriteLine($"error: {ex}");
        }


    }
    public void AddPerson()
    {
        PersonDto person = new PersonDto();
        Console.WriteLine("enter the detail of person you want to insert");
        Console.Write("FirstName:");
        person.FirstName = Console.ReadLine();
        Console.Write("LastName:");
        person.LastName = Console.ReadLine();

        Console.Write("Age:");
        person.Age = Convert.ToInt32(Console.ReadLine());

        using(SqlConnection conn = new SqlConnection(_connectionstring))
        {

           
                using (SqlConnection con = new SqlConnection(_connectionstring))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO JuneInternship (FirstName, LastName, Age) VALUES (@firstName, @lastName, @age)";
                        cmd.Parameters.AddWithValue("@firstName", person.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", person.LastName);
                        cmd.Parameters.AddWithValue("@age", person.Age);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                        

                        conn.Close();
                    }
                }

                Console.WriteLine("Person added successfully");
            }
           
        

    }
    public void UpdatePerson()
    {
        PersonDto person = new PersonDto();
        Console.WriteLine("enter the detail of person you want to ");
        Console.Write("FirstName:");
        person.FirstName = Console.ReadLine();
        Console.Write("LastName:");
        person.LastName = Console.ReadLine();

        Console.Write("Age:");
        person.Age = Convert.ToInt32(Console.ReadLine());
        using(SqlConnection con = new SqlConnection(_connectionstring))
        {
            using(SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText="update juneinternship set FirstName=@firstname,LastName=@lastname,Age=@age where Id=5";
                cmd.Parameters.AddWithValue("@firstname", person.FirstName);
                cmd.Parameters.AddWithValue("@lastname", person.LastName);
                cmd.Parameters.AddWithValue("@age", person.Age);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();

            }
        }
        Console.WriteLine("update successful");

    }

    public void Getperson()
    {
        using(SqlConnection conn = new SqlConnection(_connectionstring))
        {
            SqlCommand cmd = new SqlCommand("select * from JuneInternship", conn);
             conn.Open();
             SqlDataReader reader=cmd.ExecuteReader();
            
               if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetInt32(reader.GetOrdinal("Id"))}\t" +
                            $"{reader.GetString(reader.GetOrdinal("Firstname"))}\t" +
                            $"{reader.GetString(reader.GetOrdinal("Lastname"))}\t" +
                            $"{reader.GetInt32(reader.GetOrdinal("Age"))}\t" +
                            $"{reader.GetString(reader.GetOrdinal("Email"))}");




                    }
             }
                   else
                   {
                       Console.WriteLine("does not have data");
                   }
            /*
            if(reader.HasRows)

            {

            while (reader.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
            }

            }
            else
            {
                Console.WriteLine("no data");
            }
              */
            
        }
    }
    public void GetPersonById()
    {
        PersonDto person = new();
        Console.WriteLine("Enter Id to get that person");
        Console.Write("Enter Id: ");
        person.Id=Convert.ToInt32(Console.ReadLine());
        using(SqlConnection con = new SqlConnection(_connectionstring))
        {
            using(SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "select * from JuneInternship where Id=@id";
                cmd.Parameters.AddWithValue("@id", person.Id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[1], reader[2], reader[3], reader[4]);
                }
                con.Close();
            }
            
        }

    }
}