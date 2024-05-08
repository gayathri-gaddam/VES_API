namespace VES.API.Models.DTO
{
    public class LateFeeDTO
    {
        public int? InvoiceId { get; set; }
        public int? AccountNo { get; set; }
        public DateTime? InvoiceDate {get; set;}
        public DateTime? DueDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public decimal? ImpactAmount { get; set; }

    }
}
