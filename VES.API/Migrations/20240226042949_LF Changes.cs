using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class LFChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovedAmount",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Creditmethod",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeclinedReason",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpDatetoCredit",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImpactAmount",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceSource",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestStatus",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestedBy",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RootCause1",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RootCause2",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WaiverStatus",
                table: "LFMngment",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedAmount",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "Creditmethod",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "DeclinedReason",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "ExpDatetoCredit",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "ImpactAmount",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "InvoiceSource",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "RequestStatus",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "RequestedBy",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "RootCause1",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "RootCause2",
                table: "LFMngment");

            migrationBuilder.DropColumn(
                name: "WaiverStatus",
                table: "LFMngment");
        }
    }
}
