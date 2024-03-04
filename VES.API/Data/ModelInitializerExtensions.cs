using Microsoft.EntityFrameworkCore;
using VES.API.Models.Domain;
namespace VES.API.Data
{
    public static class ModelInitializerExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notice>().HasData(
                new Notice
                {
                    entryId = 89957,
                    pmc = "Federal Capital Partners",
                    noticeId = 5959,
                    type = "Late Notice",
                    siteName = "Estuary",
                    vendorName = "Gas South",
                    accountNo = "4777230908",
                    noticeDate = "11/28/2023",
                    unitNo = "002B",
                    postingDate = "12/9/2023",
                    impactDate = "12/18/2023",
                    impactAmount = 0.01f,
                    platform = "VES",
                    uploadDate = "12/11/2023",
                    noticeActionId = "Late Notice_5959Estuary4777230908Gas South_002B_010000",
                    noticePbMatchId = "5959Estuary4777230908Gas South_010000",
                    watchList = "",
                    remarks = "",
                    resolutionStatus = "",
                    changeReason = "",
                    autoApp = "",
                    userRc = ""
                },
                new Notice
                {
                    entryId = 89978,
                    pmc = "Greystar Management Services LP",
                    noticeId = 97909,
                    type = "Late Notice",
                    siteName = "Rosewood Apartments #10110 (26876)",
                    vendorName = "Idaho Power",
                    accountNo = "2222305563",
                    noticeDate = "12/4/2023",
                    unitNo = "H102",
                    postingDate = "12/10/2023",
                    impactDate = "12/14/2023",
                    impactAmount = 32.89f,
                    platform = "VES",
                    uploadDate = "12/11/2023",
                    noticeActionId = "Late Notice_97909Rosewood Apartments #10110 (26876)2222305563Idaho Power_H102_020100",
                    noticePbMatchId = "97909Rosewood Apartments #10110 (26876)2222305563Idaho Power_020100",
                    watchList = "",
                    remarks = "",
                    resolutionStatus = "",
                    changeReason = "",
                    autoApp = "",
                    userRc = ""
                }
            );

            modelBuilder.Entity<PastDue>().HasData(
                new PastDue
                {
                    EntryId=5896,
                    PMC = "A",
                    InvoiceID = 1,
                    Type = "",
                    SiteName = "",
                    VendorName = "",
                    AccountNo = "",
                    InvoiceDate = "",
                    HascontBFs = "",
                    PostingDate = "",
                    PriorBalance = "",
                    CurrentCharges = "",
                    LfAmount = "",
                    Priority = "",
                    TemplateAmount = "",
                    PrimaryRc = "",
                    Rc1 = "",
                    Rc2 = "",
                    Notes = ""
                });


            modelBuilder.Entity<LFManagment>().HasData(
                new LFManagment
                {
                    Id=10,
                    Name = "A",
                    SiteName="B",
                    VendorName= "D",
                    AccountNo = "123",
                    
                });
        }
    }
}
