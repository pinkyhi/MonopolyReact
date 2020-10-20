using Microsoft.EntityFrameworkCore.Migrations;

namespace Monopoly.DAL.Migrations
{
    public partial class DefaultGameSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SettingsId",
                table: "Games",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SettingsId",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 1);
        }
    }
}
