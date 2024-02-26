using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VES.API.Models.Domain
{
    public class LFMngment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string SiteName { get; set; }

        public string VendorName { get; set; }

        public string AccountNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? PostingDate { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public decimal? TotalAmountDue { get; set; }

        public decimal? LateFeeAmount { get; set; }

        
        public string? ImpactAmount { get; set; }

        public string? RequestedBy { get; set; }

        public string? RootCause1 { get; set; }

        public string? RootCause2 { get; set;}

        public string? Remarks { get; set;}

        public string? Creditmethod { get; set; }

        public string? ExpDatetoCredit { get; set; }

        public string? WaiverStatus { get; set; }

        public string? RequestStatus { get; set; }

        public string? ApprovedAmount { get; set; }

        public string? DeclinedReason { get; set; }

        public string? InvoiceSource { get; set; }
    }
}
