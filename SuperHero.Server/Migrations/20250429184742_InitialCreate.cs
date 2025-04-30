using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHero.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(120)", nullable: false),
                    NomeHeroi = table.Column<string>(type: "nvarchar(120)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperPowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperPoder = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroSuperPower",
                columns: table => new
                {
                    HeroisId = table.Column<int>(type: "int", nullable: false),
                    SuperPoderesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroSuperPower", x => new { x.HeroisId, x.SuperPoderesId });
                    table.ForeignKey(
                        name: "FK_HeroSuperPower_Heroes_HeroisId",
                        column: x => x.HeroisId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroSuperPower_SuperPowers_SuperPoderesId",
                        column: x => x.SuperPoderesId,
                        principalTable: "SuperPowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperPower_SuperPoderesId",
                table: "HeroSuperPower",
                column: "SuperPoderesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroSuperPower");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "SuperPowers");
        }
    }
}
