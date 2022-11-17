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
    public async Task<ActionResult<string>> GetColumnStatus(int id)
    {
        var column = await _context.columns.FindAsync(id);
        if(column == null) { return "no Column with this id"; }
        SetNewColumnStatus(column.id, "Active");
        return column.status;
    }

    //PUT: api/Column/5 THIS LINE SHOULD REPLACE THE VALUE OF THE STATUS WITH WHATEVER WE WANT
    [HttpPut("{id}")]
    public async Task<ActionResult<string>> SetNewColumnStatus(int id, string newStatus)
    {
        var column = await _context.columns.FindAsync(id);
        column.status = newStatus;
        _context.SaveChanges();
        return column.status;
    }
}


