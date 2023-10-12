using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectifExoEfCore.Migrations
{
    public partial class firsttry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    RealisatorId = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                    table.CheckConstraint("CK_ReleaseYear", "ReleaseYear > 1975");
                    table.ForeignKey(
                        name: "FK_Film_PersonList_RealisatorId",
                        column: x => x.RealisatorId,
                        principalTable: "PersonList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Casting",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casting", x => new { x.PersonId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_Casting_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Casting_PersonList_PersonId",
                        column: x => x.PersonId,
                        principalTable: "PersonList",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "PersonList",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, "Elijah", "Wood" },
                    { 2, "Charlie", "Hunnam" },
                    { 3, "Harisson", "Ford" },
                    { 4, "Mark", "Hammil" },
                    { 5, "Carrie", "Fisher" },
                    { 6, "Vigo", "Mortensen" },
                    { 7, "Orlando", "Bloom" },
                    { 8, "Lexi", "Alexander" },
                    { 9, "Peter", "Jackson" },
                    { 10, "Georges", "Lucas" }
                });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "Id", "Genre", "RealisatorId", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Science-Fiction", 10, 1977, "Star Wars : Un nouvel espoir" },
                    { 2, "Science-Fiction", 10, 1980, "Star Wars : L'empire contre-attaque" },
                    { 3, "Science-Fiction", 10, 1983, "Star Wars : Le retour du Jedi" },
                    { 4, "Société", 8, 2005, "Hooligans" },
                    { 5, "Heroic-Fantasy", 9, 2001, "LOTR - La communauté de l'anneau" },
                    { 6, "Heroic-Fantasy", 9, 2002, "LOTR - Les deux tours" },
                    { 7, "Heroic-Fantasy", 9, 2003, "LOTR - Le retour du roi" }
                });

            migrationBuilder.InsertData(
                table: "Casting",
                columns: new[] { "FilmId", "PersonId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 5, 6 },
                    { 6, 6 },
                    { 7, 6 },
                    { 5, 7 },
                    { 6, 7 },
                    { 7, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Casting_FilmId",
                table: "Casting",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_RealisatorId",
                table: "Film",
                column: "RealisatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Title",
                table: "Film",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casting");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "PersonList");
        }
    }
}
