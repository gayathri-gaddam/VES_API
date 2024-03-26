using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class changedfielddatatypesinlfmanagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LFManagement",
                keyColumn: "Id",
                keyValue: 277997,
                columns: new[] { "Creditmethod", "DeclinedReason", "InvoiceSource", "RequestedBy", "RootCause1" },
                values: new object[] { "Simple Bills", "Error in the System", "Philips", "Philipines team", "Error in the System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LFManagement",
                keyColumn: "Id",
                keyValue: 277997,
                columns: new[] { "Creditmethod", "DeclinedReason", "InvoiceSource", "RequestedBy", "RootCause1" },
                values: new object[] { "", "", "", "", "" });
        }
    }
}
