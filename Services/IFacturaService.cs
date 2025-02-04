using System.Collections.Generic;
using System.Threading.Tasks;

public interface IFacturaService
{
    Task<IEnumerable<Factura>> ObtenerFacturas();
    Task<IEnumerable<Factura>> ObtenerFacturasPorCliente(int idCliente);
    Task<Factura> ObtenerFacturaPorNumero(int numeroFactura);

    Task<Factura> CrearFactura(Factura factura);
}
