using Microsoft.EntityFrameworkCore;
using KumaranCoffeeCorner.Models;

namespace KumaranCoffeeCorner.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }

}
