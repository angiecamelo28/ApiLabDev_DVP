public class FacturaDTO
{
    public int Id { get; set; }
    public DateTime FechaEmisionFactura { get; set; }
    public int IdCliente { get; set; }
    public int NumeroFactura { get; set; }
    public int NumeroTotalArticulos { get; set; }
    public decimal SubTotalFacturas { get; set; }
    public decimal TotalImpuestos { get; set; }
    public decimal TotalFactura { get; set; }
    public List<DetallesFacturaDTO> Detalles { get; set; } = new List<DetallesFacturaDTO>();
}

public class DetallesFacturaDTO
{
    public int Id { get; set; }
    public int IdFactura { get; set; }
    public int IdProducto { get; set; }
    public int CantidadDeProducto { get; set; }
    public decimal PrecioUnitarioProducto { get; set; }
    public decimal SubtotalProducto { get; set; }
    public string Notas { get; set; }
}
