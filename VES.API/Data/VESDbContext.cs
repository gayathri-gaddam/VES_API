using Microsoft.EntityFrameworkCore;
using VES.API.Models.Domain;

namespace VES.API.Data
{
    //VESDbContext extends from DbContext   
    // : that means inherits
    public class VESDbContext : DbContext
    {
        public VESDbContext(DbContextOptions dbContextOptions) :base(dbContextOptions)
        {
            
        }

        public DbSet<LFMngment> LFMngment{ get; set; }
        public DbSet<pastDue> pastDues { get; set; }
    }
}
