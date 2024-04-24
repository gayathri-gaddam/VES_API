using Azure.Core;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using VES.API.Models.Domain;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

            /*modelBuilder.Entity<PastDue>().HasData(
                new PastDue
                {
                    entryId = 7910,
                    pmc = "Multifamily Management Services, LLC",
                    invoiceID = 225289,
                    type = "Master",
                    siteName = "280 Park Place",
                    vendorName = "Get-A-Can Recycling",
                    accountNo = "014205",
                    invoiceDate = "10/1/2023",
                    hascontBFs = "1",
                    postingDate = "10/17/2023",
                    priorBalance = "5/17/1900",
                    currentCharges = "$123.00",
                    lfAmount = "$0.00",
                    Priority = "New",
                    TemplateAmount = "0",
                    PrimaryRc = "",
                    Rc1 = "Missing Audited Invoice",
                    Rc2 = "Final Invoice",
                    Notes = "Payment ID and Date Posted Entered"
                });*/
            modelBuilder.Entity<LFManagement>().HasData(
            new LFManagement
            {
                Id = 277997,
                Name= "Arch Asset Management LLC",
                SiteName= "Austin Woods",
                VendorName= "Dominion Energy South Carolina",
                AccountNo= "3210131953456",
                InvoiceDate= "45271",
                DueDate= "45289",
                PostingDate= "12/18/2023",
                ReceivedDate= "45278.5985417477",
                TotalAmountDue=919000,
                LateFeeAmount=111900,
                ImpactAmount="OverDue",
                RequestedBy="Philipines team",
                ExpDatetoCredit="",
                WaiverStatus="Auto Closed",
                Remarks="",
                RootCause1="Error in the System",
                RootCause2="",
                Creditmethod="Simple Bills",
                RequestStatus="Auto Closed",
                ApprovedAmount=2.10,
                DeclinedReason="Error in the System",
                InvoiceSource="Philips",
            });
            
            
        }
    }
}
