namespace Monopoly.DAL.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class MonopoliesRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityCard_CardGroup_CardGroupId",
                table: "CityCard");

            migrationBuilder.AddForeignKey(
                name: "FK_CityCard_CardGroup_CardGroupId",
                table: "CityCard",
                column: "CardGroupId",
                principalTable: "CardGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityCard_CardGroup_CardGroupId",
                table: "CityCard");

            migrationBuilder.AddForeignKey(
                name: "FK_CityCard_CardGroup_CardGroupId",
                table: "CityCard",
                column: "CardGroupId",
                principalTable: "CardGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
