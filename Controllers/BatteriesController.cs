using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;

namespace batteriesApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class batteriesController : ControllerBase
{  
    private readonly DatabaseContext _context;

    public batteriesController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<batteries>>> GetbatteriesItems()
    {
        return await _context.batteries.ToListAsync();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    // GET: api/batteries/5
    [HttpGet("{id}")]
    public async Task<ActionResult<batteries>> GetItem(int id)
    {
        var item = await this._context.batteries.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

}