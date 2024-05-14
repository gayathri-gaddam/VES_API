using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace VES.API.Models.Domain
{
    [Table("PMC", Schema = "VES")]
    [PrimaryKey(nameof(CDSPMCID))]
    public class PMC
    {
        public int? CDSPMCID { get; set; }
        public string? PMCName {  get; set; }
        public int? PMCID {  get; set; }
    }
}
