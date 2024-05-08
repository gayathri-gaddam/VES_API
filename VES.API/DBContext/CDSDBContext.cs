using Microsoft.EntityFrameworkCore;
using VES.API.Models.Domain;

namespace VES.API.Data
{
    //VESDbContext extends from DbContext   
    // : that means inherits
    public class CDSDBContext : DbContext
    {
        public CDSDBContext(DbContextOptions<CDSDBContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<VesNotice> vesNotices { get; set; }
        public DbSet<VesInvoice> vesInvoices { get; set; }
        public DbSet<VendorNotice> vendorNotices { get; set; }
        public DbSet<VendorNoticeType> noticeTypes { get; set; }
        public DbSet<Site> sites { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<PMC> pmcs { get; set; }

        public DbSet<VendorAccount> vendorAccounts {  get; set; } 
    }
}
