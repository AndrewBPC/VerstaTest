using Microsoft.EntityFrameworkCore;
using VerstaApi.Models;

namespace VerstaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
        public DbSet<Order> Orders { get; set; } = null!;
    }
}
