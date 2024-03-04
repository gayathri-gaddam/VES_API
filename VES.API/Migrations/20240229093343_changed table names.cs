using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VES.API.Migrations
{
    /// <inheritdoc />
    public partial class changedtablenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_pastDues",
                table: "pastDues");

            migrationBuilder.RenameTable(
                name: "pastDues",
                newName: "PastDues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PastDues",
                table: "PastDues",
                column: "EntryId");

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    entryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pmc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noticeId = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    siteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noticeDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unitNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    impactDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    impactAmount = table.Column<float>(type: "real", nullable: false),
                    platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uploadDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noticeActionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noticePbMatchId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    watchList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    changeReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resolutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    autoApp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userRc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.entryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PastDues",
                table: "PastDues");

            migrationBuilder.RenameTable(
                name: "PastDues",
                newName: "pastDues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pastDues",
                table: "pastDues",
                column: "EntryId");
        }
    }
}
