using Microsoft.EntityFrameworkCore.Migrations;

namespace diploma.Migrations
{
    public partial class LinkQuestionWithVariant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Questions_QuestionId",
                table: "Variants");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Variants",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Questions_QuestionId",
                table: "Variants",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Questions_QuestionId",
                table: "Variants");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Variants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Questions_QuestionId",
                table: "Variants",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
