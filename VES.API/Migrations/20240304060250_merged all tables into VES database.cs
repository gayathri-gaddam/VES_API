using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class mergedalltablesintoVESdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LFManagment");

            migrationBuilder.CreateTable(
                name: "LFManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmountDue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LateFeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImpactAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RootCause1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RootCause2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creditmethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpDatetoCredit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaiverStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclinedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceSource = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LFManagement", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LFManagement",
                columns: new[] { "Id", "AccountNo", "ApprovedAmount", "Creditmethod", "DeclinedReason", "DueDate", "ExpDatetoCredit", "ImpactAmount", "InvoiceDate", "InvoiceSource", "LateFeeAmount", "Name", "PostingDate", "ReceivedDate", "Remarks", "RequestStatus", "RequestedBy", "RootCause1", "RootCause2", "SiteName", "TotalAmountDue", "VendorName", "WaiverStatus" },
                values: new object[] { 10, "123", null, null, null, null, null, null, null, null, null, "A", null, null, null, null, null, null, null, "B", null, "D", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LFManagement");

            migrationBuilder.CreateTable(
                name: "LFManagment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creditmethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeclinedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpDatetoCredit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImpactAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoiceSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LateFeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RootCause1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RootCause2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmountDue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaiverStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LFManagment", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LFManagment",
                columns: new[] { "Id", "AccountNo", "ApprovedAmount", "Creditmethod", "DeclinedReason", "DueDate", "ExpDatetoCredit", "ImpactAmount", "InvoiceDate", "InvoiceSource", "LateFeeAmount", "Name", "PostingDate", "ReceivedDate", "Remarks", "RequestStatus", "RequestedBy", "RootCause1", "RootCause2", "SiteName", "TotalAmountDue", "VendorName", "WaiverStatus" },
                values: new object[] { 10, "123", null, null, null, null, null, null, null, null, null, "A", null, null, null, null, null, null, null, "B", null, "D", null });
        }
    }
}
