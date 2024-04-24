namespace VES.API.Models.DTO
{
    public class NoticesDTO
    {
        public DateTime? NoticeDate { get; set; }
        public DateTime? ImpactDate { get; set; }
        public int? VendorAccountID { get; set; }
        public string? Type { get; set; }
        public decimal? ImpactAmount { get; set; }
    }
}
