using Microsoft.EntityFrameworkCore.Migrations;

namespace Monopoly.DAL.Migrations
{
    public partial class CardWithOneGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityCard_CardGroup_CardGroupId",
                table: "CityCard");

            migrationBuilder.DropIndex(
                name: "IX_CityCard_CardGroupId",
                table: "CityCard");

            migrationBuilder.DropColumn(
                name: "CardGroupId",
                table: "CityCard");

            migrationBuilder.AddColumn<int>(
                name: "CardGroupId",
                table: "EventCard",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Publicity",
                table: "City",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_EventCard_CardGroupId",
                table: "EventCard",
                column: "CardGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventCard_CardGroup_CardGroupId",
                table: "EventCard",
                column: "CardGroupId",
                principalTable: "CardGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventCard_CardGroup_CardGroupId",
                table: "EventCard");

            migrationBuilder.DropIndex(
                name: "IX_EventCard_CardGroupId",
                table: "EventCard");

            migrationBuilder.DropColumn(
                name: "CardGroupId",
                table: "EventCard");

            migrationBuilder.DropColumn(
                name: "Publicity",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "CardGroupId",
                table: "CityCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CityCard_CardGroupId",
                table: "CityCard",
                column: "CardGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_CityCard_CardGroup_CardGroupId",
                table: "CityCard",
                column: "CardGroupId",
                principalTable: "CardGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
