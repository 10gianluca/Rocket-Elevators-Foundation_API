using System;
using System.Collections.Generic;
using RocketApi.Models;

namespace RocketApi
{
    public partial class Employee
    {
        public long Id { get; set; }
        public String? Title { get; set; }
        public String? FirstName { get; set;}
        public String? LastName { get; set; }
        public String? Email { get; set; }
        public String? Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
