using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ProductoController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("listar")]
    public async Task<IActionResult> ObtenerProductos()
    {
        var productos = await _context.Productos
            .Select(p => new
            {
                p.Id,
                p.NombreProducto,
                ImagenBase64 = p.ImagenProducto != null ? Convert.ToBase64String(p.ImagenProducto) : null,
                p.PrecioUnitario,
                p.Ext
            })
            .ToListAsync();

        return Ok(productos);
    }

}
