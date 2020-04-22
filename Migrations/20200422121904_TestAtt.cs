using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinal.Migrations
{
    public partial class TestAtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Test",
                table: "NewsInfo",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "NewsInfo");
        }
    }
}
