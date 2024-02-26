using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class PBChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentCharges",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HascontBFs",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LfAmount",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostingDate",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryRc",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriorBalance",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rc1",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rc2",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemplateAmount",
                table: "pastDues",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentCharges",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "HascontBFs",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "LfAmount",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "PostingDate",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "PrimaryRc",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "PriorBalance",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "Rc1",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "Rc2",
                table: "pastDues");

            migrationBuilder.DropColumn(
                name: "TemplateAmount",
                table: "pastDues");
        }
    }
}
