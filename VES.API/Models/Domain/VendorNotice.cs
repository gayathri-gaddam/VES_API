using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace VES.API.Models.Domain
{
    [Table("VelocityVendorNotice", Schema = "OneSitePMC")]
    [PrimaryKey(nameof(CDSPMCID), nameof(CDSEntrySequenceID))]
    public class VendorNotice
    {
        public int CDSPMCID { get; set; }
        public long CDSEntrySequenceID { get; set; }
        public DateTime? NoticeDate { get; set; }
        public DateTime? ImpactDate { get; set; }
        public int? VendorAccountID { get; set; }
    }
    
}
