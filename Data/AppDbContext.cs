using Microsoft.EntityFrameworkCore;
using static Geroy.Models.InventoryModel;

namespace Geroy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
               : base(options)
        {

        }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}