using Microsoft.AspNetCore.Mvc;
using RocketApi;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase{
        private readonly RocketElevatorContext _context;
        public BuildingController(RocketElevatorContext context) => _context = context;
        [HttpGet("Intervention")]
        public async Task<IActionResult> GetBuildingsWhoNeedIntervention() {
            var buildings = _context.Buildings.Where(b => b.Batteries.Any(bat => bat.status == "Intervention" || bat.Columns
            .Any(c => c.status == "Intervention" || c.Elevators
            .Any(e => e.status == "Intervention"))));
            return Ok(buildings);
        }  

        // public async Task<IActionResult> Interventions_Building(){
        //   for(int i =0 ; i<99 ; i++ )  
        //   {
        //     var building= _context.batteries.Where(b =>  == i)
        //   }
        // }
    }
    }
