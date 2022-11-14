using System;
using Microsoft.AspNetCore.Mvc;

namespace listOfElevatorsNotInOperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ListOfElevatorsThatAreNotInOperationController : ControllerBase
    {
        // GET: api/ListOfElevatorsThatAreNotInOperation
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

    //GET api/<ListOfElevatorsThatAreNotInOperation>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    // POST api/<ListOfElevatorsThatAreNotInOperation>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    // PUT api/<ListOfElevatorsThatAreNotInOperation>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

    // DELETE api/<ListOfElevatorsThatAreNotInOperation>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
