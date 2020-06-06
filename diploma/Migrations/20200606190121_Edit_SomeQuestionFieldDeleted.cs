using Microsoft.EntityFrameworkCore.Migrations;

namespace diploma.Migrations
{
    public partial class Edit_SomeQuestionFieldDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Questions_QuestionId1",
                table: "Variants");

            migrationBuilder.DropIndex(
                name: "IX_Variants_QuestionId1",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "QuestionId1",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "AccurateRate",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Attempts",
                table: "Questions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId1",
                table: "Variants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccurateRate",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Attempts",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Variants_QuestionId1",
                table: "Variants",
                column: "QuestionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Questions_QuestionId1",
                table: "Variants",
                column: "QuestionId1",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
