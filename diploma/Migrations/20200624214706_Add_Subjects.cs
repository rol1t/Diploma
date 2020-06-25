using Microsoft.EntityFrameworkCore.Migrations;

namespace diploma.Migrations
{
    public partial class Add_Subjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Subjects",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Alias", "Name" },
                values: new object[,]
                {
                    { 1, "ТРПО", "Технологии разработки программного обеспечения" },
                    { 2, "ЗКИ", "Защита компьютерной информации" },
                    { 3, "Системное программное обеспечение", "СПО" },
                    { 4, "Базы данных и систему управления базами данных", "БДиСУБД" },
                    { 5, "ОАИП", "Основы алгоритмизации и программирования" },
                    { 6, "КС", "Компьютерные сети" },
                    { 7, "ПСИП", "Программные средства интренет приложений" },
                    { 8, "АУДП", "Автоматизация управленческой деятельности предприятия" },
                    { 9, "ТиОПО", "Тестирование и отладка программного обеспечения" },
                    { 10, "КПиЯП", "Конструирование программ и языки программирования" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Subjects");
        }
    }
}
