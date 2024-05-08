﻿namespace VES.API.Models.DTO
{
    public class InvoiceDTO
    {
        public int? InvoiceID { get; set; }
        public DateTime? PostingDate { get; set; }

        public decimal? CurrentAmount { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? PriorBalance { get; set; }
        public DateTime? NoticeDate { get; set; }
        public DateTime? ImpactDate { get; set; }
        public decimal? ImpactAmount { get; set; }
    }
}