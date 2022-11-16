using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RocketApi.Models
{
    // Name of the public class below is RocketElevatorContext because it involves the whole Rocket ////Elevator Database, so to not mix this with the actual elevator models or controller it should be named as it is in this commit.
    public class RocketElevatorContext : DbContext
    {
        public RocketElevatorContext(DbContextOptions<RocketElevatorContext> options)
            : base(options)
        {
        }

        public DbSet<Elevator> elevators { get; set; } = null!;

        public DbSet<Column> columns { get; set; } =
        null!;
    }
}