using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace VES.API.Models.Domain
{
    [Table("Vendor", Schema = "VES")]
    [PrimaryKey(nameof(CDSPMCID))]
    public class Vendor
    {
        public int CDSPMCID { get; set; }
        public string? VendorName { get; set; }
        public int? VendorID {  get; set; }
    }
}
