namespace Monopoly.DAL.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoublesCountsForArrest",
                table: "GameSettings");

            migrationBuilder.DropColumn(
                name: "ImprisonmentTurnsCount",
                table: "GameSettings");

            migrationBuilder.AddColumn<int>(
                name: "DoublesCountForArrest",
                table: "GameSettings",
                nullable: true);

            migrationBuilder.InsertData(
                table: "GameSettings",
                columns: new[] { "Id", "AnytimeBuilding", "AnytimeExchange", "Auction", "BuildingBalancing", "CasinoType", "DoubleBreaksJail", "DoublePayOnUnbuildedMonopoly", "DoubleRepeatsTurn", "DoublesCountForArrest", "FullCollateralValue", "HotelsCount", "HousesCount", "ImprisonmentDuration", "JailbreakPrice", "MovementFields", "RightStartHitAward", "StartMoney" },
                values: new object[] { 1, false, false, true, true, 0, true, true, true, 3, true, 16, 48, 3, 150, true, 250, 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameSettings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DoublesCountForArrest",
                table: "GameSettings");

            migrationBuilder.AddColumn<int>(
                name: "DoublesCountsForArrest",
                table: "GameSettings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImprisonmentTurnsCount",
                table: "GameSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
