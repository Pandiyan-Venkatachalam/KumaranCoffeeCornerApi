using Microsoft.EntityFrameworkCore;
using KumaranCoffeeCorner.Models;

namespace KumaranCoffeeCorner.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}