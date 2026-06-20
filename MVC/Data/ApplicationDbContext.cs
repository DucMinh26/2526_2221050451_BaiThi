
using Microsoft.EntityFrameworkCore;
using MVC.Models.Entities;

namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhongBan> PhongBans { get; set; }
    }
}
