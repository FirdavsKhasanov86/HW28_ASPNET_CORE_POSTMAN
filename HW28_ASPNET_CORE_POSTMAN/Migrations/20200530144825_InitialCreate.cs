using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW28_ASPNET_CORE_POSTMAN.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citatas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Citatas",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 1, "Hurshed", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grohnim vse" });

            migrationBuilder.InsertData(
                table: "Citatas",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 2, "Firdavs", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dobudet svet" });

            migrationBuilder.InsertData(
                table: "Citatas",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 3, "Payrav", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "FREE Internet Unlim Forever" });

            migrationBuilder.InsertData(
                table: "Citatas",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 4, "Shahzod", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kali luchshe tochno" });

            migrationBuilder.InsertData(
                table: "Citatas",
                columns: new[] { "Id", "Author", "Date", "Text" },
                values: new object[] { 5, "Karim", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davay vrubimsya v CS1.6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citatas");
        }
    }
}
