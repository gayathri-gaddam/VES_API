using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VES.API.Models.Domain
{
    public class PastDue
    {
        [Key]
        public int? entryId { get; set; }
        public string? pmc { get; set; }
        public int? invoiceId { get; set; }
        public string? type { get; set; }
        public int? siteName { get; set; }
        public string? vendorName { get; set; }
        public string? accountNo { get; set; }
        public string? invoiceDate { get; set; }
        public string? impactDate { get; set; }
        public string? hascontBFs { get; set; }
        public string? postingDate { get; set; }
        public int? priorBalance { get; set; }
        public int? currentAmount { get; set; }
        public int? lfAmount { get; set; }
        public string? priority { get; set; }
        public int? templateAmount { get; set; }
        public string? primaryRc { get; set; }
        public string? rc1 { get; set; }
        public string? rc2 { get; set; }
        public string? notes { get; set; }
        public int? impactAmount { get; set; }
        public string? noticeDate { get; set; }

    }
}
