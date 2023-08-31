using System;
using System.Linq;


public class ProductRepository : IProductRepository
{
    private readonly ProductContext _context;

    public ProductRepository(ProductContext context)
    {
        _context = context;
    }

    public void ShowProduct()
    {
        var products = _context.Products.ToList();

        foreach (var item in products)
        {
            Console.WriteLine($"{item.Id} " +
                $" {item.PName}\t" +
                $" Price: {item.Price}");
            
        }
            Console.WriteLine("---------------------------");
    }
    public void DeleteProduct()
    {

        Console.WriteLine("----------------------");
        Console.WriteLine("deletion of record by id");
        Console.WriteLine("insert the id to delete corresponding record");
        int dId = Convert.ToInt32(Console.ReadLine());
        var Did = _context.Products.Where(c => c.Id == dId).FirstOrDefault();
        _context.Products.Remove(Did);
        _context.SaveChanges();
        Console.WriteLine("record deleted");

    }
    public void UpdateProduct()
    {
        Console.WriteLine("insert the id to be updated");
        int updateId = Convert.ToInt32(Console.ReadLine());
        var UpdateId = _context.Products.Where(c => c.Id == updateId).FirstOrDefault();
        if (UpdateId != null)
        {
            Console.WriteLine("enter the updated name");
            string updatedName = Console.ReadLine();
            UpdateId.PName = updatedName;
            Console.WriteLine("enter the updated price");
            decimal updatedPrice = Convert.ToDecimal(Console.ReadLine());
            UpdateId.Price = updatedPrice;
            _context.SaveChanges();
            Console.WriteLine("record updated");
        }
    }
    public void CreateProduct()
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
            _context.Products.Add(p1);
            _context.SaveChanges();
            Console.WriteLine("Record Added");
        }
}
