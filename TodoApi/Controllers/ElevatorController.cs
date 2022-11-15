using ElevatorApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElevatorApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ElevatorController : ControllerBase
{  
    private readonly ElevatorContext _context;

    public ElevatorController(ElevatorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<ElevatorItem>> GetAll()
    {
        return _context.ElevatorItems.ToList();
    }

    [HttpGet("{id}", Name = "GetElevator")]
    public ActionResult<ElevatorItem> GetById(long id)
    {
        var item = _context.ElevatorItems.Find(id);
        if (item == null)
        {
            return NotFound();
        }
        return item;
    }

    [HttpPost]
    public IActionResult Create(ElevatorItem item)
    {
        _context.ElevatorItems.Add(item);
        _context.SaveChanges();

        return CreatedAtRoute("GetElevator", new { id = item.Id }, item);
    }

    [HttpPut("{id}")]
    public IActionResult Update(long id, ElevatorItem item)
    {
        var elevator = _context.ElevatorItems.Find(id);
        if (elevator == null)
        {
            return NotFound();
        }

        elevator.Name = item.Name;
        elevator.IsComplete = item.IsComplete;

        _context.ElevatorItems.Update(elevator);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        var elevator = _context.ElevatorItems.Find(id);
        if (elevator == null)
        {
            return NotFound();
        }

        _context.ElevatorItems.Remove(elevator);
        _context.SaveChanges();
        return NoContent();
    }
}
