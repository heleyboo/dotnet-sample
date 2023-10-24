using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class GameUpdate8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecondPlayerId",
                table: "game_rooms",
                newName: "second_player_id");

            migrationBuilder.RenameColumn(
                name: "FirstPlayerId",
                table: "game_rooms",
                newName: "first_player_id");

            migrationBuilder.AlterColumn<List<int>>(
                name: "game_board",
                table: "game_rooms",
                type: "integer[]",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "array",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "second_player_id",
                table: "game_rooms",
                newName: "SecondPlayerId");

            migrationBuilder.RenameColumn(
                name: "first_player_id",
                table: "game_rooms",
                newName: "FirstPlayerId");

            migrationBuilder.AlterColumn<byte[]>(
                name: "game_board",
                table: "game_rooms",
                type: "array",
                nullable: true,
                oldClrType: typeof(List<int>),
                oldType: "integer[]",
                oldNullable: true);
        }
    }
}
