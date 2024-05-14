using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VES.API.Models.Domain
{
    [Table("vesNotice",Schema = "OneSitePMC")]
    [PrimaryKey(nameof(CDSPMCID),nameof(CDSEntrySequenceID))]
    public class VesNotice
    {
        
        public int CDSEntrySequenceID { get; set; }
        
        public int CDSPMCID { get; set; }
        public DateTime ImpactDate { get; set; }
        public DateTime NoticeDate { get; set; }
        public decimal ImpactAmount { get; set; }
        public int BatchItemID {  get; set; }
        public int InvoiceID { get; set; }
    }
}
