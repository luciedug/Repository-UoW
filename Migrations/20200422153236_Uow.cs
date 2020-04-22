using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinal.Migrations
{
    public partial class Uow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsInfo",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 17, 32, 36, 559, DateTimeKind.Local).AddTicks(8440));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsInfo",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 17, 0, 48, 116, DateTimeKind.Local).AddTicks(3910));
        }
    }
}
