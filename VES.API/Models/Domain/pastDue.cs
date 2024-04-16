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
        public int? siteId { get; set; }
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

        public PastDue()
        {
            entryId = 0;
            pmc = null;
            invoiceId = 0;
            type = null;
            siteId = 0;
            vendorName = null;
            accountNo = null;
            invoiceDate = null;
            hascontBFs = null;
            postingDate = null;
            priorBalance = 0;
            currentAmount = null;
            lfAmount = 0;
            priority = null;
            templateAmount = 0;
            primaryRc = null;
            rc1 = null;
            rc2 = null;
            notes = null;
            impactDate = null;
            impactAmount = 0;
            noticeDate= null;
        }
    }
}
