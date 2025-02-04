using System.Collections.Generic;
using System.Threading.Tasks;

public interface IClienteService
{
    Task<Cliente> CrearCliente(Cliente cliente);
    Task<IEnumerable<Cliente>> ObtenerClientes();
}
