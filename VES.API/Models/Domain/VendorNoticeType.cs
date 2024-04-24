using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace VES.API.Models.Domain
{

    [Table("VelocityVendorNoticeType", Schema = "OneSitePMC")]
    [PrimaryKey(nameof(CDSPMCID), nameof(CDSEntrySequenceID))]
    public class VendorNoticeType
    {
        public int CDSPMCID { get; set; }
        public long CDSEntrySequenceID { get; set; }
        public string? NoticeType { get; set; }
    }
}
