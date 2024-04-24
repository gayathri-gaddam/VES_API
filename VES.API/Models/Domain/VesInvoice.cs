using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace VES.API.Models.Domain
{
    [Table("vesInvoice",Schema = "OneSitePMC")]
    [PrimaryKey(nameof(CDSPMCID), nameof(CDSEntrySequenceID))]
    public class VesInvoice
    {
        public long CDSEntrySequenceID { get; set; }
      
        public int CDSPMCID { get; set; }
        public int SiteID { get; set; }
        public int InvoiceID { get; set; }
        public DateTime PostingDate { get; set; }
        public decimal CurrentAmount { get; set; }
        public decimal PriorBalance { get; set; }
        public DateTime InvoiceDate { get; set; }

    }
}
