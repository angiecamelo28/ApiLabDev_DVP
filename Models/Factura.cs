using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Factura
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime FechaEmisionFactura { get; set; }

    [ForeignKey("Cliente")]
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; }

    [Required]
    public int NumeroFactura { get; set; }

    public int NumeroTotalArticulos { get; set; }

    public decimal SubTotalFacturas { get; set; }

    public decimal TotalImpuestos { get; set; }

    public decimal TotalFactura { get; set; }

    public List<DetallesFactura> Detalles { get; set; } = new List<DetallesFactura>();
}
