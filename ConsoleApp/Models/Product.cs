using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
public class Product
{
   public int Id { get; set; }
    public string PName { get; set; } = null!;

    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }

}
