

using Microsoft.Identity.Client;

namespace VES.API.Models.DTO
{
    public class PBDTO
    {
        public string? PMCName {  get; set; }
        public int? SiteID { get; set; }
        public int? InvoiceID { get; set; }
        public DateTime? PostingDate { get; set; }
        public decimal? PriorBalance { get; set; }
        public decimal? CurrentAmount { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? NoticeDate { get; set; }
        public DateTime? ImpactDate { get; set; }
        public decimal? ImpactAmount { get; set; }
        public string? SiteName { get; set; }
        public long? EntryID { get; set; }
        public string? VendorName { get; set; }
        public string? AccountNo { get; set; } 
    }
}
