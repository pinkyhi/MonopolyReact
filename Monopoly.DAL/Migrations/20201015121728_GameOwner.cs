using Microsoft.EntityFrameworkCore.Migrations;

namespace Monopoly.DAL.Migrations
{
    public partial class GameOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GameOwnerId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Games",
                maxLength: 16,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameOwnerId",
                table: "Games",
                column: "GameOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_GameOwnerId",
                table: "Games",
                column: "GameOwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_GameOwnerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameOwnerId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameOwnerId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Games");
        }
    }
}
