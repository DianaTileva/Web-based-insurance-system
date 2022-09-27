using System.Data.Entity;

namespace WebApplication5.Models
{
    public class SystemDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        // public DbSet<Student> Students { get; set; }
    }
}