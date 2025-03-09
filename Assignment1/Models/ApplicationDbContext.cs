using System.Data.Entity;
using Assignment1.Models;

namespace Assignment1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ApplicationDbContext") { }

        public DbSet<Student> Students { get; set; }
    }
}
