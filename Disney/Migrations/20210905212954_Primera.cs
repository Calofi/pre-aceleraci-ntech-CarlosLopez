using Microsoft.EntityFrameworkCore.Migrations;

namespace Disney.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "icons");

            migrationBuilder.RenameTable(
                name: "Personajes",
                newName: "Personajes",
                newSchema: "icons");

            migrationBuilder.RenameTable(
                name: "Pelicula_Series",
                newName: "Pelicula_Series",
                newSchema: "icons");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "Generos",
                newSchema: "icons");

            migrationBuilder.InsertData(
                schema: "icons",
                table: "Generos",
                columns: new[] { "Id", "Imagen", "Nombre" },
                values: new object[] { 1, "el sapo", " PEPE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "icons",
                table: "Generos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Personajes",
                schema: "icons",
                newName: "Personajes");

            migrationBuilder.RenameTable(
                name: "Pelicula_Series",
                schema: "icons",
                newName: "Pelicula_Series");

            migrationBuilder.RenameTable(
                name: "Generos",
                schema: "icons",
                newName: "Generos");
        }
    }
}
