using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketApi.Models 
{
    public class Column 
    {
        public int id { get; set; }
        public string? status { get; set; }
        public List<Elevator> Elevators { get; set;}
        public int battery_id { get; set; }
        [ForeignKey("battery_id")]
        public batteries batteries { get; set; }
    }
}