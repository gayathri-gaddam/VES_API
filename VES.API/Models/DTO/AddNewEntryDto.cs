namespace VES.API.Models.DTO
{
    public class AddNewEntryDto
    {
          public string? RootCause1 { get; set; }

        public string? RootCause2 { get; set; }

        public string? Remarks { get; set; }

        public string? Creditmethod { get; set; }

        public string? ExpDatetoCredit { get; set; }

        public string? WaiverStatus { get; set; }

        public string? RequestStatus { get; set; }

        public string? ApprovedAmount { get; set; }

        public string? DeclinedReason { get; set; }

        public string? InvoiceSource { get; set; }
    }
}
