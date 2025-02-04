using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class DetallesFactura
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Factura")]
    public int IdFactura { get; set; }

    [JsonIgnore]
    public Factura? Factura { get; set; }

    [ForeignKey("Producto")]
    public int IdProducto { get; set; }

    [JsonIgnore]
    public Producto? Producto { get; set; }

    [Required]
    public int CantidadDeProducto { get; set; }

    [Required]
    public decimal PrecioUnitarioProducto { get; set; }

    [Required]
    public decimal SubtotalProducto { get; set; }

    public string Notas { get; set; }
}
