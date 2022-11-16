using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;

namespace ColumnApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ColumnController : ControllerBase
{
    private readonly RocketElevatorContext _context;

    public ColumnController(RocketElevatorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Column>>> GetColumnItems()
    {
        return await _context.columns.ToListAsync();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    //GET: api/Column/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }
    //PUT: api/Column/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}


