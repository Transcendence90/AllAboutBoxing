using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllAboutBoxing.Data.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Residences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeightClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Division = table.Column<int>(nullable: false),
                    Kg = table.Column<float>(nullable: false),
                    Lb = table.Column<float>(nullable: false),
                    Established = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boxers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    Alias = table.Column<string>(maxLength: 50, nullable: true),
                    BoutId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LogoUrl = table.Column<string>(nullable: true),
                    ResidenceId = table.Column<int>(nullable: false),
                    BirthPlaceId = table.Column<int>(nullable: false),
                    Stance = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Reach = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boxers_Residences_BirthPlaceId",
                        column: x => x.BirthPlaceId,
                        principalTable: "Residences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Boxers_Residences_ResidenceId",
                        column: x => x.ResidenceId,
                        principalTable: "Residences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeightClassId = table.Column<int>(nullable: false),
                    BoxerId = table.Column<int>(nullable: false),
                    Organization = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_Boxers_BoxerId",
                        column: x => x.BoxerId,
                        principalTable: "Boxers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Champions_WeightClasses_WeightClassId",
                        column: x => x.WeightClassId,
                        principalTable: "WeightClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rankings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeightClassId = table.Column<int>(nullable: false),
                    BoxerId = table.Column<int>(nullable: false),
                    Organization = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rankings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rankings_Boxers_BoxerId",
                        column: x => x.BoxerId,
                        principalTable: "Boxers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rankings_WeightClasses_WeightClassId",
                        column: x => x.WeightClassId,
                        principalTable: "WeightClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoxerId = table.Column<int>(nullable: false),
                    Wins = table.Column<byte>(nullable: false),
                    Loses = table.Column<byte>(nullable: false),
                    Draws = table.Column<byte>(nullable: false),
                    NoContests = table.Column<byte>(nullable: false),
                    Knockouts = table.Column<byte>(nullable: false),
                    KnockoutsPercentage = table.Column<byte>(nullable: false),
                    Rounds = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Boxers_BoxerId",
                        column: x => x.BoxerId,
                        principalTable: "Boxers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstBoxerId = table.Column<int>(nullable: false),
                    SecondBoxerId = table.Column<int>(nullable: false),
                    WeightClassId = table.Column<int>(nullable: false),
                    WayOfFinish = table.Column<int>(nullable: false),
                    PlayedOn = table.Column<DateTime>(nullable: false),
                    RecordId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bouts_Boxers_FirstBoxerId",
                        column: x => x.FirstBoxerId,
                        principalTable: "Boxers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bouts_Records_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bouts_Boxers_SecondBoxerId",
                        column: x => x.SecondBoxerId,
                        principalTable: "Boxers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bouts_WeightClasses_WeightClassId",
                        column: x => x.WeightClassId,
                        principalTable: "WeightClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoxersBouts",
                columns: table => new
                {
                    BoutId = table.Column<int>(nullable: false),
                    BoxerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxersBouts", x => new { x.BoutId, x.BoxerId });
                    table.ForeignKey(
                        name: "FK_BoxersBouts_Bouts_BoutId",
                        column: x => x.BoutId,
                        principalTable: "Bouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BoxersBouts_Boxers_BoxerId",
                        column: x => x.BoxerId,
                        principalTable: "Boxers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bouts_FirstBoxerId",
                table: "Bouts",
                column: "FirstBoxerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bouts_RecordId",
                table: "Bouts",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Bouts_SecondBoxerId",
                table: "Bouts",
                column: "SecondBoxerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bouts_WeightClassId",
                table: "Bouts",
                column: "WeightClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Boxers_BirthPlaceId",
                table: "Boxers",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Boxers_BoutId",
                table: "Boxers",
                column: "BoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Boxers_ResidenceId",
                table: "Boxers",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_BoxersBouts_BoxerId",
                table: "BoxersBouts",
                column: "BoxerId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_BoxerId",
                table: "Champions",
                column: "BoxerId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_WeightClassId",
                table: "Champions",
                column: "WeightClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Rankings_BoxerId",
                table: "Rankings",
                column: "BoxerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rankings_WeightClassId",
                table: "Rankings",
                column: "WeightClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_BoxerId",
                table: "Records",
                column: "BoxerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Boxers_Bouts_BoutId",
                table: "Boxers",
                column: "BoutId",
                principalTable: "Bouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bouts_Boxers_FirstBoxerId",
                table: "Bouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Bouts_Boxers_SecondBoxerId",
                table: "Bouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Boxers_BoxerId",
                table: "Records");

            migrationBuilder.DropTable(
                name: "BoxersBouts");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Rankings");

            migrationBuilder.DropTable(
                name: "Boxers");

            migrationBuilder.DropTable(
                name: "Residences");

            migrationBuilder.DropTable(
                name: "Bouts");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "WeightClasses");
        }
    }
}
