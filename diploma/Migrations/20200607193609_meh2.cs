using Microsoft.EntityFrameworkCore.Migrations;

namespace diploma.Migrations
{
    public partial class meh2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Themes_Subjects_SubjectId",
                table: "Themes");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Themes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Themes_Subjects_SubjectId",
                table: "Themes",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Themes_Subjects_SubjectId",
                table: "Themes");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Themes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Themes_Subjects_SubjectId",
                table: "Themes",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
