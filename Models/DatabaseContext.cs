using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RocketApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<batteries> batteries { get; set; } = null!;

        public IEnumerable<batteries> GetItem()
        {
            return batteries;
        }
        
        public batteries GetItem(int id)
        {
            return batteries.Where(batteries => batteries.Id == id).SingleOrDefault();
        }
    }
}