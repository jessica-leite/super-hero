using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperHero.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedSuperPowers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SuperPowers",
                columns: new[] { "Id", "Descricao", "SuperPoder" },
                values: new object[,]
                {
                    { 1, "Voa para perto ou longe do adversário, melhorando ataques e esquivas.", "Voar" },
                    { 2, "Aumenta o dano do ataque realizado ao adversário.", "Super Força" },
                    { 3, "Dobra a velocidade de movimento.", "Super velocidade" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperPowers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SuperPowers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SuperPowers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
