using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketApi.Models
{
    public class batteries
    {
        public int Id { get; set; }
        public string? status { get; set; }
        public List<Column> Columns { get; set;}
         public long? building_id { get; set; }
        [ForeignKey("building_id")]
         public Building Building { get; set; }

    }
    }

