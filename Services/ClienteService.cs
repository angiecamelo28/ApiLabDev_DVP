using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ClienteService : IClienteService
{
    private readonly AppDbContext _context;

    public ClienteService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Cliente> CrearCliente(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
        return cliente;
    }

    public async Task<IEnumerable<Cliente>> ObtenerClientes()
    {
        return await _context.Clientes.ToListAsync();
    }
}
