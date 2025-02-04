using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost("crear")]
    public async Task<IActionResult> CrearCliente([FromBody] Cliente cliente)
    {
        var nuevoCliente = await _clienteService.CrearCliente(cliente);
        return Ok(nuevoCliente);
    }

    [HttpGet("listar")]
    public async Task<IEnumerable<Cliente>> ObtenerClientes()
    {
        return await _clienteService.ObtenerClientes();
    }
}
