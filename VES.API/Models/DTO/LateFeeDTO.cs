namespace VES.API.Models.DTO
{
    public class LateFeeDTO
    {
        public string? PMCName { get; set; }
        public string? SiteName { get; set; }
        public string? VendorName { get; set; }
        public int? InvoiceId { get; set; }
        public string? AccountNo { get; set; }
        public DateTime? InvoiceDate {get; set;}
        public DateTime? DueDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public decimal? ImpactAmount { get; set; }

    }
}
