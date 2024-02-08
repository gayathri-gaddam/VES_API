using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VES.API.Models.DTO
{
    public class LFMngmentDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string SiteName { get; set; }

        public string VendorName { get; set; }

        public string AccountNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? PostingDate { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public decimal? TotalAmountDue { get; set; }

        public decimal? LateFeeAmount { get; set; }
    }
}
