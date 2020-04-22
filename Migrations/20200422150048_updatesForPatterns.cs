using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinal.Migrations
{
    public partial class updatesForPatterns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsInfo",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "NewsInfo",
                columns: new[] { "ID", "CreatedAt", "Description", "Test" },
                values: new object[] { 54, new DateTime(2020, 4, 22, 17, 0, 48, 116, DateTimeKind.Local).AddTicks(3910), "blabla", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsInfo",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "NewsInfo");

            migrationBuilder.InsertData(
                table: "NewsInfo",
                columns: new[] { "ID", "Description", "Test" },
                values: new object[] { 1, "blabla", false });
        }
    }
}
