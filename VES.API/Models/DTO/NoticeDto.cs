using System.ComponentModel.DataAnnotations;

namespace VES.API.Models.DTO
{
    public class NoticeDto
    {
        [Key]
        public int entryId { get; set; }
        public string pmc { get; set; }
        public int noticeId { get; set; }
        public string type { get; set; }
        public string siteName { get; set; }
        public string vendorName { get; set; }
        public string accountNo { get; set; }
        public string noticeDate { get; set; }
        public string unitNo { get; set; }
        public string postingDate { get; set; }
        public string impactDate { get; set; }
        public float impactAmount { get; set; }
        public string platform { get; set; }
        public string uploadDate { get; set; }
        public string noticeActionId { get; set; }
        public string noticePbMatchId { get; set; }
        public string watchList { get; set; }
        public string remarks { get; set; }
        public string changeReason { get; set; }
        public string resolutionStatus { get; set; }
        public string autoApp { get; set; }
        public string userRc { get; set; }

    }
}
