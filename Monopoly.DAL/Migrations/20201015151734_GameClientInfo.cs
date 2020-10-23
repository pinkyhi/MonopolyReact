using Microsoft.EntityFrameworkCore.Migrations;

namespace Monopoly.DAL.Migrations
{
    public partial class GameClientInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Games",
                maxLength: 32,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Games");
        }
    }
}