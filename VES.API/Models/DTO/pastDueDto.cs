namespace VES.API.Models.DTO
{
    public class PastDueDTO
    {
        public int? EntryId { get; set; }
        public string? ImpactDate { get; set; }
        public string? PMC { get; set; }
        public string? NoticeDate { get; set; }
        public int? InvoiceID { get; set; }
        public string? ImpactAmount { get; set; }
        public string? Type { get; set; }
        public string? SiteName { get; set; }
        public string? VendorName { get; set; }
        public string? AccountNo { get; set; }
        public string? InvoiceDate { get; set; }
        public string? HascontBFs { get; set; }
        public string? PostingDate { get; set; }
        public string? PriorBalance { get; set; }
        public string? CurrentAmount{ get; set; }
        public string? LfAmount { get; set; }
        public string? Priority { get; set; }
        public string? TemplateAmount { get; set; }
        public string? PrimaryRc { get; set; }
        public string? Rc1 { get; set; }
        public string? Rc2 { get; set; }
        public string? Notes { get; set; }
    }
}
