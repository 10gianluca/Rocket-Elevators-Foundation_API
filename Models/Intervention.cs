using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketApi.Models
{
    public class Intervention
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public int CustomerID { get; set; }
        public int BuildingID{get; set;}
        public int BatteryID{get; set;}
        public int ColumnID{get; set;}
        public int ElevatorID{get; set;}
        public string? EmployeeID{get; set;}
        public string? StartDate{get; set;}
        public string? EndDate{get; set;}
        public string? Result{get; set;}
        public string? Report{get; set;}
        public string Status{get; set;}


    }
    }

