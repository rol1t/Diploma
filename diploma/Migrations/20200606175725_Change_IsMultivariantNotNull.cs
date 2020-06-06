using Microsoft.EntityFrameworkCore.Migrations;

namespace diploma.Migrations
{
    public partial class Change_IsMultivariantNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsTrue",
                table: "Variants",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMultiVariants",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsTrue",
                table: "Variants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsMultiVariants",
                table: "Questions",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
