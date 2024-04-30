using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Models.Domain;

namespace VES.API.DBContext
{
    /*public class VesDBContext : DbContext
    {
        public VesDBContext(DbContextOptions<VesDBContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Site> Sites { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("CDSConnectionString");
        }
    }*/
}
