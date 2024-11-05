using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdProduct { get; set; }

    [Required]
    public string? ProductCode { get; set; }

    [Required]
    public string? ProductType { get; set; }

    public string? Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(12,2)")]
    public decimal UnitPrice { get; set; }

    [Required]
    public int QtyInStock { get; set; }
}
