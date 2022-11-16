using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;

namespace ElevatorApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ElevatorController : ControllerBase
{  
    private readonly RocketElevatorContext _context;

    public ElevatorController(RocketElevatorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Elevator>>> GetElevatorItems()
    {
        return await _context.elevators.ToListAsync();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    // GET: api/Elevator/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }
    // PUT: api/Elevator/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}