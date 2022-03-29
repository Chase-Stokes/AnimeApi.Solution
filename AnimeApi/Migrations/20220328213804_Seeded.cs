using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeApi.Migrations
{
    public partial class Seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "AnimeId", "EpisodeCount", "Genre", "MovieCount", "SeasonCount", "Studio", "Title" },
                values: new object[,]
                {
                    { 1, 720, "Shonen", 11, 30, "TV Tokyo", "Naruto" },
                    { 2, 1189, "Fantasy", 23, 13, "OLM", "Pokemon" },
                    { 3, 24, "Comedy", 0, 2, "Madhouse", "One Punch Man" },
                    { 4, 113, "Shonen", 3, 5, "Bones", "Boku No Hero Academia" },
                    { 5, 203, "Shonen", 0, 9, "Artland", "Katekyo Hitman Reborn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "AnimeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "AnimeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "AnimeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "AnimeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "AnimeId",
                keyValue: 5);
        }
    }
}
