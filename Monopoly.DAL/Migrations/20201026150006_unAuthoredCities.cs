namespace Monopoly.DAL.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class unAuthoredCities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_AspNetUsers_AuthorId1",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_AuthorId1",
                table: "City");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "City",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_AuthorId1",
                table: "City",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_City_AspNetUsers_AuthorId1",
                table: "City",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
