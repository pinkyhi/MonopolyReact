namespace Monopoly.DAL.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class OneToManyGameGameSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_SettingsId",
                table: "Games");

            migrationBuilder.CreateIndex(
                name: "IX_Games_SettingsId",
                table: "Games",
                column: "SettingsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Games_SettingsId",
                table: "Games");

            migrationBuilder.CreateIndex(
                name: "IX_Games_SettingsId",
                table: "Games",
                column: "SettingsId",
                unique: true,
                filter: "[SettingsId] IS NOT NULL");
        }
    }
}
