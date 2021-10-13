using Microsoft.EntityFrameworkCore;

namespace Yatik_Task4.Models
{
    public class EFCoreDBContext:DbContext
    {
        public DbSet<Center_Master> Center_Masters { get; set; }
        public EFCoreDBContext(DbContextOptions<EFCoreDBContext> options): base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

