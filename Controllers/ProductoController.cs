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
        var productos = await _context.Productos.ToListAsync();
        return Ok(productos);
    }
}
