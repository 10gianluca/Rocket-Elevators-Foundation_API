using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketApi.Models
{
    public class Elevator
    {
        public int Id { get; set; }
        public string? status { get; set; }
         public int column_id { get; set; }
        [ForeignKey("column_id")]
        public Column Column{get; set;}

    

    }
}