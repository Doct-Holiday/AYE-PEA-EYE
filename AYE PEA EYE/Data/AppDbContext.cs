using AYE_PEA_EYE.Models;
using Microsoft.EntityFrameworkCore;

namespace AYE_PEA_EYE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customers> Customers { get; set; }
    }
}
