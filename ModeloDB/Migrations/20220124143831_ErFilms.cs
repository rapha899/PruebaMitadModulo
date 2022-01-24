using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class ErFilms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    relase_year = table.Column<int>(type: "int", nullable: false),
                    rental_duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    length = table.Column<int>(type: "int", nullable: false),
                    replacement_cost = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    special_fectures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fulltext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentMovie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.id);
                    table.ForeignKey(
                        name: "FK_films_languages_CurrentMovie",
                        column: x => x.CurrentMovie,
                        principalTable: "languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inventories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentFilmid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventories", x => x.id);
                    table.ForeignKey(
                        name: "FK_inventories_films_CurrentFilmid",
                        column: x => x.CurrentFilmid,
                        principalTable: "films",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_films_CurrentMovie",
                table: "films",
                column: "CurrentMovie");

            migrationBuilder.CreateIndex(
                name: "IX_inventories_CurrentFilmid",
                table: "inventories",
                column: "CurrentFilmid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventories");

            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
