using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectifExoEfCore.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "Id", "Genre", "MainActor", "Realisator", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Science-Fiction", "Mark Hammil", "Georges Lucas", 1977, "Star Wars : Un nouvel espoir" },
                    { 2, "Science-Fiction", "Mark Hammil", "Georges Lucas", 1980, "Star Wars : L'empire contre-attaque" },
                    { 3, "Science-Fiction", "Mark Hammil", "Georges Lucas", 1983, "Star Wars : Le retour du Jedi" },
                    { 4, "Société", "Charlie Hunnam", "Lexi Alexander", 2005, "Hooligans" },
                    { 5, "Heroic-Fantasy", "Elijah Wood", "Peter Jackson", 2001, "LOTR - La communauté de l'anneau" },
                    { 6, "Heroic-Fantasy", "Elijah Wood", "Peter Jackson", 2002, "LOTR - Les deux tours" },
                    { 7, "Heroic-Fantasy", "Elijah Wood", "Peter Jackson", 2003, "LOTR - Le retour du roi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
