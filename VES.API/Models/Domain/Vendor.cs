using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations.Schema;

namespace VES.API.Models.Domain
{
    [Table("Vendors", Schema = "OneSiteProperty")]
    [PrimaryKey(nameof(CDSPMCID))]
    public class Vendor
    {
        public int CDSPMCID { get; set; }
        public string? vndName { get; set; }
    }
}
