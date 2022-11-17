using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;

namespace batteriesApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class batteriesController : ControllerBase
{  
    private readonly RocketElevatorContext _context;

    public batteriesController(RocketElevatorContext context)
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
    public async Task<ActionResult<String>> GetItem(int id)
    {
        var item = await _context.batteries.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }else if (item.status == null)
            {
                return NotFound();
            }

            return item.status;
    }
}