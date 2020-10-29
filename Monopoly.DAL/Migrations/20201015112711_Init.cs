namespace Monopoly.DAL.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EventType = table.Column<int>(nullable: false),
                    Choice = table.Column<bool>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultName = table.Column<string>(nullable: true),
                    EventType = table.Column<int>(nullable: false),
                    Choice = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventField", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartMoney = table.Column<int>(nullable: false),
                    ImprisonmentDuration = table.Column<int>(nullable: false),
                    JailbreakPrice = table.Column<int>(nullable: false),
                    ImprisonmentTurnsCount = table.Column<int>(nullable: false),
                    HousesCount = table.Column<int>(nullable: false),
                    HotelsCount = table.Column<int>(nullable: false),
                    RightStartHitAward = table.Column<int>(nullable: false),
                    CasinoType = table.Column<int>(nullable: false),
                    DoublesCountsForArrest = table.Column<int>(nullable: true),
                    DoubleRepeatsTurn = table.Column<bool>(nullable: false),
                    AnytimeExchange = table.Column<bool>(nullable: false),
                    AnytimeBuilding = table.Column<bool>(nullable: false),
                    MovementFields = table.Column<bool>(nullable: false),
                    Auction = table.Column<bool>(nullable: false),
                    BuildingBalancing = table.Column<bool>(nullable: false),
                    FullCollateralValue = table.Column<bool>(nullable: false),
                    DoublePayOnUnbuildedMonopoly = table.Column<bool>(nullable: false),
                    DoubleBreaksJail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovementMonopoly",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BaseTax = table.Column<int>(nullable: false),
                    MonopolyMultiplier = table.Column<double>(nullable: false),
                    IterationDivider = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementMonopoly", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MultiplyMonopoly",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BaseMultiplier = table.Column<double>(nullable: false),
                    MonopolyMultipier = table.Column<double>(nullable: false),
                    IterationDivider = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiplyMonopoly", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StreetMonopoly",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetMonopoly", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AuthorId = table.Column<int>(nullable: false),
                    AuthorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_AspNetUsers_AuthorId1",
                        column: x => x.AuthorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Token = table.Column<string>(nullable: false),
                    JwtId = table.Column<string>(nullable: true),
                    CreatrionDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Token);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovementField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultName = table.Column<string>(nullable: true),
                    MovementMonopolyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementField_MovementMonopoly_MovementMonopolyId",
                        column: x => x.MovementMonopolyId,
                        principalTable: "MovementMonopoly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultiplyField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultName = table.Column<string>(nullable: true),
                    MultiplyMonopolyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiplyField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiplyField_MultiplyMonopoly_MultiplyMonopolyId",
                        column: x => x.MultiplyMonopolyId,
                        principalTable: "MultiplyMonopoly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StreetField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultName = table.Column<string>(nullable: true),
                    UnbuildedTax = table.Column<int>(nullable: false),
                    OneHouseTax = table.Column<int>(nullable: false),
                    TwoHouseeTax = table.Column<int>(nullable: false),
                    ThreeHousesTax = table.Column<int>(nullable: false),
                    FourHousesTax = table.Column<int>(nullable: false),
                    HotelTax = table.Column<int>(nullable: false),
                    StreetMonopolyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StreetField_StreetMonopoly_StreetMonopolyId",
                        column: x => x.StreetMonopolyId,
                        principalTable: "StreetMonopoly",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    CardId = table.Column<int>(nullable: false),
                    CardGroupId = table.Column<int>(nullable: false),
                    Arguments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityCard_CardGroup_CardGroupId",
                        column: x => x.CardGroupId,
                        principalTable: "CardGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityCard_EventCard_CardId",
                        column: x => x.CardId,
                        principalTable: "EventCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityCard_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityEventField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    EventFieldId = table.Column<int>(nullable: false),
                    DefaultArguments = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityEventField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityEventField_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityEventField_EventField_EventFieldId",
                        column: x => x.EventFieldId,
                        principalTable: "EventField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityMovementField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    MovementFieldId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMovementField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityMovementField_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityMovementField_MovementField_MovementFieldId",
                        column: x => x.MovementFieldId,
                        principalTable: "MovementField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityMultiplyField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    MultiplyFieldId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMultiplyField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityMultiplyField_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityMultiplyField_MultiplyField_MultiplyFieldId",
                        column: x => x.MultiplyFieldId,
                        principalTable: "MultiplyField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityStreet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    StreetId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityStreet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityStreet_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityStreet_StreetField_StreetId",
                        column: x => x.StreetId,
                        principalTable: "StreetField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    UserStatus = table.Column<int>(nullable: false),
                    PlayerStatus = table.Column<int>(nullable: false),
                    TurnArgument = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Money = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memberships_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingsId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    GameStatus = table.Column<int>(nullable: false),
                    TurnOwnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_GameSettings_SettingsId",
                        column: x => x.SettingsId,
                        principalTable: "GameSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Memberships_TurnOwnerId",
                        column: x => x.TurnOwnerId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameCard",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    CardId = table.Column<int>(nullable: false),
                    DeckPosition = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCard", x => new { x.CardId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GameCard_CityCard_CardId",
                        column: x => x.CardId,
                        principalTable: "CityCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameCard_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameCard_Memberships_GameId",
                        column: x => x.GameId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameEventField",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    EventFieldId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: true),
                    Arguments = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEventField", x => new { x.EventFieldId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GameEventField_CityEventField_EventFieldId",
                        column: x => x.EventFieldId,
                        principalTable: "CityEventField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameEventField_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameEventField_Memberships_GameId",
                        column: x => x.GameId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameMovementField",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    MovementFieldId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameMovementField", x => new { x.MovementFieldId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GameMovementField_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameMovementField_Memberships_GameId",
                        column: x => x.GameId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameMovementField_CityMovementField_MovementFieldId",
                        column: x => x.MovementFieldId,
                        principalTable: "CityMovementField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameMultiplyField",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    MultiplyFieldId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameMultiplyField", x => new { x.MultiplyFieldId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GameMultiplyField_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameMultiplyField_Memberships_GameId",
                        column: x => x.GameId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameMultiplyField_CityMultiplyField_MultiplyFieldId",
                        column: x => x.MultiplyFieldId,
                        principalTable: "CityMultiplyField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameStreet",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    StreetId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<int>(nullable: true),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStreet", x => new { x.StreetId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GameStreet_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameStreet_Memberships_GameId",
                        column: x => x.GameId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameStreet_CityStreet_StreetId",
                        column: x => x.StreetId,
                        principalTable: "CityStreet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_City_AuthorId1",
                table: "City",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_CityCard_CardGroupId",
                table: "CityCard",
                column: "CardGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CityCard_CardId",
                table: "CityCard",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CityCard_CityId_CardId",
                table: "CityCard",
                columns: new[] { "CityId", "CardId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CityEventField_EventFieldId",
                table: "CityEventField",
                column: "EventFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_CityEventField_CityId_EventFieldId",
                table: "CityEventField",
                columns: new[] { "CityId", "EventFieldId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CityMovementField_MovementFieldId",
                table: "CityMovementField",
                column: "MovementFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_CityMovementField_CityId_MovementFieldId",
                table: "CityMovementField",
                columns: new[] { "CityId", "MovementFieldId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CityMultiplyField_MultiplyFieldId",
                table: "CityMultiplyField",
                column: "MultiplyFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_CityMultiplyField_CityId_MultiplyFieldId",
                table: "CityMultiplyField",
                columns: new[] { "CityId", "MultiplyFieldId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CityStreet_StreetId",
                table: "CityStreet",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_CityStreet_CityId_StreetId",
                table: "CityStreet",
                columns: new[] { "CityId", "StreetId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameCard_GameId",
                table: "GameCard",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameEventField_GameId",
                table: "GameEventField",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameMovementField_GameId",
                table: "GameMovementField",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameMultiplyField_GameId",
                table: "GameMultiplyField",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CityId",
                table: "Games",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_SettingsId",
                table: "Games",
                column: "SettingsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_TurnOwnerId",
                table: "Games",
                column: "TurnOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameStreet_GameId",
                table: "GameStreet",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_UserId",
                table: "Memberships",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_GameId_UserId",
                table: "Memberships",
                columns: new[] { "GameId", "UserId" },
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MovementField_MovementMonopolyId",
                table: "MovementField",
                column: "MovementMonopolyId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiplyField_MultiplyMonopolyId",
                table: "MultiplyField",
                column: "MultiplyMonopolyId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StreetField_StreetMonopolyId",
                table: "StreetField",
                column: "StreetMonopolyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Memberships_Games_GameId",
                table: "Memberships",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_AspNetUsers_AuthorId1",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_AspNetUsers_UserId",
                table: "Memberships");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_City_CityId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_Games_GameId",
                table: "Memberships");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GameCard");

            migrationBuilder.DropTable(
                name: "GameEventField");

            migrationBuilder.DropTable(
                name: "GameMovementField");

            migrationBuilder.DropTable(
                name: "GameMultiplyField");

            migrationBuilder.DropTable(
                name: "GameStreet");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CityCard");

            migrationBuilder.DropTable(
                name: "CityEventField");

            migrationBuilder.DropTable(
                name: "CityMovementField");

            migrationBuilder.DropTable(
                name: "CityMultiplyField");

            migrationBuilder.DropTable(
                name: "CityStreet");

            migrationBuilder.DropTable(
                name: "CardGroup");

            migrationBuilder.DropTable(
                name: "EventCard");

            migrationBuilder.DropTable(
                name: "EventField");

            migrationBuilder.DropTable(
                name: "MovementField");

            migrationBuilder.DropTable(
                name: "MultiplyField");

            migrationBuilder.DropTable(
                name: "StreetField");

            migrationBuilder.DropTable(
                name: "MovementMonopoly");

            migrationBuilder.DropTable(
                name: "MultiplyMonopoly");

            migrationBuilder.DropTable(
                name: "StreetMonopoly");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "GameSettings");

            migrationBuilder.DropTable(
                name: "Memberships");
        }
    }
}
