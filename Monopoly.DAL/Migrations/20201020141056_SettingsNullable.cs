namespace Monopoly.DAL.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class SettingsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_SettingsId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "SettingsId",
                table: "Games",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Games_SettingsId",
                table: "Games",
                column: "SettingsId",
                unique: true,
                filter: "[SettingsId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_SettingsId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "SettingsId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Games_SettingsId",
                table: "Games",
                column: "SettingsId",
                unique: true);
        }
    }
}
