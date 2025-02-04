using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class FacturaController : ControllerBase
{
    private readonly IFacturaService _facturaService;

    public FacturaController(IFacturaService facturaService)
    {
        _facturaService = facturaService;
    }

    [HttpGet("listar")]
    public async Task<IActionResult> ObtenerFacturas()
    {
        var facturas = await _facturaService.ObtenerFacturas();
        return Ok(facturas);
    }

    [HttpGet("buscarPorCliente/{idCliente}")]
    public async Task<IActionResult> ObtenerFacturasPorCliente(int idCliente)
    {
        var facturas = await _facturaService.ObtenerFacturasPorCliente(idCliente);

        if (facturas == null)
            facturas = new List<Factura>(); 

        return Ok(facturas);
    }

    [HttpGet("buscarPorNumero/{numeroFactura}")]
    public async Task<IActionResult> ObtenerFacturaPorNumero(int numeroFactura)
    {
        var factura = await _facturaService.ObtenerFacturaPorNumero(numeroFactura);

        if (factura == null)
            return Ok(null); 

        return Ok(factura);
    }

    [HttpPost("crear")]
    public async Task<IActionResult> CrearFactura([FromBody] Factura factura)
    {
        if (factura == null || factura.Detalles == null || factura.Detalles.Count == 0)
        {
            return BadRequest("La factura no contiene productos.");
        }

        var nuevaFactura = await _facturaService.CrearFactura(factura);

        return Ok(new { mensaje = "Factura creada exitosamente.", facturaId = nuevaFactura.Id });
    }


}
