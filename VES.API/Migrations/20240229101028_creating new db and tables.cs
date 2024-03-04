using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class creatingnewdbandtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LFMngment",
                table: "LFMngment");

            migrationBuilder.RenameTable(
                name: "LFMngment",
                newName: "LFManagment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LFManagment",
                table: "LFManagment",
                column: "Id");

            migrationBuilder.InsertData(
                table: "LFManagment",
                columns: new[] { "Id", "AccountNo", "ApprovedAmount", "Creditmethod", "DeclinedReason", "DueDate", "ExpDatetoCredit", "ImpactAmount", "InvoiceDate", "InvoiceSource", "LateFeeAmount", "Name", "PostingDate", "ReceivedDate", "Remarks", "RequestStatus", "RequestedBy", "RootCause1", "RootCause2", "SiteName", "TotalAmountDue", "VendorName", "WaiverStatus" },
                values: new object[] { 10, "123", null, null, null, null, null, null, null, null, null, "A", null, null, null, null, null, null, null, "B", null, "D", null });

            migrationBuilder.InsertData(
                table: "Notices",
                columns: new[] { "entryId", "accountNo", "autoApp", "changeReason", "impactAmount", "impactDate", "noticeActionId", "noticeDate", "noticeId", "noticePbMatchId", "platform", "pmc", "postingDate", "remarks", "resolutionStatus", "siteName", "type", "unitNo", "uploadDate", "userRc", "vendorName", "watchList" },
                values: new object[,]
                {
                    { 89957, "4777230908", "", "", 0.01f, "12/18/2023", "Late Notice_5959Estuary4777230908Gas South_002B_010000", "11/28/2023", 5959, "5959Estuary4777230908Gas South_010000", "VES", "Federal Capital Partners", "12/9/2023", "", "", "Estuary", "Late Notice", "002B", "12/11/2023", "", "Gas South", "" },
                    { 89978, "2222305563", "", "", 32.89f, "12/14/2023", "Late Notice_97909Rosewood Apartments #10110 (26876)2222305563Idaho Power_H102_020100", "12/4/2023", 97909, "97909Rosewood Apartments #10110 (26876)2222305563Idaho Power_020100", "VES", "Greystar Management Services LP", "12/10/2023", "", "", "Rosewood Apartments #10110 (26876)", "Late Notice", "H102", "12/11/2023", "", "Idaho Power", "" }
                });

            migrationBuilder.InsertData(
                table: "PastDues",
                columns: new[] { "EntryId", "AccountNo", "CurrentCharges", "HascontBFs", "InvoiceDate", "InvoiceID", "LfAmount", "Notes", "PMC", "PostingDate", "PrimaryRc", "PriorBalance", "Priority", "Rc1", "Rc2", "SiteName", "TemplateAmount", "Type", "VendorName" },
                values: new object[] { 5896, "", "", "", "", 1, "", "", "A", "", "", "", "", "", "", "", "", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LFManagment",
                table: "LFManagment");

            migrationBuilder.DeleteData(
                table: "LFManagment",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Notices",
                keyColumn: "entryId",
                keyValue: 89957);

            migrationBuilder.DeleteData(
                table: "Notices",
                keyColumn: "entryId",
                keyValue: 89978);

            migrationBuilder.DeleteData(
                table: "PastDues",
                keyColumn: "EntryId",
                keyValue: 5896);

            migrationBuilder.RenameTable(
                name: "LFManagment",
                newName: "LFMngment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LFMngment",
                table: "LFMngment",
                column: "Id");
        }
    }
}
