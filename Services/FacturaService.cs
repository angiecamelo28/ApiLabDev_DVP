using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FacturaService : IFacturaService
{
    private readonly AppDbContext _context;

    public FacturaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Factura>> ObtenerFacturas()
    {
        return await _context.Facturas.Include(f => f.Detalles).ToListAsync();
    }

    public async Task<IEnumerable<Factura>> ObtenerFacturasPorCliente(int idCliente)
    {
        return await _context.Facturas
            .Include(f => f.Detalles)
            .Where(f => f.IdCliente == idCliente)
            .ToListAsync();
    }

    public async Task<Factura> ObtenerFacturaPorNumero(int numeroFactura)
    {
        return await _context.Facturas
            .Include(f => f.Detalles)
            .FirstOrDefaultAsync(f => f.NumeroFactura == numeroFactura);
    }

    public async Task<Factura> CrearFactura(Factura factura)
    {
        _context.Facturas.Add(factura);
        await _context.SaveChangesAsync();
        return factura;
    }
}
