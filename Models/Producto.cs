using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
    public string ImagenBase64
    {
        get
        {
            if (ImagenProducto == null || ImagenProducto.Length == 0)
            {
                return string.Empty; 
            }
            return Convert.ToBase64String(ImagenProducto);
        }
    }

}
