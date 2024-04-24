using Microsoft.EntityFrameworkCore;
using VES.API.Models.Domain;

namespace VES.API.Data
{
    //VESDbContext extends from DbContext   
    // : that means inherits
    public class VESDbContext : DbContext
    {
        public VESDbContext(DbContextOptions<VESDbContext> dbContextOptions) :base(dbContextOptions){ }

        public DbSet<LFManagement> LFManagement{ get; set; }
        public DbSet<PastDue> PastDues { get; set; }
        public DbSet<Notice> Notices { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
