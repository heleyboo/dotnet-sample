using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class GameUpdate9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Playing",
                table: "game_rooms",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "game_data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    room_code = table.Column<string>(type: "varchar", nullable: true),
                    first_player_id = table.Column<string>(type: "varchar", nullable: true),
                    second_player_id = table.Column<string>(type: "varchar", nullable: true),
                    winner_id = table.Column<string>(type: "varchar", nullable: true),
                    first_player_score = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    second_player_score = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    all_players_ready = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false),
                    game_matrix = table.Column<List<int>>(type: "integer[]", nullable: true, defaultValue: new List<int>()),
                    first_player_founds = table.Column<List<int>>(type: "integer[]", nullable: true, defaultValue: new List<int>()),
                    second_player_found = table.Column<List<int>>(type: "integer[]", nullable: true, defaultValue: new List<int>())
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_game_data", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "game_data");

            migrationBuilder.DropColumn(
                name: "Playing",
                table: "game_rooms");
        }
    }
}
