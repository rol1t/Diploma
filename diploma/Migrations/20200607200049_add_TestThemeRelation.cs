using Microsoft.EntityFrameworkCore.Migrations;

namespace diploma.Migrations
{
    public partial class add_TestThemeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Themes_Tests_TestId",
                table: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_Themes_TestId",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Themes");

            migrationBuilder.CreateTable(
                name: "TestThemes",
                columns: table => new
                {
                    TestId = table.Column<int>(nullable: false),
                    ThemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestThemes", x => new { x.TestId, x.ThemeId });
                    table.ForeignKey(
                        name: "FK_TestThemes_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestThemes_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestThemes_ThemeId",
                table: "TestThemes",
                column: "ThemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestThemes");

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Themes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Themes_TestId",
                table: "Themes",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Themes_Tests_TestId",
                table: "Themes",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
