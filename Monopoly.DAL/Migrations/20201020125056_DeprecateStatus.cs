using Microsoft.EntityFrameworkCore.Migrations;

namespace Monopoly.DAL.Migrations
{
    public partial class DeprecateStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserStatus",
                table: "Memberships");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserStatus",
                table: "Memberships",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
