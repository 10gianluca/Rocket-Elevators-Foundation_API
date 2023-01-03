using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi;
using RocketApi.Models;

namespace EmployeeApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class EmployeeController : ControllerBase
{  
    private readonly RocketElevatorContext _context;

    public EmployeeController(RocketElevatorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeeItems()
    {
        return await _context.employees.ToListAsync();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    //GET: api/Employee/5
    [HttpGet("{id}")]
    public async Task<ActionResult<string>> GetEmployeeEmail(long id)
    {
        var employee = await _context.employees.FindAsync(id);
            if(employee == null) 
            { 
                return NotFound(); 
            }else if (employee.Email == null)
            {
                return NotFound();
            }
            return employee.Email;
    }
}