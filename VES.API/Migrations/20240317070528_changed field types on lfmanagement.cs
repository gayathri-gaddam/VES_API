using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class changedfieldtypesonlfmanagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LFManagement",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<double>(
                name: "TotalAmountDue",
                table: "LFManagement",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReceivedDate",
                table: "LFManagement",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostingDate",
                table: "LFManagement",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LateFeeAmount",
                table: "LFManagement",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceDate",
                table: "LFManagement",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DueDate",
                table: "LFManagement",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ApprovedAmount",
                table: "LFManagement",
                type: "float",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "LFManagement",
                columns: new[] { "Id", "AccountNo", "ApprovedAmount", "Creditmethod", "DeclinedReason", "DueDate", "ExpDatetoCredit", "ImpactAmount", "InvoiceDate", "InvoiceSource", "LateFeeAmount", "Name", "PostingDate", "ReceivedDate", "Remarks", "RequestStatus", "RequestedBy", "RootCause1", "RootCause2", "SiteName", "TotalAmountDue", "VendorName", "WaiverStatus" },
                values: new object[] { 277997, "3210131953456", 2.1000000000000001, "", "", "45289", "", "OverDue", "45271", "", 111900.0, "Arch Asset Management LLC", "12/18/2023", "45278.5985417477", "", "Auto Closed", "", "", "", "Austin Woods", 919000.0, "Dominion Energy South Carolina", "Auto Closed" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LFManagement",
                keyColumn: "Id",
                keyValue: 277997);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmountDue",
                table: "LFManagement",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedDate",
                table: "LFManagement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                table: "LFManagement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LateFeeAmount",
                table: "LFManagement",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "LFManagement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "LFManagement",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedAmount",
                table: "LFManagement",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "LFManagement",
                columns: new[] { "Id", "AccountNo", "ApprovedAmount", "Creditmethod", "DeclinedReason", "DueDate", "ExpDatetoCredit", "ImpactAmount", "InvoiceDate", "InvoiceSource", "LateFeeAmount", "Name", "PostingDate", "ReceivedDate", "Remarks", "RequestStatus", "RequestedBy", "RootCause1", "RootCause2", "SiteName", "TotalAmountDue", "VendorName", "WaiverStatus" },
                values: new object[] { 10, "123", null, null, null, null, null, null, null, null, null, "A", null, null, null, null, null, null, null, "B", null, "D", null });
        }
    }
}
