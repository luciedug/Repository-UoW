using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsInfo", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "NewsInfo",
                columns: new[] { "ID", "Description" },
                values: new object[] { 1, "blabla" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsInfo");
        }
    }
}
