using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Runtime.Intrinsics.X86;
using VES.API.Data;
using VES.API.DBContext;
using VES.API.Models.DTO;
using VES.API.Types.Interfaces;


namespace VES.API.Services
{
    public class DbAccess:IDbAccess
    {
        
        private readonly CDSDBContext _cdsDbContext;
        private readonly IMapper _mapper;

        public DbAccess(CDSDBContext dbContext,IMapper mapper)
        {
            _mapper = mapper;
            _cdsDbContext = dbContext;
        }
        public async Task<List<PBDTO>> GetPastDuesByLimit(int? page, int? pageSize)
        {


            var UserList = await (from vi in _cdsDbContext.vesInvoices
                                  join vn in _cdsDbContext.vesNotices
                                  on vi.InvoiceID equals vn.InvoiceID
                                  join s in _cdsDbContext.sites
                                  on vi.SiteID equals s.SiteID
                                  join p in _cdsDbContext.pmcs
                                  on s.PMCID equals p.PMCID
                                  join va in _cdsDbContext.vendorAccounts
                                  on vi.VendorAccountID equals va.VendorAccountID
                                  join v in _cdsDbContext.vendors
                                  on va.VendorID equals v.VendorID
                                  select new PBDTO
                                  {
                                      PMCName=p.PMCName,
                                      AccountNo = va.VendorAccountNo,
                                      VendorName =v.VendorName ,
                                      SiteID = vi.SiteID,
                                      InvoiceID = vi.InvoiceID,
                                      PostingDate = vi.PostingDate,
                                      CurrentAmount = vi.CurrentAmount,
                                      PriorBalance = vi.PriorBalance,
                                      InvoiceDate = vi.InvoiceDate,
                                      NoticeDate = vn.NoticeDate,
                                      ImpactDate = vn.ImpactDate,
                                      ImpactAmount = vn.ImpactAmount,
                                      SiteName = s.SiteName,

                                   }).Distinct().Take(10).ToListAsync();


            return UserList;
        }


        public async Task<List<NoticesDTO>> GetNoticesByLimit()
        {
            var UserList = await (from vnn in _cdsDbContext.vendorNotices
                                  join vn in _cdsDbContext.vesNotices
                                   on vnn.CDSPMCID equals vn.CDSPMCID
                                   join nt in _cdsDbContext.noticeTypes 
                                   on vn.CDSPMCID equals nt.CDSPMCID 
                                  select new NoticesDTO
                                  {
                                     NoticeDate=vnn.NoticeDate,
                                     ImpactDate=vnn.ImpactDate,
                                     Type=nt.NoticeType,
                                     VendorAccountID=vnn.VendorAccountID,
                                     ImpactAmount=vn.ImpactAmount

                                  }).Take(10).ToListAsync();

            return UserList;
        }

        public async Task<List<LateFeeDTO>> GetLateFeesByLimit(int? page, int? pageSize)
        {

            var UserList = await (from vi in _cdsDbContext.vesInvoices
                                  join vn in _cdsDbContext.vesNotices
                                   on vi.BatchItemID equals vn.BatchItemID
                                  select new LateFeeDTO
                                  {
                                      InvoiceId = vi.InvoiceID,
                                      InvoiceDate = vi.InvoiceDate,
                                      DueDate = vi.DueDate,
                                      PostingDate= vi.PostingDate,
                                      ImpactAmount=vn.ImpactAmount

                                  }).Take(10).ToListAsync();

            return UserList;
        }
        /* private List<PastDue> GetPastDuesFromReader(SqlDataReader reader)
         {
             List<PastDue> pastDues = new List<PastDue>();

             while (reader.Read())
             {
                 PastDue pastDue = new PastDue();

                 if (reader["siteId"] != DBNull.Value)
                 {
                     pastDue.siteId = Convert.ToInt32(reader["siteId"]);
                 }

                 if (reader["invoiceId"] != DBNull.Value)
                 {
                     pastDue.invoiceId = Convert.ToInt32(reader["invoiceId"]);
                 }

                 if (reader["postingDate"] != DBNull.Value)
                 {
                     pastDue.postingDate = reader["postingDate"].ToString();
                 }

                 if (reader["currentAmount"] != DBNull.Value)
                 {
                     pastDue.currentAmount = Convert.ToInt32(reader["currentAmount"]);
                 }

                 if (reader["priorBalance"] != DBNull.Value)
                 {
                     pastDue.priorBalance = Convert.ToInt32(reader["priorBalance"]);
                 }

                 if (reader["invoiceDate"] != DBNull.Value)
                 {
                     pastDue.invoiceDate = reader["invoiceDate"].ToString();
                 }

                 if (reader["noticeDate"] != DBNull.Value)
                 {
                     pastDue.noticeDate = reader["noticeDate"].ToString();
                 }

                 if (reader["impactDate"] != DBNull.Value)
                 {
                     pastDue.impactDate = reader["impactDate"].ToString();
                 }

                 if (reader["impactAmount"] != DBNull.Value)
                 {
                     pastDue.impactAmount = Convert.ToInt32(reader["impactAmount"]);
                 }

                 pastDues.Add(pastDue);
             }

             return pastDues;
         }*/

    }
}
