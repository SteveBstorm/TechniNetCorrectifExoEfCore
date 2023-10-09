using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectifExoEfCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Realisator = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    MainActor = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Genre = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                    table.CheckConstraint("CK_ReleaseYear", "ReleaseYear > 1975");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Film_Title",
                table: "Film",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
