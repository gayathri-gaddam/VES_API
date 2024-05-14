using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace VES.API.Models.Domain
{
    [Table("Site",Schema ="VES")]
    [PrimaryKey(nameof(CDSPMCID), nameof(CDSEntrySequenceID))]
    public class Site
    {
        public long CDSEntrySequenceID { get; set; }
        public int CDSPMCID { get; set; }
        public string? SiteName { get; set; }   
        public int? SiteID { get; set; }
        public int? PMCID {  get; set; }
    }
}
