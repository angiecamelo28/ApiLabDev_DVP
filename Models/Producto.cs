using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Producto
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string NombreProducto { get; set; }

    public byte[] ImagenProducto { get; set; }

    [Required]
    public decimal PrecioUnitario { get; set; }

    public string Ext { get; set; }
    [NotMapped]
    public string ImagenBase64 => ImagenProducto != null ? Convert.ToBase64String(ImagenProducto) : null;

}
