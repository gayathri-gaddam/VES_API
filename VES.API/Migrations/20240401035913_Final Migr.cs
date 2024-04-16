using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PastDues",
                keyColumn: "EntryId",
                keyValue: 5896);

            migrationBuilder.InsertData(
                table: "PastDues",
                columns: new[] { "EntryId", "AccountNo", "CurrentCharges", "HascontBFs", "InvoiceDate", "InvoiceID", "LfAmount", "Notes", "PMC", "PostingDate", "PrimaryRc", "PriorBalance", "Priority", "Rc1", "Rc2", "SiteName", "TemplateAmount", "Type", "VendorName" },
                values: new object[] { 7910, "014205", "$123.00", "1", "10/1/2023", 225289, "$0.00", "Payment ID and Date Posted Entered", "Multifamily Management Services, LLC", "10/17/2023", "", "5/17/1900", "New", "Missing Audited Invoice", "Final Invoice", "280 Park Place", "0", "Master", "Get-A-Can Recycling" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PastDues",
                keyColumn: "EntryId",
                keyValue: 7910);

            migrationBuilder.InsertData(
                table: "PastDues",
                columns: new[] { "EntryId", "AccountNo", "CurrentCharges", "HascontBFs", "InvoiceDate", "InvoiceID", "LfAmount", "Notes", "PMC", "PostingDate", "PrimaryRc", "PriorBalance", "Priority", "Rc1", "Rc2", "SiteName", "TemplateAmount", "Type", "VendorName" },
                values: new object[] { 5896, "", "", "", "", 1, "", "", "A", "", "", "", "", "", "", "", "", "", "" });
        }
    }
}
