using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VES.API.Models.Domain
{
    public class Temp
    {
        [Key]
        public int? siteID { get; set; }
        public int? invoiceID { get; set; }
        public string? postingDate { get; set; }
        public int? priorBalance { get; set; }
        public int? currentAmount { get; set; }
        public string? invoiceDate { get; set; }    
        public string? noticeDate { get; set; }
        public string? impactDate { get; set; }
        public int? impactAmount { get; set; }

    }
}
