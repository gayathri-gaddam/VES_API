using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace VES.API.Models.Domain
{
    [Table("VendorAccount", Schema = "VES")]
    [PrimaryKey(nameof(CDSEntrySequenceID))]
    public class VendorAccount
    {
        public int? CDSEntrySequenceID { get; set; }
        public int? SiteID { get; set; }
        public int? VendorID {  get; set; }
    }
}
