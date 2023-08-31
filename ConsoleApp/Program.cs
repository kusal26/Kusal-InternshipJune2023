//DayOne day1 = new();
//day1.Sum(10, 20);


/*
DayTwo day2 = new();

day2.GetPersons();
day2.GetStudent();
*/

/*
//assignment given on day two
AssignmentDayTwo assignmentDayTwo = new AssignmentDayTwo();
assignmentDayTwo.ReturnMonth(5);
int[] arr = { 17, 15, 9, 1, 11 };
assignmentDayTwo.FindMinMax(arr);
int[] array = {5,1,9,-8,7};
assignmentDayTwo.getAbsSum(array);
assignmentDayTwo.CalExponent(3, 3);
assignmentDayTwo.MultiplybyLength(array);
assignmentDayTwo.NameShuffle("Harry potter");
assignmentDayTwo.smallerNum("78", "45");
assignmentDayTwo.Factorial(5);
assignmentDayTwo.SortAscending(array);
assignmentDayTwo.countvowel("Nepal");
assignmentDayTwo.countvowel("Bangladesh");
*/

/*
 //      Day Three

using System.Net;
///<summary>
///use of record which is new reference type introduced in c#9.
/// </summary>
Location person1 = new Location
{
    Address = "Kathmandu",
    Province = "Bagmati"
};

//we cannot modify the content of record . it is immutable
//person1.Province = "Gandaki";
=======
//DayTwo day2 = new();
//day2.GetPersons();

//DayThree.GetMonth(4);

//DayFour day4 = new();
//day4.Example1();
>>>>>>> 04f1556a9670803b6864ee459290b9964ddea5a8

//LinqQueries linqs = new();
//linqs.FilteringElements();
//linqs.SortingElements();
//linqs.SelectSpecifics();
//linqs.Aggregation();
//linqs.JoinLists();
//linqs.DistinctValues();
//linqs.SkipMe(4);
//linqs.TakeMe(4);
//linqs.CountMe();
//linqs.AmThere();
//linqs.FirstAndLast();
//linqs.FindMax();

PracticeADO practiceADO = new();
//practiceADO.CheckConnection();
//practiceADO.AddPerson();
//practiceADO.UpdatePerson();
practiceADO.GetPeople();

//we can clone record and can modify but original record is not mutated 
//Non destructive mutation

Console.WriteLine($"Person1 is from {person1.Address} which lies in {person1.Province} Province.");

Console.WriteLine("\nNon Destructice cloning\n");
Location person2 = person1 with { Address="Lalitpur" }; 

Console.WriteLine($"Person2 is from {person2.Address} which lies in {person2.Province} Province.");


Location person3 = new Location
{
    Address = "Kathmandu",
    Province = "Bagmati"
};
//value base equal
bool equal1 = (person1 == person3 );
bool equal2 = (person1 == person2);

Console.WriteLine("\nperson1\nAddress = \"Kathmandu\",\r\n   Province = \"Bagmati\"");
Console.WriteLine("\nperson2\nAddress = \"Lalitpur\",\r\n    Province = \"Bagmati\"");


Console.WriteLine("\nperson3\nAddress = \"Kathmandu\",\r\n   Province = \"Bagmati\"");

Console.WriteLine("\nValue based Equality/n");
Console.WriteLine("person1==person3 :: "+equal1+"  person1==person2 :: "+equal2);

Console.WriteLine("\nreferenced based Equality\n");
bool referenceequal=ReferenceEquals(person1, person3);
Console.WriteLine("person1==person3 :: "+referenceequal);


//equality in class

Console.WriteLine("\nEquality in Class\n");
nepal obj=new nepal
{
    
    Address = "Kathmandu",
    Province = "Bagmati"
};
nepal obj2=new nepal
{
    Address = "Kathmandu",
    Province = "Bagmati"
};
Console.WriteLine("\nobj\nAddress = \"Kathmandu\",\r\n    Province = \"Bagmati\"");
Console.WriteLine("\nobj1\nAddress = \"Kathmandu\",\r\n   Province = \"Bagmati\"");


Console.WriteLine("obj1==obj2 :: "+obj.Equals(obj2));

*/

//Day Four 
/*
DayFour dayFour = new DayFour();
//dayFour.GetManufacture();
dayFour.example1();
*/

//DayFour assignment 10 hard questiOn from EDABIT

/*
AssignmentDayFour assignmentDayFour = new AssignmentDayFour();
assignmentDayFour.ReverseAndNot(123);
assignmentDayFour.uncensor("K*thm*nd*","aau");
assignmentDayFour.FindVertex(-1, -1, 25);
bool smooth = assignmentDayFour.IsSmooth("nepal london newyork");
Console.WriteLine(smooth);
bool smooth1 = assignmentDayFour.IsSmooth("nepal london iewyork");
Console.WriteLine(smooth1);
assignmentDayFour.NextPrime(10);
assignmentDayFour.DuplicateCount("aabbcdecdega");
int socks=assignmentDayFour.sockpairs("aabbcdefcaa");
Console.WriteLine("No of socks = {0}",socks);
assignmentDayFour.TOH();

*/
/*
SelfPracticeADO selfpractice = new();
//selfpractice.CheckConnection();
//selfpractice.AddPerson();
selfpractice.Getperson();
//selfpractice.UpdatePerson();
//selfpractice.GetPersonById();
*/
/*
string name =" ";
if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
    Console.WriteLine("name is null or empty or whitespace");
else Console.WriteLine($"name= {name}");
*/
/*
using ProductContext context  = new ProductContext();
Product p1 = new Product()
{
   
    PName = "Iphone",
    Price = 18700
};
context.Products.Add(p1);
Product p2 = new Product()
{ 
   
PName="samsung",
Price=90000
};
context.Products.Add(p2);

context.SaveChanges();
*/

using System.Linq.Expressions;
/*
using ProductContext context = new ProductContext();
int choice;
Console.WriteLine("CRUD OPERATION in DATABASE");
do
{
Console.WriteLine("1.Create\t\t2.Read\n3.Update\t\t4.Delete\n5.Display By Id\t\t6.Exit");
 choice=Convert.ToInt32(Console.ReadLine());


    switch (choice)
    {
        case 1:
            Create();
            break;
        case 2:
            Read();
            break;
        case 3:
            Update();
            break;
        case 4:
            Delete();
            break;
        case 5:
            displayByid();
            break;
        case 6:
            Console.WriteLine("Thank you");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}
while(choice!=6);
void Create()
{
    Console.WriteLine("Insertion into table");
    Console.WriteLine("enter the name of product: ");
    string pname = Console.ReadLine();
    Console.WriteLine("enter the price of product: ");
    var pPrice = Convert.ToDecimal(Console.ReadLine());
    Product p1 = new Product()
    {
        PName = pname,
        Price = pPrice
    };
    context.Products.Add(p1);
    context.SaveChanges();
    Console.WriteLine("Record Added");
}
void Read()
{

    Console.WriteLine("displaying all record");
    var product = context.Products.ToList();
    foreach (var data in product)
    {
        Console.WriteLine($"{data.Id}-----{data.PName}------{data.Price}");
    }
    Console.WriteLine("displayed all the record");
}
void Update()
{
    Console.WriteLine("insert the id to be updated");
    int updateId = Convert.ToInt32(Console.ReadLine());
    var UpdateId = context.Products.Where(c => c.Id == updateId).FirstOrDefault();
    if (UpdateId != null)
    {
        Console.WriteLine("enter the updated name");
        string updatedName = Console.ReadLine();
        UpdateId.PName = updatedName;
        Console.WriteLine("enter the updated price");
        decimal updatedPrice = Convert.ToDecimal(Console.ReadLine());
        UpdateId.Price = updatedPrice;
        context.SaveChanges();
        Console.WriteLine("record updated");

    }
    else
    {
        Console.WriteLine("record not found");
    }
}
void Delete()
{
    Console.WriteLine("----------------------");
    Console.WriteLine("deletion of record by id");
    Console.WriteLine("insert the id to delete corresponding record");
    int dId = Convert.ToInt32(Console.ReadLine());
    var Did = context.Products.Where(c => c.Id == dId).FirstOrDefault();
    context.Products.Remove(Did);
    context.SaveChanges();
    Console.WriteLine("record deleted");


}
void displayByid()
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("display by id");
    Console.WriteLine("enter the id to display ");
    int displayid = Convert.ToInt32(Console.ReadLine());
    var showbyid = context.Products.Where(c => c.Id == displayid).FirstOrDefault();

    Console.WriteLine($"{showbyid.Id}--{showbyid.PName}---{showbyid.Price}");
    context.SaveChanges();
}

*/
/*
using Microsoft.Extensions.DependencyInjection;


        var serviceProvider = new ServiceCollection()
            .AddDbContext<ProductContext>()
            .AddScoped<ProductRepository>()
            .BuildServiceProvider();

        var repository = serviceProvider.GetService<ProductRepository>();
     /*   repository.ShowProduct();
        repository.CreateProduct();
        repository.DeleteProduct();
        repository.UpdateProduct();
     
/*
        int choice;
        do
        {
            Console.WriteLine("1.Create\t\t2.Read\n3.Update\t\t4.Delete\n5.Exit");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    repository.CreateProduct();

                    break;
                case 2:
                    
                    repository.ShowProduct();
                    break;
                case 3:
                    repository.UpdateProduct();
                    break;
                case 4:
                    repository.DeleteProduct();
                    break;
                
                case 5:
                    Console.WriteLine("Thank you");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice!=5);
*/

//Dapper
//
DapperClass dap =new DapperClass();
//dap.checkConnection();
//dap.Insert();
//dap.Update();
//dap.Delete();
//dap.Read();
dap.getById();
//dap.Read();