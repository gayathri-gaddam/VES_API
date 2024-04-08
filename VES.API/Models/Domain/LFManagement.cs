
using System.ComponentModel.DataAnnotations;

namespace VES.API.Models.Domain
{
    public class LFManagement
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SiteName { get; set; }
        public string VendorName { get; set; }
        public string AccountNo { get; set; }
        public string? InvoiceDate { get; set; }
        public string? DueDate { get; set; }
        public string? PostingDate { get; set; }
        public string? ReceivedDate { get; set; }
        public double? TotalAmountDue { get; set; }
        public double? LateFeeAmount { get; set; }
        public string? ImpactAmount { get; set; }
        public string? RequestedBy { get; set; }
        public string? RootCause1 { get; set; }
        public string? RootCause2 { get; set;}
        public string? Remarks { get; set;}
        public string? Creditmethod { get; set; }
        public string? ExpDatetoCredit { get; set; }
        public string? WaiverStatus { get; set; }
        public string? RequestStatus { get; set; }
        public double? ApprovedAmount { get; set; }
        public string? DeclinedReason { get; set; }
        public string? InvoiceSource { get; set; }

    }
}
