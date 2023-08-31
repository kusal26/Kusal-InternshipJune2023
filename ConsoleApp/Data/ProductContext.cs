public class ProductContext: DbContext
{
    public DbSet<Product> Products { get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Intern;trustServerCertificate=True");
}
