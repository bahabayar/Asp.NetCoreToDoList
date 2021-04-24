using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.NetCoreToDoList.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(maxLength: 100, nullable: false),
                    TaskDescription = table.Column<string>(maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoLists", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDoLists",
                columns: new[] { "Id", "IsDeleted", "TaskDescription", "TaskName" },
                values: new object[] { 1, false, "Belirlediğin derslerin gerekli konularına çalış!", "Ders Çalış" });

            migrationBuilder.InsertData(
                table: "ToDoLists",
                columns: new[] { "Id", "IsDeleted", "TaskDescription", "TaskName" },
                values: new object[] { 2, false, "Belirlediğin ihtiyaçları satın al!", "Alışveriş Yap" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoLists");
        }
    }
}
